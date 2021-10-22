﻿using AzerothWarsCSharp.Launcher.ObjectFactory.Abilities.Human;
using AzerothWarsCSharp.Launcher.ObjectFactory.Units;
using System.Drawing;
using War3Api.Object;

namespace AzerothWarsCSharp.Launcher.ObjectFactory
{
  public static class Human
  {
    public static void GenerateObjectData(ObjectDatabase objectDatabase)
    {
      //Militia
      var militiaFactory = new WorkerFactory(UnitType.Peasant_hpea)
      {
        TextName = "Deckhand",
        DamageBase = 11,
        DamageNumberOfDice = 1,
        DamageSidesPerDie = 2,
        HitPoints = 230,
        Flavour = "Basic worker unit that has taken up arms."
      };
      var militia = militiaFactory.Generate("zmil", objectDatabase);

      //Harvest
      var harvestfactory = new HarvestFactory()
      {
        Icon = @"GatherGold",
        TextName = "Gather",
        ButtonPosition = new Point(3, 1),
        Flavor = "Mines gold from gold mines and harvests lumber from trees."
      };
      var harvest = harvestfactory.Generate("zhar", objectDatabase);

      //Repair
      var repairfactory = new RepairFactory()
      {
        Icon = @"RepairOn",
        TextName = "Repair",
        ButtonPosition = new Point(1, 1),
        Flavor = "Repairs mechanical units and structures at the cost of resources."
      };
      var repair = repairfactory.Generate("zrep", objectDatabase);

      //Call to Arms
      var calltoarmsfactory = new CallToArmsFactory()
      {
        Icon = @"CallToArms",
        TextName = "Call to Arms",
        ButtonPosition = new Point(1, 2),
        AlternateFormUnit = { militia },
        Flavor = "Return to a nearby compatible structure to turn into a different unit."
      };
      var calltoarms = calltoarmsfactory.Generate("zcal", objectDatabase);

      //Peasant
      new WorkerFactory(UnitType.Peasant_hpea)
      {
        TextName = "Deckhand",
        DamageBase = 4,
        DamageNumberOfDice = 1,
        DamageSidesPerDie = 2,
        HitPoints = 230,
        AbilitiesNormal = new Ability[] { harvest, calltoarms, repair },
        Flavour = "Basic worker unit.",
      }.Generate("zpea", objectDatabase);

      //Defend
      var defendfactory = new DefendFactory()
      {
        Icon = @"Defend",
        TextName = "Defend",
        ButtonPosition = new Point(0, 2),
        Flavor = "Increases damage dealt to enemies with a particular armor type."
      };
      var defend = defendfactory.Generate("zdef", objectDatabase);

      //Footman
      new UnitFactory(UnitType.Footman)
      {
        TextName = "Footman",
        DamageBase = 11,
        DamageNumberOfDice = 1,
        DamageSidesPerDie = 2,
        HitPoints = 420,
        AbilitiesNormal = new Ability[] { defend },
        Flavour = "Versatile foot soldier.",
        Armor = 2,
        ArtModelFile = @"units\human\Footman\Footman"
      }.Generate("zfoo", objectDatabase);

      //Sundering Blades
      var sunderingbladesfactory = new SunderingBladesFactory()
      {
        Icon = @"SunderingBlades",
        TextName = "Sundering Blades",
        ButtonPosition = new Point(0, 2),
        Flavor = "Increases damage dealt to enemies with a particular armor type.",
        DamageBonusFlat = { 5 },
        DamageBonusPercent = {0.1f},
        DefenseTypeAffected = { DefenseTypeInt.Divine }
      };
      var sunderingblades = sunderingbladesfactory.Generate("zsun", objectDatabase);

      //Knight
      new UnitFactory(UnitType.Knight)
      {
        TextName = "Knight",
        DamageBase = 28,
        DamageNumberOfDice = 2,
        DamageSidesPerDie = 5,
        HitPoints = 885,
        AbilitiesNormal = new Ability[] { sunderingblades },
        Flavour = "Powerful mounted warrior.",
        Armor = 5,
        ArtModelFile = @"units\human\Knight\Knight"
      }.Generate("zkni", objectDatabase);

      //Holy Light
      var holyLightFactory = new HolyLightFactory()
      {
        AmountHealed = { 50, 100, 200, 250 },
        CastRange = { 300 },
        Levels = 4,
        Icon = @"HolyBolt",
        TextName = "Holy Light",
        ButtonPosition = new Point(0, 2),
        IsHeroAbility = false
      };
      var holyLight = holyLightFactory.Generate("zhol", objectDatabase);

      //Arthas
      new HeroFactory(UnitType.Paladin_Hpal)
      {
        AbilitiesHero = new Ability[] { holyLight },
        Strength = 100,
        Agility = 10,
        Intelligence = 5,
        ProperName = "Arthas",
        TextName = "Prince",
        ArtModelFile = @"units\human\Arthas\Arthas"
      }.Generate("Zart", objectDatabase);
    }
  }
}