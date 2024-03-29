using AzerothWarsCSharp.MacroTools;
using AzerothWarsCSharp.MacroTools.Frames.Books.ArtifactSystem;
using AzerothWarsCSharp.MacroTools.Frames.Books.Powers;
using AzerothWarsCSharp.MacroTools.Mechanics;
using AzerothWarsCSharp.MacroTools.UserInterface;
using AzerothWarsCSharp.Source.ArtifactBehaviour;
using AzerothWarsCSharp.Source.Game_Logic.GameEnd;
using AzerothWarsCSharp.Source.Hints;
using AzerothWarsCSharp.Source.Mechanics.Quelthalas;
using AzerothWarsCSharp.Source.Mechanics.Scourge.Blight;
using AzerothWarsCSharp.Source.Setup.FactionSetup;

namespace AzerothWarsCSharp.Source.Setup
{
  public static class GameSetup
  {
    public static void Setup()
    {
      PreplacedUnitSystem.Initialize();
      AllLegendSetup.Setup();
      ShoreSetup.Setup();
      ControlPointSetup.Setup();
      InstanceSetup.Setup();
      TeamSetup.Setup();
      AllFactionSetup.Setup();
      PersonSetup.Setup();
      ArtifactSetup.Setup();
      AllQuestSetup.Setup();
      //ResearchSetup.Setup();
      ObserverSetup.Setup();
      SpellsSetup.Setup();
      CheatSetup.Setup();
      CommandSetup.Setup();
      ControlPointVictory.Setup();
      SilvermoonDies.Setup();
      ZinrokhAssembly.Setup();
      //IncompatibleTierConfig.Setup();
      FactionMultiboard.Setup();
      ArtifactBook.Initialize();
      PowerBook.Initialize();
      HintConfig.Setup();
      WaygateManager.Setup(Constants.UNIT_N0AO_WAY_GATE_DALARAN);
      BlightSystem.Setup(ScourgeSetup.FactionScourge);
      BlightSetup.Setup();
      PreplacedUnitSystem.Shutdown();
      QuestMenuSetup.Setup();
      DialogueSetup.Setup();
    }
  }
}