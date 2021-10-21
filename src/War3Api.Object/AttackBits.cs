using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object
{
    public enum AttackBits
    {
        /// <summary>None.</summary>
        None = 0,
        /// <summary>Attack 1 only.</summary>
        Attack1Only = 1,
        /// <summary>Attack 2 only.</summary>
        Attack2Only = 2,
        /// <summary>Both.</summary>
        Both = 3
    }
}