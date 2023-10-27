using Itmo.ObjectOrientedProgramming.Lab2.Models.Bioss;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Chipsets;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Connectors;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Ddrs;
using Itmo.ObjectOrientedProgramming.Lab2.Models.OtherAtributes;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Sockets;

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