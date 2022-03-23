using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;

namespace AzerothWarsCSharp.Source.Quests.Sentinels
{
  public sealed class QuestSentinelsKillFrostwolf : QuestData{

  
    private const int RESEARCH_ID = FourCC("R052");
    private const int AMARA_ID = FourCC("h03I");
  


    protected override string CompletionPopup => "The Frostwolves have been ousted from Kalimdor, along with their Tauren allies. They will !be missed.";

    protected override string CompletionDescription => "The demihero Amara && the hero Jarod";

    protected override void OnComplete(){
      SetPlayerTechResearched(Holder.Player, RESEARCH_ID, 1);
      DisplayUnitTypeAcquired(Holder.Player, AMARA_ID, "You can now revive Amara from the Altar of Elders.");
    }

    private void OnAdd( ){
      Holder.ModObjectLimit(AMARA_ID, 1);
      Holder.ModObjectLimit(RESEARCH_ID, UNLIMITED);
    }

    public  thistype ( ){
      thistype this = thistype.allocate("Drive Them Back", "The Frostwolf Clan is beginning to seize a firm foothold within the Barrens && on the plains of Mulgore. They must be driven back.", "ReplaceableTextures\\CommandButtons\\BTNThrall.blp");
      AddQuestItem(new QuestItemLegendDead(LEGEND_THUNDERBLUFF));
      ;;
    }


  }
}
