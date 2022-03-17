using AzerothWarsCSharp.Source.Main.Libraries;

namespace AzerothWarsCSharp.Source.Main.UnitTypes
{
  public class UnitTypesNeutral{

    private static void OnInit( ){
      UnitType unitType = 0;

      unitType = UnitType.create(FourCC(h059))      ;//Gilneas City Building
      unitType.UnitCategory = UNITCATEGORY_FARM;

      unitType = UnitType.create(FourCC(h00I))      ;//Windmill
      unitType.UnitCategory = UNITCATEGORY_FARM;
    }

  }
}
