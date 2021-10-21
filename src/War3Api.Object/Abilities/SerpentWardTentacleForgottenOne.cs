using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class SerpentWardTentacleForgottenOne : Ability
    {
        private readonly Lazy<ObjectProperty<string>> _dataSummonedUnitTypeRaw;
        private readonly Lazy<ObjectProperty<Unit>> _dataSummonedUnitType;
        private readonly Lazy<ObjectProperty<int>> _dataSummonedUnitCount;
        public SerpentWardTentacleForgottenOne(): base(1853113153)
        {
            _dataSummonedUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataSummonedUnitTypeRaw, SetDataSummonedUnitTypeRaw));
            _dataSummonedUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataSummonedUnitType, SetDataSummonedUnitType));
            _dataSummonedUnitCount = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataSummonedUnitCount, SetDataSummonedUnitCount));
        }

        public SerpentWardTentacleForgottenOne(int newId): base(1853113153, newId)
        {
            _dataSummonedUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataSummonedUnitTypeRaw, SetDataSummonedUnitTypeRaw));
            _dataSummonedUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataSummonedUnitType, SetDataSummonedUnitType));
            _dataSummonedUnitCount = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataSummonedUnitCount, SetDataSummonedUnitCount));
        }

        public SerpentWardTentacleForgottenOne(string newRawcode): base(1853113153, newRawcode)
        {
            _dataSummonedUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataSummonedUnitTypeRaw, SetDataSummonedUnitTypeRaw));
            _dataSummonedUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataSummonedUnitType, SetDataSummonedUnitType));
            _dataSummonedUnitCount = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataSummonedUnitCount, SetDataSummonedUnitCount));
        }

        public SerpentWardTentacleForgottenOne(ObjectDatabase db): base(1853113153, db)
        {
            _dataSummonedUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataSummonedUnitTypeRaw, SetDataSummonedUnitTypeRaw));
            _dataSummonedUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataSummonedUnitType, SetDataSummonedUnitType));
            _dataSummonedUnitCount = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataSummonedUnitCount, SetDataSummonedUnitCount));
        }

        public SerpentWardTentacleForgottenOne(int newId, ObjectDatabase db): base(1853113153, newId, db)
        {
            _dataSummonedUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataSummonedUnitTypeRaw, SetDataSummonedUnitTypeRaw));
            _dataSummonedUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataSummonedUnitType, SetDataSummonedUnitType));
            _dataSummonedUnitCount = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataSummonedUnitCount, SetDataSummonedUnitCount));
        }

        public SerpentWardTentacleForgottenOne(string newRawcode, ObjectDatabase db): base(1853113153, newRawcode, db)
        {
            _dataSummonedUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataSummonedUnitTypeRaw, SetDataSummonedUnitTypeRaw));
            _dataSummonedUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataSummonedUnitType, SetDataSummonedUnitType));
            _dataSummonedUnitCount = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataSummonedUnitCount, SetDataSummonedUnitCount));
        }

        public ObjectProperty<string> DataSummonedUnitTypeRaw => _dataSummonedUnitTypeRaw.Value;
        public ObjectProperty<Unit> DataSummonedUnitType => _dataSummonedUnitType.Value;
        public ObjectProperty<int> DataSummonedUnitCount => _dataSummonedUnitCount.Value;
        private string GetDataSummonedUnitTypeRaw(int level)
        {
            return _modifications[828733256, level].ValueAsString;
        }

        private void SetDataSummonedUnitTypeRaw(int level, string value)
        {
            _modifications[828733256, level] = new LevelObjectDataModification{Id = 828733256, Type = ObjectDataType.String, Value = value, Level = level};
        }

        private Unit GetDataSummonedUnitType(int level)
        {
            return GetDataSummonedUnitTypeRaw(level).ToUnit(this);
        }

        private void SetDataSummonedUnitType(int level, Unit value)
        {
            SetDataSummonedUnitTypeRaw(level, value.ToRaw(null, null));
        }

        private int GetDataSummonedUnitCount(int level)
        {
            return _modifications[845510472, level].ValueAsInt;
        }

        private void SetDataSummonedUnitCount(int level, int value)
        {
            _modifications[845510472, level] = new LevelObjectDataModification{Id = 845510472, Type = ObjectDataType.Int, Value = value, Level = level, Pointer = 1};
        }
    }
}