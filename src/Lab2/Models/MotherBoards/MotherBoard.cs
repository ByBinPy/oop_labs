using Itmo.ObjectOrientedProgramming.Lab2.Bioss;
using Itmo.ObjectOrientedProgramming.Lab2.Chipsets;
using Itmo.ObjectOrientedProgramming.Lab2.Connectors;
using Itmo.ObjectOrientedProgramming.Lab2.Ddrs;
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
        DdrStandard ddrStandard,
        int qtyRamSlot,
        FormFactors formFactor,
        IBios bios,
        PciE pciE)
    {
        Socket = socket;
        QtyPcieLine = qtyPcieLine;
        QtySataPort = qtySataPort;
        DdrStandard = ddrStandard;
        Chipset = chipset;
        QtyRamSlot = qtyRamSlot;
        FormFactor = formFactor;
        Bios = bios;
        PciE = pciE;
    }

    public Socket Socket { get; }
    public int QtyPcieLine { get; }
    public int QtySataPort { get; }
    public Chipset Chipset { get; }
    public PciE PciE { get; }
    public int QtyRamSlot { get; }
    public DdrStandard DdrStandard { get; }
    public FormFactors FormFactor { get; }
    public IBios Bios { get; }
}