using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class CorrosiveBreath : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataDamagePerSecond;
        public CorrosiveBreath(): base(1919902529)
        {
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
        }

        public CorrosiveBreath(int newId): base(1919902529, newId)
        {
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
        }

        public CorrosiveBreath(string newRawcode): base(1919902529, newRawcode)
        {
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
        }

        public CorrosiveBreath(ObjectDatabase db): base(1919902529, db)
        {
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
        }

        public CorrosiveBreath(int newId, ObjectDatabase db): base(1919902529, newId, db)
        {
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
        }

        public CorrosiveBreath(string newRawcode, ObjectDatabase db): base(1919902529, newRawcode, db)
        {
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
        }

        public ObjectProperty<float> DataDamagePerSecond => _dataDamagePerSecond.Value;
        private float GetDataDamagePerSecond(int level)
        {
            return _modifications[829583171, level].ValueAsFloat;
        }

        private void SetDataDamagePerSecond(int level, float value)
        {
            _modifications[829583171, level] = new LevelObjectDataModification{Id = 829583171, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 1};
        }
    }
}