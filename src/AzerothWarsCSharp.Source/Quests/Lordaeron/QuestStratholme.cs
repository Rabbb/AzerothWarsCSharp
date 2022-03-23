using AzerothWarsCSharp.MacroTools;
using AzerothWarsCSharp.MacroTools.FactionSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem;
using AzerothWarsCSharp.MacroTools.QuestSystem.UtilityStructs;
using AzerothWarsCSharp.Source.Libraries;

namespace AzerothWarsCSharp.Source.Quests.Lordaeron
{
  public sealed class QuestStratholme : QuestData{



    protected override string CompletionPopup => "Stratholme has been liberated, && its military is now free to assist the " + this.Holder.Team.Name + ".";

    protected override string CompletionDescription => "Control of all units in Stratholme";

    private void OnFail( ){
      GeneralHelpers.RescueNeutralUnitsInRect(Regions.StratholmeUnlock.Rect, Player(PLAYER_NEUTRAL_AGGRESSIVE));
    }

    protected override void OnComplete(){
      GeneralHelpers.RescueNeutralUnitsInRect(Regions.StratholmeUnlock.Rect, this.Holder.Player);
    }

    private void OnAdd( ){
    }

    public  thistype ( ){
      thistype this = thistype.allocate("Blackrock && Roll", "The Blackrock clan has taken over Alterac, they must be eliminated for the safety of Lordaeron", "ReplaceableTextures\\CommandButtons\\BTNChaosBlademaster.blp");
      this.AddQuestItem(QuestItemKillUnit.create(gg_unit_o00B_1316)) ;//Jubei
      this.AddQuestItem(new QuestItemControlPoint(ControlPoint.GetFromUnitType(FourCC("n019"))));
      this.AddQuestItem(new QuestItemUpgrade(FourCC("hcas"), )htow)));
      this.AddQuestItem(new QuestItemExpire(1470));
      this.AddQuestItem(new QuestItemSelfExists());
      ;;
    }


  }
}
