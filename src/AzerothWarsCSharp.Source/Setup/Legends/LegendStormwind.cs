using AzerothWarsCSharp.MacroTools;
using AzerothWarsCSharp.MacroTools.FactionSystem;
using static War3Api.Common;

namespace AzerothWarsCSharp.Source.Setup.Legends
{
  public static class LegendStormwind
  {
    public static Legend LegendVarian { get; private set; }
    public static Legend LegendKhadgar { get; private set; }
    public static Legend LegendGalen { get; private set; }
    public static Legend LegendBolvar { get; private set; }
    public static Legend LegendStormwindkeep { get; private set; }
    public static Legend LegendDarkshire { get; private set; }


    public static void Setup()
    {
      LegendVarian = new Legend
      {
        UnitType = FourCC("H00R")
      };
      LegendVarian.AddUnitDependency(PreplacedUnitSystem.GetUnit(FourCC("h00X")));
      LegendVarian.DeathMessage =
        "The King of Stormwind dies a warrior’s death, defending hearth and family. The Wrynn Dynasty crumbles with his passing.";
      LegendVarian.StartingXp = 1800;
      Legend.Register(LegendVarian);

      LegendGalen = new Legend
      {
        UnitType = FourCC("H00Z"),
        StartingXp = 1000
      };
      Legend.Register(LegendGalen);

      LegendBolvar = new Legend
      {
        UnitType = FourCC("H017")
      };
      Legend.Register(LegendBolvar);

      LegendKhadgar = new Legend
      {
        UnitType = FourCC("H05Y"),
        StartingXp = 7000
      };
      Legend.Register(LegendKhadgar);

      LegendStormwindkeep = new Legend
      {
        Unit = PreplacedUnitSystem.GetUnit(FourCC("h00X")),
        DeathMessage = "Stormwind Keep, the capitol of the nation of Stormwind, has been destroyed!"
      };
      Legend.Register(LegendStormwindkeep);

      LegendDarkshire = new Legend
      {
        Unit = PreplacedUnitSystem.GetUnit(FourCC("h03Y"))
      };
      Legend.Register(LegendDarkshire);
    }
  }
}