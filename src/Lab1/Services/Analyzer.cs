using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Ships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;

public class Analyzer
{
    private const int Start = 0;

    public Analyzer()
    {
        Fuel = Start;
        Answer = new Message();
        SpecialFuel = Start;
    }

    public Analyzer(IEnumerable<RouteCut> route, IShip ship)
        : this()
    {
        Route = route;
        Ship = ship;
        Answer = MoveProcessing();
    }

    // the fuel was used
    public double? Fuel { get; private set; }
    public double? SpecialFuel { get; private set; }
    public Message Answer { get; }
    public IShip? Ship { get; init; }
    private IEnumerable<RouteCut>? Route { get; init; }

    public Message MoveProcessing()
    {
        if (Route == null)

            return new Message(Message.NullRouteMessage);

        foreach (RouteCut cut in Route)
        {
            if (cut.Environment is HighDensityNebula)
            {
                if (Ship?.InstalledJumpEngine == null || Ship?.InstalledJumpEngine.Range < cut.LengthWay)
                    return new Message(Message.LackRangeMessage);
                else if (Ship?.InstalledJumpEngine.Range > cut.LengthWay)
                    SpecialFuel += Ship?.InstalledJumpEngine.Consumption();
            }

            Fuel += Ship?.InstalledPulseEngine.Consumption();
            Message answer = DamageProcessing(cut.Environment?.EnvironmentObstacles, Ship?.IsAntinitrineEmitterInstalled ?? false);
            if (answer.Text is Message.DiedMessage or Message.CrashMessage or Message.LackRangeMessage)

                return answer;
        }

        return new Message();
    }

    private Message DamageProcessing(Collection<IObstacle>? obstacles, bool installedAntinitrineEmitter)
    {
        if (obstacles == null)
            return new Message(Message.NullObstacleMessage);

        foreach (IObstacle obstacle in obstacles)
        {
            if (obstacle is CosmoWhale && installedAntinitrineEmitter)
                continue;
            Message? answer = Ship?.InstalledHull?.Damage(obstacle);
            if (answer?.Text == Message.DefaultMessage || answer?.Text == Message.UnfunctionalMessage) continue;
            if (answer != null)

                return answer;
        }

        return new Message();
    }
}