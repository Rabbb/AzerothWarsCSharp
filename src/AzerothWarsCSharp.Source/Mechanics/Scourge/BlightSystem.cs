﻿using System.Collections.Generic;
using AzerothWarsCSharp.MacroTools;
using AzerothWarsCSharp.MacroTools.FactionSystem;
using AzerothWarsCSharp.MacroTools.Libraries;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace AzerothWarsCSharp.Source.Mechanics.Scourge
{
  /// <summary>
  ///   Units can be registered to the <see cref="BlightSystem" /> so that when they are killed by allies of a specicic
  ///   <see cref="Faction" />, they spread a certain amount of blight around them.
  /// </summary>
  public static class BlightSystem
  {
    private static readonly Dictionary<unit, BlightParameters> BlightParameters = new();
    private static Faction? _blightFaction;

    private static bool _initialized;

    private static void UnitDies()
    {
      var triggerUnit = GetTriggerUnit();
      var parameters = BlightParameters[triggerUnit];

      if (_blightFaction?.Team is not null && _blightFaction.Player is not null &&
          _blightFaction.Team.ContainsPlayer(GetOwningPlayer(GetKillingUnit())))
      {
        GeneralHelpers.SetBlightRadius(_blightFaction.Player, new Point(GetUnitX(triggerUnit), GetUnitY(triggerUnit)),
          parameters.PrimaryBlightRadius, true);
        if (parameters.RandomBlightRectangle is not null)
          for (var i = 0; i < parameters.RandomBlightCount; i++)
            GeneralHelpers.SetBlightRadius(_blightFaction.Player, parameters.RandomBlightRectangle.GetRandomPoint(),
              parameters.RandomBlightRadius, true);
      }
    }

    /// <summary>
    ///   Causes the specified unit to create blight around it when it dies.
    /// </summary>
    /// <param name="whichUnit">The dying unit.</param>
    /// <param name="blightParameters">Instructions as to how much blight should be created and where.</param>
    /// <exception cref="SystemNotInitializedException">Thrown if the system hasn't been initialized.</exception>
    public static void Register(unit whichUnit, BlightParameters blightParameters)
    {
      if (!_initialized) throw new SystemNotInitializedException($"{nameof(BlightSystem)} has not been initialized.");

      var deathTrigger = CreateTrigger();
      TriggerRegisterUnitEvent(deathTrigger, whichUnit, EVENT_UNIT_DEATH);
      TriggerAddAction(deathTrigger, UnitDies);
      BlightParameters.Add(whichUnit, blightParameters);
    }

    public static void Setup(Faction blightFaction)
    {
      if (_initialized)
        throw new SystemAlreadyInitializedException($"{nameof(BlightSystem)} has already been initialized.");

      _blightFaction = blightFaction;
      _initialized = true;
    }
  }
}