using AzerothWarsCSharp.Source.Main.Libraries.QuestSystem.UtilityStructs;

namespace AzerothWarsCSharp.Source.RoC.Quests.Stormwind
{
  public class QuestNethergarde{


    private string operator CompletionPopup( ){
      return "Varian has come to relieve the Nethergarde garrison.";
    }

    private string operator CompletionDescription( ){
      return "You gain control of the Nethergarde base";
    }

    private void GrantNethergarde(player whichPlayer ){
      group tempGroup = CreateGroup();
      unit u;

      //Transfer all Neutral Passive units in Nethergarde
      GroupEnumUnitsInRect(tempGroup, gg_rct_NethergardeUnlock, null);
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

    private void OnFail( ){
      this.GrantNethergarde(Player(PLAYER_NEUTRAL_AGGRESSIVE));
    }

    private void OnComplete( ){
      this.GrantNethergarde(this.Holder.Player);
      FACTION_STORMWIND.ModObjectLimit(FourCC(h03F),1)               ;//Reginald windsor
    }

    private void OnAdd( ){
    }

    public  thistype ( ){
      thistype this = thistype.allocate("Nethergarde relief", "The nethergarde fort is holding down the Dark Portal, they will need to be reinforced soon!", "ReplaceableTextures\\CommandButtons\\BTNNobbyMansionBarracks.blp");
      this.AddQuestItem(QuestItemLegendInRect.create(LEGEND_VARIAN, gg_rct_NethergardeUnlock, "Nethergarde"));
      this.AddQuestItem(QuestItemExpire.create(1440));
      this.AddQuestItem(QuestItemSelfExists.create());
      ;;
    }


  }
}
