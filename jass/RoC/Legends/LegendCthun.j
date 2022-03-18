library LegendCthun initializer OnInit requires Legend

  globals
    public static Legend LEGEND_SKERAM
    public static Legend LEGEND_GATESAHNQIRAJ
    public static Legend LEGEND_CTHUN

  endglobals

  private function OnInit takes nothing returns nothing

    set LEGEND_CTHUN = new Legend()
    set LEGEND_CTHUN.Unit = gg_unit_U00R_0609
    set LEGEND_CTHUN.PermaDies = true
    set LEGEND_CTHUN.DeathMessage = "The Old God C'thun has fallen"

    set LEGEND_SKERAM = new Legend()
    set LEGEND_SKERAM.UnitType = 'E005'
    set LEGEND_SKERAM.PlayerColor = PLAYER_COLOR_RED
    set LEGEND_SKERAM.Name = "Prophet Skeram"

    set LEGEND_GATESAHNQIRAJ = new Legend()
    set LEGEND_GATESAHNQIRAJ.Unit = gg_unit_h02U_2413

  endfunction

endlibrary