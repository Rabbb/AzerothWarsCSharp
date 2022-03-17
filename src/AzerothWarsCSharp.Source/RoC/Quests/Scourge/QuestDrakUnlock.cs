using AzerothWarsCSharp.Source.Main.Libraries.MacroTools;
using AzerothWarsCSharp.Source.Main.Libraries.QuestSystem.UtilityStructs;

namespace AzerothWarsCSharp.Source.RoC.Quests.Scourge
{
  public class QuestDrakUnlock{

  
    private const int QUEST_RESEARCH_ID = FourCC(R08J);
  



    private string operator CompletionPopup( ){
      return "DrakFourCC(taron Keep is now under the control of the Scourge.";
    }

    private string operator CompletionDescription( ){
      return "Control of all buildings in DrakFourCC(taron Keep)";
    }

    private void OnFail( ){
      RescueNeutralUnitsInRect(gg_rct_DrakUnlock, Player(PLAYER_NEUTRAL_AGGRESSIVE));
    }

    private void OnComplete( ){
      RescueNeutralUnitsInRect(gg_rct_DrakUnlock, this.Holder.Player);
    }

    public  thistype ( ){
      thistype this = thistype.allocate("DrakFourCC(taron Keep", "Drak)taron)s Keep will be the place for an outpost by the sea.", "ReplaceableTextures\\CommandButtons\\BTNUndeadShipyard.blp");
      this.AddQuestItem(QuestItemControlPoint.create(ControlPoint.ByUnitType(FourCC(n030))));
      this.AddQuestItem(QuestItemControlLegend.create(LEGEND_DRAKTHARONKEEP, false));
      this.AddQuestItem(QuestItemExpire.create(1140));
      this.AddQuestItem(QuestItemSelfExists.create());
      this.ResearchId = QUEST_RESEARCH_ID;
      ;;
    }


  }
}
