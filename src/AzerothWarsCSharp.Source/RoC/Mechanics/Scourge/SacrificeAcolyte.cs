using WCSharp.Events;

namespace AzerothWarsCSharp.Source.RoC.Mechanics.Scourge
{
  public static class SacrificeAcolyte
  {
    private static readonly int AcolyteId = FourCC("uaco");
    
    private static void OnSell()
    {
      KillUnit(GetTriggerUnit());
      BlzSetUnitFacingEx(GetSoldUnit(), GetUnitFacing(GetTriggerUnit()));
      if (GetLocalPlayer() == GetOwningPlayer(GetSoldUnit()))
      {
        SelectUnit(GetSoldUnit(), true);
      }
    }

    public static void Setup()
    {
      PlayerUnitEvents.Register(PlayerUnitEvent.UnitTypeSellsUnit, OnSell, AcolyteId);
    }
  }
}