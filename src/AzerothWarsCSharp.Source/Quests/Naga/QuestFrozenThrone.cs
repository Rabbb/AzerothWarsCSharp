using AzerothWarsCSharp.MacroTools.FactionSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.Source.Setup;
using AzerothWarsCSharp.Source.Setup.FactionSetup;
using AzerothWarsCSharp.Source.Setup.Legends;
using AzerothWarsCSharp.Source.Setup.QuestSetup;

using static War3Api.Common;

namespace AzerothWarsCSharp.Source.Quests.Naga
{
  public sealed class QuestFrozenThrone : QuestData
  {
    public QuestFrozenThrone() : base("A Symphony of Frost and Flame",
      "Kil'jaeden has ordered Illidan to destroy the Frozen Throne, and he shall obey.",
      "ReplaceableTextures\\CommandButtons\\BTNMetamorphosis.blp")
    {
      AddObjective(new ObjectiveKillUnit(LegendScourge.LegendLichking.Unit));
      AddObjective(new ObjectiveResearch(FourCC("R063"), FourCC("n055")));
      Global = true;
    }

    protected override string CompletionPopup =>
      "As a reward for his mission, Illidan and his followers have been welcomed into the ranks of the Burning Legion";

    protected override string RewardDescription => "The Illidari team will join the Burning Legion in their team";
    
    protected override void OnComplete(Faction completingFaction)
    {
      if (QuelthalasSetup.FactionQuelthalas.Team == TeamSetup.Naga)
      {
        QuelthalasSetup.FactionQuelthalas.Team = TeamSetup.Legion;
        QuelthalasQuestSetup.SUMMON_KIL.Progress = QuestProgress.Incomplete;
        QuelthalasQuestSetup.GREAT_TREACHERY.Progress = QuestProgress.Failed;
        QuelthalasQuestSetup.STAY_LOYAL.Progress = QuestProgress.Failed;
        UnitRemoveAbility(LegendQuelthalas.LegendKael.Unit, FourCC("A0IK"));
        UnitRemoveAbility(LegendQuelthalas.LegendKael.Unit, FourCC("A0IF"));
        UnitAddAbility(LegendQuelthalas.LegendKael.Unit, FourCC("A0R7"));
      }

      if (FelHordeSetup.FactionFelHorde.Team == TeamSetup.Naga)
        FelHordeSetup.FactionFelHorde.Team = TeamSetup.Legion;
      NagaSetup.FactionNaga.Team = TeamSetup.Legion;
      SetPlayerTechResearched(QuelthalasSetup.FactionQuelthalas.Player, FourCC("R075"), 1);
    }
  }
}