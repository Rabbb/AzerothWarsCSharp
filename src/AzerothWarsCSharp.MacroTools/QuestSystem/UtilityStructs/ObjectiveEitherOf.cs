using AzerothWarsCSharp.MacroTools.FactionSystem;
using WCSharp.Shared.Data;

namespace AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs
{
  public class ObjectiveEitherOf : Objective
  {
    private readonly Objective _questItemA;
    private readonly Objective _questItemB;

    public ObjectiveEitherOf(Objective questItemA, Objective questItemB)
    {
      _questItemA = questItemA;
      _questItemB = questItemB;
      Description = questItemA.Description + " or " + questItemB.Description;
      questItemA.ProgressChanged += OnChildProgressChanged;
      questItemB.ProgressChanged += OnChildProgressChanged;
    }

    public override Point Position => new(_questItemA.Position.X, _questItemB.Position.Y);

    internal override void OnAdd(Faction whichFaction)
    {
      _questItemA.OnAdd(whichFaction);
      _questItemB.OnAdd(whichFaction);
      Update();
    }

    private void Update()
    {
      if (_questItemA.Progress == QuestProgress.Complete || _questItemB.Progress == QuestProgress.Complete)
      {
        Progress = QuestProgress.Complete;
        return;
      }

      if (_questItemA.Progress == QuestProgress.Failed && _questItemB.Progress == QuestProgress.Failed)
        Progress = QuestProgress.Failed;
    }

    private void OnChildProgressChanged(object? sender, Objective objective)
    {
      Update();
    }
  }
}