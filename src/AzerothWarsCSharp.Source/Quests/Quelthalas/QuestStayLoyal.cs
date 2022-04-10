using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.Source.Legends;
using AzerothWarsCSharp.Source.Setup.QuestSetup;

using static War3Api.Common; using static War3Api.Blizzard;

namespace AzerothWarsCSharp.Source.Quests.Quelthalas
{
  public sealed class QuestStayLoyal : QuestData
  {
    public QuestStayLoyal() : base("Refuse Kil'Jaeden's Offer", "Kil'jaeden has approached Kael with an offer of power and salvation. He should refuse it and resist the temptation of Fel power.", "ReplaceableTextures\\CommandButtons\\BTNDemonHunter2.blp")
    {
      AddQuestItem(new QuestItemCastSpell(FourCC("A0IK"), true));
      AddQuestItem(new QuestItemLegendLevel(LegendQuelthalas.LegendKael, 6));
      Global = true;
    }

    //Todo: boring flavour
    protected override string CompletionPopup => "The Blood Elves stay loyal to Illidan";

    protected override string RewardDescription => "Stay allied to Illidan";
    
    protected override void OnComplete()
    {
      QuelthalasQuestSetup.GREAT_TREACHERY.Progress = QuestProgress.Failed;
      QuelthalasQuestSetup.SUMMON_KIL.Progress = QuestProgress.Failed;
      UnitRemoveAbilityBJ(FourCC("A0IK"), LegendQuelthalas.LegendKael.Unit);
      UnitRemoveAbilityBJ(FourCC("A0IF"), LegendQuelthalas.LegendKael.Unit);
    }
  }
}