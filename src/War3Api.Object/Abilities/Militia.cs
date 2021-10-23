using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class Militia : Ability
    {
        private readonly Lazy<ObjectProperty<string>> _dataNormalFormUnitRaw;
        private readonly Lazy<ObjectProperty<Unit>> _dataNormalFormUnit;
        private readonly Lazy<ObjectProperty<string>> _dataAlternateFormUnitRaw;
        private readonly Lazy<ObjectProperty<Unit>> _dataAlternateFormUnit;
        public Militia(): base(1818848577)
        {
            _dataNormalFormUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataNormalFormUnitRaw, SetDataNormalFormUnitRaw));
            _dataNormalFormUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataNormalFormUnit, SetDataNormalFormUnit));
            _dataAlternateFormUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataAlternateFormUnitRaw, SetDataAlternateFormUnitRaw));
            _dataAlternateFormUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataAlternateFormUnit, SetDataAlternateFormUnit));
        }

        public Militia(int newId): base(1818848577, newId)
        {
            _dataNormalFormUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataNormalFormUnitRaw, SetDataNormalFormUnitRaw));
            _dataNormalFormUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataNormalFormUnit, SetDataNormalFormUnit));
            _dataAlternateFormUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataAlternateFormUnitRaw, SetDataAlternateFormUnitRaw));
            _dataAlternateFormUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataAlternateFormUnit, SetDataAlternateFormUnit));
        }

        public Militia(string newRawcode): base(1818848577, newRawcode)
        {
            _dataNormalFormUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataNormalFormUnitRaw, SetDataNormalFormUnitRaw));
            _dataNormalFormUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataNormalFormUnit, SetDataNormalFormUnit));
            _dataAlternateFormUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataAlternateFormUnitRaw, SetDataAlternateFormUnitRaw));
            _dataAlternateFormUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataAlternateFormUnit, SetDataAlternateFormUnit));
        }

        public Militia(ObjectDatabase db): base(1818848577, db)
        {
            _dataNormalFormUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataNormalFormUnitRaw, SetDataNormalFormUnitRaw));
            _dataNormalFormUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataNormalFormUnit, SetDataNormalFormUnit));
            _dataAlternateFormUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataAlternateFormUnitRaw, SetDataAlternateFormUnitRaw));
            _dataAlternateFormUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataAlternateFormUnit, SetDataAlternateFormUnit));
        }

        public Militia(int newId, ObjectDatabase db): base(1818848577, newId, db)
        {
            _dataNormalFormUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataNormalFormUnitRaw, SetDataNormalFormUnitRaw));
            _dataNormalFormUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataNormalFormUnit, SetDataNormalFormUnit));
            _dataAlternateFormUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataAlternateFormUnitRaw, SetDataAlternateFormUnitRaw));
            _dataAlternateFormUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataAlternateFormUnit, SetDataAlternateFormUnit));
        }

        public Militia(string newRawcode, ObjectDatabase db): base(1818848577, newRawcode, db)
        {
            _dataNormalFormUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataNormalFormUnitRaw, SetDataNormalFormUnitRaw));
            _dataNormalFormUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataNormalFormUnit, SetDataNormalFormUnit));
            _dataAlternateFormUnitRaw = new Lazy<ObjectProperty<string>>(() => new ObjectProperty<string>(GetDataAlternateFormUnitRaw, SetDataAlternateFormUnitRaw));
            _dataAlternateFormUnit = new Lazy<ObjectProperty<Unit>>(() => new ObjectProperty<Unit>(GetDataAlternateFormUnit, SetDataAlternateFormUnit));
        }

        public ObjectProperty<string> DataNormalFormUnitRaw => _dataNormalFormUnitRaw.Value;
        public ObjectProperty<Unit> DataNormalFormUnit => _dataNormalFormUnit.Value;
        public ObjectProperty<string> DataAlternateFormUnitRaw => _dataAlternateFormUnitRaw.Value;
        public ObjectProperty<Unit> DataAlternateFormUnit => _dataAlternateFormUnit.Value;
        private string GetDataNormalFormUnitRaw(int level)
        {
            return _modifications[829188429, level].ValueAsString;
        }

        private void SetDataNormalFormUnitRaw(int level, string value)
        {
            _modifications[829188429, level] = new LevelObjectDataModification{Id = 829188429, Type = ObjectDataType.String, Value = value, Level = level, Pointer = 1};
        }

        private Unit GetDataNormalFormUnit(int level)
        {
            return GetDataNormalFormUnitRaw(level).ToUnit(this);
        }

        private void SetDataNormalFormUnit(int level, Unit value)
        {
            SetDataNormalFormUnitRaw(level, value.ToRaw(null, null));
        }

        private string GetDataAlternateFormUnitRaw(int level)
        {
            return _modifications[845965645, level].ValueAsString;
        }

        private void SetDataAlternateFormUnitRaw(int level, string value)
        {
            _modifications[845965645, level] = new LevelObjectDataModification{Id = 845965645, Type = ObjectDataType.String, Value = value, Level = level, Pointer = 2};
        }

        private Unit GetDataAlternateFormUnit(int level)
        {
            return GetDataAlternateFormUnitRaw(level).ToUnit(this);
        }

        private void SetDataAlternateFormUnit(int level, Unit value)
        {
            SetDataAlternateFormUnitRaw(level, value.ToRaw(null, null));
        }
    }
}