namespace AzerothWarsCSharp.Source.Main.Libraries.QuestSystem.UtilityStructs
{
  public class QuestItemCastSpell{


    private unit caster;
    private int spellId = 0;
    private boolean holderOnly = false;

    private static int count = 0;
    private static thistype[] byIndex;

    unit operator Caster( ){
      ;.caster;
    }

    private void OnCast(unit caster ){
      if (this.Progress != QUEST_PROGRESS_COMPLETE && (GetOwningPlayer(caster) == this.Holder.Player || !holderOnly)){
        this.caster = caster;
        this.Progress = QUEST_PROGRESS_COMPLETE;
      }
    }

    private static void OnAnyUnitFinishesSpell( ){
      int i = 0;
      thistype loopItem;
      int spellAbilityId = GetSpellAbilityId();
      while(true){
        if ( i == thistype.count){ break; }
        loopItem = thistype.byIndex[i];
        if (loopItem.spellId == spellAbilityId){
          loopItem.OnCast(GetTriggerUnit());
        }
        i = i + 1;
      }
    }

    thistype (int spellId, boolean holderOnly ){

      PlayerUnitEventAddAction(EVENT_PLAYER_UNIT_SPELL_FINISH,  thistype.OnAnyUnitFinishesSpell) ;//TODO: use filtered events
      if (holderOnly){
        this.Description = "Cast " + GetObjectName(spellId);
      }else {
        this.Description = "Anyone casts " + GetObjectName(spellId);
      }
      this.spellId = spellId;
      this.holderOnly = holderOnly;
      thistype.byIndex[thistype.count] = this;
      thistype.count = thistype.count + 1;
      ;;
    }


  }
}
