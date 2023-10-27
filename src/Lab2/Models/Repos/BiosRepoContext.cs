using Itmo.ObjectOrientedProgramming.Lab2.Bioss;
using Itmo.ObjectOrientedProgramming.Lab2.Repos;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Repos;

public record BiosRepoContext(IBiosRepos<Phoenix> PhoenixRepo, IBiosRepos<Ami> AmiRepo, IBiosRepos<Intel> IntelRepo, IBiosRepos<Uefi> UefiRepo);