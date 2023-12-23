using FluentMigrator;
using Itmo.Dev.Platform.Postgres.Migrations;
namespace Infrastructure;
[Migration(1, "Initial")]
public class Migrations : SqlMigration
{
        protected override string GetUpSql(IServiceProvider serviceProvider) =>
            """
            create type type_operation as enum
            (
                'Refill',
                'Withdrawal',
                'Add',
                'Delete',
                'Find'
            );
            create table bank_account
            (
                account_id bigint primary key generated always as identity,
                bank_account bigint,
                balance money not null
            );
            create table operations
            (
                operation_id bigint primary key generated always as identity,
                operation_time timestamp not null,
                account_id bigint not null,
                type_operation type_operation not null
            );
            create table admins
            (
                admin_id bigint primary key generated always as identity,
                username varchar(10)
            )
            """;

        protected override string GetDownSql(IServiceProvider serviceProvider) =>
            """
            drop table bank_account;
            drop table operations;
            drop type type_operation;
            """;
    }