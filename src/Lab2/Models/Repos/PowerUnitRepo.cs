using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.PowerUnits;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Repos;

public class PowerUnitRepo
{
    private readonly List<PowerUnit> _powerUnits;

    /*
        Capacity = capacity;
        SpedRotation = spedRotation;
        Power = power;
     */
    public PowerUnitRepo()
    {
        _powerUnits = new List<PowerUnit>()
        {
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