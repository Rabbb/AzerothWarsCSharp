using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class ReplenishLifeMana : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataHitPointsGained;
        private readonly Lazy<ObjectProperty<float>> _dataManaPointsGained;
        private readonly Lazy<ObjectProperty<float>> _dataMinimumLifeRequired;
        private readonly Lazy<ObjectProperty<float>> _dataMinimumManaRequired;
        private readonly Lazy<ObjectProperty<int>> _dataMaximumUnitsChargedToCaster;
        private readonly Lazy<ObjectProperty<int>> _dataMaximumUnitsAffected;
        public ReplenishLifeMana(): base(1651536449)
        {
            _dataHitPointsGained = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataHitPointsGained, SetDataHitPointsGained));
            _dataManaPointsGained = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataManaPointsGained, SetDataManaPointsGained));
            _dataMinimumLifeRequired = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMinimumLifeRequired, SetDataMinimumLifeRequired));
            _dataMinimumManaRequired = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMinimumManaRequired, SetDataMinimumManaRequired));
            _dataMaximumUnitsChargedToCaster = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaximumUnitsChargedToCaster, SetDataMaximumUnitsChargedToCaster));
            _dataMaximumUnitsAffected = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaximumUnitsAffected, SetDataMaximumUnitsAffected));
        }

        public ReplenishLifeMana(int newId): base(1651536449, newId)
        {
            _dataHitPointsGained = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataHitPointsGained, SetDataHitPointsGained));
            _dataManaPointsGained = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataManaPointsGained, SetDataManaPointsGained));
            _dataMinimumLifeRequired = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMinimumLifeRequired, SetDataMinimumLifeRequired));
            _dataMinimumManaRequired = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMinimumManaRequired, SetDataMinimumManaRequired));
            _dataMaximumUnitsChargedToCaster = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaximumUnitsChargedToCaster, SetDataMaximumUnitsChargedToCaster));
            _dataMaximumUnitsAffected = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaximumUnitsAffected, SetDataMaximumUnitsAffected));
        }

        public ReplenishLifeMana(string newRawcode): base(1651536449, newRawcode)
        {
            _dataHitPointsGained = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataHitPointsGained, SetDataHitPointsGained));
            _dataManaPointsGained = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataManaPointsGained, SetDataManaPointsGained));
            _dataMinimumLifeRequired = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMinimumLifeRequired, SetDataMinimumLifeRequired));
            _dataMinimumManaRequired = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMinimumManaRequired, SetDataMinimumManaRequired));
            _dataMaximumUnitsChargedToCaster = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaximumUnitsChargedToCaster, SetDataMaximumUnitsChargedToCaster));
            _dataMaximumUnitsAffected = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaximumUnitsAffected, SetDataMaximumUnitsAffected));
        }

        public ReplenishLifeMana(ObjectDatabase db): base(1651536449, db)
        {
            _dataHitPointsGained = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataHitPointsGained, SetDataHitPointsGained));
            _dataManaPointsGained = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataManaPointsGained, SetDataManaPointsGained));
            _dataMinimumLifeRequired = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMinimumLifeRequired, SetDataMinimumLifeRequired));
            _dataMinimumManaRequired = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMinimumManaRequired, SetDataMinimumManaRequired));
            _dataMaximumUnitsChargedToCaster = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaximumUnitsChargedToCaster, SetDataMaximumUnitsChargedToCaster));
            _dataMaximumUnitsAffected = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaximumUnitsAffected, SetDataMaximumUnitsAffected));
        }

        public ReplenishLifeMana(int newId, ObjectDatabase db): base(1651536449, newId, db)
        {
            _dataHitPointsGained = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataHitPointsGained, SetDataHitPointsGained));
            _dataManaPointsGained = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataManaPointsGained, SetDataManaPointsGained));
            _dataMinimumLifeRequired = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMinimumLifeRequired, SetDataMinimumLifeRequired));
            _dataMinimumManaRequired = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMinimumManaRequired, SetDataMinimumManaRequired));
            _dataMaximumUnitsChargedToCaster = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaximumUnitsChargedToCaster, SetDataMaximumUnitsChargedToCaster));
            _dataMaximumUnitsAffected = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaximumUnitsAffected, SetDataMaximumUnitsAffected));
        }

        public ReplenishLifeMana(string newRawcode, ObjectDatabase db): base(1651536449, newRawcode, db)
        {
            _dataHitPointsGained = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataHitPointsGained, SetDataHitPointsGained));
            _dataManaPointsGained = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataManaPointsGained, SetDataManaPointsGained));
            _dataMinimumLifeRequired = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMinimumLifeRequired, SetDataMinimumLifeRequired));
            _dataMinimumManaRequired = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataMinimumManaRequired, SetDataMinimumManaRequired));
            _dataMaximumUnitsChargedToCaster = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaximumUnitsChargedToCaster, SetDataMaximumUnitsChargedToCaster));
            _dataMaximumUnitsAffected = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaximumUnitsAffected, SetDataMaximumUnitsAffected));
        }

        public ObjectProperty<float> DataHitPointsGained => _dataHitPointsGained.Value;
        public ObjectProperty<float> DataManaPointsGained => _dataManaPointsGained.Value;
        public ObjectProperty<float> DataMinimumLifeRequired => _dataMinimumLifeRequired.Value;
        public ObjectProperty<float> DataMinimumManaRequired => _dataMinimumManaRequired.Value;
        public ObjectProperty<int> DataMaximumUnitsChargedToCaster => _dataMaximumUnitsChargedToCaster.Value;
        public ObjectProperty<int> DataMaximumUnitsAffected => _dataMaximumUnitsAffected.Value;
        private float GetDataHitPointsGained(int level)
        {
            return _modifications[829056338, level].ValueAsFloat;
        }

        private void SetDataHitPointsGained(int level, float value)
        {
            _modifications[829056338, level] = new LevelObjectDataModification{Id = 829056338, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 1};
        }

        private float GetDataManaPointsGained(int level)
        {
            return _modifications[845833554, level].ValueAsFloat;
        }

        private void SetDataManaPointsGained(int level, float value)
        {
            _modifications[845833554, level] = new LevelObjectDataModification{Id = 845833554, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 2};
        }

        private float GetDataMinimumLifeRequired(int level)
        {
            return _modifications[862089298, level].ValueAsFloat;
        }

        private void SetDataMinimumLifeRequired(int level, float value)
        {
            _modifications[862089298, level] = new LevelObjectDataModification{Id = 862089298, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 3};
        }

        private float GetDataMinimumManaRequired(int level)
        {
            return _modifications[878866514, level].ValueAsFloat;
        }

        private void SetDataMinimumManaRequired(int level, float value)
        {
            _modifications[878866514, level] = new LevelObjectDataModification{Id = 878866514, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 4};
        }

        private int GetDataMaximumUnitsChargedToCaster(int level)
        {
            return _modifications[895643730, level].ValueAsInt;
        }

        private void SetDataMaximumUnitsChargedToCaster(int level, int value)
        {
            _modifications[895643730, level] = new LevelObjectDataModification{Id = 895643730, Type = ObjectDataType.Int, Value = value, Level = level, Pointer = 5};
        }

        private int GetDataMaximumUnitsAffected(int level)
        {
            return _modifications[912420946, level].ValueAsInt;
        }

        private void SetDataMaximumUnitsAffected(int level, int value)
        {
            _modifications[912420946, level] = new LevelObjectDataModification{Id = 912420946, Type = ObjectDataType.Int, Value = value, Level = level};
        }
    }
}