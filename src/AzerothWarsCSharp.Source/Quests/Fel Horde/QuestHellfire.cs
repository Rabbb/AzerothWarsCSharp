using AzerothWarsCSharp.MacroTools;
using AzerothWarsCSharp.MacroTools.FactionSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.Source.Libraries;

namespace AzerothWarsCSharp.Source.Quests.Fel_Horde
{
  public sealed class QuestHellfire : QuestData{

  
    private const int QUEST_RESEARCH_ID = FourCC("R00P");
  


    protected override string CompletionPopup => "Hellfire Citadel has been subjugated, && its military is now free to assist the " + this.Holder.Team.Name + ".";

    protected override string CompletionDescription => "Control of all units in Hellfire Citadel && enable Kargath to be trained at the altar";

    private void GrantHellfire(player whichPlayer ){
      group tempGroup = CreateGroup();
      unit u;

      //Transfer all Neutral Passive units in Hellfire Citadel
      GroupEnumUnitsInRect(tempGroup, Regions.HellfireUnlock.Rect, null);
      u = FirstOfGroup(tempGroup);
      while(true){
        if ( u == null){ break; }
        if (GetOwningPlayer(u) == Player(PLAYER_NEUTRAL_AGGRESSIVE)){
          GeneralHelpers.UnitRescue(u, whichPlayer);
        }
        GroupRemoveUnit(tempGroup, u);
        u = FirstOfGroup(tempGroup);
      }
      DestroyGroup(tempGroup);
      tempGroup = null;
    }

    protected override void OnComplete(){
      GeneralHelpers.UnitRescue(gg_unit_n081_0882, FACTION_FEL_HORDE.Player);
      GeneralHelpers.UnitRescue(gg_unit_n081_0717, FACTION_FEL_HORDE.Player);
      SetPlayerTechResearched(Holder.Player, FourCC("R00P"), 1);
      GrantHellfire(this.Holder.Player);
      if (GetLocalPlayer() == this.Holder.Player){
        PlayThematicMusicBJ( "war3mapImported\\FelTheme.mp3" );
      }
    }

    private void OnFail( ){
      GrantHellfire(Player(PLAYER_NEUTRAL_AGGRESSIVE));
    }

    private void OnAdd( ){
      this.Holder.ModObjectLimit(QUEST_RESEARCH_ID, 1);
    }

    public  thistype ( ){
      thistype this = thistype.allocate("The Citadel", "The clans holding Hellfire Citadel do !respect Kargath authority yet, destroy Murmur to finally establish Magtheridon as the undisputable king of Outland", "ReplaceableTextures\\CommandButtons\\BTNFelOrcFortress.blp");
      this.AddQuestItem(new QuestItemLegendDead(LEGEND_EXODARSHIP));
      this.AddQuestItem(new QuestItemControlPoint(ControlPoint.GetFromUnitType(FourCC("n01J"))));
      this.AddQuestItem(new QuestItemControlPoint(ControlPoint.GetFromUnitType(FourCC("n02N"))));
      this.AddQuestItem(new QuestItemUpgrade(FourCC("o030"), )o02Y)));
      this.AddQuestItem(new QuestItemExpire(1450));
      this.AddQuestItem(QuestItemSelfExists);
      ;;
    }


  }
}
