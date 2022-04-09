using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;

namespace AzerothWarsCSharp.Source.Quests.Zandalar
{
  public sealed class QuestZandalar : QuestData
  {
    private static readonly int QuestResearchId = FourCC("R04W"); //This research is given when the quest is completed

    public QuestZandalar() : base("City of Gold", "We need to regain control of our land.",
      "ReplaceableTextures\\CommandButtons\\BTNBloodTrollMage.blp")
    {
      this.AddQuestItem(new QuestItemResearch(FourCC("R04R"), FourCC("o03Z")));
      this.AddQuestItem(new QuestItemUpgrade(FourCC("o03Z"), FourCC("o03Y")));
      AddQuestItem(new QuestItemExpire(900));
      AddQuestItem(new QuestItemSelfExists());
      ResearchId = QuestResearchId;
      ;
      ;
    }


    protected override string CompletionPopup =>
      "The City of Gold is now yours to command && has joined the " + Holder.Team.Name + ".";

    protected override string RewardDescription =>
      "Control of all units in Zandalar && enables the Golden Fleet to be built";

    protected override void OnFail()
    {
      RescueNeutralUnitsInRect(Regions.ZandalarUnlock.Rect, Player(PLAYER_NEUTRAL_AGGRESSIVE));
    }

    protected override void OnComplete()
    {
      RescueNeutralUnitsInRect(Regions.ZandalarUnlock.Rect, Holder.Player);
      if (GetLocalPlayer() == Holder.Player) PlayThematicMusicBJ("war3mapImported\\ZandalarTheme.mp3");
    }

    protected override void OnAdd()
    {
      Holder.ModObjectLimit(QuestResearchId, 1);
    }
  }
}