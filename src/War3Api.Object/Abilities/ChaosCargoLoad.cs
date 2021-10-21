using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class ChaosCargoLoad : Ability
    {
        private readonly Lazy<ObjectProperty<string>> _dataUnitTypeAllowedRaw;
        private readonly Lazy<ObjectProperty<Unit>> _dataUnitTypeAllowed;
        public ChaosCargoLoad(): base(1818780481)
        {
            _dataUnitTypeAllowedRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataUnitTypeAllowedRaw, SetDataUnitTypeAllowedRaw));
            _dataUnitTypeAllowed = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataUnitTypeAllowed, SetDataUnitTypeAllowed));
        }

        public ChaosCargoLoad(int newId): base(1818780481, newId)
        {
            _dataUnitTypeAllowedRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataUnitTypeAllowedRaw, SetDataUnitTypeAllowedRaw));
            _dataUnitTypeAllowed = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataUnitTypeAllowed, SetDataUnitTypeAllowed));
        }

        public ChaosCargoLoad(string newRawcode): base(1818780481, newRawcode)
        {
            _dataUnitTypeAllowedRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataUnitTypeAllowedRaw, SetDataUnitTypeAllowedRaw));
            _dataUnitTypeAllowed = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataUnitTypeAllowed, SetDataUnitTypeAllowed));
        }

        public ChaosCargoLoad(ObjectDatabase db): base(1818780481, db)
        {
            _dataUnitTypeAllowedRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataUnitTypeAllowedRaw, SetDataUnitTypeAllowedRaw));
            _dataUnitTypeAllowed = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataUnitTypeAllowed, SetDataUnitTypeAllowed));
        }

        public ChaosCargoLoad(int newId, ObjectDatabase db): base(1818780481, newId, db)
        {
            _dataUnitTypeAllowedRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataUnitTypeAllowedRaw, SetDataUnitTypeAllowedRaw));
            _dataUnitTypeAllowed = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataUnitTypeAllowed, SetDataUnitTypeAllowed));
        }

        public ChaosCargoLoad(string newRawcode, ObjectDatabase db): base(1818780481, newRawcode, db)
        {
            _dataUnitTypeAllowedRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataUnitTypeAllowedRaw, SetDataUnitTypeAllowedRaw));
            _dataUnitTypeAllowed = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataUnitTypeAllowed, SetDataUnitTypeAllowed));
        }

        public ObjectProperty<string> DataUnitTypeAllowedRaw => _dataUnitTypeAllowedRaw.Value;
        public ObjectProperty<Unit> DataUnitTypeAllowed => _dataUnitTypeAllowed.Value;
        private string GetDataUnitTypeAllowedRaw(int level)
        {
            return _modifications[829188163, level].ValueAsString;
        }

        private void SetDataUnitTypeAllowedRaw(int level, string value)
        {
            _modifications[829188163, level] = new LevelObjectDataModification{Id = 829188163, Type = ObjectDataType.String, Value = value, Level = level};
        }

        private Unit GetDataUnitTypeAllowed(int level)
        {
            return GetDataUnitTypeAllowedRaw(level).ToUnit(this);
        }

        private void SetDataUnitTypeAllowed(int level, Unit value)
        {
            SetDataUnitTypeAllowedRaw(level, value.ToRaw(null, null));
        }
    }
}