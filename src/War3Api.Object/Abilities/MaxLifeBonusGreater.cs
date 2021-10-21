using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class MaxLifeBonusGreater : Ability
    {
        private readonly Lazy<ObjectProperty<int>> _dataMaxLifeGained;
        public MaxLifeBonusGreater(): base(845957441)
        {
            _dataMaxLifeGained = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaxLifeGained, SetDataMaxLifeGained));
        }

        public MaxLifeBonusGreater(int newId): base(845957441, newId)
        {
            _dataMaxLifeGained = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaxLifeGained, SetDataMaxLifeGained));
        }

        public MaxLifeBonusGreater(string newRawcode): base(845957441, newRawcode)
        {
            _dataMaxLifeGained = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaxLifeGained, SetDataMaxLifeGained));
        }

        public MaxLifeBonusGreater(ObjectDatabase db): base(845957441, db)
        {
            _dataMaxLifeGained = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaxLifeGained, SetDataMaxLifeGained));
        }

        public MaxLifeBonusGreater(int newId, ObjectDatabase db): base(845957441, newId, db)
        {
            _dataMaxLifeGained = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaxLifeGained, SetDataMaxLifeGained));
        }

        public MaxLifeBonusGreater(string newRawcode, ObjectDatabase db): base(845957441, newRawcode, db)
        {
            _dataMaxLifeGained = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaxLifeGained, SetDataMaxLifeGained));
        }

        public ObjectProperty<int> DataMaxLifeGained => _dataMaxLifeGained.Value;
        private int GetDataMaxLifeGained(int level)
        {
            return _modifications[1718185033, level].ValueAsInt;
        }

        private void SetDataMaxLifeGained(int level, int value)
        {
            _modifications[1718185033, level] = new LevelObjectDataModification{Id = 1718185033, Type = ObjectDataType.Int, Value = value, Level = level, Pointer = 1};
        }
    }
}