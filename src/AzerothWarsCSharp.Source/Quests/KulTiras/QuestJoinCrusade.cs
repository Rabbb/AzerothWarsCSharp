
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;

namespace AzerothWarsCSharp.Source.Quests.KulTiras
{
  public sealed class QuestJoinCrusade : QuestData{

  
    private static readonly int QUEST_RESEARCH_ID = FourCC("R06U")   ;//This research is given when the quest is completed
  



    protected override string CompletionPopup => "Kul Tiras has joined the Scarlet Crusade";

    protected override string CompletionDescription => "Unlock Order Inquisitor && join the Scarlet Crusade";

    protected override void OnComplete(){
      UnitRemoveAbilityBJ( FourCC("A0JB"), LEGEND_ADMIRAL.Unit);
      Holder.Team = TEAM_SCARLET;
    }

    public  QuestJoinCrusade ( ){
      thistype this = thistype.allocate("Join the Crusade", "Daelin Proudmoore sees the plight of the Scarlet Crusade. As fellow human survivors of horrible war, they should join forces with KulFourCC("tiras.", "ReplaceableTextures\\CommandButtons\\BTNDivine_Reckoning_Icon.blp"");
      AddQuestItem(new QuestItemCastSpell(FourCC("A0JB"), true));
      ResearchId = QUEST_RESEARCH_ID;
      
    }


  }
}
