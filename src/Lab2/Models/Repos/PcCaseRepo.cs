using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.OtherAtributes;
using Itmo.ObjectOrientedProgramming.Lab2.PcCases;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Repos;

public class PcCaseRepo
{
    private readonly List<PcCase> _pcCases;

    public PcCaseRepo()
    {
        _pcCases = new List<PcCase>()
        {
            new PcCaseBuilder()
                .WithLength(321)
                .WithWidth(250)
                .WithDepth(441)
                .WithWidthVideoCard(33)
                .WithLengthVideoCard(101)
                .WithMotherBoardFormFactor(FormFactors.StandardAtx).Build(),
            new PcCaseBuilder()
                .WithLength(244)
                .WithWidth(215)
                .WithDepth(320)
                .WithWidthVideoCard(39)
                .WithLengthVideoCard(92)
                .WithMotherBoardFormFactor(FormFactors.MicroAtx).Build(),
            new PcCaseBuilder()
                .WithLength(115)
                .WithWidth(99)
                .WithDepth(190)
                .WithWidthVideoCard(25)
                .WithLengthVideoCard(69)
                .WithMotherBoardFormFactor(FormFactors.MiniItx).Build(),
        };
    }

    public PcCaseRepo(IList<PcCase> pcCases)
    {
        _pcCases = new List<PcCase>(pcCases);
    }

    public PcCaseRepo Add(PcCase pcCase)
    {
        if (!RepoValidator.IsValidPcCase(pcCase))
            return new PcCaseRepo();

        _pcCases.Add(pcCase);

        return this;
    }

    public bool Update(PcCase pcCase, PcCase newPcCase)
    {
        if (_pcCases.IndexOf(pcCase) == -1)
            return false;

        _pcCases[_pcCases.IndexOf(pcCase)] = newPcCase;

        return true;
    }

    public bool Delete(PcCase pcCase)
    {
        return _pcCases.Remove(pcCase);
    }

    public IList<PcCase>? FindAll(Predicate<PcCase> predicate) => _pcCases.FindAll(predicate);
}