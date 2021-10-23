using System;
using System.Collections.Generic;
using System.Linq;
using War3Net.Build.Object;
using War3Net.Common.Extensions;

namespace War3Api.Object
{
    public sealed class Buff : BaseObject
    {
        private readonly SimpleObjectDataModifications _modifications = new SimpleObjectDataModifications();
        public Buff(BuffType baseBuffType): this((int)baseBuffType)
        {
        }

        public Buff(BuffType baseBuffType, int newId): this((int)baseBuffType, newId)
        {
        }

        public Buff(BuffType baseBuffType, string newRawcode): this((int)baseBuffType, newRawcode)
        {
        }

        public Buff(BuffType baseBuffType, ObjectDatabase db): this((int)baseBuffType, db)
        {
        }

        public Buff(BuffType baseBuffType, int newId, ObjectDatabase db): this((int)baseBuffType, newId, db)
        {
        }

        public Buff(BuffType baseBuffType, string newRawcode, ObjectDatabase db): this((int)baseBuffType, newRawcode, db)
        {
        }

        private Buff(int oldId): base(oldId)
        {
        }

        private Buff(int oldId, int newId): base(oldId, newId)
        {
        }

        private Buff(int oldId, string newRawcode): base(oldId, newRawcode)
        {
        }

        private Buff(int oldId, ObjectDatabase db): base(oldId, db)
        {
        }

        private Buff(int oldId, int newId, ObjectDatabase db): base(oldId, newId, db)
        {
        }

        private Buff(int oldId, string newRawcode, ObjectDatabase db): base(oldId, newRawcode, db)
        {
        }

        public SimpleObjectDataModifications Modifications => _modifications;
        public string TextNameEditorOnly
        {
            get => _modifications[1835101798].ValueAsString;
            set => _modifications[1835101798] = new SimpleObjectDataModification{Id = 1835101798, Type = ObjectDataType.String, Value = value};
        }

        public string TextEditorSuffix
        {
            get => _modifications[1718840934].ValueAsString;
            set => _modifications[1718840934] = new SimpleObjectDataModification{Id = 1718840934, Type = ObjectDataType.String, Value = value};
        }

        public string TextTooltip
        {
            get => _modifications[1885959270].ValueAsString;
            set => _modifications[1885959270] = new SimpleObjectDataModification{Id = 1885959270, Type = ObjectDataType.String, Value = value};
        }

        public string TextTooltipExtended
        {
            get => _modifications[1700951398].ValueAsString;
            set => _modifications[1700951398] = new SimpleObjectDataModification{Id = 1700951398, Type = ObjectDataType.String, Value = value};
        }

        public bool StatsIsAnEffect
        {
            get => _modifications[1717986662].ValueAsBool;
            set => _modifications[1717986662] = new SimpleObjectDataModification{Id = 1717986662, Type = ObjectDataType.Bool, Value = value};
        }

        public string StatsRaceRaw
        {
            get => _modifications[1667330662].ValueAsString;
            set => _modifications[1667330662] = new SimpleObjectDataModification{Id = 1667330662, Type = ObjectDataType.String, Value = value};
        }

        public UnitRace StatsRace
        {
            get => StatsRaceRaw.ToUnitRace(this);
            set => StatsRaceRaw = value.ToRaw(null, null);
        }

        public string ArtIconRaw
        {
            get => _modifications[1953653094].ValueAsString;
            set => _modifications[1953653094] = new SimpleObjectDataModification{Id = 1953653094, Type = ObjectDataType.String, Value = value};
        }

        public string ArtIcon
        {
            get => ArtIconRaw.ToString(this);
            set => ArtIconRaw = value.ToRaw(null, null);
        }

        public string ArtTargetRaw
        {
            get => _modifications[1952543846].ValueAsString;
            set => _modifications[1952543846] = new SimpleObjectDataModification{Id = 1952543846, Type = ObjectDataType.String, Value = value};
        }

        public IEnumerable<string> ArtTarget
        {
            get => ArtTargetRaw.ToIEnumerableString(this);
            set => ArtTargetRaw = value.ToRaw(null, null);
        }

