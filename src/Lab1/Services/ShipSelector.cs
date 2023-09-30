using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Ships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;

public class ShipSelector
{
    public ShipSelector(IEnumerable<Analyzer> analyzers)
    {
        ShipsAnalyzers = analyzers;
    }

    public IEnumerable<Analyzer> ShipsAnalyzers { get; init; }
    public string Selector()
    {
        /*
        possible answers
        "Nothing" - if all so nice
        "Incorrect data" - if input data invalid
        "Impossible" - if uninstall jumpEngines in HighDensityNebula
        "Crew is died"
        "Ship has been broken"
        "
         */
        foreach (Analyzer analyzerShip in ShipsAnalyzers)
        {
            555
        }
    }
}