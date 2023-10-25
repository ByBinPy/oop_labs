using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.OtherAtributes;
using Itmo.ObjectOrientedProgramming.Lab2.XmpProfiles;

namespace Itmo.ObjectOrientedProgramming.Lab2.Ddrs;

public interface IDdrBuilder
{
   IDdrBuilder WithQtyMemory(int qtyMemory);
   IDdrBuilder WithJedec(Jedec jedec);
   IDdrBuilder WithDefaultVoltage(int voltage);
   IDdrBuilder WithFormFactors(FormFactors formFactor);
   IDdrBuilder WithDdrStandard(DdrStandard ddrStandard);
   IDdrBuilder WithXmpProfiles(Collection<IXmpProfile> xmpProfiles);
   IDdrBuilder Power(int power);
   Ddr Build();
}