using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.PowerUnits;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Repos;

public class PowerUnitRepo
{
    private readonly List<PowerUnit> _powerUnits;
    public PowerUnitRepo()
    {
        _powerUnits = new List<PowerUnit>()
        {
            new PowerUnit(100),
            new PowerUnit(150),
            new PowerUnit(160),
            new PowerUnit(170),
            new PowerUnit(180),
            new PowerUnit(190),
            new PowerUnit(200),
            new PowerUnit(350),
            new PowerUnit(400),
            new PowerUnit(450),
            new PowerUnit(500),
            new PowerUnit(550),
            new PowerUnit(600),
            new PowerUnit(650),
            new PowerUnit(700),
            new PowerUnit(750),
            new PowerUnit(800),
        };
    }

    public PowerUnitRepo(IList<PowerUnit> powerUnits)
    {
        _powerUnits = new List<PowerUnit>(powerUnits);
    }

    public PowerUnitRepo Add(PowerUnit powerUnit)
    {
        if (powerUnit == null)
            throw new ArgumentNullException(nameof(powerUnit));

        if (!RepoValidator.IsValidPowerUnit(powerUnit))
            return new PowerUnitRepo();

        _powerUnits.Add(powerUnit);

        return this;
    }

    public bool Update(PowerUnit powerUnit, PowerUnit newPowerUnit)
    {
        if (_powerUnits.IndexOf(powerUnit) == -1)
            return false;

        _powerUnits[_powerUnits.IndexOf(powerUnit)] = newPowerUnit;

        return true;
    }

    public bool Delete(PowerUnit powerUnit)
    {
        return _powerUnits.Remove(powerUnit);
    }

    public IList<PowerUnit>? FindAll(Predicate<PowerUnit> predicate) => _powerUnits.FindAll(predicate);
}