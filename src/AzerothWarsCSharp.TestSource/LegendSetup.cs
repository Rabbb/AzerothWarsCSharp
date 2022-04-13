﻿using AzerothWarsCSharp.MacroTools.FactionSystem;
using static War3Api.Common;

namespace AzerothWarsCSharp.TestSource
{
  public static class LegendSetup
  {
    public static Legend Kael { get; private set; }
    public static Legend Uther { get; private set; }

    public static void Setup()
    {
      Kael = new Legend
      {
        Unit = CreateUnit(Player(0), FourCC("Hkal"), 0, 0, 0)
      };
      Uther = new Legend
      {
        Unit = CreateUnit(Player(3), FourCC("Huth"), 0, 0, 0)
      };
    }
  }
}