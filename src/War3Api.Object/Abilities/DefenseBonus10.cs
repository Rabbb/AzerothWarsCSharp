using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class DefenseBonus10 : Ability
    {
        public DefenseBonus10(): base(811878721)
        {
        }

        public DefenseBonus10(int newId): base(811878721, newId)
        {
        }

        public DefenseBonus10(string newRawcode): base(811878721, newRawcode)
        {
        }

        public DefenseBonus10(ObjectDatabase db): base(811878721, db)
        {
        }

        public DefenseBonus10(int newId, ObjectDatabase db): base(811878721, newId, db)
        {
        }

        public DefenseBonus10(string newRawcode, ObjectDatabase db): base(811878721, newRawcode, db)
        {
        }
    }
}