using WCSharp.Events;

using static War3Api.Common;

namespace AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs
{
  /// <summary>
  /// Completes when a unit casts a specific spell.
  /// </summary>
  public sealed class QuestItemCastSpell : QuestItemData
  {
    private readonly bool _holderOnly;

    /// <summary>
    /// The unit that was used to complete the quest.
    /// </summary>
    public unit Caster { get; private set; }

    private void OnCast()
    {
      if (Progress != QuestProgress.Complete && (GetOwningPlayer(GetTriggerUnit()) == Holder.Player || !_holderOnly))
      {
        Caster = GetTriggerUnit();
        Progress = QuestProgress.Complete;
      }
    }

    /// <summary>
    /// Completes when a unit casts a specific spell.
    /// </summary>
    /// <param name="spellId">The spell that needs to be casted for completion.</param>
    /// <param name="holderOnly">If true, the quest holder must cast the spell themselves.</param>
    public QuestItemCastSpell(int spellId, bool holderOnly)
    {
      PlayerUnitEvents.Register(PlayerUnitEvent.SpellFinish, OnCast);
      if (holderOnly)
      {
        Description = "Cast " + GetObjectName(spellId);
      }
      else
      {
        Description = "Anyone casts " + GetObjectName(spellId);
      }
      
      _holderOnly = holderOnly;
    }
  }
}