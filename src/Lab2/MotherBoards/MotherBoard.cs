using Itmo.ObjectOrientedProgramming.Lab2.Bioss;
using Itmo.ObjectOrientedProgramming.Lab2.Chipsets;
using Itmo.ObjectOrientedProgramming.Lab2.OtherAtributes;
using Itmo.ObjectOrientedProgramming.Lab2.Sockets;

namespace Itmo.ObjectOrientedProgramming.Lab2.MotherBoards;

public class MotherBoard
{
    public MotherBoard(
        Socket socket,
        int qtyPcieLine,
        int qtySataPort,
        Chipset chipset,
        int qtyRamSlot,
        FormFactors formFactor,
        IBios bios)
    {
        Socket = socket;
        QtyPcieLine = qtyPcieLine;
        QtySataPort = qtySataPort;
        Chipset = chipset;
        QtyRamSlot = qtyRamSlot;
        FormFactor = formFactor;
        Bios = bios;
    }

    public Socket Socket { get; }
    public int QtyPcieLine { get; }
    public int QtySataPort { get; }
    public Chipset Chipset { get; }
    public int QtyRamSlot { get; }
    public FormFactors FormFactor { get; }
    public IBios Bios { get; }
}