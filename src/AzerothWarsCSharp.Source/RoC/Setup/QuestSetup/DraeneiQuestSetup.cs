using AzerothWarsCSharp.Source.Main.Libraries.QuestSystem;
using AzerothWarsCSharp.Source.RoC.Quests.Draenei;

namespace AzerothWarsCSharp.Source.RoC.Setup.QuestSetup
{
  public class DraeneiQuestSetup{

    public static void OnInit( ){
      //Setup
      QuestData newQuest = FACTION_DRAENEI.AddQuest(QuestExiled.create());
      FACTION_DRAENEI.StartingQuest = newQuest;
      //Early duel
      FACTION_DRAENEI.AddQuest(QuestFirstWave.create());
      FACTION_DRAENEI.AddQuest(QuestSurvivorsShattrah.create());
      FACTION_DRAENEI.AddQuest(QuestBrokenOne.create());
      FACTION_DRAENEI.AddQuest(QuestTriumvirate.create());

      SHIP_ARGUS = QuestShipArgus.create();
      //Misc
    }

  }
}
