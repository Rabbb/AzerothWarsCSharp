using AzerothWarsCSharp.Source.Main.Libraries.MacroTools;

namespace AzerothWarsCSharp.Source.Main.Libraries.QuestSystem.UtilityStructs
{
  public class QuestItemControlLegend{


    private Legend target = 0;
    private static int count = 0;
    private static thistype[] byIndex;
    private boolean canFail;

    float operator X( ){
      if (IsUnitType(target.Unit, UNIT_TYPE_STRUCTURE) || IsPlayerNeutralHostile(GetOwningPlayer(target.Unit))){
        return GetUnitX(target.Unit);
      }
      return 0;
    }

    float operator Y( ){
      if (IsUnitType(target.Unit, UNIT_TYPE_STRUCTURE) || IsPlayerNeutralHostile(GetOwningPlayer(target.Unit))){
        return GetUnitY(target.Unit);
      }
      return 0;
    }

    private void OnAdd( ){
      if (this.Holder.Team.ContainsPlayer(GetOwningPlayer(target.Unit))){
        this.Progress = QUEST_PROGRESS_COMPLETE;
      }
    }

    private void OnTargetChangeOwner( ){
      if (this.Holder.Team.ContainsPlayer(GetOwningPlayer(target.Unit))){
        this.Progress = QUEST_PROGRESS_COMPLETE;
      }else {
        if (canFail){
          this.Progress = QUEST_PROGRESS_FAILED;
        }else {
          this.Progress = QUEST_PROGRESS_INCOMPLETE;
        }
      }
    }

    public static void OnAnyUnitDeath( ){
      var i = 0;
      thistype loopItem;
      Legend triggerLegend = GetTriggerLegend();
      while(true){
        if ( i == thistype.count){ break; }
        loopItem = thistype.byIndex[i];
        if (loopItem.target == triggerLegend && loopItem.canFail == true){
          loopItem.Progress = QUEST_PROGRESS_FAILED;
        }
        i = i + 1;
      }
    }

    public static void OnAnyLegendChangeOwner( ){
      var i = 0;
      thistype loopItem;
      while(true){
        if ( i == thistype.count){ break; }
        loopItem = thistype.byIndex[i];
        if (loopItem.target == GetTriggerLegend()){
          loopItem.OnTargetChangeOwner();
        }
        i = i + 1;
      }
    }

    thistype (Legend target, boolean canFail ){

      this.target = target;
      this.Description = "Your team controls " + target.Name;
      this.canFail = canFail;
      this.targetWidget = target.Unit;
      thistype.byIndex[thistype.count] = this;
      thistype.count = thistype.count + 1;
      ;;
    }



    public static void Setup( ){
      trigger trig = CreateTrigger();
      OnLegendChangeOwner.register(trig);
      TriggerAddAction(trig,  OnAnyLegendChangeOwner);

      trig = CreateTrigger();
      OnLegendPermaDeath.register(trig);
      TriggerAddAction(trig,  OnAnyUnitDeath);
    }

  }
}
