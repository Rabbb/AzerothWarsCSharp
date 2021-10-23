using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class FrostNovaCreep : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataAreaOfEffectDamage;
        private readonly Lazy<ObjectProperty<float>> _dataSpecificTargetDamage;
        private readonly Lazy<ObjectProperty<float>> _dataMaximumDamage;
        public FrostNovaCreep(): base(1852195649)
        {
            _dataAreaOfEffectDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAreaOfEffectDamage, SetDataAreaOfEffectDamage));
            _dataSpecificTargetDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataSpecificTargetDamage, SetDataSpecificTargetDamage));
            _dataMaximumDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMaximumDamage, SetDataMaximumDamage));
        }

        public FrostNovaCreep(int newId): base(1852195649, newId)
        {
            _dataAreaOfEffectDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAreaOfEffectDamage, SetDataAreaOfEffectDamage));
            _dataSpecificTargetDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataSpecificTargetDamage, SetDataSpecificTargetDamage));
            _dataMaximumDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMaximumDamage, SetDataMaximumDamage));
        }

        public FrostNovaCreep(string newRawcode): base(1852195649, newRawcode)
        {
            _dataAreaOfEffectDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAreaOfEffectDamage, SetDataAreaOfEffectDamage));
            _dataSpecificTargetDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataSpecificTargetDamage, SetDataSpecificTargetDamage));
            _dataMaximumDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMaximumDamage, SetDataMaximumDamage));
        }

        public FrostNovaCreep(ObjectDatabase db): base(1852195649, db)
        {
            _dataAreaOfEffectDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAreaOfEffectDamage, SetDataAreaOfEffectDamage));
            _dataSpecificTargetDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataSpecificTargetDamage, SetDataSpecificTargetDamage));
            _dataMaximumDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMaximumDamage, SetDataMaximumDamage));
        }

        public FrostNovaCreep(int newId, ObjectDatabase db): base(1852195649, newId, db)
        {
            _dataAreaOfEffectDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAreaOfEffectDamage, SetDataAreaOfEffectDamage));
            _dataSpecificTargetDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataSpecificTargetDamage, SetDataSpecificTargetDamage));
            _dataMaximumDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMaximumDamage, SetDataMaximumDamage));
        }

        public FrostNovaCreep(string newRawcode, ObjectDatabase db): base(1852195649, newRawcode, db)
        {
            _dataAreaOfEffectDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAreaOfEffectDamage, SetDataAreaOfEffectDamage));
            _dataSpecificTargetDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataSpecificTargetDamage, SetDataSpecificTargetDamage));
            _dataMaximumDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMaximumDamage, SetDataMaximumDamage));
        }

        public ObjectProperty<float> DataAreaOfEffectDamage => _dataAreaOfEffectDamage.Value;
        public ObjectProperty<float> DataSpecificTargetDamage => _dataSpecificTargetDamage.Value;
        public ObjectProperty<float> DataMaximumDamage => _dataMaximumDamage.Value;
        private float GetDataAreaOfEffectDamage(int level)
        {
            return _modifications[829318741, level].ValueAsFloat;
        }

        private void SetDataAreaOfEffectDamage(int level, float value)
        {
            _modifications[829318741, level] = new LevelObjectDataModification{Id = 829318741, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 1};
        }

        private float GetDataSpecificTargetDamage(int level)
        {
            return _modifications[846095957, level].ValueAsFloat;
        }

        private void SetDataSpecificTargetDamage(int level, float value)
        {
            _modifications[846095957, level] = new LevelObjectDataModification{Id = 846095957, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 2};
        }

        private float GetDataMaximumDamage(int level)
        {
            return _modifications[896427605, level].ValueAsFloat;
        }

        private void SetDataMaximumDamage(int level, float value)
        {
            _modifications[896427605, level] = new LevelObjectDataModification{Id = 896427605, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 5};
        }
    }
}