public class Display{

  static void DisplayHint(player whichPlayer, string msg ){
    DisplayTextToPlayer(whichPlayer, 0, 0, "\n|cff00ff00HINT|r - " + msg);
    if (GetLocalPlayer() == whichPlayer){
      StartSound(bj_questHintSound);
    }
  }

  static void DisplayHeroReward(unit whichUnit, int strength, int agility, int intelligence, int experience ){
    string display = "\n|cff00ff00HERO REWARD EARNED -" + GetHeroProperName(whichUnit) + "|r";
    if (strength > 0){
      display = display + "\n+" + I2S(strength) + " Strength";
    }
    if (agility > 0){
      display = display + "\n+" + I2S(agility) + " Agility";
    }
    if (intelligence > 0){
      display = display + "\n+" + I2S(intelligence) + " Intelligence";
    }
    if (experience > 0){
      display = display + "\n+" + I2S(experience) + " Experience";
    }
    DisplayTextToPlayer(GetOwningPlayer(whichUnit), 0, 0, display);
    if (GetLocalPlayer() == GetOwningPlayer(whichUnit)){
      StartSound(bj_questHintSound);
    }
  }

  static void DisplayUnitLimit(Faction whichFaction, int unitTypeId ){
    DisplayTextToPlayer(whichFaction.Player, 0, 0, "\n|cff00ff00UNIT LIMIT CHANGED - " + GetObjectName(unitTypeId) + "|r\nYou can now train up to " + I2S(whichFaction.objectLimits[unitTypeId]) + " " + GetObjectName(unitTypeId) + "s.");
    if (GetLocalPlayer() == whichFaction.Player){
      StartSound(bj_questHintSound);
    }
  }

  static void DisplayResearchAcquired(player whichPlayer, int researchId, int researchLevel ){
    DisplayTextToPlayer(whichPlayer, 0, 0, "\n|cff00ff00RESEARCH ACQUIRED - " + GetObjectName(researchId) + "|r\n" + BlzGetAbilityExtendedTooltip(researchId, researchLevel));
    if (GetLocalPlayer() == whichPlayer){
      StartSound(bj_questHintSound);
    }
  }

  static void DisplayUnitTypeAcquired(player whichPlayer, int unitId, string flavor ){
    DisplayTextToPlayer(whichPlayer, 0, 0, "\n|cff00ff00NEW UNIT ACQUIRED - " + GetObjectName(unitId) + "\n|r" + flavor);
    if (GetLocalPlayer() == whichPlayer){
      StartSound(bj_questHintSound);
    }
  }

  static void DisplaySoloPath(Faction whichFaction, string flavour ){
    string display = "\n|cffffcc00PATH - " + whichFaction.prefixCol + whichFaction.Name + "|r\n" + flavour + "\n";
    StartSound(bj_rescueSound);
    DisplayTextToPlayer(GetLocalPlayer(), 0, 0, display);
  }

}
