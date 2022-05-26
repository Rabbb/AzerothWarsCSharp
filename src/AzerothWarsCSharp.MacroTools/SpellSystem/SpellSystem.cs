﻿using System;
using System.Collections.Generic;
using WCSharp.Events;
using static War3Api.Common;

namespace AzerothWarsCSharp.MacroTools.SpellSystem
{
  public static class SpellSystem
  {
    private static readonly Dictionary<int, Spell> SpellsByAbilityId = new();

    public static Spell GetSpellByAbilityId(int abilityId)
    {
      if (!SpellsByAbilityId.ContainsKey(abilityId))
        throw new Exception($"There is no Spell with abilityId {abilityId}.");
      return SpellsByAbilityId[abilityId];
    }

    private static void OnStop()
    {
      SpellsByAbilityId[GetSpellAbilityId()]
        .OnStop(GetTriggerUnit());
    }
    
    private static void OnCast()
    {
      SpellsByAbilityId[GetSpellAbilityId()]
        .OnCast(GetTriggerUnit(), GetSpellTargetUnit(), GetSpellTargetX(), GetSpellTargetY());
    }

    private static void OnLearn()
    {
      Console.WriteLine("a");
      SpellsByAbilityId[GetLearnedSkill()].OnLearn(GetTriggerUnit());
    }

    public static void Register(TakeDamageEffect takeDamageEffect)
    {
      PlayerUnitEvents.Register(PlayerUnitEvent.UnitTypeDamages, takeDamageEffect.OnTakesDamage,
        takeDamageEffect.DamagedUnitTypeId);
    }

    /// <summary>
    ///   Registers an <see cref="UnitEffect" /> to the <see cref="SpellSystem" />.
    /// </summary>
    public static void Register(UnitEffect unitEffect)
    {
      PlayerUnitEvents.Register(PlayerUnitEvent.UnitTypeDamages, unitEffect.OnDealsDamage, unitEffect.UnitTypeId);
      PlayerUnitEvents.Register(PlayerUnitEvent.UnitTypeIsCreated, unitEffect.OnCreated, unitEffect.UnitTypeId);
      PlayerUnitEvents.Register(PlayerUnitEvent.HeroTypeFinishesRevive, unitEffect.OnCreated, unitEffect.UnitTypeId);
    }

    /// <summary>
    ///   Registers a spell to the SpellSystem.
    /// </summary>
    public static void Register(Spell spell)
    {
      PlayerUnitEvents.Register(PlayerUnitEvent.SpellEffect, OnCast, spell.Id);
      PlayerUnitEvents.Register(PlayerUnitEvent.SpellEndCast, OnStop, spell.Id);
      PlayerUnitEvents.Register(PlayerUnitEvent.SpellLearnedByHeroType, OnLearn, spell.Id);
      SpellsByAbilityId.Add(spell.Id, spell);
    }
  }
}