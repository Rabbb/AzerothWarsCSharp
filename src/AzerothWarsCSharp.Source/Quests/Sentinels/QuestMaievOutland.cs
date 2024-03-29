using System.Collections.Generic;
using AzerothWarsCSharp.MacroTools;
using AzerothWarsCSharp.MacroTools.FactionSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.MacroTools.Wrappers;
using AzerothWarsCSharp.Source.Setup.Legends;
using WCSharp.Shared.Data;
using static War3Api.Common;

namespace AzerothWarsCSharp.Source.Quests.Sentinels
{
  public sealed class QuestMaievOutland : QuestData
  {
    private readonly List<unit> _rescueUnits = new();

    public QuestMaievOutland(Rectangle rescueRect) : base("Driven by Vengeance",
      "Maiev drive for vengeance leads her to chase Illidan all the way to other worlds.",
      "ReplaceableTextures\\CommandButtons\\BTNMaievArmor.blp")
    {
      AddObjective(new ObjectiveCastSpell(FourCC("A0J5"), true));
      AddObjective(new ObjectiveControlLegend(LegendSentinels.legendMaiev, true));

      foreach (var unit in new GroupWrapper().EnumUnitsInRect(rescueRect).EmptyToList())
      {
        SetUnitInvulnerable(unit, true);
        ShowUnit(unit, false);
        _rescueUnits.Add(unit);
      }
    }

    protected override string RewardDescription => "Control of Maiev's Outland outpost and moves Maiev to Outland";
    protected override string CompletionPopup => "Maiev's Outland outpost have been constructed.";

    protected override void OnComplete(Faction completingFaction)
    {
      SetUnitPosition(LegendSentinels.legendMaiev.Unit, -5252, -27597);
      UnitRemoveAbility(LegendSentinels.legendMaiev.Unit, FourCC("A0J5"));
      foreach (var unit in _rescueUnits) unit.Rescue(completingFaction.Player);
    }
  }
}