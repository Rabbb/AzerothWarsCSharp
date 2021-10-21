using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class SpawnHydra : Ability
    {
        private readonly Lazy<ObjectProperty<int>> _dataNumberOfUnits;
        private readonly Lazy<ObjectProperty<string>> _dataUnitTypeRaw;
        private readonly Lazy<ObjectProperty<Unit>> _dataUnitType;
        public SpawnHydra(): base(2037412673)
        {
            _dataNumberOfUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataNumberOfUnits, SetDataNumberOfUnits));
            _dataUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataUnitTypeRaw, SetDataUnitTypeRaw));
            _dataUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataUnitType, SetDataUnitType));
        }

        public SpawnHydra(int newId): base(2037412673, newId)
        {
            _dataNumberOfUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataNumberOfUnits, SetDataNumberOfUnits));
            _dataUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataUnitTypeRaw, SetDataUnitTypeRaw));
            _dataUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataUnitType, SetDataUnitType));
        }

        public SpawnHydra(string newRawcode): base(2037412673, newRawcode)
        {
            _dataNumberOfUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataNumberOfUnits, SetDataNumberOfUnits));
            _dataUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataUnitTypeRaw, SetDataUnitTypeRaw));
            _dataUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataUnitType, SetDataUnitType));
        }

        public SpawnHydra(ObjectDatabase db): base(2037412673, db)
        {
            _dataNumberOfUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataNumberOfUnits, SetDataNumberOfUnits));
            _dataUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataUnitTypeRaw, SetDataUnitTypeRaw));
            _dataUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataUnitType, SetDataUnitType));
        }

        public SpawnHydra(int newId, ObjectDatabase db): base(2037412673, newId, db)
        {
            _dataNumberOfUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataNumberOfUnits, SetDataNumberOfUnits));
            _dataUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataUnitTypeRaw, SetDataUnitTypeRaw));
            _dataUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataUnitType, SetDataUnitType));
        }

        public SpawnHydra(string newRawcode, ObjectDatabase db): base(2037412673, newRawcode, db)
        {
            _dataNumberOfUnits = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataNumberOfUnits, SetDataNumberOfUnits));
            _dataUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataUnitTypeRaw, SetDataUnitTypeRaw));
            _dataUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataUnitType, SetDataUnitType));
        }

        public ObjectProperty<int> DataNumberOfUnits => _dataNumberOfUnits.Value;
        public ObjectProperty<string> DataUnitTypeRaw => _dataUnitTypeRaw.Value;
        public ObjectProperty<Unit> DataUnitType => _dataUnitType.Value;
        private int GetDataNumberOfUnits(int level)
        {
            return _modifications[828665683, level].ValueAsInt;
        }

        private void SetDataNumberOfUnits(int level, int value)
        {
            _modifications[828665683, level] = new LevelObjectDataModification{Id = 828665683, Type = ObjectDataType.Int, Value = value, Level = level, Pointer = 1};
        }

        private string GetDataUnitTypeRaw(int level)
        {
            return _modifications[845442899, level].ValueAsString;
        }

        private void SetDataUnitTypeRaw(int level, string value)
        {
            _modifications[845442899, level] = new LevelObjectDataModification{Id = 845442899, Type = ObjectDataType.String, Value = value, Level = level, Pointer = 2};
        }

        private Unit GetDataUnitType(int level)
        {
            return GetDataUnitTypeRaw(level).ToUnit(this);
        }

        private void SetDataUnitType(int level, Unit value)
        {
            SetDataUnitTypeRaw(level, value.ToRaw(null, null));
        }
    }
}