using AzerothWarsCSharp.Source.Main.Libraries.MacroTools;

namespace AzerothWarsCSharp.Source.RoC.Legends
{
  public static class LegendScourge
  {
    public static Legend? LegendKelthuzad { get; private set; }
    public static Legend? LegendAnubarak { get; private set; }
    public static Legend? LegendRivendare { get; private set; }
    public static Legend? LegendLichking { get; private set; }
    public static Legend? LegendUtgarde { get; private set; }

    public static int UnittypeKelthuzadNecromancer { get; } = FourCC("U001");
    public static int UnittypeKelthuzadGhost { get; } = FourCC("U00M");
    public static int UnittypeKelthuzadLich { get; } = FourCC("Uktl");

    public static void Setup()
    {
      LegendKelthuzad = new Legend
      {
        UnitType = FourCC("U001"),
        PermaDies = true,
        DeathMessage =
          "KelFourCC(thuzad has been slain. He lives on in spectral form, && may yet return if (he is brought to the Sunwell.",
        DeathSfx = "Abilities\\Spells\\Undead\\DeathCoil\\DeathCoilSpecialArt.mdl",
        Essential = true,
        StartingXp = 1000,
        Name = "KelFourCC(thuzad"
      };

      LegendAnubarak = new Legend
      {
        UnitType = FourCC("Uanb")
      };

      LegendRivendare = new Legend
      {
        UnitType = FourCC("U00A"),
        StartingXp = 1000
      };

      LegendUtgarde = new Legend
      {
        Unit = gg_unit_h00O_2516,
        Capturable = true
      };

      LegendLichking = new Legend
      {
        Unit = gg_unit_u000_0649,
        Hivemind = true,
        DeathMessage =
          "The great Lich King has been destroyed. With no central mind to command them, the forces of the Undead have gone rogue."
      };
    }
  }
}