        public string ArtSpecialRaw
        {
            get => _modifications[1952543590].ValueAsString;
            set => _modifications[1952543590] = new SimpleObjectDataModification{Id = 1952543590, Type = ObjectDataType.String, Value = value};
        }

        public IEnumerable<string> ArtSpecial
        {
            get => ArtSpecialRaw.ToIEnumerableString(this);
            set => ArtSpecialRaw = value.ToRaw(null, null);
        }

        public string ArtEffectRaw
        {
            get => _modifications[1952540006].ValueAsString;
            set => _modifications[1952540006] = new SimpleObjectDataModification{Id = 1952540006, Type = ObjectDataType.String, Value = value};
        }

        public IEnumerable<string> ArtEffect
        {
            get => ArtEffectRaw.ToIEnumerableString(this);
            set => ArtEffectRaw = value.ToRaw(null, null);
        }

        public string ArtLightningRaw
        {
            get => _modifications[1734962278].ValueAsString;
            set => _modifications[1734962278] = new SimpleObjectDataModification{Id = 1734962278, Type = ObjectDataType.String, Value = value};
        }

        public LightningEffect ArtLightning
        {
            get => ArtLightningRaw.ToLightningEffect(this);
            set => ArtLightningRaw = value.ToRaw(null, null);
        }

        public string ArtMissileArtRaw
        {
            get => _modifications[1952542054].ValueAsString;
            set => _modifications[1952542054] = new SimpleObjectDataModification{Id = 1952542054, Type = ObjectDataType.String, Value = value};
        }

        public IEnumerable<string> ArtMissileArt
        {
            get => ArtMissileArtRaw.ToIEnumerableString(this);
            set => ArtMissileArtRaw = value.ToRaw(null, null);
        }

        public int ArtMissileSpeed
        {
            get => _modifications[1886612838].ValueAsInt;
            set => _modifications[1886612838] = new SimpleObjectDataModification{Id = 1886612838, Type = ObjectDataType.Int, Value = value};
        }

        public float ArtMissileArc
        {
            get => _modifications[1667329382].ValueAsFloat;
            set => _modifications[1667329382] = new SimpleObjectDataModification{Id = 1667329382, Type = ObjectDataType.Unreal, Value = value};
        }

        public bool ArtMissileHomingEnabled
        {
            get => _modifications[1869114726].ValueAsBool;
            set => _modifications[1869114726] = new SimpleObjectDataModification{Id = 1869114726, Type = ObjectDataType.Bool, Value = value};
        }

        public int ArtTargetAttachments
        {
            get => _modifications[1667331174].ValueAsInt;
            set => _modifications[1667331174] = new SimpleObjectDataModification{Id = 1667331174, Type = ObjectDataType.Int, Value = value};
        }

        public string ArtTargetAttachmentPoint1Raw
        {
            get => _modifications[811693158].ValueAsString;
            set => _modifications[811693158] = new SimpleObjectDataModification{Id = 811693158, Type = ObjectDataType.String, Value = value};
        }

        public IEnumerable<string> ArtTargetAttachmentPoint1
        {
            get => ArtTargetAttachmentPoint1Raw.ToIEnumerableString(this);
            set => ArtTargetAttachmentPoint1Raw = value.ToRaw(null, 32);
        }

        public string ArtTargetAttachmentPoint2Raw
        {
            get => _modifications[828470374].ValueAsString;
            set => _modifications[828470374] = new SimpleObjectDataModification{Id = 828470374, Type = ObjectDataType.String, Value = value};
        }

        public IEnumerable<string> ArtTargetAttachmentPoint2
        {
            get => ArtTargetAttachmentPoint2Raw.ToIEnumerableString(this);
            set => ArtTargetAttachmentPoint2Raw = value.ToRaw(null, 32);
        }

        public string ArtTargetAttachmentPoint3Raw
        {
            get => _modifications[845247590].ValueAsString;
            set => _modifications[845247590] = new SimpleObjectDataModification{Id = 845247590, Type = ObjectDataType.String, Value = value};
        }

        public IEnumerable<string> ArtTargetAttachmentPoint3
        {
            get => ArtTargetAttachmentPoint3Raw.ToIEnumerableString(this);
            set => ArtTargetAttachmentPoint3Raw = value.ToRaw(null, 32);
        }

