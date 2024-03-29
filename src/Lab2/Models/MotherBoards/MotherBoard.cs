using Itmo.ObjectOrientedProgramming.Lab2.Models.Bioss;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Chipsets;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Connectors;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Ddrs;
using Itmo.ObjectOrientedProgramming.Lab2.Models.OtherAtributes;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Sockets;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.MotherBoards;

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