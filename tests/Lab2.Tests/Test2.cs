#pragma warning disable IDE0005
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Cpus;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Computer;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Cpus;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Ddrs;
using Itmo.ObjectOrientedProgramming.Lab2.Models.MotherBoards;
using Itmo.ObjectOrientedProgramming.Lab2.Models.PowerUnits;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Repos;
using Itmo.ObjectOrientedProgramming.Lab2.Models.WiFiAdapters;
using Itmo.ObjectOrientedProgramming.Lab2.Services;
using Xunit;
#pragma warning restore IDE0005
// анализатор говорит что эти директрии не нужны но они нужны, т.к при удалении пропадает возможность обращения к соотвествющим элементам
namespace Itmo.ObjectOrientedProgramming.Lab2.Tests;

public class Test2
{
    [Fact]
    public void TestingConfigurator()
    {
        MotherBoard? motherBoard = ComponentsContext.MotherBoardRepo.FindAll(board => board.DdrStandard.Version == "DDR4" && board.Socket.Version == "LGA 1700")?.FirstOrDefault();
        if (motherBoard != null)
        {
            var configurator = new Configurator(motherBoard);
            Validator.IsValidPc(configurator.Configurate());
            Assert.True(configurator.Configurate() is not null);
        }
    }

    [Fact]
    public void TestingValidatorOnWeakPowerUnit()
    {
        MotherBoard? motherBoard = ComponentsContext.MotherBoardRepo.FindAll(board => board.DdrStandard.Version == "DDR4" && board.Socket.Version == "LGA 1700")?.FirstOrDefault();
        if (motherBoard != null)
        {
            var configurator = new Configurator(motherBoard);
            PowerUnit? powerUnit = ComponentsContext.PowerUnitRepo.FindAll((unit) => unit.PeakLoad < 157)?.MaxBy(unit => unit.PeakLoad);
            if (powerUnit == null)
                return;
            Pc pc = new PcBuilder(configurator.Configurate()).WithPowerUnit(powerUnit).Build();
            var waitingAnswer = new Message(Message.DisclaimerOfWarrantyDueTo + nameof(PowerUnit));
            Assert.Equal(Validator.IsValidPc(pc), new List<Message>() { waitingAnswer });
        }
    }

    [Fact]
    public void TestingValidatorOnCpuCoolerSystem()
    {
        MotherBoard? motherBoard = ComponentsContext.MotherBoardRepo.FindAll(board => board.DdrStandard.Version == "DDR4" && board.Socket.Version == "LGA 1700")?.FirstOrDefault();
        if (motherBoard != null)
        {
            var configurator = new Configurator(motherBoard);
            Pc pc = configurator.Configurate();
            CpuCoolingSystem? cpuCoolingSystem = ComponentsContext.CpuCoolingSystemRepo
                .FindAll(cooler => cooler.Tdp < pc.CpuPc.Tdp)
                ?.FirstOrDefault(cooler => cooler.SupportSockets
                    .FirstOrDefault(socket => socket.Version == pc.MotherBoardPc.Socket.Version) != null);

            if (cpuCoolingSystem != null)
            {
                pc = new PcBuilder(pc).WithCpuCoolingSystem(cpuCoolingSystem).Build();
                var waitingAnswer = new Message(Message.DisclaimerOfWarrantyDueTo + nameof(CpuCoolingSystem));
                Assert.Equal(Validator.IsValidPc(pc), new List<Message>() { waitingAnswer });
            }
        }
    }

    [Fact]
    public void TestingValidatorOnIncompatibleDdr()
    {
        MotherBoard? motherBoard = ComponentsContext.MotherBoardRepo.FindAll(board => board.DdrStandard.Version == "DDR4" && board.Socket.Version == "LGA 1700")?.FirstOrDefault();
        if (motherBoard != null)
        {
            var configurator = new Configurator(motherBoard);
            Ddr? ddr = ComponentsContext.DdrRepo.FindAll(ddr => ddr.Standard.Version == "DDR3")?.First();
            if (ddr != null)
            {
                Pc pc = new PcBuilder(configurator.Configurate()).WithDdr(ddr).Build();
                Assert.Equal(Validator.IsValidPc(pc), new List<Message>() { new Message(Message.Incompatible + nameof(Ddr)) });
            }
        }
    }

    [Fact]
    public void TestingValidatorOnIncompatibleCpu()
    {
        MotherBoard? motherBoard = ComponentsContext.MotherBoardRepo.FindAll(board => board.DdrStandard.Version == "DDR4" && board.Socket.Version == "LGA 1700")?.FirstOrDefault();
        if (motherBoard != null)
        {
            var configurator = new Configurator(motherBoard);
            Cpu? cpu = ComponentsContext.CpuRepo.FindAll(cpu => cpu.Socket.Version != configurator.Configurate().MotherBoardPc.Socket.Version)?.First();
            if (cpu != null)
            {
                Pc pc = new PcBuilder(configurator.Configurate()).WithCpu(cpu).Build();
                Assert.Equal(Validator.IsValidPc(pc), new List<Message>() { new Message(Message.Incompatible + nameof(Cpu)) });
            }
        }
    }

    [Fact]
    public void TestingValidatorOnIncompatibleWiFiAdapter()
    {
        MotherBoard? motherBoard = ComponentsContext.MotherBoardRepo.FindAll(board => board.DdrStandard.Version == "DDR4" && board.Socket.Version == "LGA 1700")?.FirstOrDefault();
        if (motherBoard != null)
        {
            var configurator = new Configurator(motherBoard);
            WiFiAdapter? wiFiAdapter = ComponentsContext.WiFiAdapterRepo.FindAll(adapter => adapter.PciEVersion != configurator.Configurate().MotherBoardPc.PciE.Version)?.First();
            if (wiFiAdapter != null)
            {
                Pc pc = new PcBuilder(configurator.Configurate()).WithWifiAdapter(wiFiAdapter).Build();
                Assert.Equal(Validator.IsValidPc(pc), new List<Message>() { new Message(Message.Incompatible + nameof(WiFiAdapter)) });
            }
        }
    }
}