using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object
{
    public enum UpgradeClass
    {
        /// <summary>Armor.</summary>
        Armor = 0,
        /// <summary>Artillery.</summary>
        Artillery = 1,
        /// <summary>Melee.</summary>
        Melee = 2,
        /// <summary>Ranged.</summary>
        Ranged = 3,
        /// <summary>Caster.</summary>
        Caster = 4
    }
}