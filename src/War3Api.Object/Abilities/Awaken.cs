using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class Awaken : Ability
    {
        public Awaken(): base(1635213633)
        {
        }

        public Awaken(int newId): base(1635213633, newId)
        {
        }

        public Awaken(string newRawcode): base(1635213633, newRawcode)
        {
        }

        public Awaken(ObjectDatabase db): base(1635213633, db)
        {
        }

        public Awaken(int newId, ObjectDatabase db): base(1635213633, newId, db)
        {
        }

        public Awaken(string newRawcode, ObjectDatabase db): base(1635213633, newRawcode, db)
        {
        }
    }
}