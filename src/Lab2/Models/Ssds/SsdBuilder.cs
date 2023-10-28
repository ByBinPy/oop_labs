using System;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Connectors;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Ssds;

public class SsdBuilder : ISsdBuilder
{
    private int _capacity;
    private Connector? _howConnection;
    private int _maxSpeed;
    private int _power;

    public SsdBuilder() { }

    public SsdBuilder(Ssd ssd)
    {
        if (ssd == null)
            return;
        _capacity = ssd.Capacity;
        _howConnection = ssd.HowConnection;
        _maxSpeed = ssd.MaxSpeed;
        _power = ssd.Power;
    }

    public ISsdBuilder WithCapacity(int capacity)
    {
        _capacity = capacity;

        return this;
    }

    public ISsdBuilder WithConnection(Connector connector)
    {
        _howConnection = connector;

        return this;
    }

    public ISsdBuilder WithMaxSpeed(int maxSpeed)
    {
        _maxSpeed = maxSpeed;

        return this;
    }

    public ISsdBuilder WithPower(int power)
    {
        _power = power;

        return this;
    }

    public Ssd Build()
    {
        return new Ssd(
            _capacity,
            _howConnection ?? throw new ArgumentNullException(),
            _maxSpeed,
            _power);
    }
}