using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Models.OtherAtributes;
using Itmo.ObjectOrientedProgramming.Lab2.Models.XmpProfiles;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Ddrs;

public interface IDdrBuilder
{
   IDdrBuilder WithQtyMemory(int qtyMemory);
   IDdrBuilder WithJedec(Jedec jedec);
   IDdrBuilder WithDefaultVoltage(int voltage);
   IDdrBuilder WithFormFactors(string formFactor);
   IDdrBuilder WithDdrStandard(DdrStandard ddrStandard);
   IDdrBuilder WithXmpProfiles(Collection<IXmpProfile> xmpProfiles);
   IDdrBuilder Power(int power);
   Ddr Build();
}