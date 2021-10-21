using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class BeserkItem : Ability
    {
        public BeserkItem(): base(1803045185)
        {
        }

        public BeserkItem(int newId): base(1803045185, newId)
        {
        }

        public BeserkItem(string newRawcode): base(1803045185, newRawcode)
        {
        }

        public BeserkItem(ObjectDatabase db): base(1803045185, db)
        {
        }

        public BeserkItem(int newId, ObjectDatabase db): base(1803045185, newId, db)
        {
        }

        public BeserkItem(string newRawcode, ObjectDatabase db): base(1803045185, newRawcode, db)
        {
        }
    }
}