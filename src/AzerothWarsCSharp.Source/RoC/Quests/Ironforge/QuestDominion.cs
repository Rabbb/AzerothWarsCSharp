public class QuestDominion{

  
    private const int RESEARCH_ID = FourCC(R043)   ;//This research is given when the quest is completed
  


    private string operator CompletionPopup( ){
      return "The Dwarven Empire is re-united again, Ironforge is ready for war again.";
    }

    private string operator CompletionDescription( ){
      return "Control of all units in Ironforge";
    }

    private void GrantDominion(player whichPlayer ){
      group tempGroup = CreateGroup();
      unit u;

      //Transfer all Neutral Passive units in Dominion
      GroupEnumUnitsInRect(tempGroup, gg_rct_IronforgeAmbient, null);
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
      this.GrantDominion(Player(PLAYER_NEUTRAL_AGGRESSIVE));
    }

    private void OnComplete( ){
      this.GrantDominion(this.Holder.Player);
      if (GetLocalPlayer() == this.Holder.Player){
        PlayThematicMusicBJ( "war3mapImported\\DwarfTheme.mp3" );
      }
    }

    private void OnAdd( ){
      this.Holder.ModObjectLimit(RESEARCH_ID, 1);
    }

    public  thistype ( ){
      thistype this = thistype.allocate("Dwarven Dominion", "The Dwarven Dominion must be established before Ironforge can join the war.", "ReplaceableTextures\\CommandButtons\\BTNNorthrendCastle.blp");
      this.AddQuestItem(QuestItemControlPoint.create(ControlPoint.ByUnitType(FourCC(n017))));
      this.AddQuestItem(QuestItemControlPoint.create(ControlPoint.ByUnitType(FourCC(n014))));
      this.AddQuestItem(QuestItemControlPoint.create(ControlPoint.ByUnitType(FourCC(n013))));
      this.AddQuestItem(QuestItemUpgrade.create(FourCC(h07G), )h07E)));
      this.AddQuestItem(QuestItemExpire.create(1462));
      this.AddQuestItem(QuestItemSelfExists.create());
      this.ResearchId = RESEARCH_ID;
      ;;
    }


}
