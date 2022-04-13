using AzerothWarsCSharp.MacroTools.FactionSystem;
using static AzerothWarsCSharp.MacroTools.Libraries.GeneralHelpers;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.Source.Legends;

using static War3Api.Common; using static War3Api.Blizzard;

namespace AzerothWarsCSharp.Source.Quests.Sentinels
{
  public sealed class QuestFeathermoon : QuestData
  {
    public QuestFeathermoon() : base("Feathermoon Stronghold",
      "Feathermoon Stronghold stood guard for ten thousand years, it is time to relieve the guards from their duty.",
      "ReplaceableTextures\\CommandButtons\\BTNBearDen.blp")
    {
      AddQuestItem(new QuestItemLegendReachRect(LegendSentinels.legendTyrande, Regions.FeathermoonUnlock,
        "Feathermoon Stronghold"));
      AddQuestItem(new QuestItemControlPoint(ControlPoint.GetFromUnitType(FourCC("n01R"))));
      AddQuestItem(new QuestItemUpgrade(FourCC("n06J"), FourCC("n06J")));
      AddQuestItem(new QuestItemExpire(1485));
      AddQuestItem(new QuestItemSelfExists());
      ResearchId = FourCC("R06M");
    }
    
    protected override string CompletionPopup =>
      "Feathermoon Stronghold has been relieved && has joined the Sentinels in their war effort";

    protected override string RewardDescription =>
      "Control of all units in Feathermoon Stronghold && make Shandris && Maiev trainable at the Altar";

    private static void GrantFeathermoon(player whichPlayer)
    {
      group tempGroup = CreateGroup();

      //Transfer all Neutral Passive units in Feathermoon
      GroupEnumUnitsInRect(tempGroup, Regions.FeathermoonUnlock.Rect, null);
      unit u = FirstOfGroup(tempGroup);
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
      GrantFeathermoon(Player(PLAYER_NEUTRAL_AGGRESSIVE));
    }

    protected override void OnComplete()
    {
      GrantFeathermoon(Holder.Player);
      AdjustPlayerStateBJ(300, Holder.Player, PLAYER_STATE_RESOURCE_LUMBER);
      AdjustPlayerStateBJ(300, Holder.Player, PLAYER_STATE_RESOURCE_GOLD);
      if (GetLocalPlayer() == Holder.Player) PlayThematicMusicBJ("war3mapImported\\SentinelTheme.mp3");
    }
  }
}