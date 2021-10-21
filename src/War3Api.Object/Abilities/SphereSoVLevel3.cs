using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class SphereSoVLevel3 : Ability
    {
        public SphereSoVLevel3(): base(863007553)
        {
        }

        public SphereSoVLevel3(int newId): base(863007553, newId)
        {
        }

        public SphereSoVLevel3(string newRawcode): base(863007553, newRawcode)
        {
        }

        public SphereSoVLevel3(ObjectDatabase db): base(863007553, db)
        {
        }

        public SphereSoVLevel3(int newId, ObjectDatabase db): base(863007553, newId, db)
        {
        }

        public SphereSoVLevel3(string newRawcode, ObjectDatabase db): base(863007553, newRawcode, db)
        {
        }
    }
}