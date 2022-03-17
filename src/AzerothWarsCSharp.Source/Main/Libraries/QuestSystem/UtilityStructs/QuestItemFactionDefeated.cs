public class QuestItemFactionDefeated{


    private static int count = 0;
    private static thistype[] byIndex;
    private Faction target = 0;

    static void OnAnyFactionScoreStatusChanged( ){
      int i = 0;
      Faction triggerFaction = GetTriggerFaction();
      if (triggerFaction.ScoreStatus == SCORESTATUS_DEFEATED){
        while(true){
          if ( i == thistype.count){ break; }
          if (thistype.byIndex[i].target == triggerFaction){
            thistype.byIndex[i].Progress = QUEST_PROGRESS_COMPLETE;
          }
          i = i + 1;
        }
      }
    }

     thistype (Faction whichFaction ){

      thistype.byIndex[thistype.count] = this;
      thistype.count = thistype.count + 1;
      this.target = whichFaction;
      this.Description = whichFaction.Name + " has been defeated";
      ;;
    }


  private static void OnInit( ){
    trigger trig = CreateTrigger();
    FactionScoreStatusChanged.register(trig);
    TriggerAddAction(trig,  QuestItemFactionDefeated.OnAnyFactionScoreStatusChanged);
  }

}
