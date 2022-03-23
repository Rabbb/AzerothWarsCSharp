using AzerothWarsCSharp.MacroTools;
using AzerothWarsCSharp.MacroTools.FactionSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.Source.Libraries;

namespace AzerothWarsCSharp.Source.Quests.Scourge
{
  public sealed class QuestSpiderWar : QuestData{

  
    private const int QUEST_RESEARCH_ID = FourCC("R03A");
  


    protected override string CompletionPopup => "Northrend && the Icecrown Citadel is now under full control of the Lich King && the " + this.Holder.Team.Name + ".";

    protected override string CompletionDescription => "Access to the Plague Research at the Frozen Throne, KelFourCC(tuzad && Rivendare trainable && a base in Icecrown";

    private void OnFail( ){
      GeneralHelpers.RescueNeutralUnitsInRect(Regions.Ice_Crown.Rect, Player(PLAYER_NEUTRAL_AGGRESSIVE));
    }

    protected override void OnComplete(){
      GeneralHelpers.RescueNeutralUnitsInRect(Regions.Ice_Crown.Rect, this.Holder.Player);
      SetPlayerTechResearched(Holder.Player, FourCC("R03A"), 1);
      if (GetLocalPlayer() == this.Holder.Player){
        PlayThematicMusicBJ( "war3mapImported\\ScourgeTheme.mp3" );
      }
    }

    private void OnAdd( ){
      this.Holder.ModObjectLimit(QUEST_RESEARCH_ID, 1);
    }

    public  thistype ( ){
      thistype this = thistype.allocate("War of the Spider", "The proud Nerubians have declared war on the newly formed Lich King, destroy them to secure the continent of Northrend.", "ReplaceableTextures\\CommandButtons\\BTNNerubianQueen.blp");
      this.AddQuestItem(new QuestItemControlPoint(ControlPoint.GetFromUnitType(FourCC("n00I"))));
      this.AddQuestItem(new QuestItemControlPoint(ControlPoint.GetFromUnitType(FourCC("n08D"))));
      this.AddQuestItem(new QuestItemControlPoint(ControlPoint.GetFromUnitType(FourCC("n00G"))));
      this.AddQuestItem(QuestItemKillUnit.create(gg_unit_n074_1565)) ;//Nezar)azret
      this.AddQuestItem(new QuestItemUpgrade(FourCC("unp2"), )unpl)));
      this.AddQuestItem(new QuestItemExpire(1480));
      this.AddQuestItem(new QuestItemSelfExists());
      ;;
    }


  }
}
