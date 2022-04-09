using AzerothWarsCSharp.MacroTools.FactionSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;

namespace AzerothWarsCSharp.Source.Quests.Fel_Horde
{
  public sealed class QuestBlackrock : QuestData
  {
    private static readonly int QuestResearchId = FourCC("R03C");

    public QuestBlackrock() : base("Blackrock Unification",
      "Make contact with the Blackrock clan && convince them to join Magtheridon",
      "ReplaceableTextures\\CommandButtons\\BTNBlackhand.blp")
    {
      AddQuestItem(new QuestItemControlPoint(ControlPoint.GetFromUnitType(FourCC("n00S"))));
      AddQuestItem(new QuestItemControlPoint(ControlPoint.GetFromUnitType(FourCC("n09Y"))));
      AddQuestItem(new QuestItemControlPoint(ControlPoint.GetFromUnitType(FourCC("n0A9"))));
      AddQuestItem(new QuestItemExpire(1451));
      AddQuestItem(new QuestItemSelfExists());
    }


    protected override string CompletionPopup =>
      "Blackrock Citadel has been subjugated, && its military is now free to assist the " + Holder.Team.Name + ".";

    protected override string RewardDescription =>
      "Control of all units in Blackrock Citadel && enable DalFourCC(rend Blackhand to be trained at the altar";

    private void GrantBlackrock(player whichPlayer)
    {
      group tempGroup = CreateGroup();
      unit u;

      //Transfer all Neutral Passive units in Blackrock
      GroupEnumUnitsInRect(tempGroup, Regions.BlackrockUnlock.Rect, null);
      u = FirstOfGroup(tempGroup);
      while (true)
      {
        if (u == null) break;
        if (GetOwningPlayer(u) == Player(PLAYER_NEUTRAL_PASSIVE)) UnitRescue(u, whichPlayer);
        GroupRemoveUnit(tempGroup, u);
        u = FirstOfGroup(tempGroup);
      }

      DestroyGroup(tempGroup);
      
    }

    protected override void OnFail()
    {
      GrantBlackrock(Player(PLAYER_NEUTRAL_AGGRESSIVE));
    }

    protected override void OnComplete()
    {
      SetPlayerTechResearched(Holder.Player, FourCC("R03C"), 1);
      GrantBlackrock(Holder.Player);
    }

    protected override void OnAdd()
    {
      Holder.ModObjectLimit(QuestResearchId, 1);
    }
  }
}