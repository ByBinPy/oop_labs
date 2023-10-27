using Itmo.ObjectOrientedProgramming.Lab2.Connectors;
using Itmo.ObjectOrientedProgramming.Lab2.Models.VideoCards;

namespace Itmo.ObjectOrientedProgramming.Lab2.VideoCards;

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