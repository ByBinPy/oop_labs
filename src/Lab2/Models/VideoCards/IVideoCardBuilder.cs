using Itmo.ObjectOrientedProgramming.Lab2.Models.Connectors;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.VideoCards;

public interface IVideoCardBuilder
{
    IVideoCardBuilder WithWidth(int width);
    IVideoCardBuilder WithHeight(int height);
    IVideoCardBuilder WithQtyMemory(int qtyMemory);
    IVideoCardBuilder WithVersionPciE(PciE pciE);
    IVideoCardBuilder WithChipFrequency(int chipFrequency);
    IVideoCardBuilder WithPower(int power);
    VideoCard Build();
}