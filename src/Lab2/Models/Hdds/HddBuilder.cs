namespace Itmo.ObjectOrientedProgramming.Lab2.Hdds;

public class HddBuilder : IHddBuilder
{
    private int _capacity;
    private int _speedRotation;
    private int _power;

    public HddBuilder() { }

    public HddBuilder(Hdd hdd)
    {
        if (hdd == null)

            return;

        _capacity = hdd.Capacity;
        _speedRotation = hdd.SpedRotation;
        _power = hdd.Power;
    }

    public IHddBuilder WithCapacity(int capacity)
    {
        _capacity = capacity;

        return this;
    }

    public IHddBuilder WithSpeedRotation(int speedRotation)
    {
        _speedRotation = speedRotation;

        return this;
    }

    public IHddBuilder WithPower(int power)
    {
        _power = power;

        return this;
    }

    public Hdd Build()
    {
        return new Hdd(
            _capacity,
            _speedRotation,
            _power);
    }
}