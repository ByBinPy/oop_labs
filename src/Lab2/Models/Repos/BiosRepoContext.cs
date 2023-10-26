using Itmo.ObjectOrientedProgramming.Lab2.Bioss;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repos;

public record BiosRepoContext(IBiosRepos<Phoenix> PhoenixRepo, IBiosRepos<Ami> AmiRepo, IBiosRepos<Intel> IntelRepo, IBiosRepos<Uefi> UefiRepo);