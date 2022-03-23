using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;

namespace AzerothWarsCSharp.Source.Quests.Zandalar
{
  public sealed class QuestGundrak : QuestData{

  
    private static readonly int GundrakResearch = FourCC("R02Q");
    private static readonly int WarlordId = FourCC("nftk");
    private static readonly int TrollShrineId = FourCC("o04X");
  


    protected override string CompletionPopup => 
      return "Gundrak has fallen. The Drakkari trolls lend their might to the " + this.Holder.Team.Name;
    }

    protected override string CompletionDescription => 
      return "Control of Gundrak, 300 gold tribute && the ability to train " + GetObjectName(WARLORD_ID) + "s from the " + GetObjectName(TROLL_SHRINE_ID);
    }

    protected override void OnComplete(){
      SetPlayerTechResearched(Holder.Player, GUNDRAK_RESEARCH, 1);
      AdjustPlayerStateBJ( 300, this.Holder.Player, PLAYER_STATE_RESOURCE_GOLD );
    }

    protected override void OnAdd( ){
      this.Holder.ModObjectLimit(GUNDRAK_RESEARCH, UNLIMITED);
    }

    public  QuestGundrak ( ){
      thistype this = thistype.allocate("The Drakkari Fortress", "The Drakkari troll of Gundrak believe their fortress to be impregnable. Capture it to gain their loyalty.", "ReplaceableTextures\\CommandButtons\\BTNTerrorTroll.blp");
      this.AddQuestItem(new QuestItemControlLegend(LEGEND_GUNDRAK, false));
      ;;
    }


  }
}
