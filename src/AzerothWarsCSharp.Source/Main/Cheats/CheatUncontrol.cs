
namespace AzerothWarsCSharp.Source.Main.Cheats
{
  public class CheatUncontrol{

    //**CONFIG
  
    private const string COMMAND = "-uncontrol ";
  
    //*ENDCONFIG

    private static void Actions( ){
      int i = 0;
      string enteredString = GetEventPlayerChatString();
      player p = GetTriggerPlayer();
      int pId = GetPlayerId(p);
      string parameter = SubString(enteredString, StringLength(COMMAND), StringLength(enteredString));

      if (parameter == "all"){
        i = 0;
        while(true){
          if ( i > MAX_PLAYERS){ break; }
          SetPlayerAlliance(Player(i), GetTriggerPlayer(), ALLIANCE_SHARED_CONTROL, false);
          SetPlayerAlliance(Player(i), GetTriggerPlayer(), ALLIANCE_SHARED_ADVANCED_CONTROL, false);
          i = i + 1;
        }
        DisplayTextToPlayer(p, 0, 0, "|cffD27575CHEAT:|r Revoked control of all players.");
      }else {
        SetPlayerAlliance(Player(S2I(parameter)), GetTriggerPlayer(), ALLIANCE_SHARED_CONTROL, false);
        SetPlayerAlliance(Player(S2I(parameter)), GetTriggerPlayer(), ALLIANCE_SHARED_ADVANCED_CONTROL, false);
        DisplayTextToPlayer(p, 0, 0, "|cffD27575CHEAT:|r Revoked control of player " + GetPlayerName(Player(S2I(parameter))) + ".");
      }
    }

    private static void OnInit( ){
      trigger trig = CreateTrigger(  );
      int i = 0;
      while(true){
        if ( i > MAX_PLAYERS){ break; }
        TriggerRegisterPlayerChatEvent( trig, Player(i), COMMAND, false );
        i = i + 1;
      }
      TriggerAddCondition(trig, ( CheatCondition));
      TriggerAddAction( trig,  Actions );
    }

  }
}
