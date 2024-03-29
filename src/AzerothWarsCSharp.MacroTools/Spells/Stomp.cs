﻿using AzerothWarsCSharp.MacroTools.SpellSystem;
using AzerothWarsCSharp.MacroTools.Wrappers;
using static War3Api.Common;

namespace AzerothWarsCSharp.MacroTools.Spells
{
  public class Stomp : Spell
  {
    public float DamageBase { get; init; } = 20;
    public float DamageLevel { get; init; } = 30;
    public int DurationBase { get; init; }
    public int DurationLevel { get; init; }
    public float Radius { get; init; } = 300;
    public int StunAbilityId { get; init; }
    public string StunOrderString { get; init; }
    
    private void DamageUnit(unit caster, widget target)
    {
      UnitDamageTarget(caster, target, DamageBase + DamageLevel * GetAbilityLevel(caster), false, false, ATTACK_TYPE_NORMAL,
        DAMAGE_TYPE_MAGIC, WEAPON_TYPE_WHOKNOWS);
    }

    private void StunUnit(unit caster, unit target)
    {
      var duration = DurationBase + DurationLevel * GetAbilityLevel(caster);
      if (StunAbilityId == 0 || StunOrderString == null || duration <= 0)
      {
        return;
      }
      DummyCast.CastOnUnit(caster, StunAbilityId, StunOrderString, duration, target);
    }

    public override void OnCast(unit caster, unit target, float targetX, float targetY)
    {
      var tempGroup = new GroupWrapper();
      tempGroup.EnumUnitsInRange(GetUnitX(caster), GetUnitY(caster), Radius);
      foreach (var enumUnit in tempGroup.EmptyToList())
      {
        if (CastFilters.IsTargetEnemyAndAlive(caster, enumUnit))
        {
          DamageUnit(caster, enumUnit);
          StunUnit(caster, enumUnit);
        }
      }
      DestroyEffect(AddSpecialEffect(@"Abilities\\Spells\\Orc\\Warstomp\\WarStompCaster.mdl", GetUnitX(caster),
        GetUnitY(caster)));
    }

    public Stomp(int id) : base(id)
    {
      
    }
  }
}