using AzerothWarsCSharp.MacroTools.FactionSystem;

namespace AzerothWarsCSharp.Source.Researches.Stormwind
{
  public class TierExpeditionSurvivors{

    private static void Research( ){
      FACTION_STORMWIND.ModObjectLimit(FourCC(h00A), -Faction.UNLIMITED)     ;//Spearman
      FACTION_STORMWIND.ModObjectLimit(FourCC(h05N), Faction.UNLIMITED)      ;//Marksman
    }

    public static void Setup( ){
      RegisterResearchFinishedAction(FourCC(R031),  Research);
    }

  }
}
