using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Models.Ships;

namespace Itmo.ObjectOrientedProgramming.Lab1.Services;

public class Analyzer
{
    public Analyzer()
    {
        Answer = new Message();
    }

    public Analyzer(IEnumerable<RouteCut> route, IShip ship)
        : this()
    {
        Route = new ReadOnlyCollection<RouteCut>(route.ToList());
        Ship = ship;
        Answer = MoveProcessing();
    }

    // the fuel was used
    public Message Answer { get; }
    public IShip? Ship { get; }

    public ReadOnlyCollection<RouteCut>? Route { get; }

    public Message MoveProcessing()
    {
        if (Route == null)

            return new Message(Message.NullRouteMessage);

        foreach (RouteCut cut in Route)
        {
            if (cut.Environment is HighDensityNebula)
            {
                if (Ship?.InstalledJumpEngine == null || !Ship.InstalledJumpEngine.IsValidRange(cut.LengthWay))
                {
                    return new Message(Message.LackRangeMessage);
                }
                else if (Ship.InstalledJumpEngine.IsValidRange(cut.LengthWay))
                {
                    Ship.InstalledJumpEngine.Move(cut.LengthWay);
                }
            }

            if (Ship?.InstalledPulseEngine != null)
            {
                if (cut.Environment is NeutrinoPerticleNebula && Ship.InstalledPulseEngine is PulseEngineC)
                {
                    Ship.InstalledPulseEngine.Move(7 * cut.LengthWay);
                }
                else
                {
                    Ship.InstalledPulseEngine.Move(cut.LengthWay);
                }
            }

            Message answer = DamageProcessing(cut.Environment?.EnvironmentObstacles, Ship?.IsAntinitrineEmitterInstalled ?? false);
            if (answer.Text is Message.DiedMessage or Message.CrashMessage or Message.LackRangeMessage)

                return answer;
        }

        return new Message();
    }

    private Message DamageProcessing(ReadOnlyCollection<IObstacle>? obstacles, bool installedAntinitrineEmitter)
    {
        if (obstacles == null)
            return new Message(Message.NullObstacleMessage);

        foreach (IObstacle obstacle in obstacles)
        {
            if (obstacle is CosmoWhale && installedAntinitrineEmitter)
                continue;
            Message? answer = Ship?.InstalledHull?.Damage(obstacle);

            if (answer?.Text is Message.DefaultMessage or Message.UnfunctionalMessage) continue;

            if (answer != null)

                return answer;
        }

        return new Message();
    }
}