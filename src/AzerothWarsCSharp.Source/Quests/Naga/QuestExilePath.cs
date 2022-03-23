using AzerothWarsCSharp.MacroTools;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.Source.Libraries;

namespace AzerothWarsCSharp.Source.Quests.Naga
{
  public sealed class QuestExilePath : QuestData{

  
    private const int RESEARCH_ID = FourCC("R063")         ;//This research is required to complete the quest
    private const int QUEST_RESEARCH_ID = FourCC("R008")   ;//This research is given when the quest is completed
  



    private void GrantAkama(player whichPlayer ){
      group tempGroup = CreateGroup();
      unit u;

      //Transfer all Neutral Passive units in Exiled
      GroupEnumUnitsInRect(tempGroup, Regions.AkamaUnlock.Rect, null);
      u = FirstOfGroup(tempGroup);
      while(true){
        if ( u == null){ break; }
        if (GetOwningPlayer(u) == Player(PLAYER_NEUTRAL_PASSIVE)){
          UnitRescue(u, whichPlayer);
        }
        GroupRemoveUnit(tempGroup, u);
        u = FirstOfGroup(tempGroup);
      }
      DestroyGroup(tempGroup);
      tempGroup = null;
    }

    bool operator Global( ){
      return true;
    }

    protected override string CompletionPopup => "Illidan has invaded Outland && has allied himself with the Draenei Broken Ones.";

    protected override string CompletionDescription => "Open a portal to Outland, grants you the Draenei village near it, enables you to train Akama, Najentus && Draenei units, grants you 300 food limit && grants you 800 gold";

    protected override void OnComplete(){
      GrantAkama(Holder.Player);
      FACTION_NAGA.ModObjectLimit(FourCC("n08W"), UNLIMITED)   ;//Lost One Den
      FACTION_NAGA.ModObjectLimit(FourCC("ndrn"), UNLIMITED)   ;//Vindicator
      FACTION_NAGA.ModObjectLimit(FourCC("ndrs"), 6)   ;//Seer
      SetUnitOwner(LEGEND_NZOTH.Unit, Player(PLAYER_NEUTRAL_AGGRESSIVE), true);
      REDEMPTION_PATH.Progress = QUEST_PROGRESS_FAILED;
      MADNESS_PATH.Progress = QUEST_PROGRESS_FAILED;
      WaygateActivateBJ( true, gg_unit_n07E_1491 );
      WaygateActivateBJ( true, gg_unit_n07E_0958 );
      ShowUnitShow( gg_unit_n07E_1491  );
      ShowUnitShow( gg_unit_n07E_0958 );
      WaygateSetDestinationLocBJ( gg_unit_n07E_1491, GetRectCenter(gg_rct_NazjatarExit3) );
      WaygateSetDestinationLocBJ( gg_unit_n07E_0958 , GetRectCenter(gg_rct_IllidanOutlandEntrance) );
      SetPlayerTechResearched(FACTION_SENTINELS.Player, FourCC("R06D"), 1);
      Holder.Name = "Illidari";
      WaygateActivateBJ( true, gg_unit_h01D_3378 );
      ShowUnitShow( gg_unit_h01D_3378 );
      WaygateSetDestinationLocBJ( gg_unit_h01D_3378, GetRectCenter(gg_rct_NazjatarExit2) );
      WaygateActivateBJ( true, gg_unit_h01A_0402 );
      ShowUnitShow( gg_unit_h01A_0402 );
      WaygateSetDestinationLocBJ( gg_unit_h01A_0402, GetRectCenter(gg_rct_NazjatarExit1) );
      WaygateActivateBJ( true, gg_unit_h01D_3381 );
      ShowUnitShow( gg_unit_h01D_3381 );
      WaygateSetDestinationLocBJ( gg_unit_h01D_3381, GetRectCenter(gg_rct_NazjatarEntrance1) );
      WaygateActivateBJ( true, gg_unit_h01D_3384 );
      ShowUnitShow( gg_unit_h01D_3384 );
      WaygateSetDestinationLocBJ( gg_unit_h01D_3384, GetRectCenter(gg_rct_NazjatarEntrance2) );
      SetPlayerStateBJ( Holder.Player, PLAYER_STATE_FOOD_CAP_CEILING, 300 );
      AdjustPlayerStateBJ( 800, Holder.Player, PLAYER_STATE_RESOURCE_GOLD );
    }

    public  QuestExilePath ( ){
      thistype this = thistype.allocate("A Parting of Ways", "Illidan must go his own way to find power, && Outland is the perfect place to acquire it.", "ReplaceableTextures\\CommandButtons\\BTNIllidanDemonicPower.blp");
      AddQuestItem(new QuestItemResearch(RESEARCH_ID, FourCC("n055")));
      AddQuestItem(new QuestItemControlLegend(LEGEND_ILLIDAN, true));
      AddQuestItem(new QuestItemSelfExists());
      this.AddQuestItem(new QuestItemLegendReachRect(LEGEND_ILLIDAN, Regions.NazjatarHidden.Rect, "Nazjatar"));
      ResearchId = QUEST_RESEARCH_ID;
      ;;
    }


  }
}
