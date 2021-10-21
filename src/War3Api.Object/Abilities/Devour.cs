using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class Devour : Ability
    {
        private readonly Lazy<ObjectProperty<int>> _dataMaxCreepLevel;
        public Devour(): base(1986356289)
        {
            _dataMaxCreepLevel = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaxCreepLevel, SetDataMaxCreepLevel));
        }

        public Devour(int newId): base(1986356289, newId)
        {
            _dataMaxCreepLevel = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaxCreepLevel, SetDataMaxCreepLevel));
        }

        public Devour(string newRawcode): base(1986356289, newRawcode)
        {
            _dataMaxCreepLevel = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaxCreepLevel, SetDataMaxCreepLevel));
        }

        public Devour(ObjectDatabase db): base(1986356289, db)
        {
            _dataMaxCreepLevel = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaxCreepLevel, SetDataMaxCreepLevel));
        }

        public Devour(int newId, ObjectDatabase db): base(1986356289, newId, db)
        {
            _dataMaxCreepLevel = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaxCreepLevel, SetDataMaxCreepLevel));
        }

        public Devour(string newRawcode, ObjectDatabase db): base(1986356289, newRawcode, db)
        {
            _dataMaxCreepLevel = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaxCreepLevel, SetDataMaxCreepLevel));
        }

        public ObjectProperty<int> DataMaxCreepLevel => _dataMaxCreepLevel.Value;
        private int GetDataMaxCreepLevel(int level)
        {
            return _modifications[829842756, level].ValueAsInt;
        }

        private void SetDataMaxCreepLevel(int level, int value)
        {
            _modifications[829842756, level] = new LevelObjectDataModification{Id = 829842756, Type = ObjectDataType.Int, Value = value, Level = level, Pointer = 1};
        }
    }
}