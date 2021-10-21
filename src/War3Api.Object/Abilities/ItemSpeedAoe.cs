using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class ItemSpeedAoe : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataMovementSpeedIncrease;
        public ItemSpeedAoe(): base(1634945345)
        {
            _dataMovementSpeedIncrease = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedIncrease, SetDataMovementSpeedIncrease));
        }

        public ItemSpeedAoe(int newId): base(1634945345, newId)
        {
            _dataMovementSpeedIncrease = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedIncrease, SetDataMovementSpeedIncrease));
        }

        public ItemSpeedAoe(string newRawcode): base(1634945345, newRawcode)
        {
            _dataMovementSpeedIncrease = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedIncrease, SetDataMovementSpeedIncrease));
        }

        public ItemSpeedAoe(ObjectDatabase db): base(1634945345, db)
        {
            _dataMovementSpeedIncrease = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedIncrease, SetDataMovementSpeedIncrease));
        }

        public ItemSpeedAoe(int newId, ObjectDatabase db): base(1634945345, newId, db)
        {
            _dataMovementSpeedIncrease = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedIncrease, SetDataMovementSpeedIncrease));
        }

        public ItemSpeedAoe(string newRawcode, ObjectDatabase db): base(1634945345, newRawcode, db)
        {
            _dataMovementSpeedIncrease = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedIncrease, SetDataMovementSpeedIncrease));
        }

        public ObjectProperty<float> DataMovementSpeedIncrease => _dataMovementSpeedIncrease.Value;
        private float GetDataMovementSpeedIncrease(int level)
        {
            return _modifications[1768977225, level].ValueAsFloat;
        }

        private void SetDataMovementSpeedIncrease(int level, float value)
        {
            _modifications[1768977225, level] = new LevelObjectDataModification{Id = 1768977225, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 1};
        }
    }
}