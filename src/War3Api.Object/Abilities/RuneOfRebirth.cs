using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class RuneOfRebirth : Ability
    {
        public RuneOfRebirth(): base(1651657025)
        {
        }

        public RuneOfRebirth(int newId): base(1651657025, newId)
        {
        }

        public RuneOfRebirth(string newRawcode): base(1651657025, newRawcode)
        {
        }

        public RuneOfRebirth(ObjectDatabase db): base(1651657025, db)
        {
        }

        public RuneOfRebirth(int newId, ObjectDatabase db): base(1651657025, newId, db)
        {
        }

        public RuneOfRebirth(string newRawcode, ObjectDatabase db): base(1651657025, newRawcode, db)
        {
        }
    }
}