using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class FingerOfPain21Button : Ability
    {
        public FingerOfPain21Button(): base(862339905)
        {
        }

        public FingerOfPain21Button(int newId): base(862339905, newId)
        {
        }

        public FingerOfPain21Button(string newRawcode): base(862339905, newRawcode)
        {
        }

        public FingerOfPain21Button(ObjectDatabase db): base(862339905, db)
        {
        }

        public FingerOfPain21Button(int newId, ObjectDatabase db): base(862339905, newId, db)
        {
        }

        public FingerOfPain21Button(string newRawcode, ObjectDatabase db): base(862339905, newRawcode, db)
        {
        }
    }
}