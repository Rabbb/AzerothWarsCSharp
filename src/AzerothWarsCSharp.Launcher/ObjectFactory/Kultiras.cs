﻿using AzerothWarsCSharp.Launcher.ObjectFactory.Abilities;
using AzerothWarsCSharp.Launcher.ObjectFactory.Units;
using System.Drawing;
using War3Api.Object;

namespace AzerothWarsCSharp.Launcher.ObjectFactory
{
  public static class Kultiras
  {
    public static void Setup()
    {
      try
      {
        //Sea Elemental
        var seaElemental = new UnitFactory(UnitType.Seaelemental, "ksea")
        {
          TextName = "Sea Elemental",
          ArtIconGameInterface = @"ReplaceableTextures\CommandButtons\BTNSeaElemental.blp",
          AbilitiesNormal = System.Array.Empty<Ability>(),
          DamageBase = 10,
          DamageNumberOfDice = 2,
          DamageSidesPerDie = 6,
          HitPoints = 600,
          Flavour = "Avatar of the sea's primordial force.",
        }.Generate();

        //Summon Sea Elemental
        var summonSeaElemental = new SummonWaterElementalFactory("asea")
        {
          Levels = 1,
          SummonedUnit = new Unit[] { seaElemental },
          SummonCount = new int[] { 1 },
          ArtIcon = seaElemental.ArtIconGameInterface,
          Duration = new int[] { 40 },
        }.Generate();

        //Tidesage
        var tidesage = new UnitFactory(UnitType.Priest, "ktid")
        {
          TextName = "Tidepriest",
          Flavour = "Spellcaster empowered with mystical control over the tides.",
          AbilitiesNormal = new Ability[] { summonSeaElemental },
          DamageBase = 4,
          DamageNumberOfDice = 2,
          DamageSidesPerDie = 7,
          HitPoints = 600,
        }.Generate();

        //Blacksmith
        var blacksmith = new BuildingFactory(UnitType.Blacksmith, "kbla")
        {
          //ButtonPosition = new Point(2, 0),
          ScalingValue = 0.85F,
          SelectionScale = 3.00F,
          HitPoints = 200,
          UnitsTrained = System.Array.Empty<Unit>(),
          ResearchesAvailable = System.Array.Empty<Upgrade>(),
          Flavour = "Where the weapons and armor of Kul'tiras are forged.",
          AbilitiesNormal = System.Array.Empty<Ability>()
        }.Generate();

        //Deckhand
        var deckhand = new WorkerFactory(UnitType.Peasant, "kdec")
        {
          TextName = "Deckhand",
          DamageBase = 4,
          DamageNumberOfDice = 1,
          DamageSidesPerDie = 2,
          HitPoints = 230,
          AbilitiesNormal = System.Array.Empty<Ability>(),
          StructuresBuilt = new Unit[] { },
          Flavour = "The backbone of Kul'tiran seafaring society."
        }.Generate();
      } catch
      {
        throw;
      }
    }
  }
}