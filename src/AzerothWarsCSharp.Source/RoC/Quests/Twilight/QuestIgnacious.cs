using AzerothWarsCSharp.Source.Main.Libraries.MacroTools;
using AzerothWarsCSharp.Source.Main.Libraries.QuestSystem.UtilityStructs;

namespace AzerothWarsCSharp.Source.RoC.Quests.Twilight
{
  public class QuestIgnacious{

  
    private const int RESEARCH_ID = FourCC(R07Q);
  


    private string operator CompletionPopup( ){
      return "The great Ragnaros has ascended one of our shamans.";
    }

    private string operator CompletionDescription( ){
      return "You can summon Ignacious from the Altar";
    }


    public  thistype ( ){
      thistype this = thistype.allocate("Gift of the Firelord", "Destroying the Dwarf great forge will please the Great Elemental Lord, Ragnaros.", "ReplaceableTextures\\CommandButtons\\BTNHeroAvatarOfFlame.blp");
      this.AddQuestItem(QuestItemLegendDead.create(LEGEND_GREATFORGE));
      this.AddQuestItem(QuestItemControlPoint.create(ControlPoint.ByUnitType(FourCC(n0AA))));
      this.ResearchId = RESEARCH_ID;
      ;;
    }


  }
}
