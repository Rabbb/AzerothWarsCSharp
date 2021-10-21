using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class CairneReincarnation : Ability
    {
        public CairneReincarnation(): base(863129409)
        {
        }

        public CairneReincarnation(int newId): base(863129409, newId)
        {
        }

        public CairneReincarnation(string newRawcode): base(863129409, newRawcode)
        {
        }

        public CairneReincarnation(ObjectDatabase db): base(863129409, db)
        {
        }

        public CairneReincarnation(int newId, ObjectDatabase db): base(863129409, newId, db)
        {
        }

        public CairneReincarnation(string newRawcode, ObjectDatabase db): base(863129409, newRawcode, db)
        {
        }
    }
}