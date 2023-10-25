using Itmo.ObjectOrientedProgramming.Lab2.OtherAtributes;

namespace Itmo.ObjectOrientedProgramming.Lab2.PcCases;

public class PcCase
{
    public PcCase(
        int lenghtVideoCard,
        int widthVideoCard,
        FormFactors motherBoardFormFactor,
        int length,
        int depth,
        int width)
    {
        LenghtVideoCard = lenghtVideoCard;
        WidthVideoCard = widthVideoCard;
        MotherBoardFormFactor = motherBoardFormFactor;
        Length = length;
        Depth = depth;
        Width = width;
    }

    public int LenghtVideoCard { get; }
    public int WidthVideoCard { get; }
    public FormFactors MotherBoardFormFactor { get; }
    public int Length { get; }
    public int Depth { get; }
    public int Width { get; }
}