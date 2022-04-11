using AzerothWarsCSharp.MacroTools.Factions;
using static AzerothWarsCSharp.MacroTools.GeneralHelpers;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;

using static War3Api.Common;

namespace AzerothWarsCSharp.Source.Quests.Lordaeron
{
  public sealed class QuestStrahnbrad : QuestData
  {
    public QuestStrahnbrad() : base("The Defense of Strahnbrad",
      "The Strahnbrad is under attack by some brigands, clear them out",
      "ReplaceableTextures\\CommandButtons\\BTNFarm.blp")
    {
      AddQuestItem(new QuestItemControlPoint(ControlPoint.GetFromUnitType(FourCC("n01C"))));
      AddQuestItem(new QuestItemExpire(1170));
      AddQuestItem(new QuestItemSelfExists());
      ;
      ;
    }


    protected override string CompletionPopup => "Strahnbrad has been liberated.";

    protected override string RewardDescription => "Control of all buildings in Strahnbrad";

    protected override void OnFail()
    {
      RescueNeutralUnitsInRect(Regions.StrahnbradUnlock.Rect, Player(PLAYER_NEUTRAL_AGGRESSIVE));
    }

    protected override void OnComplete()
    {
      RescueNeutralUnitsInRect(Regions.StrahnbradUnlock.Rect, Holder.Player);
    }
  }
}