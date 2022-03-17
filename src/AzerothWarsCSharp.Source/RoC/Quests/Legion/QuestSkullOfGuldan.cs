using AzerothWarsCSharp.Source.Main.Libraries.QuestSystem.UtilityStructs;

namespace AzerothWarsCSharp.Source.RoC.Quests.Legion
{
  public class QuestSkullOfGuldan{


    private QuestItemAnyUnitInRect questItemAnyUnitInRect;

    private string operator CompletionPopup( ){
      return "The Skull of GulFourCC(dan has been retrieved by " + GetHeroProperName(questItemAnyUnitInRect.TriggerUnit) + ". Its nefarious energies will fuel the Legion)s operations on Azeroth.";
    }

    private string operator CompletionDescription( ){
      return "The Skull of GulFourCC(dan";
    }

    private void OnComplete( ){
      ARTIFACT_SKULLOFGULDAN.setStatus(ARTIFACT_STATUS_GROUND);
      UnitAddItemSafe(questItemAnyUnitInRect.TriggerUnit, ARTIFACT_SKULLOFGULDAN.item);
    }

    private void OnFail( ){
      SetItemPosition(ARTIFACT_SKULLOFGULDAN.item, -11867, 222165);
      ARTIFACT_SKULLOFGULDAN.setStatus(ARTIFACT_STATUS_GROUND);
    }

    public  thistype ( ){
      thistype this = thistype.allocate("The Skull of GulFourCC(dan", "The Skull of the master warlock Gul)dan is protected by the Mages of Dalaran. It rightfully belongs to the Legion.", "ReplaceableTextures\\CommandButtons\\BTNGuldanSkull.blp");
      this.questItemAnyUnitInRect = this.AddQuestItem(QuestItemAnyUnitInRect.create(gg_rct_DalaranDungeon, "Dalaran Dungeons", true));
      this.AddQuestItem(QuestItemEitherOf.create(QuestItemLegendDead.create(LEGEND_ILLIDAN), QuestItemFactionDefeated.create(FACTION_NAGA)));
      this.AddQuestItem(QuestItemSelfExists.create());
      ;;
    }


  }
}
