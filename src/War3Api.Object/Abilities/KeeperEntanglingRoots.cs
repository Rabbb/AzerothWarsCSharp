using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class KeeperEntanglingRoots : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataDamagePerSecond;
        public KeeperEntanglingRoots(): base(1919239489)
        {
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
        }

        public KeeperEntanglingRoots(int newId): base(1919239489, newId)
        {
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
        }

        public KeeperEntanglingRoots(string newRawcode): base(1919239489, newRawcode)
        {
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
        }

        public KeeperEntanglingRoots(ObjectDatabase db): base(1919239489, db)
        {
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
        }

        public KeeperEntanglingRoots(int newId, ObjectDatabase db): base(1919239489, newId, db)
        {
            _dataDamagePerSecond = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamagePerSecond, SetDataDamagePerSecond));
        }

        public KeeperEntanglingRoots(string newRawcode, ObjectDatabase db): base(1919239489, newRawcode, db)
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