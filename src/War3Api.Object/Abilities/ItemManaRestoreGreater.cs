using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class ItemManaRestoreGreater : Ability
    {
        private readonly Lazy<ObjectProperty<int>> _dataManaPointsGained;
        public ItemManaRestoreGreater(): base(846022977)
        {
            _dataManaPointsGained = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataManaPointsGained, SetDataManaPointsGained));
        }

        public ItemManaRestoreGreater(int newId): base(846022977, newId)
        {
            _dataManaPointsGained = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataManaPointsGained, SetDataManaPointsGained));
        }

        public ItemManaRestoreGreater(string newRawcode): base(846022977, newRawcode)
        {
            _dataManaPointsGained = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataManaPointsGained, SetDataManaPointsGained));
        }

        public ItemManaRestoreGreater(ObjectDatabase db): base(846022977, db)
        {
            _dataManaPointsGained = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataManaPointsGained, SetDataManaPointsGained));
        }

        public ItemManaRestoreGreater(int newId, ObjectDatabase db): base(846022977, newId, db)
        {
            _dataManaPointsGained = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataManaPointsGained, SetDataManaPointsGained));
        }

        public ItemManaRestoreGreater(string newRawcode, ObjectDatabase db): base(846022977, newRawcode, db)
        {
            _dataManaPointsGained = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataManaPointsGained, SetDataManaPointsGained));
        }

        public ObjectProperty<int> DataManaPointsGained => _dataManaPointsGained.Value;
        private int GetDataManaPointsGained(int level)
        {
            return _modifications[1735421257, level].ValueAsInt;
        }

        private void SetDataManaPointsGained(int level, int value)
        {
            _modifications[1735421257, level] = new LevelObjectDataModification{Id = 1735421257, Type = ObjectDataType.Int, Value = value, Level = level, Pointer = 1};
        }
    }
}