        public string ArtTargetAttachmentPoint4Raw
        {
            get => _modifications[862024806].ValueAsString;
            set => _modifications[862024806] = new SimpleObjectDataModification{Id = 862024806, Type = ObjectDataType.String, Value = value};
        }

        public IEnumerable<string> ArtTargetAttachmentPoint4
        {
            get => ArtTargetAttachmentPoint4Raw.ToIEnumerableString(this);
            set => ArtTargetAttachmentPoint4Raw = value.ToRaw(null, 32);
        }

        public string ArtTargetAttachmentPoint5Raw
        {
            get => _modifications[878802022].ValueAsString;
            set => _modifications[878802022] = new SimpleObjectDataModification{Id = 878802022, Type = ObjectDataType.String, Value = value};
        }

        public IEnumerable<string> ArtTargetAttachmentPoint5
        {
            get => ArtTargetAttachmentPoint5Raw.ToIEnumerableString(this);
            set => ArtTargetAttachmentPoint5Raw = value.ToRaw(null, 32);
        }

        public string ArtTargetAttachmentPoint6Raw
        {
            get => _modifications[895579238].ValueAsString;
            set => _modifications[895579238] = new SimpleObjectDataModification{Id = 895579238, Type = ObjectDataType.String, Value = value};
        }

        public IEnumerable<string> ArtTargetAttachmentPoint6
        {
            get => ArtTargetAttachmentPoint6Raw.ToIEnumerableString(this);
            set => ArtTargetAttachmentPoint6Raw = value.ToRaw(null, 32);
        }

        public string ArtEffectAttachmentPointRaw
        {
            get => _modifications[1952867686].ValueAsString;
            set => _modifications[1952867686] = new SimpleObjectDataModification{Id = 1952867686, Type = ObjectDataType.String, Value = value};
        }

        public IEnumerable<string> ArtEffectAttachmentPoint
        {
            get => ArtEffectAttachmentPointRaw.ToIEnumerableString(this);
            set => ArtEffectAttachmentPointRaw = value.ToRaw(null, 32);
        }

        public string ArtSpecialAttachmentPointRaw
        {
            get => _modifications[1953526630].ValueAsString;
            set => _modifications[1953526630] = new SimpleObjectDataModification{Id = 1953526630, Type = ObjectDataType.String, Value = value};
        }

        public IEnumerable<string> ArtSpecialAttachmentPoint
        {
            get => ArtSpecialAttachmentPointRaw.ToIEnumerableString(this);
            set => ArtSpecialAttachmentPointRaw = value.ToRaw(null, 32);
        }

        public string SoundEffectSoundRaw
        {
            get => _modifications[1936090470].ValueAsString;
            set => _modifications[1936090470] = new SimpleObjectDataModification{Id = 1936090470, Type = ObjectDataType.String, Value = value};
        }

        public string SoundEffectSound
        {
            get => SoundEffectSoundRaw.ToString(this);
            set => SoundEffectSoundRaw = value.ToRaw(null, null);
        }

        public string SoundEffectSoundLoopingRaw
        {
            get => _modifications[1818649958].ValueAsString;
            set => _modifications[1818649958] = new SimpleObjectDataModification{Id = 1818649958, Type = ObjectDataType.String, Value = value};
        }

        public string SoundEffectSoundLooping
        {
            get => SoundEffectSoundLoopingRaw.ToString(this);
            set => SoundEffectSoundLoopingRaw = value.ToRaw(null, null);
        }

        public int ArtRequiredSpellDetailRaw
        {
            get => _modifications[1685091174].ValueAsInt;
            set => _modifications[1685091174] = new SimpleObjectDataModification{Id = 1685091174, Type = ObjectDataType.Int, Value = value};
        }

        public SpellDetail ArtRequiredSpellDetail
        {
            get => ArtRequiredSpellDetailRaw.ToSpellDetail(this);
            set => ArtRequiredSpellDetailRaw = value.ToRaw(null, null);
        }

        public static explicit operator SimpleObjectModification(Buff buff) => new SimpleObjectModification{OldId = buff.OldId, NewId = buff.NewId, Modifications = buff.Modifications.ToList()};
    }
}