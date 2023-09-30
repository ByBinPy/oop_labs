using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Ships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;

public class Analyzer
{
    private const int Start = 0;
    public Analyzer()
    {
        Fuel = Start;
        SpecialFuel = Start;
        Answer = "Nothing";
    }

    public Analyzer(IEnumerable<RouteCut> route, IShip ship)
    : this()
    {
        Route = route;
        Ship = ship;
        MoveProcessing();
    }

    public string Answer { get; private set; }

    // the fuel was used
    public double? Fuel { get; private set; }
    public double? SpecialFuel { get; private set; }
    public IShip? Ship { get; init; }
    private IEnumerable<RouteCut>? Route { get; init; }

    private void MoveProcessing()
    {
        if (Route == null) throw new ArgumentException("Null Route in MoveProcessing");
        foreach (RouteCut cut in Route)
        {
            if (Answer != "Nothing") return;

            switch (cut.Environment?.Description)
            {
                case "HighDensityNebula":
                {
                    if (Ship?.Description == "PleasureShuttle" || Ship?.Description == "Meridian" || Ship?.InstalledJumpEngine?.Range < cut.Len)
                        Answer = "Impossible";
                    else if (Ship?.InstalledJumpEngine != null)
                        SpecialFuel += Ship?.InstalledJumpEngine.Consumption();

                    DamageProcessing(cut.Environment?.EnvironmentObstacles, Ship?.IsAntinitrineEmitterInstalled ?? false);
                    break;
            }

                case "NeutrinoPerticleNebula":
                {
                    Fuel += Ship?.InstalledPulseEngine.Consumption();
                    DamageProcessing(cut.Environment?.EnvironmentObstacles);
                    break;
                }

                case "Space":
                {
                    Fuel += Ship?.InstalledPulseEngine.Consumption();
                    DamageProcessing(cut.Environment?.EnvironmentObstacles);
                    break;
                }

                default:
                {
                    Answer = "Incorrect data";
                    break;
                }
            }
        }
    }

    private void DamageProcessing(Collection<Obstacles>? obstacles, bool installedAntinitrineEmitter = false)
    {
        if (obstacles != null)
        {
            foreach (Obstacles obstacle in obstacles)
            {
                try
                {
                    if (obstacle == Obstacles.CosmoWhales && installedAntinitrineEmitter)
                        continue;
                    Ship?.InstalledHull?.Damage(obstacle);
                }
                catch (AggregateException e)
                {
                    Answer = e.Message;
                    break;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Answer = "Incorrect data";
                    break;
                }
            }
        }
    }
}