using Itmo.ObjectOrientedProgramming.Lab2.Chipsets;
using Itmo.ObjectOrientedProgramming.Lab2.Connectors;
using Itmo.ObjectOrientedProgramming.Lab2.Ddrs;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Bioss;
using Itmo.ObjectOrientedProgramming.Lab2.OtherAtributes;
using Itmo.ObjectOrientedProgramming.Lab2.Sockets;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.MotherBoards;

public interface IMotherBoardBuilder
{
    IMotherBoardBuilder WithSocket(Socket socket);
    IMotherBoardBuilder WithQtyPcieLine(int qtyPcieLine);
    IMotherBoardBuilder WithQtySataPort(int qtySataPort);
    IMotherBoardBuilder WithChipset(Chipset chipset);
    IMotherBoardBuilder WithQtyRamSlot(int qtyRamSlot);
    IMotherBoardBuilder WithFormFactor(FormFactors formFactor);
    IMotherBoardBuilder WithBios(IBios bios);
    IMotherBoardBuilder WithDdrStandard(DdrStandard ddrStandard);
    IMotherBoardBuilder WithPciE(PciE pciE);
    MotherBoard Build();
}