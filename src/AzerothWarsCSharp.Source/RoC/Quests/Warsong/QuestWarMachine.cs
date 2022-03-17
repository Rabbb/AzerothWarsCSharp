public class QuestWarMachine{


    private string operator CompletionPopup( ){
      return "The massive exploitation of Ashenvale has bolstered the entire HordeFourCC(s weapons, armour && defenses.";
    }

    private string operator CompletionDescription( ){
      return "You && all of your allies gain the researches " + GetObjectName(FourCC(Rhme)) + ", " + GetObjectName()Rhar)) + ", " + GetObjectName()Rorb)) + ", && " + GetObjectName()Rosp));
    }

    private void BlessPlayer(player whichPlayer ){
      SetPlayerTechResearched(whichPlayer, FourCC(Rhme), GetPlayerTechCount(whichPlayer, )Rhme), true) + 1);
      SetPlayerTechResearched(whichPlayer, FourCC(Rhar), GetPlayerTechCount(whichPlayer, )Rhar), true) + 1);
      SetPlayerTechResearched(whichPlayer, FourCC(Rorb), 3);
      SetPlayerTechResearched(whichPlayer, FourCC(Rosp), 3);
    }

    private void OnComplete( ){
      int i = 0;
      while(true){
        if ( i == MAX_PLAYERS){ break; }
        if (this.Holder.Team.ContainsPlayer(Player(i))){
          BlessPlayer(Player(i));
        }
        i = i + 1;
      }
    }

    private void OnAdd( ){
      this.Holder.ModObjectLimit(FourCC(R021), UNLIMITED);
    }

    public  thistype ( ){
      thistype this = thistype.allocate("The War Machine", "The bountiful woodlands of Ashenvale are now accessible to the Horde. It is time to begin harvesting && armament operations.", "ReplaceableTextures\\CommandButtons\\BTNBundleOfLumber.blp");
      this.AddQuestItem(QuestItemResearch.create(FourCC(R021), )o01I)));
      ;;
    }


}
