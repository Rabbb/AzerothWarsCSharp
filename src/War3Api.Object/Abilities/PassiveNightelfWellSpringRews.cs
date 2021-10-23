using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class PassiveNightelfWellSpringRews : Ability
    {
        public PassiveNightelfWellSpringRews(): base(1937204545)
        {
        }

        public PassiveNightelfWellSpringRews(int newId): base(1937204545, newId)
        {
        }

        public PassiveNightelfWellSpringRews(string newRawcode): base(1937204545, newRawcode)
        {
        }

        public PassiveNightelfWellSpringRews(ObjectDatabase db): base(1937204545, db)
        {
        }

        public PassiveNightelfWellSpringRews(int newId, ObjectDatabase db): base(1937204545, newId, db)
        {
        }

        public PassiveNightelfWellSpringRews(string newRawcode, ObjectDatabase db): base(1937204545, newRawcode, db)
        {
        }
    }
}