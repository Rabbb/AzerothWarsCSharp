using AzerothWarsCSharp.MacroTools.Wrappers;
using static War3Api.Common;  using static AzerothWarsCSharp.MacroTools.Libraries.GeneralHelpers;

namespace AzerothWarsCSharp.MacroTools.Cheats
{
  public static class CheatMp
  {
    private const string COMMAND = "-mp ";
    private static string? _parameter;


    private static void SetMana(unit whichUnit)
    {
      SetUnitState(whichUnit, UNIT_STATE_MANA, S2R(_parameter));
    }

    private static void Actions()
    {
      if (!TestSafety.CheatCondition()) return;
      string enteredString = GetEventPlayerChatString();
      player p = GetTriggerPlayer();
      _parameter = SubString(enteredString, StringLength(COMMAND), StringLength(enteredString));

      if (S2I(_parameter) >= 0)
      {
        foreach (var unit in new GroupWrapper().EnumSelectedUnits(p).EmptyToList())
        {
          SetMana(unit);
        }
        DisplayTextToPlayer(p, 0, 0, "|cffD27575CHEAT:|r Setting mana of selected units to " + _parameter + ".");
      }
    }

    public static void Setup()
    {
      trigger trig = CreateTrigger();
      foreach (var player in GetAllPlayers()) TriggerRegisterPlayerChatEvent(trig, player, COMMAND, false);
      TriggerAddAction(trig, Actions);
    }
  }
}