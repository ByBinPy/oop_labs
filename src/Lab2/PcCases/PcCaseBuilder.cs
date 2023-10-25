using Itmo.ObjectOrientedProgramming.Lab2.OtherAtributes;

namespace Itmo.ObjectOrientedProgramming.Lab2.PcCases;

public class PcCaseBuilder : IPcCaseBuilder
{
    private int _lenghtVideoCard;
    private int _widthVideoCard;
    private FormFactors _motherBoardFormFactor;
    private int _length;
    private int _depth;
    private int _width;

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

    public IPcCaseBuilder WithLengthVideoCard(int length)
    {
        _lenghtVideoCard = length;
        return this;
    }

    public IPcCaseBuilder WithWidthVideoCard(int width)
    {
        _widthVideoCard = width;
        return this;
    }

    public IPcCaseBuilder WithMotherBoardFormFactor(FormFactors formFactor)
    {
        _motherBoardFormFactor = formFactor;
        return this;
    }

    public IPcCaseBuilder WithLength(int length)
    {
        _length = length;
        return this;
    }

    public IPcCaseBuilder WithDepth(int depth)
    {
        _depth = depth;
        return this;
    }

    public IPcCaseBuilder WithWidth(int width)
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