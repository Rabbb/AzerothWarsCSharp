using WCSharp.Events;

namespace AzerothWarsCSharp.Source.RoC.Mechanics.Scourge
{
  public static class Plagueling
  {
    private static readonly int PlaguelingId = FourCC("n08G");
    private const float DURATION = 15;
    
    private static void OnSell()
    {
      UnitApplyTimedLife(GetSoldUnit(), 0, DURATION);
      SetUnitExploded(GetSoldUnit(), true);
    }

    public static void Setup()
    {
      PlayerUnitEvents.Register(PlayerUnitEvent.UnitTypeSellsUnit, OnSell, PlaguelingId);
    }
  }
}