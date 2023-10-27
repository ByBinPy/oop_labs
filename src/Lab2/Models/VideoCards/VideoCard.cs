using Itmo.ObjectOrientedProgramming.Lab2.Models.Connectors;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.VideoCards;

public class VideoCard
{
    public VideoCard(
        int width,
        int height,
        int qtyMemory,
        PciE versionPciE,
        int chipFrequency,
        int power)
    {
        Width = width;
        Height = height;
        QtyMemory = qtyMemory;
        VersionPciE = versionPciE;
        ChipFrequency = chipFrequency;
        Power = power;
    }

    public int Width { get; }
    public int Height { get; }
    public int QtyMemory { get; }
    public PciE VersionPciE { get; }
    public int ChipFrequency { get; }
    public int Power { get; }
}