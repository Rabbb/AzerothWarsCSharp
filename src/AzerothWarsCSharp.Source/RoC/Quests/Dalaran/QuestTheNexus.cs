using AzerothWarsCSharp.Source.Main.Libraries.QuestSystem.UtilityStructs;

namespace AzerothWarsCSharp.Source.RoC.Quests.Dalaran
{
  public class QuestTheNexus{



    boolean operator Global( ){
      return true;
    }

    private string operator CompletionPopup( ){
      return "The Nexus powers have been absorbed by Jaina && she joins the Lich King in the eternal ice of Northrend.";
    }

    private string operator CompletionDescription( ){
      return "You become the Nexus faction, allied with the Scourge && enemy with everyone else. Jaina becomes much more powerful";
    }

    private void OnComplete( ){
      FACTION_DALARAN.ModObjectLimit(FourCC(h069),-UNLIMITED)       ;//Military Quarters
      FACTION_DALARAN.ModObjectLimit(FourCC(h067),-UNLIMITED)       ;//Laboratory
      FACTION_DALARAN.ModObjectLimit(FourCC(n096),-UNLIMITED)       ;//Golem
      FACTION_DALARAN.ModObjectLimit(FourCC(o02U),-UNLIMITED)       ;//Crystal artillery
      FACTION_DALARAN.ModObjectLimit(FourCC(n0AD),-UNLIMITED)       ;//Crystal Golem
      FACTION_DALARAN.ModObjectLimit(FourCC(h032),-UNLIMITED)       ;//Battlemage
      FACTION_DALARAN.ModObjectLimit(FourCC(n007),-UNLIMITED)       ;//Kirintor
      FACTION_DALARAN.ModObjectLimit(FourCC(h022),-UNLIMITED)       ;//Peasant
      FACTION_DALARAN.ModObjectLimit(FourCC(Hant),-UNLIMITED)       ;//Antonidas
      FACTION_DALARAN.ModObjectLimit(FourCC(Haah),-UNLIMITED)       ;//Mediv
      FACTION_DALARAN.ModObjectLimit(FourCC(njks),-UNLIMITED)       ;//Kasan
      FACTION_DALARAN.ModObjectLimit(FourCC(R06O),-UNLIMITED)       ;//Phase Blade
      FACTION_DALARAN.ModObjectLimit(FourCC(R061),-UNLIMITED)       ;//Forked Lightning
      RemoveUnit(LEGEND_ANTONIDAS.Unit);
      RemoveUnit(LEGEND_MEDIVH.Unit);

      FACTION_DALARAN.ModObjectLimit(FourCC(U026),1)               ;//Malygos
      FACTION_DALARAN.ModObjectLimit(FourCC(U027),1)               ;//Kalecgos
      FACTION_DALARAN.ModObjectLimit(FourCC(H04A),1)               ;//Nexus Jaina

      FACTION_DALARAN.ModObjectLimit(FourCC(n0A1),6)               ;//Elite
      FACTION_DALARAN.ModObjectLimit(FourCC(h09C),UNLIMITED)               ;//Worker
      FACTION_DALARAN.ModObjectLimit(FourCC(h099),UNLIMITED)               ;//Infantry
      FACTION_DALARAN.ModObjectLimit(FourCC(n0A4),UNLIMITED)               ;//Dragonspawn
      FACTION_DALARAN.ModObjectLimit(FourCC(u025),12)               ;//Elementalist
      FACTION_DALARAN.ModObjectLimit(FourCC(n09T),6)               ;//Judicator
      FACTION_DALARAN.ModObjectLimit(FourCC(h09A),UNLIMITED)               ;//Nexus
      FACTION_DALARAN.ModObjectLimit(FourCC(h09B),UNLIMITED)               ;//Roost

      LEGEND_JAINA.UnitType = FourCC(H04A);

      UnitRemoveAbilityBJ( FourCC(A0RB), LEGEND_JAINA.Unit);
      this.Holder.Team = TEAM_SCOURGE;
      this.Holder.Name = "The Nexus";
      this.Holder.Icon = "ReplaceableTextures\\CommandButtons\\BTNJaina_Archmage.blp";
      SetPlayerStateBJ( this.Holder.Player, PLAYER_STATE_FOOD_CAP_CEILING, 300 );
    }

    public  thistype ( ){
      thistype this = thistype.allocate("The Nexus", "The new Lich King calls for Jaina, tempts her with power. The Nexus needs a master, && Jaina is perfect for it.", "ReplaceableTextures\\CommandButtons\\BTNBlueDragonNexus.blp");
      this.AddQuestItem(QuestItemChannelRect.create(gg_rct_JainaChannel, "The Nexus", LEGEND_JAINA, 60, 270));
      this.AddQuestItem(QuestItemControlLegend.create(LEGEND_JAINA, true));
      this.AddQuestItem(QuestItemControlLegend.create(LEGEND_NEXUS, false));
      ;;
    }


  }
}
