using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class SlowCreep : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataMovementSpeedFactor;
        private readonly Lazy<ObjectProperty<float>> _dataAttackSpeedFactor;
        private readonly Lazy<ObjectProperty<bool>> _dataAlwaysAutocast;
        public SlowCreep(): base(2004042561)
        {
            _dataMovementSpeedFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedFactor, SetDataMovementSpeedFactor));
            _dataAttackSpeedFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedFactor, SetDataAttackSpeedFactor));
            _dataAlwaysAutocast = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataAlwaysAutocast, SetDataAlwaysAutocast));
        }

        public SlowCreep(int newId): base(2004042561, newId)
        {
            _dataMovementSpeedFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedFactor, SetDataMovementSpeedFactor));
            _dataAttackSpeedFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedFactor, SetDataAttackSpeedFactor));
            _dataAlwaysAutocast = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataAlwaysAutocast, SetDataAlwaysAutocast));
        }

        public SlowCreep(string newRawcode): base(2004042561, newRawcode)
        {
            _dataMovementSpeedFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedFactor, SetDataMovementSpeedFactor));
            _dataAttackSpeedFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedFactor, SetDataAttackSpeedFactor));
            _dataAlwaysAutocast = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataAlwaysAutocast, SetDataAlwaysAutocast));
        }

        public SlowCreep(ObjectDatabase db): base(2004042561, db)
        {
            _dataMovementSpeedFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedFactor, SetDataMovementSpeedFactor));
            _dataAttackSpeedFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedFactor, SetDataAttackSpeedFactor));
            _dataAlwaysAutocast = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataAlwaysAutocast, SetDataAlwaysAutocast));
        }

        public SlowCreep(int newId, ObjectDatabase db): base(2004042561, newId, db)
        {
            _dataMovementSpeedFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedFactor, SetDataMovementSpeedFactor));
            _dataAttackSpeedFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedFactor, SetDataAttackSpeedFactor));
            _dataAlwaysAutocast = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataAlwaysAutocast, SetDataAlwaysAutocast));
        }

        public SlowCreep(string newRawcode, ObjectDatabase db): base(2004042561, newRawcode, db)
        {
            _dataMovementSpeedFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMovementSpeedFactor, SetDataMovementSpeedFactor));
            _dataAttackSpeedFactor = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttackSpeedFactor, SetDataAttackSpeedFactor));
            _dataAlwaysAutocast = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataAlwaysAutocast, SetDataAlwaysAutocast));
        }

        public ObjectProperty<float> DataMovementSpeedFactor => _dataMovementSpeedFactor.Value;
        public ObjectProperty<float> DataAttackSpeedFactor => _dataAttackSpeedFactor.Value;
        public ObjectProperty<bool> DataAlwaysAutocast => _dataAlwaysAutocast.Value;
        private float GetDataMovementSpeedFactor(int level)
        {
            return _modifications[829385811, level].ValueAsFloat;
        }

        private void SetDataMovementSpeedFactor(int level, float value)
        {
            _modifications[829385811, level] = new LevelObjectDataModification{Id = 829385811, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 1};
        }

        private float GetDataAttackSpeedFactor(int level)
        {
            return _modifications[846163027, level].ValueAsFloat;
        }

        private void SetDataAttackSpeedFactor(int level, float value)
        {
            _modifications[846163027, level] = new LevelObjectDataModification{Id = 846163027, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 2};
        }

        private bool GetDataAlwaysAutocast(int level)
        {
            return _modifications[862940243, level].ValueAsBool;
        }

        private void SetDataAlwaysAutocast(int level, bool value)
        {
            _modifications[862940243, level] = new LevelObjectDataModification{Id = 862940243, Type = ObjectDataType.Bool, Value = value, Level = level, Pointer = 3};
        }
    }
}