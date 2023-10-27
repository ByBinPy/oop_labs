using System;
using Itmo.ObjectOrientedProgramming.Lab2.Models.OtherAtributes;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.PcCases;

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
    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        var other = (PcCase)obj;

        return Math.Abs(LenghtVideoCard - other.LenghtVideoCard) < 0.00001 &&
               Math.Abs(WidthVideoCard - other.WidthVideoCard) < 0.00001 &&
               MotherBoardFormFactor == other.MotherBoardFormFactor &&
               Math.Abs(Length - other.Length) < 0.00001 &&
               Math.Abs(Depth - other.Depth) < 0.00001 &&
               Math.Abs(Width - other.Width) < 0.00001;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(LenghtVideoCard, WidthVideoCard, MotherBoardFormFactor, Length, Depth, Width);
    }
}