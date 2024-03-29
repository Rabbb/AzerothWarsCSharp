using System.Collections.Generic;
using AzerothWarsCSharp.MacroTools;
using AzerothWarsCSharp.MacroTools.FactionSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.MacroTools.Wrappers;
using WCSharp.Shared.Data;
using static War3Api.Common;


namespace AzerothWarsCSharp.Source.Quests.Zandalar
{
  public sealed class QuestZandalar : QuestData
  {
    private readonly List<unit> _rescueUnits = new();

    public QuestZandalar(Rectangle rescueRect) : base("City of Gold", "We need to regain control of our land.",
      "ReplaceableTextures\\CommandButtons\\BTNBloodTrollMage.blp")
    {
      AddObjective(new ObjectiveResearch(FourCC("R04R"), FourCC("o03Z")));
      AddObjective(new ObjectiveUpgrade(FourCC("o03Z"), FourCC("o03Y")));
      AddObjective(new ObjectiveExpire(900));
      AddObjective(new ObjectiveSelfExists());
      ResearchId = FourCC("R04W");

      foreach (var unit in new GroupWrapper().EnumUnitsInRect(rescueRect).EmptyToList())
        if (GetOwningPlayer(unit) == Player(PLAYER_NEUTRAL_PASSIVE))
        {
          SetUnitInvulnerable(unit, true);
          _rescueUnits.Add(unit);
        }
    }

    protected override string CompletionPopup =>
      "The City of Gold is now yours to command and has joined the Zandalari";

    protected override string RewardDescription =>
      "Control of all units in Zandalar and enables the Golden Fleet to be built";

    protected override void OnFail(Faction completingFaction)
    {
      foreach (var unit in _rescueUnits) unit.Rescue(Player(PLAYER_NEUTRAL_AGGRESSIVE));
    }

    protected override void OnComplete(Faction completingFaction)
    {
      foreach (var unit in _rescueUnits) unit.Rescue(completingFaction.Player);
      if (GetLocalPlayer() == completingFaction.Player) PlayThematicMusic("war3mapImported\\ZandalarTheme.mp3");
    }
  }
}