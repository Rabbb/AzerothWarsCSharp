using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.Source.Legends;
using AzerothWarsCSharp.Source.Setup;
using AzerothWarsCSharp.Source.Setup.FactionSetup;

namespace AzerothWarsCSharp.Source.Quests.BlackEmpire
{
  public sealed class QuestBladeOfTheBlackEmpire : QuestData
  {
    private readonly QuestData _sequel;

    public QuestBladeOfTheBlackEmpire(QuestData sequel) : base("Xal'atath",
      "Xal'atath is one of the oldest and most powerful entities serving the Old Gods, living inside a cursed blade. A human priestess stole it long ago; the blade is entombed with her in Duskwood Crypt.",
      "ReplaceableTextures\\CommandButtons\\BTNmidnightGS.blp")
    {
      _sequel = sequel;
      AddQuestItem(new QuestItemLegendInRect(LegendBlackEmpire.LEGEND_VOLAZJ, Regions.DuskwoodCrypt.Rect,
        "Duskwood Graveyard Crypt"));
      AddQuestItem(new QuestItemControlLegend(LegendNeutral.LEGEND_DUSKWOODGRAVEYARD, false));
    }

    protected override string CompletionPopup => "Herald Volazj has found the Black Blade, Xal'alath.";

    protected override string CompletionDescription =>
      "Xal'alath will be ours and the Tomb of Tyr quest will be revealed.";

    protected override void OnComplete()
    {
      if (LegendBlackEmpire.LEGEND_VOLAZJ.Unit != null && ArtifactSetup.ArtifactXalatath != null)
        UnitAddItemSafe(LegendBlackEmpire.LEGEND_VOLAZJ.Unit, ArtifactSetup.ArtifactXalatath.Item);
      BlackEmpireSetup.FACTION_BLACKEMPIRE.AddQuest(_sequel);
      _sequel.Progress = QUEST_PROGRESS_INCOMPLETE;
    }
  }
}