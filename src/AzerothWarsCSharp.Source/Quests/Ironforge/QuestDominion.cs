using AzerothWarsCSharp.MacroTools;
using AzerothWarsCSharp.MacroTools.FactionSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.Source.Libraries;

namespace AzerothWarsCSharp.Source.Quests.Ironforge
{
  public sealed class QuestDominion : QuestData{

  
    private const int RESEARCH_ID = FourCC("R043")   ;//This research is given when the quest is completed
  


    protected override string CompletionPopup => "The Dwarven Empire is re-united again, Ironforge is ready for war again.";

    protected override string CompletionDescription => "Control of all units in Ironforge";

    private void GrantDominion(player whichPlayer ){
      group tempGroup = CreateGroup();
      unit u;

      //Transfer all Neutral Passive units in Dominion
      GroupEnumUnitsInRect(tempGroup, Regions.IronforgeAmbient.Rect, null);
      u = FirstOfGroup(tempGroup);
      while(true){
        if ( u == null){ break; }
        if (GetOwningPlayer(u) == Player(PLAYER_NEUTRAL_PASSIVE)){
          GeneralHelpers.UnitRescue(u, whichPlayer);
        }
        GroupRemoveUnit(tempGroup, u);
        u = FirstOfGroup(tempGroup);
      }
      DestroyGroup(tempGroup);
      tempGroup = null;
    }

    private void OnFail( ){
      GrantDominion(Player(PLAYER_NEUTRAL_AGGRESSIVE));
    }

    protected override void OnComplete(){
      GrantDominion(this.Holder.Player);
      if (GetLocalPlayer() == this.Holder.Player){
        PlayThematicMusicBJ( "war3mapImported\\DwarfTheme.mp3" );
      }
    }

    private void OnAdd( ){
      this.Holder.ModObjectLimit(RESEARCH_ID, 1);
    }

    public  thistype ( ){
      thistype this = thistype.allocate("Dwarven Dominion", "The Dwarven Dominion must be established before Ironforge can join the war.", "ReplaceableTextures\\CommandButtons\\BTNNorthrendCastle.blp");
      this.AddQuestItem(new QuestItemControlPoint(ControlPoint.GetFromUnitType(FourCC("n017"))));
      this.AddQuestItem(new QuestItemControlPoint(ControlPoint.GetFromUnitType(FourCC("n014"))));
      this.AddQuestItem(new QuestItemControlPoint(ControlPoint.GetFromUnitType(FourCC("n013"))));
      this.AddQuestItem(new QuestItemUpgrade(FourCC("h07G"), )h07E)));
      this.AddQuestItem(new QuestItemExpire(1462));
      this.AddQuestItem(new QuestItemSelfExists());
      this.ResearchId = RESEARCH_ID;
      ;;
    }


  }
}
