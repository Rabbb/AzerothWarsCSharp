using AzerothWarsCSharp.MacroTools.FactionSystem;
using static War3Api.Common;

namespace AzerothWarsCSharp.Source.Setup.FactionSetup
{
  public static class DalaranSetup
  {
    public static Faction Dalaran { get; private set; }

    public static void Setup()
    {
      Faction f;

      Dalaran = new Faction("Dalaran", PLAYER_COLOR_PINK, "|c00e55bb0",
        "ReplaceableTextures\\CommandButtons\\BTNJaina.blp")
      {
        UndefeatedResearch = FourCC("R05N"),
        StartingGold = 150,
        StartingLumber = 500,
        Team = TeamSetup.Alliance
      };

      //Structures
      Dalaran.ModObjectLimit(FourCC("h065"), Faction.UNLIMITED); //Refuge
      Dalaran.ModObjectLimit(FourCC("h066"), Faction.UNLIMITED); //Conclave
      Dalaran.ModObjectLimit(FourCC("h068"), Faction.UNLIMITED); //Observatory
      Dalaran.ModObjectLimit(FourCC("h063"), Faction.UNLIMITED); //Granary
      Dalaran.ModObjectLimit(FourCC("h044"), Faction.UNLIMITED); //Altar of Knowledge
      Dalaran.ModObjectLimit(FourCC("h069"), Faction.UNLIMITED); //Barracks
      Dalaran.ModObjectLimit(FourCC("h02N"), Faction.UNLIMITED); //Trade Quarters
      Dalaran.ModObjectLimit(FourCC("h036"), Faction.UNLIMITED); //Arcane Sanctuary
      Dalaran.ModObjectLimit(FourCC("h078"), Faction.UNLIMITED); //Scout Tower
      Dalaran.ModObjectLimit(FourCC("h079"), Faction.UNLIMITED); //Arcane Tower
      Dalaran.ModObjectLimit(FourCC("h07A"), Faction.UNLIMITED); //Arcane Tower (Improved)
      Dalaran.ModObjectLimit(FourCC("hvlt"), Faction.UNLIMITED); //Arcane Vault
      Dalaran.ModObjectLimit(FourCC("h076"), Faction.UNLIMITED); //Alliance Shipyard
      Dalaran.ModObjectLimit(FourCC("ndgt"), Faction.UNLIMITED); //Dalaran Tower
      Dalaran.ModObjectLimit(FourCC("n004"), Faction.UNLIMITED); //Dalaran Tower (Improved)
      Dalaran.ModObjectLimit(FourCC("h067"), Faction.UNLIMITED); //Laboratory
      Dalaran.ModObjectLimit(FourCC("n0AO"), 2); //Way Gate

      //Units
      Dalaran.ModObjectLimit(FourCC("h022"), Faction.UNLIMITED); //Shaper
      Dalaran.ModObjectLimit(FourCC("hbot"), 12); //Alliance Transport Ship
      Dalaran.ModObjectLimit(FourCC("hdes"), 12); //Alliance Frigate
      Dalaran.ModObjectLimit(FourCC("hbsh"), 6); //Alliance Battle Ship
      Dalaran.ModObjectLimit(FourCC("nhym"), Faction.UNLIMITED); //Hydromancer
      Dalaran.ModObjectLimit(FourCC("h032"), Faction.UNLIMITED); //Battlemage
      Dalaran.ModObjectLimit(FourCC("h02D"), Faction.UNLIMITED); //Geomancer
      Dalaran.ModObjectLimit(FourCC("h01I"), Faction.UNLIMITED); //Arcanist
      Dalaran.ModObjectLimit(FourCC("n007"), 6); //Kirin Tor
      Dalaran.ModObjectLimit(FourCC("n096"), 6); //Earth Golem
      Dalaran.ModObjectLimit(FourCC("n03E"), Faction.UNLIMITED); //Pyromancer
      Dalaran.ModObjectLimit(FourCC("n0AK"), Faction.UNLIMITED); //Sludge Flinger
      Dalaran.ModObjectLimit(FourCC("o02U"), 6); //Crystal Artillery


      //Demi-heroes
      Dalaran.ModObjectLimit(FourCC("njks"), 1); //Jailor Kassan
      Dalaran.ModObjectLimit(FourCC("Hjai"), 1); //jaina
      Dalaran.ModObjectLimit(FourCC("Hant"), 1); //antonidas

      //Upgrades
      Dalaran.ModObjectLimit(FourCC("R01I"), Faction.UNLIMITED); //Arcanist Adept Training
      Dalaran.ModObjectLimit(FourCC("R01V"), Faction.UNLIMITED); //Geomancer Adept Training
      Dalaran.ModObjectLimit(FourCC("R00E"), Faction.UNLIMITED); //Hydromancer Adept Training
      Dalaran.ModObjectLimit(FourCC("R01L"), Faction.UNLIMITED); //Magic Sentry
      Dalaran.ModObjectLimit(FourCC("R00K"), Faction.UNLIMITED); //Power Infusion
      Dalaran.ModObjectLimit(FourCC("R00D"), Faction.UNLIMITED); //Pyromancer Adept Training
      Dalaran.ModObjectLimit(FourCC("Rhac"), Faction.UNLIMITED); //Improved Masonry
      Dalaran.ModObjectLimit(FourCC("R06J"), Faction.UNLIMITED); //Improved Ooze
      Dalaran.ModObjectLimit(FourCC("R061"), Faction.UNLIMITED); //Improved Forked Lightning
      Dalaran.ModObjectLimit(FourCC("R06O"), Faction.UNLIMITED); //Improved Phase Blade
      Dalaran.ModObjectLimit(FourCC("R00J"), Faction.UNLIMITED); //Combat Tomes

      FactionManager.Register(Dalaran);
    }
  }
}