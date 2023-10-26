using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Bioss;
using Itmo.ObjectOrientedProgramming.Lab2.Chipsets;
using Itmo.ObjectOrientedProgramming.Lab2.MotherBoards;
using Itmo.ObjectOrientedProgramming.Lab2.OtherAtributes;
using Itmo.ObjectOrientedProgramming.Lab2.Sockets;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repos;

public class MotherBoardRepo
{
    private readonly Collection<MotherBoard> _motherBoards;
    /*
            new MotherBoardBuilder().WithSocket(new Socket()).WithQtyPcieLine().WithQtySataPort().WithChipset(new Chipset()).WithQtyRamSlot()
                                    .WithFormFactor().WithBios(new IntelFabric().Create()),
     */
    public MotherBoardRepo()
    {
        _motherBoards = new Collection<MotherBoard>
        {
            new MotherBoardBuilder().WithSocket(new Socket("LGA 1700")).WithQtyPcieLine(1).WithQtySataPort(4)
                .WithChipset(new Chipset(false, 3200)).WithQtyRamSlot(2)
                .WithFormFactor(FormFactors.MicroAtx).WithBios(new AmiFabric().Create("2.0")).Build(),

            new MotherBoardBuilder().WithSocket(new Socket("FM2")).WithQtyPcieLine(1).WithQtySataPort(4)
                .WithChipset(new Chipset(false, 3050)).WithQtyRamSlot(4)
                .WithFormFactor(FormFactors.MicroAtx).WithBios(new PhoenixFabric().Create("2.0")).Build(),

            new MotherBoardBuilder().WithSocket(new Socket("AM4")).WithQtyPcieLine(2).WithQtySataPort(6)
                .WithChipset(new Chipset(true, 3600)).WithQtyRamSlot(4)
                .WithFormFactor(FormFactors.StandardAtx).WithBios(new UefiFabric().Create("3.0")).Build(),

            new MotherBoardBuilder().WithSocket(new Socket("LGA 1200")).WithQtyPcieLine(2).WithQtySataPort(6)
                .WithChipset(new Chipset(true, 3200)).WithQtyRamSlot(4)
                .WithFormFactor(FormFactors.StandardAtx).WithBios(new IntelFabric().Create("1.0")).Build(),

            new MotherBoardBuilder().WithSocket(new Socket("AM3")).WithQtyPcieLine(1).WithQtySataPort(4)
                .WithChipset(new Chipset(false, 2966)).WithQtyRamSlot(2)
                .WithFormFactor(FormFactors.MicroAtx).WithBios(new PhoenixFabric().Create("1.0")).Build(),

            new MotherBoardBuilder().WithSocket(new Socket("LGA 1151")).WithQtyPcieLine(1).WithQtySataPort(2)
                .WithChipset(new Chipset(false, 2666)).WithQtyRamSlot(2)
                .WithFormFactor(FormFactors.MiniItx).WithBios(new IntelFabric().Create("1.2")).Build(),

            new MotherBoardBuilder().WithSocket(new Socket("AM5")).WithQtyPcieLine(4).WithQtySataPort(8)
                .WithChipset(new Chipset(true, 4333)).WithQtyRamSlot(6)
                .WithFormFactor(FormFactors.StandardAtx).WithBios(new UefiFabric().Create("4.0")).Build(),

            new MotherBoardBuilder().WithSocket(new Socket("LGA 2066")).WithQtyPcieLine(2).WithQtySataPort(4)
                .WithChipset(new Chipset(true, 2899)).WithQtyRamSlot(4)
                .WithFormFactor(FormFactors.MicroAtx).WithBios(new AmiFabric().Create("2.0")).Build(),
        };
    }

    public MotherBoardRepo(IList<MotherBoard> motherBoards)
    {
        _motherBoards = new Collection<MotherBoard>(motherBoards);
    }

    public MotherBoardRepo Add(MotherBoard motherBoard)
    {
        if (!RepoValidator.IsValidMotherBoard(motherBoard))
            return new MotherBoardRepo();

        _motherBoards.Add(motherBoard);

        return this;
    }

    public bool Update(MotherBoard motherBoard, MotherBoard newMotherBoard)
    {
        if (_motherBoards.IndexOf(motherBoard) == -1)
            return false;

        _motherBoards[_motherBoards.IndexOf(motherBoard)] = newMotherBoard;

        return true;
    }
}