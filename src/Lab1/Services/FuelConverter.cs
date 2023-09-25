using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Ships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;

public static class FuelConverter
{
    public int ConvertFuel(IShip ship, int distance)
    {
        switch (ship.WeightCharacteristic)
        {
            case WieghtDimensional.Tiny:
            {
                distance *= distance;
                break;l
            }
        }
    }
}