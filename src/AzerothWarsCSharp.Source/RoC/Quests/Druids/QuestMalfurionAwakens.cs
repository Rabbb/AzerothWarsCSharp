//Anyone on the Night Elves team approaches Moonglade with a unit with the Horn of Cenarius,
//Causing Malfurion to spawn.

using AzerothWarsCSharp.Source.Main.Libraries.QuestSystem.UtilityStructs;

namespace AzerothWarsCSharp.Source.RoC.Quests.Druids
{
  public class QuestMalfurionAwakens{

  
    private group MoongladeUnits;

    private const int HORN_OF_CENARIUS = FourCC(cnhn);
    private const int GHANIR = FourCC(I00C);
  


    private string operator CompletionPopup( ){
      return "Malfurion has emerged from his deep slumber in the Barrow Den.";
    }

    private string operator CompletionDescription( ){
      return "Gain the hero Malfurion && the artifact GFourCC(hanir";
    }

    private void GiveMoonglade(player whichPlayer ){
      group tempGroup = CreateGroup();
      unit u;

      //Transfer all Neutral Passive units in Moonglade
      GroupEnumUnitsInRect(tempGroup, gg_rct_MoongladeVillage, null);
      u = FirstOfGroup(tempGroup);
      while(true){
        if ( u == null){ break; }
        if (GetOwningPlayer(u) == Player(PLAYER_NEUTRAL_PASSIVE)){
          UnitRescue(u, whichPlayer);
        }
        GroupRemoveUnit(tempGroup, u);
        u = FirstOfGroup(tempGroup);
      }

      //Cleanup
      DestroyGroup(tempGroup);
      tempGroup = null;
    }

    private void OnFail( ){
      this.GiveMoonglade(Player(PLAYER_NEUTRAL_AGGRESSIVE));
    }

    private void OnComplete( ){
      this.GiveMoonglade(this.Holder.Player);
      if (LEGEND_MALFURION.Unit == null){
        LEGEND_MALFURION.Spawn(Holder.Player, GetRectCenterX(gg_rct_Moonglade), GetRectCenterY(gg_rct_Moonglade), 270);
        SetHeroLevel(LEGEND_MALFURION.Unit, 3, false);
        UnitAddItemSafe(LEGEND_MALFURION.Unit, ARTIFACT_GHANIR.item);
      }else {
        SetItemPosition(ARTIFACT_GHANIR.item, GetUnitX(GetTriggerUnit()), GetUnitY(GetTriggerUnit()));
      }
    }

    public  thistype ( ){
      thistype this = thistype.allocate("Awakening of Stormrage", "Ever since the War of the Ancients ten thousand years ago, Malfurion Stormrage && his druids have slumbered within the Barrow Den. Now, their help is required once again.", "ReplaceableTextures\\CommandButtons\\BTNFurion.blp");
      this.AddQuestItem(QuestItemAcquireArtifact.create(ARTIFACT_HORNOFCENARIUS));
      this.AddQuestItem(QuestItemArtifactInRect.create(ARTIFACT_HORNOFCENARIUS, gg_rct_Moonglade, "The Barrow Den"));
      this.AddQuestItem(QuestItemExpire.create(1440));
      this.AddQuestItem(QuestItemSelfExists.create());
      ;;
    }


    private static void OnInit( ){
      //Setup initially invulnerable and hidden group at Moonglade
      group tempGroup = CreateGroup();
      unit u;
      int i = 0;
      MoongladeUnits = CreateGroup();
      GroupEnumUnitsInRect(tempGroup, gg_rct_MoongladeVillage, null);
      while(true){
        u = FirstOfGroup(tempGroup);
        if ( u == null){ break; }
        if (GetOwningPlayer(u) == Player(PLAYER_NEUTRAL_PASSIVE)){
          SetUnitInvulnerable(u, true);
          GroupAddUnit(MoongladeUnits, u);
        }
        GroupRemoveUnit(tempGroup, u);
        i = i + 1;
      }
      DestroyGroup(tempGroup);
      tempGroup = null;
      //Add quest
    }

  }
}
