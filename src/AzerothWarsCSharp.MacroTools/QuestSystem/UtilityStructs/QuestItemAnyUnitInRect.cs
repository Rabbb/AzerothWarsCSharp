using AzerothWarsCSharp.MacroTools.Wrappers;
using WCSharp.Shared.Data;

namespace AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs
{
  public sealed class QuestItemAnyUnitInRect : QuestItemData
  {
    private static readonly trigger EntersRectTrig = CreateTrigger();
    private static readonly trigger ExitsRectTrig = CreateTrigger();
    private readonly bool _heroOnly;
    private readonly rect _targetRect;

    public QuestItemAnyUnitInRect(rect targetRect, string rectName, bool heroOnly)
    {
      if (heroOnly)
        Description = "You have a hero at " + rectName;
      else
        Description = "You have a unit at " + rectName;
      region target = RectToRegion(targetRect);
      _targetRect = targetRect;
      _heroOnly = heroOnly;
      DisplaysPosition = true;
      TriggerRegisterEnterRegion(EntersRectTrig, target, null);
      TriggerRegisterLeaveRegion(ExitsRectTrig, target, null);
      PingPath = "MinimapQuestTurnIn";
    }

    public override Point Position => new(GetRectCenterX(_targetRect), GetRectCenterY(_targetRect));

    /// <summary>
    ///   The <see cref="unit" /> that completed this objective.
    /// </summary>
    public unit? TriggerUnit { get; private set; }

    private static region RectToRegion(rect whichRect)
    {
      region rectRegion = CreateRegion();
      RegionAddRect(rectRegion, whichRect);
      return rectRegion;
    }

    private bool IsValidUnitInRect()
    {
      foreach (var unit in new GroupWrapper().EnumUnitsInRect(_targetRect).EmptyToList())
        if (GetOwningPlayer(unit) == Holder.Player && UnitAlive(unit) &&
            (IsUnitType(unit, UNIT_TYPE_HERO) || !_heroOnly))
          return true;
      return false;
    }

    private void OnRegionEnter()
    {
      var triggerUnit = GetTriggerUnit();
      if (GetOwningPlayer(triggerUnit) == Holder.Player && UnitAlive(triggerUnit) &&
        (IsUnitType(triggerUnit, UNIT_TYPE_HERO) || !_heroOnly) || IsValidUnitInRect())
      {
        TriggerUnit = triggerUnit;
        Progress = QuestProgress.Complete;
      }
      else
      {
        Progress = QuestProgress.Incomplete;
      }
    }

    private void OnRegionExit()
    {
      Progress = IsValidUnitInRect() ? QuestProgress.Complete : QuestProgress.Incomplete;
    }

    internal override void OnAdd()
    {
      Progress = IsValidUnitInRect() ? QuestProgress.Complete : QuestProgress.Incomplete;
      TriggerAddAction(EntersRectTrig, OnRegionEnter);
      TriggerAddAction(ExitsRectTrig, OnRegionExit);
    }
  }
}