using AzerothWarsCSharp.Source.Main.Libraries.QuestSystem.UtilityStructs;

namespace AzerothWarsCSharp.Source.RoC.Quests.Frostwolf
{
  public class QuestZeppelins{

  
    private const int RESEARCH_ID = FourCC(R058);
    private const int UNITTYPE_ID = FourCC(nzep);
    private const int LIMIT_CHANGE = 2;
  


    private string operator CompletionPopup( ){
      return "The Sentinels have been slain. With their Hippogryphs no longer terrorizing the skies, the Horde can field its refurbished Zeppelins.";
    }

    private string operator CompletionDescription( ){
      return "Learn to train " + GetObjectName(UNITTYPE_ID) + "s";
    }

    private void OnAdd( ){
      this.Holder.ModObjectLimit(UNITTYPE_ID, LIMIT_CHANGE);
      this.Holder.ModObjectLimit(RESEARCH_ID, UNLIMITED);
    }

    private void OnComplete( ){
      SetPlayerTechResearched(this.Holder.Player, RESEARCH_ID, 1);
      DisplayUnitTypeAcquired(this.Holder.Player, UNITTYPE_ID, "You can now train Zeppelins from the Goblin Laboratory.");
    }

    public  thistype ( ){
      thistype this = thistype.allocate("The Spirits of Ashenvale", "The Sentinels have laid claim over Kalimdor. As long as they survive, the Orcs will never be safe.", "ReplaceableTextures\\CommandButtons\\BTNGoblinZeppelin.blp");
      this.AddQuestItem(QuestItemLegendDead.create(LEGEND_AUBERDINE));
      this.AddQuestItem(QuestItemLegendDead.create(LEGEND_FEATHERMOON));
      ;;
    }


  }
}
