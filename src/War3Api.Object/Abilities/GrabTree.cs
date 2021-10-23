using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object.Abilities
{
    public sealed class GrabTree : Ability
    {
        private readonly Lazy<ObjectProperty<float>> _dataAttachDelay;
        private readonly Lazy<ObjectProperty<float>> _dataRemoveDelay;
        private readonly Lazy<ObjectProperty<int>> _dataDisabledAttackIndex;
        private readonly Lazy<ObjectProperty<int>> _dataEnabledAttackIndex;
        private readonly Lazy<ObjectProperty<int>> _dataMaximumAttacks;
        public GrabTree(): base(1634887489)
        {
            _dataAttachDelay = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttachDelay, SetDataAttachDelay));
            _dataRemoveDelay = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataRemoveDelay, SetDataRemoveDelay));
            _dataDisabledAttackIndex = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataDisabledAttackIndex, SetDataDisabledAttackIndex));
            _dataEnabledAttackIndex = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataEnabledAttackIndex, SetDataEnabledAttackIndex));
            _dataMaximumAttacks = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaximumAttacks, SetDataMaximumAttacks));
        }

        public GrabTree(int newId): base(1634887489, newId)
        {
            _dataAttachDelay = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttachDelay, SetDataAttachDelay));
            _dataRemoveDelay = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataRemoveDelay, SetDataRemoveDelay));
            _dataDisabledAttackIndex = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataDisabledAttackIndex, SetDataDisabledAttackIndex));
            _dataEnabledAttackIndex = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataEnabledAttackIndex, SetDataEnabledAttackIndex));
            _dataMaximumAttacks = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaximumAttacks, SetDataMaximumAttacks));
        }

        public GrabTree(string newRawcode): base(1634887489, newRawcode)
        {
            _dataAttachDelay = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttachDelay, SetDataAttachDelay));
            _dataRemoveDelay = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataRemoveDelay, SetDataRemoveDelay));
            _dataDisabledAttackIndex = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataDisabledAttackIndex, SetDataDisabledAttackIndex));
            _dataEnabledAttackIndex = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataEnabledAttackIndex, SetDataEnabledAttackIndex));
            _dataMaximumAttacks = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaximumAttacks, SetDataMaximumAttacks));
        }

        public GrabTree(ObjectDatabase db): base(1634887489, db)
        {
            _dataAttachDelay = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttachDelay, SetDataAttachDelay));
            _dataRemoveDelay = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataRemoveDelay, SetDataRemoveDelay));
            _dataDisabledAttackIndex = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataDisabledAttackIndex, SetDataDisabledAttackIndex));
            _dataEnabledAttackIndex = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataEnabledAttackIndex, SetDataEnabledAttackIndex));
            _dataMaximumAttacks = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaximumAttacks, SetDataMaximumAttacks));
        }

        public GrabTree(int newId, ObjectDatabase db): base(1634887489, newId, db)
        {
            _dataAttachDelay = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttachDelay, SetDataAttachDelay));
            _dataRemoveDelay = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataRemoveDelay, SetDataRemoveDelay));
            _dataDisabledAttackIndex = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataDisabledAttackIndex, SetDataDisabledAttackIndex));
            _dataEnabledAttackIndex = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataEnabledAttackIndex, SetDataEnabledAttackIndex));
            _dataMaximumAttacks = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaximumAttacks, SetDataMaximumAttacks));
        }

        public GrabTree(string newRawcode, ObjectDatabase db): base(1634887489, newRawcode, db)
        {
            _dataAttachDelay = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataAttachDelay, SetDataAttachDelay));
            _dataRemoveDelay = new Lazy<ObjectProperty<float>>(() => new ObjectProperty<float>(GetDataRemoveDelay, SetDataRemoveDelay));
            _dataDisabledAttackIndex = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataDisabledAttackIndex, SetDataDisabledAttackIndex));
            _dataEnabledAttackIndex = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataEnabledAttackIndex, SetDataEnabledAttackIndex));
            _dataMaximumAttacks = new Lazy<ObjectProperty<int>>(() => new ObjectProperty<int>(GetDataMaximumAttacks, SetDataMaximumAttacks));
        }

        public ObjectProperty<float> DataAttachDelay => _dataAttachDelay.Value;
        public ObjectProperty<float> DataRemoveDelay => _dataRemoveDelay.Value;
        public ObjectProperty<int> DataDisabledAttackIndex => _dataDisabledAttackIndex.Value;
        public ObjectProperty<int> DataEnabledAttackIndex => _dataEnabledAttackIndex.Value;
        public ObjectProperty<int> DataMaximumAttacks => _dataMaximumAttacks.Value;
        private float GetDataAttachDelay(int level)
        {
            return _modifications[828469863, level].ValueAsFloat;
        }

        private void SetDataAttachDelay(int level, float value)
        {
            _modifications[828469863, level] = new LevelObjectDataModification{Id = 828469863, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 1};
        }

        private float GetDataRemoveDelay(int level)
        {
            return _modifications[845247079, level].ValueAsFloat;
        }

        private void SetDataRemoveDelay(int level, float value)
        {
            _modifications[845247079, level] = new LevelObjectDataModification{Id = 845247079, Type = ObjectDataType.Unreal, Value = value, Level = level, Pointer = 2};
        }

        private int GetDataDisabledAttackIndex(int level)
        {
            return _modifications[862024295, level].ValueAsInt;
        }

        private void SetDataDisabledAttackIndex(int level, int value)
        {
            _modifications[862024295, level] = new LevelObjectDataModification{Id = 862024295, Type = ObjectDataType.Int, Value = value, Level = level, Pointer = 3};
        }

        private int GetDataEnabledAttackIndex(int level)
        {
            return _modifications[878801511, level].ValueAsInt;
        }

        private void SetDataEnabledAttackIndex(int level, int value)
        {
            _modifications[878801511, level] = new LevelObjectDataModification{Id = 878801511, Type = ObjectDataType.Int, Value = value, Level = level, Pointer = 4};
        }

        private int GetDataMaximumAttacks(int level)
        {
            return _modifications[895578727, level].ValueAsInt;
        }

        private void SetDataMaximumAttacks(int level, int value)
        {
            _modifications[895578727, level] = new LevelObjectDataModification{Id = 895578727, Type = ObjectDataType.Int, Value = value, Level = level, Pointer = 5};
        }
    }
}