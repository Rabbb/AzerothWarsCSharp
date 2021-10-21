using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class ChenDrunkenBrawler : Ability
    {
        public ChenDrunkenBrawler(): base(1650746177)
        {
        }

        public ChenDrunkenBrawler(int newId): base(1650746177, newId)
        {
        }

        public ChenDrunkenBrawler(string newRawcode): base(1650746177, newRawcode)
        {
        }

        public ChenDrunkenBrawler(ObjectDatabase db): base(1650746177, db)
        {
        }

        public ChenDrunkenBrawler(int newId, ObjectDatabase db): base(1650746177, newId, db)
        {
        }

        public ChenDrunkenBrawler(string newRawcode, ObjectDatabase db): base(1650746177, newRawcode, db)
        {
        }
    }
}