using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class AgilityBonus10 : Ability
    {
        public AgilityBonus10(): base(2053196097)
        {
        }

        public AgilityBonus10(int newId): base(2053196097, newId)
        {
        }

        public AgilityBonus10(string newRawcode): base(2053196097, newRawcode)
        {
        }

        public AgilityBonus10(ObjectDatabase db): base(2053196097, db)
        {
        }

        public AgilityBonus10(int newId, ObjectDatabase db): base(2053196097, newId, db)
        {
        }

        public AgilityBonus10(string newRawcode, ObjectDatabase db): base(2053196097, newRawcode, db)
        {
        }
    }
}