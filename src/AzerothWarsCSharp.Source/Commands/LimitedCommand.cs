//A command that pings all units belonging to the user that have a limit on how many of them can be made.

using AzerothWarsCSharp.MacroTools.FactionSystem;
using AzerothWarsCSharp.MacroTools.Wrappers;
using static War3Api.Common;
using static AzerothWarsCSharp.MacroTools.Libraries.GeneralHelpers;

namespace AzerothWarsCSharp.Source.Commands
{
  public static class LimitedCommand
  {
    private const string COMMAND = "-limited";

    private static void Actions()
    {
      var triggerPlayer = GetTriggerPlayer();
      Faction triggerFaction = triggerPlayer.GetFaction();
      foreach (var unit in new GroupWrapper().EnumUnitsOfPlayer(triggerPlayer).EmptyToList())
      foreach (var objectTypeId in triggerFaction.GetLimitedObjects())
      {
        var objectLimit = triggerFaction.GetObjectLimit(objectTypeId);
        if (objectLimit < Faction.UNLIMITED && GetUnitTypeId(unit) == triggerFaction.GetObjectLimit(objectTypeId))
          if (GetLocalPlayer() == triggerPlayer)
            PingMinimap(GetUnitX(unit), GetUnitY(unit), 5);
      }
    }

    public static void Setup()
    {
      trigger trig = CreateTrigger();
      foreach (var player in GetAllPlayers()) TriggerRegisterPlayerChatEvent(trig, player, COMMAND, true);
      TriggerAddAction(trig, Actions);
    }
  }
}