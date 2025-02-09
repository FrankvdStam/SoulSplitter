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
public class BulletParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.I32)]
    public int AtkIdBullet
    {
        get => _atkIdBullet;
        set => WriteParamField(ref _atkIdBullet, value);
    }
    private int _atkIdBullet;

    [ParamField(0x4, ParamType.I32)]
    public int SfxIdBullet
    {
        get => _sfxIdBullet;
        set => WriteParamField(ref _sfxIdBullet, value);
    }
    private int _sfxIdBullet;

    [ParamField(0x8, ParamType.I32)]
    public int SfxIdHit
    {
        get => _sfxIdHit;
        set => WriteParamField(ref _sfxIdHit, value);
    }
    private int _sfxIdHit;

    [ParamField(0xC, ParamType.I32)]
    public int SfxIdFlick
    {
        get => _sfxIdFlick;
        set => WriteParamField(ref _sfxIdFlick, value);
    }
    private int _sfxIdFlick;

    [ParamField(0x10, ParamType.F32)]
    public float Life
    {
        get => _life;
        set => WriteParamField(ref _life, value);
    }
    private float _life;

    [ParamField(0x14, ParamType.F32)]
    public float Dist
    {
        get => _dist;
        set => WriteParamField(ref _dist, value);
    }
    private float _dist;

    [ParamField(0x18, ParamType.F32)]
    public float ShootInterval
    {
        get => _shootInterval;
        set => WriteParamField(ref _shootInterval, value);
    }
    private float _shootInterval;

    [ParamField(0x1C, ParamType.F32)]
    public float GravityInRange
    {
        get => _gravityInRange;
        set => WriteParamField(ref _gravityInRange, value);
    }
    private float _gravityInRange;

    [ParamField(0x20, ParamType.F32)]
    public float GravityOutRange
    {
        get => _gravityOutRange;
        set => WriteParamField(ref _gravityOutRange, value);
    }
    private float _gravityOutRange;

    [ParamField(0x24, ParamType.F32)]
    public float HormingStopRange
    {
        get => _hormingStopRange;
        set => WriteParamField(ref _hormingStopRange, value);
    }
    private float _hormingStopRange;

    [ParamField(0x28, ParamType.F32)]
    public float InitVellocity
    {
        get => _initVellocity;
        set => WriteParamField(ref _initVellocity, value);
    }
    private float _initVellocity;

    [ParamField(0x2C, ParamType.F32)]
    public float AccelInRange
    {
        get => _accelInRange;
        set => WriteParamField(ref _accelInRange, value);
    }
    private float _accelInRange;

    [ParamField(0x30, ParamType.F32)]
    public float AccelOutRange
    {
        get => _accelOutRange;
        set => WriteParamField(ref _accelOutRange, value);
    }
    private float _accelOutRange;

    [ParamField(0x34, ParamType.F32)]
    public float MaxVellocity
    {
        get => _maxVellocity;
        set => WriteParamField(ref _maxVellocity, value);
    }
    private float _maxVellocity;

    [ParamField(0x38, ParamType.F32)]
    public float MinVellocity
    {
        get => _minVellocity;
        set => WriteParamField(ref _minVellocity, value);
    }
    private float _minVellocity;

    [ParamField(0x3C, ParamType.F32)]
    public float AccelTime
    {
        get => _accelTime;
        set => WriteParamField(ref _accelTime, value);
    }
    private float _accelTime;

    [ParamField(0x40, ParamType.F32)]
    public float HomingBeginDist
    {
        get => _homingBeginDist;
        set => WriteParamField(ref _homingBeginDist, value);
    }
    private float _homingBeginDist;

    [ParamField(0x44, ParamType.F32)]
    public float HitRadius
    {
        get => _hitRadius;
        set => WriteParamField(ref _hitRadius, value);
    }
    private float _hitRadius;

    [ParamField(0x48, ParamType.F32)]
    public float HitRadiusMax
    {
        get => _hitRadiusMax;
        set => WriteParamField(ref _hitRadiusMax, value);
    }
    private float _hitRadiusMax;

    [ParamField(0x4C, ParamType.F32)]
    public float SpreadTime
    {
        get => _spreadTime;
        set => WriteParamField(ref _spreadTime, value);
    }
    private float _spreadTime;

    [ParamField(0x50, ParamType.F32)]
    public float ExpDelay
    {
        get => _expDelay;
        set => WriteParamField(ref _expDelay, value);
    }
    private float _expDelay;

    [ParamField(0x54, ParamType.F32)]
    public float HormingOffsetRange
    {
        get => _hormingOffsetRange;
        set => WriteParamField(ref _hormingOffsetRange, value);
    }
    private float _hormingOffsetRange;

    [ParamField(0x58, ParamType.F32)]
    public float DmgHitRecordLifeTime
    {
        get => _dmgHitRecordLifeTime;
        set => WriteParamField(ref _dmgHitRecordLifeTime, value);
    }
    private float _dmgHitRecordLifeTime;

    [ParamField(0x5C, ParamType.F32)]
    public float ExternalForce
    {
        get => _externalForce;
        set => WriteParamField(ref _externalForce, value);
    }
    private float _externalForce;

    [ParamField(0x60, ParamType.I32)]
    public int SpEffectIdForShooter
    {
        get => _spEffectIdForShooter;
        set => WriteParamField(ref _spEffectIdForShooter, value);
    }
    private int _spEffectIdForShooter;

    [ParamField(0x64, ParamType.I32)]
    public int AutoSearchNpcThinkId
    {
        get => _autoSearchNpcThinkId;
        set => WriteParamField(ref _autoSearchNpcThinkId, value);
    }
    private int _autoSearchNpcThinkId;

    [ParamField(0x68, ParamType.I32)]
    public int HitBulletId
    {
        get => _hitBulletId;
        set => WriteParamField(ref _hitBulletId, value);
    }
    private int _hitBulletId;

    [ParamField(0x6C, ParamType.I32)]
    public int SpEffectId0
    {
        get => _spEffectId0;
        set => WriteParamField(ref _spEffectId0, value);
    }
    private int _spEffectId0;

    [ParamField(0x70, ParamType.I32)]
    public int SpEffectId1
    {
        get => _spEffectId1;
        set => WriteParamField(ref _spEffectId1, value);
    }
    private int _spEffectId1;

    [ParamField(0x74, ParamType.I32)]
    public int SpEffectId2
    {
        get => _spEffectId2;
        set => WriteParamField(ref _spEffectId2, value);
    }
    private int _spEffectId2;

    [ParamField(0x78, ParamType.I32)]
    public int SpEffectId3
    {
        get => _spEffectId3;
        set => WriteParamField(ref _spEffectId3, value);
    }
    private int _spEffectId3;

    [ParamField(0x7C, ParamType.I32)]
    public int SpEffectId4
    {
        get => _spEffectId4;
        set => WriteParamField(ref _spEffectId4, value);
    }
    private int _spEffectId4;

    [ParamField(0x80, ParamType.U16)]
    public ushort NumShoot
    {
        get => _numShoot;
        set => WriteParamField(ref _numShoot, value);
    }
    private ushort _numShoot;

    [ParamField(0x82, ParamType.I16)]
    public short HomingAngle
    {
        get => _homingAngle;
        set => WriteParamField(ref _homingAngle, value);
    }
    private short _homingAngle;

    [ParamField(0x84, ParamType.I16)]
    public short ShootAngle
    {
        get => _shootAngle;
        set => WriteParamField(ref _shootAngle, value);
    }
    private short _shootAngle;

    [ParamField(0x86, ParamType.I16)]
    public short ShootAngleInterval
    {
        get => _shootAngleInterval;
        set => WriteParamField(ref _shootAngleInterval, value);
    }
    private short _shootAngleInterval;

    [ParamField(0x88, ParamType.I16)]
    public short ShootAngleXInterval
    {
        get => _shootAngleXInterval;
        set => WriteParamField(ref _shootAngleXInterval, value);
    }
    private short _shootAngleXInterval;

    [ParamField(0x8A, ParamType.I8)]
    public sbyte DamageDamp
    {
        get => _damageDamp;
        set => WriteParamField(ref _damageDamp, value);
    }
    private sbyte _damageDamp;

    [ParamField(0x8B, ParamType.I8)]
    public sbyte SpelDamageDamp
    {
        get => _spelDamageDamp;
        set => WriteParamField(ref _spelDamageDamp, value);
    }
    private sbyte _spelDamageDamp;

    [ParamField(0x8C, ParamType.I8)]
    public sbyte FireDamageDamp
    {
        get => _fireDamageDamp;
        set => WriteParamField(ref _fireDamageDamp, value);
    }
    private sbyte _fireDamageDamp;

    [ParamField(0x8D, ParamType.I8)]
    public sbyte ThunderDamageDamp
    {
        get => _thunderDamageDamp;
        set => WriteParamField(ref _thunderDamageDamp, value);
    }
    private sbyte _thunderDamageDamp;

    [ParamField(0x8E, ParamType.I8)]
    public sbyte StaminaDamp
    {
        get => _staminaDamp;
        set => WriteParamField(ref _staminaDamp, value);
    }
    private sbyte _staminaDamp;

    [ParamField(0x8F, ParamType.I8)]
    public sbyte KnockbackDamp
    {
        get => _knockbackDamp;
        set => WriteParamField(ref _knockbackDamp, value);
    }
    private sbyte _knockbackDamp;

    [ParamField(0x90, ParamType.I8)]
    public sbyte ShootAngleXz
    {
        get => _shootAngleXz;
        set => WriteParamField(ref _shootAngleXz, value);
    }
    private sbyte _shootAngleXz;

    [ParamField(0x91, ParamType.U8)]
    public byte LockShootLimitAng
    {
        get => _lockShootLimitAng;
        set => WriteParamField(ref _lockShootLimitAng, value);
    }
    private byte _lockShootLimitAng;

    [ParamField(0x92, ParamType.U8)]
    public byte IsPenetrate
    {
        get => _isPenetrate;
        set => WriteParamField(ref _isPenetrate, value);
    }
    private byte _isPenetrate;

    [ParamField(0x93, ParamType.U8)]
    public byte PrevVelocityDirRate
    {
        get => _prevVelocityDirRate;
        set => WriteParamField(ref _prevVelocityDirRate, value);
    }
    private byte _prevVelocityDirRate;

    [ParamField(0x94, ParamType.U8)]
    public byte AtkAttribute
    {
        get => _atkAttribute;
        set => WriteParamField(ref _atkAttribute, value);
    }
    private byte _atkAttribute;

    [ParamField(0x95, ParamType.U8)]
    public byte SpAttribute
    {
        get => _spAttribute;
        set => WriteParamField(ref _spAttribute, value);
    }
    private byte _spAttribute;

    [ParamField(0x96, ParamType.U8)]
    public byte MaterialAttackType
    {
        get => _materialAttackType;
        set => WriteParamField(ref _materialAttackType, value);
    }
    private byte _materialAttackType;

    [ParamField(0x97, ParamType.U8)]
    public byte MaterialAttackMaterial
    {
        get => _materialAttackMaterial;
        set => WriteParamField(ref _materialAttackMaterial, value);
    }
    private byte _materialAttackMaterial;

    [ParamField(0x98, ParamType.U8)]
    public byte MaterialSize
    {
        get => _materialSize;
        set => WriteParamField(ref _materialSize, value);
    }
    private byte _materialSize;

    [ParamField(0x99, ParamType.U8)]
    public byte LaunchConditionType
    {
        get => _launchConditionType;
        set => WriteParamField(ref _launchConditionType, value);
    }
    private byte _launchConditionType;

    #region BitField FollowTypeBitfield ==============================================================================

    [ParamField(0x9A, ParamType.U8)]
    public byte FollowTypeBitfield
    {
        get => _followTypeBitfield;
        set => WriteParamField(ref _followTypeBitfield, value);
    }
    private byte _followTypeBitfield;

    [ParamBitField(nameof(FollowTypeBitfield), bits: 3, bitsOffset: 0)]
    public byte FollowType
    {
        get => GetbitfieldValue(_followTypeBitfield);
        set => SetBitfieldValue(ref _followTypeBitfield, value);
    }

    [ParamBitField(nameof(FollowTypeBitfield), bits: 3, bitsOffset: 3)]
    public byte EmittePosType
    {
        get => GetbitfieldValue(_followTypeBitfield);
        set => SetBitfieldValue(ref _followTypeBitfield, value);
    }

    [ParamBitField(nameof(FollowTypeBitfield), bits: 1, bitsOffset: 6)]
    public byte IsAttackSfx
    {
        get => GetbitfieldValue(_followTypeBitfield);
        set => SetBitfieldValue(ref _followTypeBitfield, value);
    }

    [ParamBitField(nameof(FollowTypeBitfield), bits: 1, bitsOffset: 7)]
    public byte IsEndlessHit
    {
        get => GetbitfieldValue(_followTypeBitfield);
        set => SetBitfieldValue(ref _followTypeBitfield, value);
    }

    #endregion BitField FollowTypeBitfield

    #region BitField IsPenetrateMapBitfield ==============================================================================

    [ParamField(0x9B, ParamType.U8)]
    public byte IsPenetrateMapBitfield
    {
        get => _isPenetrateMapBitfield;
        set => WriteParamField(ref _isPenetrateMapBitfield, value);
    }
    private byte _isPenetrateMapBitfield;

    [ParamBitField(nameof(IsPenetrateMapBitfield), bits: 1, bitsOffset: 0)]
    public byte IsPenetrateMap
    {
        get => GetbitfieldValue(_isPenetrateMapBitfield);
        set => SetBitfieldValue(ref _isPenetrateMapBitfield, value);
    }

    [ParamBitField(nameof(IsPenetrateMapBitfield), bits: 1, bitsOffset: 1)]
    public byte IsHitBothTeam
    {
        get => GetbitfieldValue(_isPenetrateMapBitfield);
        set => SetBitfieldValue(ref _isPenetrateMapBitfield, value);
    }

    [ParamBitField(nameof(IsPenetrateMapBitfield), bits: 1, bitsOffset: 2)]
    public byte IsUseSharedHitList
    {
        get => GetbitfieldValue(_isPenetrateMapBitfield);
        set => SetBitfieldValue(ref _isPenetrateMapBitfield, value);
    }

    [ParamBitField(nameof(IsPenetrateMapBitfield), bits: 1, bitsOffset: 3)]
    public byte IsUseMultiDmyPolyIfPlace
    {
        get => GetbitfieldValue(_isPenetrateMapBitfield);
        set => SetBitfieldValue(ref _isPenetrateMapBitfield, value);
    }

    [ParamBitField(nameof(IsPenetrateMapBitfield), bits: 2, bitsOffset: 4)]
    public byte AttachEffectType
    {
        get => GetbitfieldValue(_isPenetrateMapBitfield);
        set => SetBitfieldValue(ref _isPenetrateMapBitfield, value);
    }

    [ParamBitField(nameof(IsPenetrateMapBitfield), bits: 1, bitsOffset: 6)]
    public byte IsHitForceMagic
    {
        get => GetbitfieldValue(_isPenetrateMapBitfield);
        set => SetBitfieldValue(ref _isPenetrateMapBitfield, value);
    }

    [ParamBitField(nameof(IsPenetrateMapBitfield), bits: 1, bitsOffset: 7)]
    public byte IsIgnoreSfxIfHitWater
    {
        get => GetbitfieldValue(_isPenetrateMapBitfield);
        set => SetBitfieldValue(ref _isPenetrateMapBitfield, value);
    }

    #endregion BitField IsPenetrateMapBitfield

    #region BitField IsIgnoreMoveStateIfHitWaterBitfield ==============================================================================

    [ParamField(0x9C, ParamType.U8)]
    public byte IsIgnoreMoveStateIfHitWaterBitfield
    {
        get => _isIgnoreMoveStateIfHitWaterBitfield;
        set => WriteParamField(ref _isIgnoreMoveStateIfHitWaterBitfield, value);
    }
    private byte _isIgnoreMoveStateIfHitWaterBitfield;

    [ParamBitField(nameof(IsIgnoreMoveStateIfHitWaterBitfield), bits: 1, bitsOffset: 0)]
    public byte IsIgnoreMoveStateIfHitWater
    {
        get => GetbitfieldValue(_isIgnoreMoveStateIfHitWaterBitfield);
        set => SetBitfieldValue(ref _isIgnoreMoveStateIfHitWaterBitfield, value);
    }

    [ParamBitField(nameof(IsIgnoreMoveStateIfHitWaterBitfield), bits: 1, bitsOffset: 1)]
    public byte IsHitDarkForceMagic
    {
        get => GetbitfieldValue(_isIgnoreMoveStateIfHitWaterBitfield);
        set => SetBitfieldValue(ref _isIgnoreMoveStateIfHitWaterBitfield, value);
    }

    #endregion BitField IsIgnoreMoveStateIfHitWaterBitfield

    [ParamField(0x9D, ParamType.Dummy8, 3)]
    public byte[] Pad
    {
        get => _pad;
        set => WriteParamField(ref _pad, value);
    }
    private byte[] _pad = null!;

}
