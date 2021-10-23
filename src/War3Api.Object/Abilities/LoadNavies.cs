using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class LoadNavies : Ability
    {
        private readonly Lazy<ObjectProperty<string>> _dataAllowedUnitTypeRaw;
        private readonly Lazy<ObjectProperty<Unit>> _dataAllowedUnitType;
        public LoadNavies(): base(862940243)
        {
            _dataAllowedUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataAllowedUnitTypeRaw, SetDataAllowedUnitTypeRaw));
            _dataAllowedUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataAllowedUnitType, SetDataAllowedUnitType));
        }

        public LoadNavies(int newId): base(862940243, newId)
        {
            _dataAllowedUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataAllowedUnitTypeRaw, SetDataAllowedUnitTypeRaw));
            _dataAllowedUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataAllowedUnitType, SetDataAllowedUnitType));
        }

        public LoadNavies(string newRawcode): base(862940243, newRawcode)
        {
            _dataAllowedUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataAllowedUnitTypeRaw, SetDataAllowedUnitTypeRaw));
            _dataAllowedUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataAllowedUnitType, SetDataAllowedUnitType));
        }

        public LoadNavies(ObjectDatabase db): base(862940243, db)
        {
            _dataAllowedUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataAllowedUnitTypeRaw, SetDataAllowedUnitTypeRaw));
            _dataAllowedUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataAllowedUnitType, SetDataAllowedUnitType));
        }

        public LoadNavies(int newId, ObjectDatabase db): base(862940243, newId, db)
        {
            _dataAllowedUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataAllowedUnitTypeRaw, SetDataAllowedUnitTypeRaw));
            _dataAllowedUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataAllowedUnitType, SetDataAllowedUnitType));
        }

        public LoadNavies(string newRawcode, ObjectDatabase db): base(862940243, newRawcode, db)
        {
            _dataAllowedUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataAllowedUnitTypeRaw, SetDataAllowedUnitTypeRaw));
            _dataAllowedUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataAllowedUnitType, SetDataAllowedUnitType));
        }

        public ObjectProperty<string> DataAllowedUnitTypeRaw => _dataAllowedUnitTypeRaw.Value;
        public ObjectProperty<Unit> DataAllowedUnitType => _dataAllowedUnitType.Value;
        private string GetDataAllowedUnitTypeRaw(int level)
        {
            return _modifications[828469068, level].ValueAsString;
        }

        private void SetDataAllowedUnitTypeRaw(int level, string value)
        {
            _modifications[828469068, level] = new LevelObjectDataModification{Id = 828469068, Type = ObjectDataType.String, Value = value, Level = level};
        }

        private Unit GetDataAllowedUnitType(int level)
        {
            return GetDataAllowedUnitTypeRaw(level).ToUnit(this);
        }

        private void SetDataAllowedUnitType(int level, Unit value)
        {
            SetDataAllowedUnitTypeRaw(level, value.ToRaw(null, null));
        }
    }
}