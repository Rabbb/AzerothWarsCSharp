using AzerothWarsCSharp.Source.Main.Libraries.QuestSystem.UtilityStructs;

namespace AzerothWarsCSharp.Source.RoC.Quests.Warsong
{
  public class QuestFountainOfBlood{

  
    private const int RESEARCH_ID = FourCC(R00X);
  


    private string operator CompletionPopup( ){
      return "The Fountain of Blood is under Warsong control. As the orcs drink from it, they feel a a familiar fury awake within them.";
    }

    private string operator CompletionDescription( ){
      return "Allows Orcish units to increase their attack rate && movement speed temporarily";
    }

    private void OnComplete( ){
      SetPlayerTechResearched(this.Holder.Player, RESEARCH_ID, 1);
    }

    private void OnAdd( ){
      this.Holder.ModObjectLimit(RESEARCH_ID, UNLIMITED);
    }

    public  thistype ( ){
      thistype this = thistype.allocate("The Blood of Mannoroth", "Long ago, the orcs drank the blood of Mannoroth && were infused with demonic fury. A mere taste of his blood would reignite those powers.", "ReplaceableTextures\\CommandButtons\\BTNFountainOfLifeBlood.blp");
      this.AddQuestItem(QuestItemControlLegend.create(LEGEND_FOUNTAINOFBLOOD, false));
      ;;
    }


  }
}
