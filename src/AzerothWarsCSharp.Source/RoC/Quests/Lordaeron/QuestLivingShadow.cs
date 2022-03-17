
using AzerothWarsCSharp.Source.Main.Libraries.QuestSystem.UtilityStructs;

namespace AzerothWarsCSharp.Source.RoC.Quests.Lordaeron
{
  public class QuestLivingShadow{


    private string operator CompletionPopup( ){
      return "Uther has discovered the Living Embodiment of Shadow in the ruins of the Twilight Citadel";
    }

    private string operator CompletionDescription( ){
      return "The Living Shadow && the Ashbringer Quest discovery";
    }

    private void OnComplete( ){
      UnitAddItemSafe(LEGEND_UTHER.Unit, ARTIFACT_LIVINGSHADOW.item);
      FACTION_LORDAERON.AddQuest(THE_ASHBRINGER);
      THE_ASHBRINGER.Progress = QUEST_PROGRESS_INCOMPLETE;
    }

    public  thistype ( ){
      thistype this = thistype.allocate("The Living Embodiment of Shadow", "The Dark Fortress looming over the Twilight Highlands is a beacon of darkness. Destroy it && clear the surrounding lands of evil.", "ReplaceableTextures\\CommandButtons\\BTNShadow Orb.blp");
      this.AddQuestItem(QuestItemLegendInRect.create(LEGEND_UTHER, gg_rct_TwilightOutside, "Twilight Citadel"));
      this.AddQuestItem(QuestItemLegendDead.create(LEGEND_TWILIGHTCITADEL));
      ;;
    }


  }
}
