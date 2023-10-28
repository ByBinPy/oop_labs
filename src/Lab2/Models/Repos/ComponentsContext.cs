namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Repos;

public record ComponentsContext
{
        public static CpuRepo CpuRepo { get; } = new CpuRepo();
        public static DdrRepo DdrRepo { get; } = new DdrRepo();
        public static WiFiAdapterRepo WiFiAdapterRepo { get; } = new WiFiAdapterRepo();
        public static CpuCoolingSystemRepo CpuCoolingSystemRepo { get; } = new CpuCoolingSystemRepo();
        public static PowerUnitRepo PowerUnitRepo { get; } = new PowerUnitRepo();
        public static HddRepo HddRepo { get; } = new HddRepo();
        public static SsdRepo SsdRepo { get; } = new SsdRepo();
        public static MotherBoardRepo MotherBoardRepo { get; } = new MotherBoardRepo();
        public static PcCaseRepo PcCaseRepo { get; } = new PcCaseRepo();
        public static VideoCardRepo VideoCardRepo { get; } = new VideoCardRepo();
}