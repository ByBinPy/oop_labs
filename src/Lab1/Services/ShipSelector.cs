using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Ships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;

public class ShipSelector
{
    private Collection<IShip> _successShips;
    public ShipSelector(IEnumerable<Analyzer> analyzers)
    {
        ShipsAnalyzers = analyzers;
        _successShips = new Collection<IShip>();
    }

    private IEnumerable<Analyzer> ShipsAnalyzers { get; }
    public IShip? Selector()
    {
        SetAnswers();
        IShip? outShip = null;
        foreach (IShip ship in _successShips)
        {
            if (outShip == null)

                outShip = ship;

            if (outShip != null && GetConsumption(ship) < GetConsumption(outShip))

                outShip = ship;
        }

        return outShip;
    }

    private static double GetConsumption(IShip ship)
    {
        if (ship?.InstalledJumpEngine != null)

            return ship.InstalledPulseEngine.Consumption() + ship.InstalledJumpEngine.Consumption();

        if (ship != null)

            return ship.InstalledPulseEngine.Consumption();

        return 0;
    }

    private void SetAnswers()
    {
        foreach (Analyzer analyzerShip in ShipsAnalyzers)
        {
            if (analyzerShip.Answer.Text == Message.DefaultMessage)
            {
                if (analyzerShip?.Ship != null)
                {
                    _successShips.Add(analyzerShip.Ship);
                }
            }
        }
    }
}