﻿using static War3Api.Common;

namespace AzerothWarsCSharp.MacroTools.SpellSystem
{
  public abstract class Spell
  {
    public int Id { get; }

    public abstract void OnCast(unit caster, unit target, float targetX, float targetY);
    
    protected int GetAbilityLevel(unit whichUnit)
    {
      return GetUnitAbilityLevel(whichUnit, Id);
    }

    protected Spell(int id)
    {
      Id = id;
    }
  }
}