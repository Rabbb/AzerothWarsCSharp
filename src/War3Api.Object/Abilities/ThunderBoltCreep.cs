using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class ThunderBoltCreep : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataDamage;
        public ThunderBoltCreep(): base(1651786561)
        {
            _dataDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamage, SetDataDamage));
        }

        public ThunderBoltCreep(int newId): base(1651786561, newId)
        {
            _dataDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamage, SetDataDamage));
        }

        public ThunderBoltCreep(string newRawcode): base(1651786561, newRawcode)
        {
            _dataDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamage, SetDataDamage));
        }

        public ThunderBoltCreep(ObjectDatabase db): base(1651786561, db)
        {
            _dataDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamage, SetDataDamage));
        }

        public ThunderBoltCreep(int newId, ObjectDatabase db): base(1651786561, newId, db)
        {
            _dataDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamage, SetDataDamage));
        }

        public ThunderBoltCreep(string newRawcode, ObjectDatabase db): base(1651786561, newRawcode, db)
        {
            _dataDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamage, SetDataDamage));
        }

        public ObjectProperty<float> DataDamage => _dataDamage.Value;
        private float GetDataDamage(int level)
        {
            return _modifications[828535875, level].ValueAsFloat;
        }

        private void SetDataDamage(int level, float value)
        {
            _modifications[828535875, level] = new LevelObjectDataModification{Id = 828535875, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 1};
        }
    }
}