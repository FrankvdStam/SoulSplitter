// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
// Copyright (c) 2022 Frank van der Stam.
// https://github.com/FrankvdStam/SoulSplitter/blob/main/LICENSE
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, version 3.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.

using SoulMemory.Memory;
using SoulMemory.Parameters;
using System.Diagnostics.CodeAnalysis;

namespace SoulMemory.DarkSouls1.Parameters;

[ExcludeFromCodeCoverage]
public class BulletParam : BaseParam
{
    public BulletParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){}

    [ParamField(0x0, ParamType.I32)]
    public int AtkId_Bullet
    {
        get => _AtkId_Bullet;
        set => WriteParamField(ref _AtkId_Bullet, value);
    }
    private int _AtkId_Bullet;

    [ParamField(0x4, ParamType.I32)]
    public int SfxId_Bullet
    {
        get => _SfxId_Bullet;
        set => WriteParamField(ref _SfxId_Bullet, value);
    }
    private int _SfxId_Bullet;

    [ParamField(0x8, ParamType.I32)]
    public int SfxId_Hit
    {
        get => _SfxId_Hit;
        set => WriteParamField(ref _SfxId_Hit, value);
    }
    private int _SfxId_Hit;

    [ParamField(0xC, ParamType.I32)]
    public int SfxId_Flick
    {
        get => _SfxId_Flick;
        set => WriteParamField(ref _SfxId_Flick, value);
    }
    private int _SfxId_Flick;

    [ParamField(0x10, ParamType.F32)]
    public float Life
    {
        get => _Life;
        set => WriteParamField(ref _Life, value);
    }
    private float _Life;

    [ParamField(0x14, ParamType.F32)]
    public float Dist
    {
        get => _Dist;
        set => WriteParamField(ref _Dist, value);
    }
    private float _Dist;

    [ParamField(0x18, ParamType.F32)]
    public float ShootInterval
    {
        get => _ShootInterval;
        set => WriteParamField(ref _ShootInterval, value);
    }
    private float _ShootInterval;

    [ParamField(0x1C, ParamType.F32)]
    public float GravityInRange
    {
        get => _GravityInRange;
        set => WriteParamField(ref _GravityInRange, value);
    }
    private float _GravityInRange;

    [ParamField(0x20, ParamType.F32)]
    public float GravityOutRange
    {
        get => _GravityOutRange;
        set => WriteParamField(ref _GravityOutRange, value);
    }
    private float _GravityOutRange;

    [ParamField(0x24, ParamType.F32)]
    public float HormingStopRange
    {
        get => _HormingStopRange;
        set => WriteParamField(ref _HormingStopRange, value);
    }
    private float _HormingStopRange;

    [ParamField(0x28, ParamType.F32)]
    public float InitVellocity
    {
        get => _InitVellocity;
        set => WriteParamField(ref _InitVellocity, value);
    }
    private float _InitVellocity;

    [ParamField(0x2C, ParamType.F32)]
    public float AccelInRange
    {
        get => _AccelInRange;
        set => WriteParamField(ref _AccelInRange, value);
    }
    private float _AccelInRange;

    [ParamField(0x30, ParamType.F32)]
    public float AccelOutRange
    {
        get => _AccelOutRange;
        set => WriteParamField(ref _AccelOutRange, value);
    }
    private float _AccelOutRange;

    [ParamField(0x34, ParamType.F32)]
    public float MaxVellocity
    {
        get => _MaxVellocity;
        set => WriteParamField(ref _MaxVellocity, value);
    }
    private float _MaxVellocity;

    [ParamField(0x38, ParamType.F32)]
    public float MinVellocity
    {
        get => _MinVellocity;
        set => WriteParamField(ref _MinVellocity, value);
    }
    private float _MinVellocity;

    [ParamField(0x3C, ParamType.F32)]
    public float AccelTime
    {
        get => _AccelTime;
        set => WriteParamField(ref _AccelTime, value);
    }
    private float _AccelTime;

    [ParamField(0x40, ParamType.F32)]
    public float HomingBeginDist
    {
        get => _HomingBeginDist;
        set => WriteParamField(ref _HomingBeginDist, value);
    }
    private float _HomingBeginDist;

    [ParamField(0x44, ParamType.F32)]
    public float HitRadius
    {
        get => _HitRadius;
        set => WriteParamField(ref _HitRadius, value);
    }
    private float _HitRadius;

    [ParamField(0x48, ParamType.F32)]
    public float HitRadiusMax
    {
        get => _HitRadiusMax;
        set => WriteParamField(ref _HitRadiusMax, value);
    }
    private float _HitRadiusMax;

    [ParamField(0x4C, ParamType.F32)]
    public float SpreadTime
    {
        get => _SpreadTime;
        set => WriteParamField(ref _SpreadTime, value);
    }
    private float _SpreadTime;

    [ParamField(0x50, ParamType.F32)]
    public float ExpDelay
    {
        get => _ExpDelay;
        set => WriteParamField(ref _ExpDelay, value);
    }
    private float _ExpDelay;

    [ParamField(0x54, ParamType.F32)]
    public float HormingOffsetRange
    {
        get => _HormingOffsetRange;
        set => WriteParamField(ref _HormingOffsetRange, value);
    }
    private float _HormingOffsetRange;

    [ParamField(0x58, ParamType.F32)]
    public float DmgHitRecordLifeTime
    {
        get => _DmgHitRecordLifeTime;
        set => WriteParamField(ref _DmgHitRecordLifeTime, value);
    }
    private float _DmgHitRecordLifeTime;

    [ParamField(0x5C, ParamType.F32)]
    public float ExternalForce
    {
        get => _ExternalForce;
        set => WriteParamField(ref _ExternalForce, value);
    }
    private float _ExternalForce;

    [ParamField(0x60, ParamType.I32)]
    public int SpEffectIDForShooter
    {
        get => _SpEffectIDForShooter;
        set => WriteParamField(ref _SpEffectIDForShooter, value);
    }
    private int _SpEffectIDForShooter;

    [ParamField(0x64, ParamType.I32)]
    public int AutoSearchNPCThinkID
    {
        get => _AutoSearchNPCThinkID;
        set => WriteParamField(ref _AutoSearchNPCThinkID, value);
    }
    private int _AutoSearchNPCThinkID;

    [ParamField(0x68, ParamType.I32)]
    public int HitBulletID
    {
        get => _HitBulletID;
        set => WriteParamField(ref _HitBulletID, value);
    }
    private int _HitBulletID;

    [ParamField(0x6C, ParamType.I32)]
    public int SpEffectId0
    {
        get => _SpEffectId0;
        set => WriteParamField(ref _SpEffectId0, value);
    }
    private int _SpEffectId0;

    [ParamField(0x70, ParamType.I32)]
    public int SpEffectId1
    {
        get => _SpEffectId1;
        set => WriteParamField(ref _SpEffectId1, value);
    }
    private int _SpEffectId1;

    [ParamField(0x74, ParamType.I32)]
    public int SpEffectId2
    {
        get => _SpEffectId2;
        set => WriteParamField(ref _SpEffectId2, value);
    }
    private int _SpEffectId2;

    [ParamField(0x78, ParamType.I32)]
    public int SpEffectId3
    {
        get => _SpEffectId3;
        set => WriteParamField(ref _SpEffectId3, value);
    }
    private int _SpEffectId3;

    [ParamField(0x7C, ParamType.I32)]
    public int SpEffectId4
    {
        get => _SpEffectId4;
        set => WriteParamField(ref _SpEffectId4, value);
    }
    private int _SpEffectId4;

    [ParamField(0x80, ParamType.U16)]
    public ushort NumShoot
    {
        get => _NumShoot;
        set => WriteParamField(ref _NumShoot, value);
    }
    private ushort _NumShoot;

    [ParamField(0x82, ParamType.I16)]
    public short HomingAngle
    {
        get => _HomingAngle;
        set => WriteParamField(ref _HomingAngle, value);
    }
    private short _HomingAngle;

    [ParamField(0x84, ParamType.I16)]
    public short ShootAngle
    {
        get => _ShootAngle;
        set => WriteParamField(ref _ShootAngle, value);
    }
    private short _ShootAngle;

    [ParamField(0x86, ParamType.I16)]
    public short ShootAngleInterval
    {
        get => _ShootAngleInterval;
        set => WriteParamField(ref _ShootAngleInterval, value);
    }
    private short _ShootAngleInterval;

    [ParamField(0x88, ParamType.I16)]
    public short ShootAngleXInterval
    {
        get => _ShootAngleXInterval;
        set => WriteParamField(ref _ShootAngleXInterval, value);
    }
    private short _ShootAngleXInterval;

    [ParamField(0x8A, ParamType.I8)]
    public sbyte DamageDamp
    {
        get => _DamageDamp;
        set => WriteParamField(ref _DamageDamp, value);
    }
    private sbyte _DamageDamp;

    [ParamField(0x8B, ParamType.I8)]
    public sbyte SpelDamageDamp
    {
        get => _SpelDamageDamp;
        set => WriteParamField(ref _SpelDamageDamp, value);
    }
    private sbyte _SpelDamageDamp;

    [ParamField(0x8C, ParamType.I8)]
    public sbyte FireDamageDamp
    {
        get => _FireDamageDamp;
        set => WriteParamField(ref _FireDamageDamp, value);
    }
    private sbyte _FireDamageDamp;

    [ParamField(0x8D, ParamType.I8)]
    public sbyte ThunderDamageDamp
    {
        get => _ThunderDamageDamp;
        set => WriteParamField(ref _ThunderDamageDamp, value);
    }
    private sbyte _ThunderDamageDamp;

    [ParamField(0x8E, ParamType.I8)]
    public sbyte StaminaDamp
    {
        get => _StaminaDamp;
        set => WriteParamField(ref _StaminaDamp, value);
    }
    private sbyte _StaminaDamp;

    [ParamField(0x8F, ParamType.I8)]
    public sbyte KnockbackDamp
    {
        get => _KnockbackDamp;
        set => WriteParamField(ref _KnockbackDamp, value);
    }
    private sbyte _KnockbackDamp;

    [ParamField(0x90, ParamType.I8)]
    public sbyte ShootAngleXZ
    {
        get => _ShootAngleXZ;
        set => WriteParamField(ref _ShootAngleXZ, value);
    }
    private sbyte _ShootAngleXZ;

    [ParamField(0x91, ParamType.U8)]
    public byte LockShootLimitAng
    {
        get => _LockShootLimitAng;
        set => WriteParamField(ref _LockShootLimitAng, value);
    }
    private byte _LockShootLimitAng;

    [ParamField(0x92, ParamType.U8)]
    public byte IsPenetrate
    {
        get => _IsPenetrate;
        set => WriteParamField(ref _IsPenetrate, value);
    }
    private byte _IsPenetrate;

    [ParamField(0x93, ParamType.U8)]
    public byte PrevVelocityDirRate
    {
        get => _PrevVelocityDirRate;
        set => WriteParamField(ref _PrevVelocityDirRate, value);
    }
    private byte _PrevVelocityDirRate;

    [ParamField(0x94, ParamType.U8)]
    public byte AtkAttribute
    {
        get => _AtkAttribute;
        set => WriteParamField(ref _AtkAttribute, value);
    }
    private byte _AtkAttribute;

    [ParamField(0x95, ParamType.U8)]
    public byte SpAttribute
    {
        get => _SpAttribute;
        set => WriteParamField(ref _SpAttribute, value);
    }
    private byte _SpAttribute;

    [ParamField(0x96, ParamType.U8)]
    public byte Material_AttackType
    {
        get => _Material_AttackType;
        set => WriteParamField(ref _Material_AttackType, value);
    }
    private byte _Material_AttackType;

    [ParamField(0x97, ParamType.U8)]
    public byte Material_AttackMaterial
    {
        get => _Material_AttackMaterial;
        set => WriteParamField(ref _Material_AttackMaterial, value);
    }
    private byte _Material_AttackMaterial;

    [ParamField(0x98, ParamType.U8)]
    public byte Material_Size
    {
        get => _Material_Size;
        set => WriteParamField(ref _Material_Size, value);
    }
    private byte _Material_Size;

    [ParamField(0x99, ParamType.U8)]
    public byte LaunchConditionType
    {
        get => _LaunchConditionType;
        set => WriteParamField(ref _LaunchConditionType, value);
    }
    private byte _LaunchConditionType;

    #region BitField FollowTypeBitfield ==============================================================================

    [ParamField(0x9A, ParamType.U8)]
    public byte FollowTypeBitfield
    {
        get => _FollowTypeBitfield;
        set => WriteParamField(ref _FollowTypeBitfield, value);
    }
    private byte _FollowTypeBitfield;

    [ParamBitField(nameof(FollowTypeBitfield), bits: 3, bitsOffset: 0)]
    public byte FollowType
    {
        get => GetbitfieldValue(_FollowTypeBitfield);
        set => SetBitfieldValue(ref _FollowTypeBitfield, value);
    }

    [ParamBitField(nameof(FollowTypeBitfield), bits: 3, bitsOffset: 3)]
    public byte EmittePosType
    {
        get => GetbitfieldValue(_FollowTypeBitfield);
        set => SetBitfieldValue(ref _FollowTypeBitfield, value);
    }

    [ParamBitField(nameof(FollowTypeBitfield), bits: 1, bitsOffset: 6)]
    public byte IsAttackSFX
    {
        get => GetbitfieldValue(_FollowTypeBitfield);
        set => SetBitfieldValue(ref _FollowTypeBitfield, value);
    }

    [ParamBitField(nameof(FollowTypeBitfield), bits: 1, bitsOffset: 7)]
    public byte IsEndlessHit
    {
        get => GetbitfieldValue(_FollowTypeBitfield);
        set => SetBitfieldValue(ref _FollowTypeBitfield, value);
    }

    #endregion BitField FollowTypeBitfield

    #region BitField IsPenetrateMapBitfield ==============================================================================

    [ParamField(0x9B, ParamType.U8)]
    public byte IsPenetrateMapBitfield
    {
        get => _IsPenetrateMapBitfield;
        set => WriteParamField(ref _IsPenetrateMapBitfield, value);
    }
    private byte _IsPenetrateMapBitfield;

    [ParamBitField(nameof(IsPenetrateMapBitfield), bits: 1, bitsOffset: 0)]
    public byte IsPenetrateMap
    {
        get => GetbitfieldValue(_IsPenetrateMapBitfield);
        set => SetBitfieldValue(ref _IsPenetrateMapBitfield, value);
    }

    [ParamBitField(nameof(IsPenetrateMapBitfield), bits: 1, bitsOffset: 1)]
    public byte IsHitBothTeam
    {
        get => GetbitfieldValue(_IsPenetrateMapBitfield);
        set => SetBitfieldValue(ref _IsPenetrateMapBitfield, value);
    }

    [ParamBitField(nameof(IsPenetrateMapBitfield), bits: 1, bitsOffset: 2)]
    public byte IsUseSharedHitList
    {
        get => GetbitfieldValue(_IsPenetrateMapBitfield);
        set => SetBitfieldValue(ref _IsPenetrateMapBitfield, value);
    }

    [ParamBitField(nameof(IsPenetrateMapBitfield), bits: 1, bitsOffset: 3)]
    public byte IsUseMultiDmyPolyIfPlace
    {
        get => GetbitfieldValue(_IsPenetrateMapBitfield);
        set => SetBitfieldValue(ref _IsPenetrateMapBitfield, value);
    }

    [ParamBitField(nameof(IsPenetrateMapBitfield), bits: 2, bitsOffset: 4)]
    public byte AttachEffectType
    {
        get => GetbitfieldValue(_IsPenetrateMapBitfield);
        set => SetBitfieldValue(ref _IsPenetrateMapBitfield, value);
    }

    [ParamBitField(nameof(IsPenetrateMapBitfield), bits: 1, bitsOffset: 6)]
    public byte IsHitForceMagic
    {
        get => GetbitfieldValue(_IsPenetrateMapBitfield);
        set => SetBitfieldValue(ref _IsPenetrateMapBitfield, value);
    }

    [ParamBitField(nameof(IsPenetrateMapBitfield), bits: 1, bitsOffset: 7)]
    public byte IsIgnoreSfxIfHitWater
    {
        get => GetbitfieldValue(_IsPenetrateMapBitfield);
        set => SetBitfieldValue(ref _IsPenetrateMapBitfield, value);
    }

    #endregion BitField IsPenetrateMapBitfield

    #region BitField IsIgnoreMoveStateIfHitWaterBitfield ==============================================================================

    [ParamField(0x9C, ParamType.U8)]
    public byte IsIgnoreMoveStateIfHitWaterBitfield
    {
        get => _IsIgnoreMoveStateIfHitWaterBitfield;
        set => WriteParamField(ref _IsIgnoreMoveStateIfHitWaterBitfield, value);
    }
    private byte _IsIgnoreMoveStateIfHitWaterBitfield;

    [ParamBitField(nameof(IsIgnoreMoveStateIfHitWaterBitfield), bits: 1, bitsOffset: 0)]
    public byte IsIgnoreMoveStateIfHitWater
    {
        get => GetbitfieldValue(_IsIgnoreMoveStateIfHitWaterBitfield);
        set => SetBitfieldValue(ref _IsIgnoreMoveStateIfHitWaterBitfield, value);
    }

    [ParamBitField(nameof(IsIgnoreMoveStateIfHitWaterBitfield), bits: 1, bitsOffset: 1)]
    public byte IsHitDarkForceMagic
    {
        get => GetbitfieldValue(_IsIgnoreMoveStateIfHitWaterBitfield);
        set => SetBitfieldValue(ref _IsIgnoreMoveStateIfHitWaterBitfield, value);
    }

    #endregion BitField IsIgnoreMoveStateIfHitWaterBitfield

    [ParamField(0x9D, ParamType.Dummy8, 3)]
    public byte[] Pad
    {
        get => _Pad;
        set => WriteParamField(ref _Pad, value);
    }
    private byte[] _Pad = null!;

}
