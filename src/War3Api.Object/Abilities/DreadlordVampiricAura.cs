using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class DreadlordVampiricAura : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataAttackDamageStolen;
        public DreadlordVampiricAura(): base(1986090305)
        {
            _dataAttackDamageStolen = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackDamageStolen, SetDataAttackDamageStolen));
        }

        public DreadlordVampiricAura(int newId): base(1986090305, newId)
        {
            _dataAttackDamageStolen = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackDamageStolen, SetDataAttackDamageStolen));
        }

        public DreadlordVampiricAura(string newRawcode): base(1986090305, newRawcode)
        {
            _dataAttackDamageStolen = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackDamageStolen, SetDataAttackDamageStolen));
        }

        public DreadlordVampiricAura(ObjectDatabase db): base(1986090305, db)
        {
            _dataAttackDamageStolen = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackDamageStolen, SetDataAttackDamageStolen));
        }

        public DreadlordVampiricAura(int newId, ObjectDatabase db): base(1986090305, newId, db)
        {
            _dataAttackDamageStolen = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackDamageStolen, SetDataAttackDamageStolen));
        }

        public DreadlordVampiricAura(string newRawcode, ObjectDatabase db): base(1986090305, newRawcode, db)
        {
            _dataAttackDamageStolen = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackDamageStolen, SetDataAttackDamageStolen));
        }

        public ObjectProperty<float> DataAttackDamageStolen => _dataAttackDamageStolen.Value;
        private float GetDataAttackDamageStolen(int level)
        {
            return _modifications[829841749, level].ValueAsFloat;
        }

        private void SetDataAttackDamageStolen(int level, float value)
        {
            _modifications[829841749, level] = new LevelObjectDataModification{Id = 829841749, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 1};
        }
    }
}