using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object
{
    [FlagsAttribute]
    public enum ChannelFlags
    {
        /// <summary>Visible.</summary>
        Visible = 1 << 0,
        /// <summary>Targeting image.</summary>
        TargetingImage = 1 << 1,
        /// <summary>Physical spell.</summary>
        PhysicalSpell = 1 << 2,
        /// <summary>Universal spell.</summary>
        UniversalSpell = 1 << 3,
        /// <summary>Unique cast.</summary>
        UniqueCast = 1 << 4
    }
}