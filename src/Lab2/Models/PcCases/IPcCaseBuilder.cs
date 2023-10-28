using Itmo.ObjectOrientedProgramming.Lab2.Models.OtherAtributes;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.PcCases;

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