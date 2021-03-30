﻿using AzerothWarsCSharp.Source.Libraries;
using static War3Api.Common;

namespace AzerothWarsCSharp.Source.Commands
{
  /// <summary>
  /// A cheat to change the user's faction.
  /// </summary>
  public static class CheatFaction
  {
    public static void Initialize()
    {
      CheatCommand.Register("faction", (player triggerPlayer, string[] arguments) =>
      {
        var newFaction = arguments[0];
        Person.ByPlayerHandle(triggerPlayer).Faction = Faction.ByName(newFaction);
        CheatCommand.Display(triggerPlayer, "Changed faction to " + newFaction + ".");
      }
      );
    }
  }
}