public class QuestKillDraenei{


    private string operator CompletionPopup( ){
      return "The Draenei have been eliminated from Outland && their gold mine is ours.";
    }

    private string operator CompletionDescription( ){
      return "The Draenei rich gold mine in Tempest Keep, the faster we destroy them, the more gold will be left";
    }

    private void OnComplete( ){
      group tempGroup = CreateGroup();
      unit u;

      AdjustPlayerStateBJ( 500, this.Holder.Player, PLAYER_STATE_RESOURCE_GOLD );
      AdjustPlayerStateBJ( 500, this.Holder.Player, PLAYER_STATE_RESOURCE_LUMBER );

      GroupEnumUnitsInRect(tempGroup, gg_rct_InstanceOutland, null);
      u = FirstOfGroup(tempGroup);
      while(true){
      if ( u == null){ break; }
        if (GetOwningPlayer(u) == FACTION_DRAENEI.Player){
          if (IsUnitType(u, UNIT_TYPE_STRUCTURE) && !IsUnitType(u, UNIT_TYPE_ANCIENT)){
            KillUnit(u);
          }
        }
        GroupRemoveUnit(tempGroup, u);
        u = FirstOfGroup(tempGroup);
      }
      DestroyGroup(tempGroup);
      tempGroup = null;
    }

    public  thistype ( ){
      thistype this = thistype.allocate("The Shattrah Massacre", "The Draenei race existence insults the Fel Horde demon masters, slaughter them all ", "ReplaceableTextures\\CommandButtons\\BTNChaosWolfRider.blp");
      this.AddQuestItem(QuestItemControlPoint.create(ControlPoint.ByUnitType(FourCC(n09X))));
      this.AddQuestItem(QuestItemLegendDead.create(LEGEND_EXODARSHIP));
      this.AddQuestItem(QuestItemSelfExists.create());
      ;;
    }


}
