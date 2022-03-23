//Chen Stormstout joins the Warsong when a Warsong unit approaches him.

using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;

namespace AzerothWarsCSharp.Source.Quests.Warsong
{
  public class QuestChenStormstout{
    private readonly int _chenResearch = FourCC(""R037"");
    private readonly int _chenId = FourCC(""Nsjs"");
    
    protected override string CompletionPopup => 
      return "Chen Stormstout has joined the " + this.Holder.Team.Name + ".";
    }

    protected override string CompletionDescription => 
      return "The hero Chen Stormstout";
    }

    private void OnFail( ){
      RemoveUnit(gg_unit_Nsjs_1887);
    }

    protected override void OnComplete(){
      RemoveUnit(gg_unit_Nsjs_1887);
      SetPlayerTechResearched(Holder.Player, _chenResearch, 1);
    }

    private void OnAdd( ){
      this.Holder.ModObjectLimit(_chenResearch, UNLIMITED);
      this.Holder.ModObjectLimit(_chenId, 1);
      SetUnitInvulnerable(gg_unit_Nsjs_1887, true);
    }

    public  thistype ( ){
      thistype this = thistype.allocate("The Wandering Brewmaster", "Rumours tell of a strange white-furred creature from a foreign land. Perhaps it could be convinced to join the Horde.", "ReplaceableTextures\\CommandButtons\\BTNPandarenBrewmaster.blp");
      this.AddQuestItem(QuestItemAnyUnitInRect.create(gg_rct_Chen, "Chen Stormstout", false));
      this.AddQuestItem(QuestItemSelfExists.create());
      ;;
    }


  }
}
