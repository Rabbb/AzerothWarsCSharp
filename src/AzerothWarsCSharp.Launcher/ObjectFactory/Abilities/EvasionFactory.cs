﻿using War3Api.Object.Abilities;

namespace AzerothWarsCSharp.Launcher.ObjectFactory.Abilities
{
  public class EvasionFactory : PassiveAbilityFactory<Evasion>
  {
    public float[] ChanceToEvade { get; set; }

    private void GenerateTooltip(Evasion ability)
    {
      ability.TextTooltipLearnExtended = $"Gives a {ArrayToConcatenatedString(ChanceToEvade, true)}% chance to avoid an attack.";
      ability.TextName = TextName;
      for (var i = 0; i < Levels; i++)
      {
        ability.TextTooltipNormal[i+1] = $"{TextName} - [|cffffcc00Level {i+1}|r]";
        ability.TextTooltipNormalExtended[i+1] = $"Gives a {ChanceToEvade[i] * 100}% chance to avoid an attack.";
        ability.DataChanceToEvade[i+1] = ChanceToEvade[i];
      }
    }

    private void GenerateStats(Evasion ability)
    {
      for (var i = 0; i < Levels; i++)
      {
        ability.ArtIconNormal = ArtIcon;
        ability.ArtIconResearch = ArtIcon;
      }
      ability.ArtButtonPositionNormalX = ButtonPosition.X;
      ability.ArtButtonPositionNormalY = ButtonPosition.Y;
    }

    public override Evasion Generate(string newRawCode)
    {
      var newAbility = new Evasion(newRawCode);
      GenerateStats(newAbility);
      GenerateTooltip(newAbility);
      return newAbility;
    }
  }
}