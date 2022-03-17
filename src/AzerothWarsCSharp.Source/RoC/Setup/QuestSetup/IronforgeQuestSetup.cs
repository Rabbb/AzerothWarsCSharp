public class IronforgeQuestSetup{

  public static void OnInit( ){
    //Setup
    QuestData newQuest = FACTION_IRONFORGE.AddQuest(QuestThelsamar.create());
    FACTION_IRONFORGE.StartingQuest = newQuest;
    //Early duel
    FACTION_IRONFORGE.AddQuest(QuestDunMorogh.create());
    FACTION_IRONFORGE.AddQuest(QuestDominion.create());
    FACTION_IRONFORGE.AddQuest(QuestGnomeregan.create());
    FACTION_IRONFORGE.AddQuest(QuestDarkIron.create());
    FACTION_IRONFORGE.AddQuest(QuestWildhammer.create());
    //Misc
  }

}
