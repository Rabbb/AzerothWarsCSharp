using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class Sphere : Ability
    {
        public Sphere(): base(1752200001)
        {
        }

        public Sphere(int newId): base(1752200001, newId)
        {
        }

        public Sphere(string newRawcode): base(1752200001, newRawcode)
        {
        }

        public Sphere(ObjectDatabase db): base(1752200001, db)
        {
        }

        public Sphere(int newId, ObjectDatabase db): base(1752200001, newId, db)
        {
        }

        public Sphere(string newRawcode, ObjectDatabase db): base(1752200001, newRawcode, db)
        {
        }
    }
}