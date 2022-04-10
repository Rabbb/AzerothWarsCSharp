using AzerothWarsCSharp.MacroTools.FactionSystem;
using WCSharp.Events;

namespace AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs
{
  public sealed class QuestItemLegendNotPermanentlyDead : QuestItemData
  {
    private readonly Legend _target;

    public QuestItemLegendNotPermanentlyDead(Legend target)
    {
      _target = target;
      if (IsUnitType(target.Unit, UNIT_TYPE_STRUCTURE))
        Description = target.Name + " is intact";
      else
        Description = target.Name + " is alive";

      target.PermanentlyDied += OnAnyUnitDeath;
      PlayerUnitEvents.Register(PlayerUnitEvent.UnitTypeFinishesTraining, OnAnyUnitTrain);
    }

    private void OnAnyUnitDeath(object? sender, Legend legend)
    {
      Progress = QuestProgress.Failed;
    }

    private void OnAnyUnitTrain()
    {
      if (!ProgressLocked && _target.UnitType == GetUnitTypeId(GetTriggerUnit()) &&
          Holder.Player == GetOwningPlayer(GetTrainedUnit())) Progress = QuestProgress.Complete;
    }

    internal override void OnAdd()
    {
      if (UnitAlive(_target.Unit)) Progress = QuestProgress.Complete;
    }
  }
}