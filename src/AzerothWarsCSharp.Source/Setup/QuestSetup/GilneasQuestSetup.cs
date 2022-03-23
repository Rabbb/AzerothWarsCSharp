using AzerothWarsCSharp.MacroTools.QuestSystem;

namespace AzerothWarsCSharp.Source.Setup.QuestSetup
{
  public class GilneasQuestSetup{

    public static void Setup( ){
      //Early duel
      QuestData chapterOne = FACTION_GILNEAS.AddQuest(QuestGilneasChapterOne.create());
      QuestData chapterTwo = FACTION_GILNEAS.AddQuest(QuestGilneasChapterTwo.create());
      QuestData chapterThree = FACTION_GILNEAS.AddQuest(QuestGilneasChapterThree.create());

      FACTION_GILNEAS.StartingQuest = chapterOne;

      chapterTwo.Progress = QUEST_PROGRESS_UNDISCOVERED;
      chapterThree.Progress = QUEST_PROGRESS_UNDISCOVERED;

      GOLDRINNELVE_PATH = QuestGoldrinnElvePath.create();
      //set GOLDRINNHUMAN_PATH = QuestGoldrinnHumanPath.create()

    }

  }
}
