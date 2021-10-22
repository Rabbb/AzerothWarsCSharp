﻿using AzerothWarsCSharp.Launcher.ObjectFactory.AbilityProperties;
using War3Api.Object;
using War3Api.Object.Abilities;

namespace AzerothWarsCSharp.Launcher.ObjectFactory.Abilities.Human
{
  public sealed class SunderingBladesFactory : PassiveAbilityFactory<SunderingBlades>
  {
    public LeveledAbilityPropertyFloat DamageBonusFlat { get; set; } = new("Damage bonus (flat)", 0);
    public LeveledAbilityPropertyFloat DamageBonusPercent { get; set; } = new("Damage bonus (percent)", 0, true);
    public LeveledAbilityPropertyDefenseType DefenseTypeAffected { get; set; } = new("Armor type affected", DefenseTypeInt.Small);

    protected override void ApplyStats(SunderingBlades ability)
    {
      ability.StatsLevels = Levels;
      for (var i = 0; i < Levels; i++)
      {
        ability.DataBonusDamageFlat[i + 1] = DamageBonusFlat[i];
        ability.DataBonusDamagePercent[i+1] = DamageBonusPercent[i];
        ability.DataDefenseTypeAffected[i + 1] = DefenseTypeAffected[i];
      }
    }

    public override SunderingBlades Generate(string newRawCode, ObjectDatabase objectDatabase)
    {
      var newAbility = new SunderingBlades(newRawCode, objectDatabase);
      Apply(newAbility);
      return newAbility;
    }

    public SunderingBladesFactory() : base()
    {
      Properties.Add(DamageBonusFlat);
      Properties.Add(DamageBonusPercent);
      Properties.Add(DefenseTypeAffected);
    }
  }
}