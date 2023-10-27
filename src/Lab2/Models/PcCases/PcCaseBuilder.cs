using Itmo.ObjectOrientedProgramming.Lab2.OtherAtributes;

namespace Itmo.ObjectOrientedProgramming.Lab2.PcCases;

public class PcCaseBuilder : IPcCaseBuilder
{
    private double _lenghtVideoCard;
    private double _widthVideoCard;
    private FormFactors _motherBoardFormFactor;
    private double _length;
    private double _depth;
    private double _width;

    public PcCaseBuilder() { }

    public PcCaseBuilder(PcCase pcCase)
    {
        if (pcCase == null)
            return;
        _lenghtVideoCard = pcCase.LenghtVideoCard;
        _widthVideoCard = pcCase.WidthVideoCard;
        _motherBoardFormFactor = pcCase.MotherBoardFormFactor;
        _length = pcCase.Length;
        _depth = pcCase.Depth;
        _width = pcCase.Width;
    }

    public IPcCaseBuilder WithLengthVideoCard(double length)
    {
        _lenghtVideoCard = length;
        return this;
    }

    public IPcCaseBuilder WithWidthVideoCard(double width)
    {
        _widthVideoCard = width;
        return this;
    }

    public IPcCaseBuilder WithMotherBoardFormFactor(FormFactors formFactor)
    {
        _motherBoardFormFactor = formFactor;
        return this;
    }

    public IPcCaseBuilder WithLength(double length)
    {
        _length = length;
        return this;
    }

    public IPcCaseBuilder WithDepth(double depth)
    {
        _depth = depth;
        return this;
    }

    public IPcCaseBuilder WithWidth(double width)
    {
        _width = width;
        return this;
    }

    public PcCase Build()
    {
        return new PcCase(
            _lenghtVideoCard,
            _widthVideoCard,
            _motherBoardFormFactor,
            _length,
            _depth,
            _width);
    }
}