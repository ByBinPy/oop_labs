using Itmo.ObjectOrientedProgramming.Lab2.OtherAtributes;

namespace Itmo.ObjectOrientedProgramming.Lab2.PcCases;

public interface IPcCaseBuilder
{
    IPcCaseBuilder WithLengthVideoCard(double length);
    IPcCaseBuilder WithWidthVideoCard(double width);
    IPcCaseBuilder WithMotherBoardFormFactor(FormFactors formFactor);
    IPcCaseBuilder WithLength(double length);
    IPcCaseBuilder WithDepth(double depth);
    IPcCaseBuilder WithWidth(double width);
    PcCase Build();
}