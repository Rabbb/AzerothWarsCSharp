using AzerothWarsCSharp.MacroTools.FactionSystem;
using AzerothWarsCSharp.MacroTools.Powers;
using AzerothWarsCSharp.TestSource.Setup.FactionSetup.FactionSetup;
using static War3Api.Common;

namespace AzerothWarsCSharp.TestSource.Setup
{
  public static class AllFactionSetup
  {
    public static void Setup()
    {
      DalaranSetup.Setup();
      DruidsSetup.Setup();
      CthunSetup.Setup();
      BlackEmpireSetup.Setup();
      DraeneiSetup.Setup();

      var spaceMarines = new Faction("Space Marines", PLAYER_COLOR_BLUE, "|c000042ff",
        "ReplaceableTextures\\CommandButtons\\BTNMarine.blp")
      {
        Team = TeamSetup.TeamAlliance
      };
      var newPower = new DummyPower("Space", "You're from space, and can use spaceships.", "Marine");
      spaceMarines.AddPower(newPower);
      FactionManager.Register(spaceMarines);
    }
  }
}