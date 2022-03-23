using AzerothWarsCSharp.MacroTools;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.Source.Libraries;

namespace AzerothWarsCSharp.Source.Quests.Scarlet
{
  public sealed class QuestMonastery : QuestData{

  
    private const int RESEARCH_ID = FourCC("R03P")         ;//This research is required to complete the quest
    private const int QUEST_RESEARCH_ID = FourCC("R03F")   ;//This research is given when the quest is completed
  



    bool operator Global( ){
      return true;
    }

    protected override string CompletionPopup => "The Scarlet Monastery Hand is complete && ready to join the " + this.Holder.Team.Name + ".";

    protected override string CompletionDescription => "Control of all units in the Scarlet Monastery && you will unally the alliance";

    private void OnFail( ){
      GeneralHelpers.RescueNeutralUnitsInRect(Regions.ScarletAmbient.Rect, Player(PLAYER_NEUTRAL_AGGRESSIVE));
    }

    protected override void OnComplete(){
      SetPlayerTechResearched(FACTION_KULTIRAS.Player, FourCC("R06V"), 1);
      SetPlayerTechResearched(FACTION_LORDAERON.Player, FourCC("R06V"), 1);
      SetPlayerTechResearched(FACTION_SCARLET.Player, FourCC("R086"), 1);
      GeneralHelpers.RescueNeutralUnitsInRect(Regions.ScarletAmbient.Rect, this.Holder.Player);
      WaygateActivateBJ( true, gg_unit_h00T_0786 );
      WaygateSetDestinationLocBJ( gg_unit_h00T_0786, GetRectCenter(gg_rct_Scarlet_Monastery_Interior) );
      this.Holder.Team = TEAM_SCARLET;
      this.Holder.Name = "Scarlet";
      this.Holder.Icon = "ReplaceableTextures\\CommandButtons\\BTNSaidan Dathrohan.blp";
      PlayThematicMusicBJ( "war3mapImported\\ScarletTheme.mp3" );
      SetPlayerStateBJ( this.Holder.Player, PLAYER_STATE_FOOD_CAP_CEILING, 300 );
    }

    private void OnAdd( ){
      this.Holder.ModObjectLimit(RESEARCH_ID, 1);
    }

    public  thistype ( ){
      thistype this = thistype.allocate("The Secret Cloister", "The Scarlet Monastery is the perfect place for the secret base of the Scarlet Crusade.", "ReplaceableTextures\\CommandButtons\\BTNDivine_Reckoning_Icon.blp");
      this.AddQuestItem(new QuestItemResearch(RESEARCH_ID, FourCC("h00T")));
      this.AddQuestItem(new QuestItemSelfExists());
      this.ResearchId = QUEST_RESEARCH_ID;
      ;;
    }


  }
}
