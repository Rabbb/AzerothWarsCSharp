using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class TichondriusInferno : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataDamage;
        private readonly Lazy<ObjectProperty<float>> _dataDuration;
        private readonly Lazy<ObjectProperty<float>> _dataImpactDelay;
        private readonly Lazy<ObjectProperty<string>> _dataSummonedUnitRaw;
        private readonly Lazy<ObjectProperty<Unit>> _dataSummonedUnit;
        public TichondriusInferno(): base(1852395091)
        {
            _dataDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamage, SetDataDamage));
            _dataDuration = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDuration, SetDataDuration));
            _dataImpactDelay = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataImpactDelay, SetDataImpactDelay));
            _dataSummonedUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataSummonedUnitRaw, SetDataSummonedUnitRaw));
            _dataSummonedUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataSummonedUnit, SetDataSummonedUnit));
        }

        public TichondriusInferno(int newId): base(1852395091, newId)
        {
            _dataDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamage, SetDataDamage));
            _dataDuration = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDuration, SetDataDuration));
            _dataImpactDelay = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataImpactDelay, SetDataImpactDelay));
            _dataSummonedUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataSummonedUnitRaw, SetDataSummonedUnitRaw));
            _dataSummonedUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataSummonedUnit, SetDataSummonedUnit));
        }

        public TichondriusInferno(string newRawcode): base(1852395091, newRawcode)
        {
            _dataDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamage, SetDataDamage));
            _dataDuration = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDuration, SetDataDuration));
            _dataImpactDelay = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataImpactDelay, SetDataImpactDelay));
            _dataSummonedUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataSummonedUnitRaw, SetDataSummonedUnitRaw));
            _dataSummonedUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataSummonedUnit, SetDataSummonedUnit));
        }

        public TichondriusInferno(ObjectDatabase db): base(1852395091, db)
        {
            _dataDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamage, SetDataDamage));
            _dataDuration = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDuration, SetDataDuration));
            _dataImpactDelay = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataImpactDelay, SetDataImpactDelay));
            _dataSummonedUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataSummonedUnitRaw, SetDataSummonedUnitRaw));
            _dataSummonedUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataSummonedUnit, SetDataSummonedUnit));
        }

        public TichondriusInferno(int newId, ObjectDatabase db): base(1852395091, newId, db)
        {
            _dataDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamage, SetDataDamage));
            _dataDuration = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDuration, SetDataDuration));
            _dataImpactDelay = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataImpactDelay, SetDataImpactDelay));
            _dataSummonedUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataSummonedUnitRaw, SetDataSummonedUnitRaw));
            _dataSummonedUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataSummonedUnit, SetDataSummonedUnit));
        }

        public TichondriusInferno(string newRawcode, ObjectDatabase db): base(1852395091, newRawcode, db)
        {
            _dataDamage = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDamage, SetDataDamage));
            _dataDuration = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataDuration, SetDataDuration));
            _dataImpactDelay = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataImpactDelay, SetDataImpactDelay));
            _dataSummonedUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataSummonedUnitRaw, SetDataSummonedUnitRaw));
            _dataSummonedUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataSummonedUnit, SetDataSummonedUnit));
        }

        public ObjectProperty<float> DataDamage => _dataDamage.Value;
        public ObjectProperty<float> DataDuration => _dataDuration.Value;
        public ObjectProperty<float> DataImpactDelay => _dataImpactDelay.Value;
        public ObjectProperty<string> DataSummonedUnitRaw => _dataSummonedUnitRaw.Value;
        public ObjectProperty<Unit> DataSummonedUnit => _dataSummonedUnit.Value;
        private float GetDataDamage(int level)
        {
            return _modifications[829319509, level].ValueAsFloat;
        }

        private void SetDataDamage(int level, float value)
        {
            _modifications[829319509, level] = new LevelObjectDataModification{Id = 829319509, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 1};
        }

        private float GetDataDuration(int level)
        {
            return _modifications[846096725, level].ValueAsFloat;
        }

        private void SetDataDuration(int level, float value)
        {
            _modifications[846096725, level] = new LevelObjectDataModification{Id = 846096725, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 2};
        }

        private float GetDataImpactDelay(int level)
        {
            return _modifications[862873941, level].ValueAsFloat;
        }

        private void SetDataImpactDelay(int level, float value)
        {
            _modifications[862873941, level] = new LevelObjectDataModification{Id = 862873941, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 3};
        }

        private string GetDataSummonedUnitRaw(int level)
        {
            return _modifications[879651157, level].ValueAsString;
        }

        private void SetDataSummonedUnitRaw(int level, string value)
        {
            _modifications[879651157, level] = new LevelObjectDataModification{Id = 879651157, Type = ObjectDataType.String, Value = value, Level = level};
        }

        private Unit GetDataSummonedUnit(int level)
        {
            return GetDataSummonedUnitRaw(level).ToUnit(this);
        }

        private void SetDataSummonedUnit(int level, Unit value)
        {
            SetDataSummonedUnitRaw(level, value.ToRaw(null, null));
        }
    }
}