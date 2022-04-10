using AzerothWarsCSharp.MacroTools.FactionSystem;
using WCSharp.Shared.Data;

namespace AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs
{
  public sealed class QuestItemControlLegend : QuestItemData
  {
    private readonly Legend _target;
    private readonly bool _canFail;

    public override Point Position => new(GetUnitX(_target.Unit), GetUnitY(_target.Unit));

    internal override void OnAdd()
    {
      if (Holder.Team.ContainsPlayer(GetOwningPlayer(_target.Unit)))
      {
        Progress = QuestProgress.Complete;
      }
    }

    private void OnTargetChangeOwner(object? sender, LegendChangeOwnerEventArgs legendChangeOwnerEventArgs)
    {
      if (Holder.Team.ContainsPlayer(GetOwningPlayer(_target.Unit)))
      {
        Progress = QuestProgress.Complete;
      }
      else
      {
        Progress = _canFail ? QuestProgress.Failed : QuestProgress.Incomplete;
      }
    }

    private void OnTargetDeath(object? sender, Legend legend)
    {
      if (_canFail)
      {
        Progress = QuestProgress.Failed;
      }
    }

    public QuestItemControlLegend(Legend target, bool canFail)
    {
      _target = target;
      Description = "Your team controls " + target.Name;
      _canFail = canFail;
      if (target.Unit != null)
      {
        TargetWidget = target.Unit;
      }

      DisplaysPosition = Environment.IsPlayerNeutralHostile(GetOwningPlayer(target.Unit));
      target.ChangedOwner += OnTargetChangeOwner;
      target.PermanentlyDied += OnTargetDeath;
    }
  }
}