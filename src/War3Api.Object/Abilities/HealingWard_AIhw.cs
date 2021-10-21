using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class HealingWard_AIhw : Ability
    {
        private readonly Lazy<ObjectProperty<string>> _dataWardUnitTypeRaw;
        private readonly Lazy<ObjectProperty<Unit>> _dataWardUnitType;
        public HealingWard_AIhw(): base(2003323201)
        {
            _dataWardUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataWardUnitTypeRaw, SetDataWardUnitTypeRaw));
            _dataWardUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataWardUnitType, SetDataWardUnitType));
        }

        public HealingWard_AIhw(int newId): base(2003323201, newId)
        {
            _dataWardUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataWardUnitTypeRaw, SetDataWardUnitTypeRaw));
            _dataWardUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataWardUnitType, SetDataWardUnitType));
        }

        public HealingWard_AIhw(string newRawcode): base(2003323201, newRawcode)
        {
            _dataWardUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataWardUnitTypeRaw, SetDataWardUnitTypeRaw));
            _dataWardUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataWardUnitType, SetDataWardUnitType));
        }

        public HealingWard_AIhw(ObjectDatabase db): base(2003323201, db)
        {
            _dataWardUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataWardUnitTypeRaw, SetDataWardUnitTypeRaw));
            _dataWardUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataWardUnitType, SetDataWardUnitType));
        }

        public HealingWard_AIhw(int newId, ObjectDatabase db): base(2003323201, newId, db)
        {
            _dataWardUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataWardUnitTypeRaw, SetDataWardUnitTypeRaw));
            _dataWardUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataWardUnitType, SetDataWardUnitType));
        }

        public HealingWard_AIhw(string newRawcode, ObjectDatabase db): base(2003323201, newRawcode, db)
        {
            _dataWardUnitTypeRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataWardUnitTypeRaw, SetDataWardUnitTypeRaw));
            _dataWardUnitType = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataWardUnitType, SetDataWardUnitType));
        }

        public ObjectProperty<string> DataWardUnitTypeRaw => _dataWardUnitTypeRaw.Value;
        public ObjectProperty<Unit> DataWardUnitType => _dataWardUnitType.Value;
        private string GetDataWardUnitTypeRaw(int level)
        {
            return _modifications[1969518440, level].ValueAsString;
        }

        private void SetDataWardUnitTypeRaw(int level, string value)
        {
            _modifications[1969518440, level] = new LevelObjectDataModification{Id = 1969518440, Type = ObjectDataType.String, Value = value, Level = level};
        }

        private Unit GetDataWardUnitType(int level)
        {
            return GetDataWardUnitTypeRaw(level).ToUnit(this);
        }

        private void SetDataWardUnitType(int level, Unit value)
        {
            SetDataWardUnitTypeRaw(level, value.ToRaw(null, null));
        }
    }
}