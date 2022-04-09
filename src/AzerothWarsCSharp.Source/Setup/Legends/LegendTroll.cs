using AzerothWarsCSharp.MacroTools.FactionSystem;

namespace AzerothWarsCSharp.Source.Legends
{
  public static class LegendTroll{
    public static Legend LEGEND_PRIEST { get; private set; }
    public static Legend LEGEND_RASTAKHAN { get; private set; }
    public static Legend LEGEND_HAKKAR { get; private set; }
    
    public static void Setup( ){
      LEGEND_PRIEST = new Legend
      {
        UnitType = FourCC("O01J"),
        Essential = true
      };

      LEGEND_HAKKAR = new Legend
      {
        UnitType = FourCC("U023")
      };

      LEGEND_RASTAKHAN = new Legend
      {
        UnitType = FourCC("O026"),
        StartingXp = 2800
      };
    }

  }
}
