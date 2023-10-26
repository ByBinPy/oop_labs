using Itmo.ObjectOrientedProgramming.Lab2.OtherAtributes;

namespace Itmo.ObjectOrientedProgramming.Lab2.PcCases;

public interface IPcCaseBuilder
{
    IPcCaseBuilder WithLengthVideoCard(int length);
    IPcCaseBuilder WithWidthVideoCard(int width);
    IPcCaseBuilder WithMotherBoardFormFactor(FormFactors formFactor);
    IPcCaseBuilder WithLength(int length);
    IPcCaseBuilder WithDepth(int depth);
    IPcCaseBuilder WithWidth(int width);
    PcCase Build();
}