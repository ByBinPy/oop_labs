using System;
using Itmo.ObjectOrientedProgramming.Lab2.Bioss;
using Itmo.ObjectOrientedProgramming.Lab2.Chipsets;
using Itmo.ObjectOrientedProgramming.Lab2.OtherAtributes;
using Itmo.ObjectOrientedProgramming.Lab2.Sockets;

namespace Itmo.ObjectOrientedProgramming.Lab2.MotherBoards;

public class MotherBoardBuilder : IMotherBoardBuilder
{
    private Socket? _socket;
    private int _qtyPcieLine;
    private int _qtySataPort;
    private Chipset? _chipset;
    private int _qtyRamSlot;
    private FormFactors _formFactor;
    private IBios? _bios;
    public MotherBoardBuilder() { }

    public MotherBoardBuilder(MotherBoard motherBoard)
    {
        if (motherBoard == null) return;
        _socket = motherBoard.Socket;
        _qtyPcieLine = motherBoard.QtyPcieLine;
        _qtySataPort = motherBoard.QtySataPort;
        _chipset = motherBoard.Chipset;
        _qtyRamSlot = motherBoard.QtyRamSlot;
        _formFactor = motherBoard.FormFactor;
        _bios = motherBoard.Bios;
    }

    public IMotherBoardBuilder WithSocket(Socket socket)
    {
        _socket = socket;
        return this;
    }

    public IMotherBoardBuilder WithQtyPcieLine(int qtyPcieLine)
    {
        _qtyPcieLine = qtyPcieLine;
        return this;
    }

    public IMotherBoardBuilder WithQtySataPort(int qtySataPort)
    {
        _qtySataPort = qtySataPort;
        return this;
    }

    public IMotherBoardBuilder WithChipset(Chipset chipset)
    {
        _chipset = chipset;
        return this;
    }

    public IMotherBoardBuilder WithQtyRamSlot(int qtyRamSlot)
    {
        _qtyRamSlot = qtyRamSlot;
        return this;
    }

    public IMotherBoardBuilder WithFormFactor(FormFactors formFactor)
    {
        _formFactor = formFactor;
        return this;
    }

    public IMotherBoardBuilder WithBios(IBios bios)
    {
        _bios = bios;
        return this;
    }

    public MotherBoard Build()
    {
        return new MotherBoard(
            _socket ?? throw new ArgumentNullException(),
            _qtyPcieLine,
            _qtySataPort,
            _chipset ?? throw new ArgumentNullException(),
            _qtyRamSlot,
            _formFactor,
            _bios ?? throw new ArgumentNullException());
    }
}