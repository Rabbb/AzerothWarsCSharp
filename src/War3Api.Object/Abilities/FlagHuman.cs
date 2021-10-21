using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class FlagHuman : Ability
    {
        public FlagHuman(): base(1835419969)
        {
        }

        public FlagHuman(int newId): base(1835419969, newId)
        {
        }

        public FlagHuman(string newRawcode): base(1835419969, newRawcode)
        {
        }

        public FlagHuman(ObjectDatabase db): base(1835419969, db)
        {
        }

        public FlagHuman(int newId, ObjectDatabase db): base(1835419969, newId, db)
        {
        }

        public FlagHuman(string newRawcode, ObjectDatabase db): base(1835419969, newRawcode, db)
        {
        }
    }
}