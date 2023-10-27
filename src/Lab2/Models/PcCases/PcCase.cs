using Itmo.ObjectOrientedProgramming.Lab2.OtherAtributes;

namespace Itmo.ObjectOrientedProgramming.Lab2.PcCases;

public class PcCase
{
    public PcCase(
        double lenghtVideoCard,
        double widthVideoCard,
        FormFactors motherBoardFormFactor,
        double length,
        double depth,
        double width)
    {
        LenghtVideoCard = lenghtVideoCard;
        WidthVideoCard = widthVideoCard;
        MotherBoardFormFactor = motherBoardFormFactor;
        Length = length;
        Depth = depth;
        Width = width;
    }

    public double LenghtVideoCard { get; }
    public double WidthVideoCard { get; }
    public FormFactors MotherBoardFormFactor { get; }
    public double Length { get; }
    public double Depth { get; }
    public double Width { get; }
}