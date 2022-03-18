//When a Ravager reduces an enemy units hit points such that it ends up with less than 500% of the Ravager)s damage, it dies instantly.
namespace AzerothWarsCSharp.Source.Main.Spells.Warsong
{
  public class Execute{

  
    private const int UNITTYPE_ID = FourCC(o021);
    private const string EFFECT = "Objects\\Spawnmodels\\Human\\HumanLargeDeathExplode\\HumanLargeDeathExplode.mdl";
    private const int DAMAGE_MULT = 5;
  

    private static void OnDamage( ){
      unit triggerUnit = GetTriggerUnit();
      if (BlzGetEventIsAttack() && GetUnitState(triggerUnit, UNIT_STATE_LIFE) < GetEventDamage() + GetUnitAverageDamage(GetEventDamageSource(), 0) * DAMAGE_MULT){
        BlzSetEventDamage(GetUnitState(triggerUnit, UNIT_STATE_LIFE) + 1);
        DestroyEffect(AddSpecialEffectTarget(EFFECT, triggerUnit, "origin"));
      }
      triggerUnit = null;
    }

    public static void Setup( ){
      RegisterUnitTypeInflictsDamageAction(UNITTYPE_ID,  OnDamage);
    }

  }
}
