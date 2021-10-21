using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class EntanglingSeaweed : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataDamagePerSecond;
        public EntanglingSeaweed(): base(2003723585)
        {
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
        }

        public EntanglingSeaweed(int newId): base(2003723585, newId)
        {
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
        }

        public EntanglingSeaweed(string newRawcode): base(2003723585, newRawcode)
        {
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
        }

        public EntanglingSeaweed(ObjectDatabase db): base(2003723585, db)
        {
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
        }

        public EntanglingSeaweed(int newId, ObjectDatabase db): base(2003723585, newId, db)
        {
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
        }

        public EntanglingSeaweed(string newRawcode, ObjectDatabase db): base(2003723585, newRawcode, db)
        {
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
        }

        public ObjectProperty<float> DataDamagePerSecond => _dataDamagePerSecond.Value;
        private float GetDataDamagePerSecond(int level)
        {
            return _modifications[829580613, level].ValueAsFloat;
        }

        private void SetDataDamagePerSecond(int level, float value)
        {
            _modifications[829580613, level] = new LevelObjectDataModification{Id = 829580613, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 1};
        }
    }
}