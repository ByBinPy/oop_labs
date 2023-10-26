using System;
using Itmo.ObjectOrientedProgramming.Lab2.Connectors;

namespace Itmo.ObjectOrientedProgramming.Lab2.VideoCards;

public class VideoCardBuilder : IVideoCardBuilder
{
    private int _width;
    private int _height;
    private int _qtyMemory;
    private PciE? _versionPciE;
    private int _chipFrequency;
    private int _power;

    public VideoCardBuilder() { }

    public VideoCardBuilder(VideoCard videoCard)
    {
        if (videoCard == null)
            return;

        _width = videoCard.Width;
        _height = videoCard.Height;
        _qtyMemory = videoCard.QtyMemory;
        _versionPciE = videoCard.VersionPciE;
        _chipFrequency = videoCard.ChipFrequency;
        _power = videoCard.Power;
    }

    public IVideoCardBuilder WithWidth(int width)
    {
        _width = width;
        return this;
    }

    public IVideoCardBuilder WithHeight(int height)
    {
        _height = height;
        return this;
    }

    public IVideoCardBuilder WithQtyMemory(int qtyMemory)
    {
        _qtyMemory = qtyMemory;
        return this;
    }

    public IVideoCardBuilder WithVersionPciE(PciE pciE)
    {
        _versionPciE = pciE;
        return this;
    }

    public IVideoCardBuilder WithChipFrequency(int chipFrequency)
    {
        _chipFrequency = chipFrequency;
        return this;
    }

    public IVideoCardBuilder WithPower(int power)
    {
        _power = power;
        return this;
    }

    public VideoCard Build()
    {
        return new VideoCard(
            _width,
            _height,
            _qtyMemory,
            _versionPciE ?? throw new ArgumentNullException(),
            _chipFrequency,
            _power);
    }
}