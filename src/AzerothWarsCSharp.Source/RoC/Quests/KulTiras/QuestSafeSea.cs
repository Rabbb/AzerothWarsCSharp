using AzerothWarsCSharp.Source.Main.Libraries.MacroTools;
using AzerothWarsCSharp.Source.Main.Libraries.QuestSystem.UtilityStructs;

namespace AzerothWarsCSharp.Source.RoC.Quests.KulTiras
{
  public class QuestSafeSea{

  
    private const int QUEST_RESEARCH_ID = FourCC(R06T)   ;//This research is given when the quest is completed
  


    private string operator CompletionPopup( ){
      return "With the SeaFourCC(s now secure, the Ember Order can be reformed && Lucille Waycrest is trainable";
    }

    private string operator CompletionDescription( ){
      return "The Order of Embers is reborn && Lucille Waycrest is trainable";
    }

    private void OnComplete( ){

    }

    public  thistype ( ){
      thistype this = thistype.allocate("Safe Sea Decree", "The seas must be secured && the KulFourCC(tiras navy must be returned to its former glory!", "ReplaceableTextures\\CommandButtons\\BTNKulTirasDreadnought.blp");
      this.AddQuestItem(QuestItemTrain.create(FourCC(hdes),)hshy), 2));
      this.AddQuestItem(QuestItemTrain.create(FourCC(h04J),)hshy), 1));
      this.AddQuestItem(QuestItemControlPoint.create(ControlPoint.ByUnitType(FourCC(n01W))));
      this.AddQuestItem(QuestItemControlPoint.create(ControlPoint.ByUnitType(FourCC(n07L))));
      this.AddQuestItem(QuestItemControlPoint.create(ControlPoint.ByUnitType(FourCC(n08Q))));
      this.AddQuestItem(QuestItemControlPoint.create(ControlPoint.ByUnitType(FourCC(n09K))));
      this.ResearchId = QUEST_RESEARCH_ID;
      ;;
    }


  }
}
