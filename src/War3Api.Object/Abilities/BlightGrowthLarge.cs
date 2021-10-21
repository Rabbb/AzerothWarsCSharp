using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class BlightGrowthLarge : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataExpansionAmount;
        private readonly Lazy<ObjectProperty<bool>> _dataCreatesBlight;
        public BlightGrowthLarge(): base(1818714689)
        {
            _dataExpansionAmount = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExpansionAmount, SetDataExpansionAmount));
            _dataCreatesBlight = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataCreatesBlight, SetDataCreatesBlight));
        }

        public BlightGrowthLarge(int newId): base(1818714689, newId)
        {
            _dataExpansionAmount = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExpansionAmount, SetDataExpansionAmount));
            _dataCreatesBlight = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataCreatesBlight, SetDataCreatesBlight));
        }

        public BlightGrowthLarge(string newRawcode): base(1818714689, newRawcode)
        {
            _dataExpansionAmount = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExpansionAmount, SetDataExpansionAmount));
            _dataCreatesBlight = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataCreatesBlight, SetDataCreatesBlight));
        }

        public BlightGrowthLarge(ObjectDatabase db): base(1818714689, db)
        {
            _dataExpansionAmount = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExpansionAmount, SetDataExpansionAmount));
            _dataCreatesBlight = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataCreatesBlight, SetDataCreatesBlight));
        }

        public BlightGrowthLarge(int newId, ObjectDatabase db): base(1818714689, newId, db)
        {
            _dataExpansionAmount = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExpansionAmount, SetDataExpansionAmount));
            _dataCreatesBlight = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataCreatesBlight, SetDataCreatesBlight));
        }

        public BlightGrowthLarge(string newRawcode, ObjectDatabase db): base(1818714689, newRawcode, db)
        {
            _dataExpansionAmount = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataExpansionAmount, SetDataExpansionAmount));
            _dataCreatesBlight = new Lazy<ObjectProperty<bool>>(() => new ObjectProperty<bool>(GetDataCreatesBlight, SetDataCreatesBlight));
        }

        public ObjectProperty<float> DataExpansionAmount => _dataExpansionAmount.Value;
        public ObjectProperty<bool> DataCreatesBlight => _dataCreatesBlight.Value;
        private float GetDataExpansionAmount(int level)
        {
            return _modifications[828992578, level].ValueAsFloat;
        }

        private void SetDataExpansionAmount(int level, float value)
        {
            _modifications[828992578, level] = new LevelObjectDataModification{Id = 828992578, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 1};
        }

        private bool GetDataCreatesBlight(int level)
        {
            return _modifications[845769794, level].ValueAsBool;
        }

        private void SetDataCreatesBlight(int level, bool value)
        {
            _modifications[845769794, level] = new LevelObjectDataModification{Id = 845769794, Type = ObjectDataType.Bool, Value = value, Level = level, Pointer = 2};
        }
    }
}