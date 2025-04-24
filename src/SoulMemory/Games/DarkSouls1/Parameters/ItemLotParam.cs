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

namespace SoulMemory.Games.DarkSouls1.Parameters;

[ExcludeFromCodeCoverage]
public class ItemLotParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.I32)]
    public int LotItemId01
    {
        get => _lotItemId01;
        set => WriteParamField(ref _lotItemId01, value);
    }
    private int _lotItemId01;

    [ParamField(0x4, ParamType.I32)]
    public int LotItemId02
    {
        get => _lotItemId02;
        set => WriteParamField(ref _lotItemId02, value);
    }
    private int _lotItemId02;

    [ParamField(0x8, ParamType.I32)]
    public int LotItemId03
    {
        get => _lotItemId03;
        set => WriteParamField(ref _lotItemId03, value);
    }
    private int _lotItemId03;

    [ParamField(0xC, ParamType.I32)]
    public int LotItemId04
    {
        get => _lotItemId04;
        set => WriteParamField(ref _lotItemId04, value);
    }
    private int _lotItemId04;

    [ParamField(0x10, ParamType.I32)]
    public int LotItemId05
    {
        get => _lotItemId05;
        set => WriteParamField(ref _lotItemId05, value);
    }
    private int _lotItemId05;

    [ParamField(0x14, ParamType.I32)]
    public int LotItemId06
    {
        get => _lotItemId06;
        set => WriteParamField(ref _lotItemId06, value);
    }
    private int _lotItemId06;

    [ParamField(0x18, ParamType.I32)]
    public int LotItemId07
    {
        get => _lotItemId07;
        set => WriteParamField(ref _lotItemId07, value);
    }
    private int _lotItemId07;

    [ParamField(0x1C, ParamType.I32)]
    public int LotItemId08
    {
        get => _lotItemId08;
        set => WriteParamField(ref _lotItemId08, value);
    }
    private int _lotItemId08;

    [ParamField(0x20, ParamType.I32)]
    public int LotItemCategory01
    {
        get => _lotItemCategory01;
        set => WriteParamField(ref _lotItemCategory01, value);
    }
    private int _lotItemCategory01;

    [ParamField(0x24, ParamType.I32)]
    public int LotItemCategory02
    {
        get => _lotItemCategory02;
        set => WriteParamField(ref _lotItemCategory02, value);
    }
    private int _lotItemCategory02;

    [ParamField(0x28, ParamType.I32)]
    public int LotItemCategory03
    {
        get => _lotItemCategory03;
        set => WriteParamField(ref _lotItemCategory03, value);
    }
    private int _lotItemCategory03;

    [ParamField(0x2C, ParamType.I32)]
    public int LotItemCategory04
    {
        get => _lotItemCategory04;
        set => WriteParamField(ref _lotItemCategory04, value);
    }
    private int _lotItemCategory04;

    [ParamField(0x30, ParamType.I32)]
    public int LotItemCategory05
    {
        get => _lotItemCategory05;
        set => WriteParamField(ref _lotItemCategory05, value);
    }
    private int _lotItemCategory05;

    [ParamField(0x34, ParamType.I32)]
    public int LotItemCategory06
    {
        get => _lotItemCategory06;
        set => WriteParamField(ref _lotItemCategory06, value);
    }
    private int _lotItemCategory06;

    [ParamField(0x38, ParamType.I32)]
    public int LotItemCategory07
    {
        get => _lotItemCategory07;
        set => WriteParamField(ref _lotItemCategory07, value);
    }
    private int _lotItemCategory07;

    [ParamField(0x3C, ParamType.I32)]
    public int LotItemCategory08
    {
        get => _lotItemCategory08;
        set => WriteParamField(ref _lotItemCategory08, value);
    }
    private int _lotItemCategory08;

    [ParamField(0x40, ParamType.U16)]
    public ushort LotItemBasePoint01
    {
        get => _lotItemBasePoint01;
        set => WriteParamField(ref _lotItemBasePoint01, value);
    }
    private ushort _lotItemBasePoint01;

    [ParamField(0x42, ParamType.U16)]
    public ushort LotItemBasePoint02
    {
        get => _lotItemBasePoint02;
        set => WriteParamField(ref _lotItemBasePoint02, value);
    }
    private ushort _lotItemBasePoint02;

    [ParamField(0x44, ParamType.U16)]
    public ushort LotItemBasePoint03
    {
        get => _lotItemBasePoint03;
        set => WriteParamField(ref _lotItemBasePoint03, value);
    }
    private ushort _lotItemBasePoint03;

    [ParamField(0x46, ParamType.U16)]
    public ushort LotItemBasePoint04
    {
        get => _lotItemBasePoint04;
        set => WriteParamField(ref _lotItemBasePoint04, value);
    }
    private ushort _lotItemBasePoint04;

    [ParamField(0x48, ParamType.U16)]
    public ushort LotItemBasePoint05
    {
        get => _lotItemBasePoint05;
        set => WriteParamField(ref _lotItemBasePoint05, value);
    }
    private ushort _lotItemBasePoint05;

    [ParamField(0x4A, ParamType.U16)]
    public ushort LotItemBasePoint06
    {
        get => _lotItemBasePoint06;
        set => WriteParamField(ref _lotItemBasePoint06, value);
    }
    private ushort _lotItemBasePoint06;

    [ParamField(0x4C, ParamType.U16)]
    public ushort LotItemBasePoint07
    {
        get => _lotItemBasePoint07;
        set => WriteParamField(ref _lotItemBasePoint07, value);
    }
    private ushort _lotItemBasePoint07;

    [ParamField(0x4E, ParamType.U16)]
    public ushort LotItemBasePoint08
    {
        get => _lotItemBasePoint08;
        set => WriteParamField(ref _lotItemBasePoint08, value);
    }
    private ushort _lotItemBasePoint08;

    [ParamField(0x50, ParamType.U16)]
    public ushort CumulateLotPoint01
    {
        get => _cumulateLotPoint01;
        set => WriteParamField(ref _cumulateLotPoint01, value);
    }
    private ushort _cumulateLotPoint01;

    [ParamField(0x52, ParamType.U16)]
    public ushort CumulateLotPoint02
    {
        get => _cumulateLotPoint02;
        set => WriteParamField(ref _cumulateLotPoint02, value);
    }
    private ushort _cumulateLotPoint02;

    [ParamField(0x54, ParamType.U16)]
    public ushort CumulateLotPoint03
    {
        get => _cumulateLotPoint03;
        set => WriteParamField(ref _cumulateLotPoint03, value);
    }
    private ushort _cumulateLotPoint03;

    [ParamField(0x56, ParamType.U16)]
    public ushort CumulateLotPoint04
    {
        get => _cumulateLotPoint04;
        set => WriteParamField(ref _cumulateLotPoint04, value);
    }
    private ushort _cumulateLotPoint04;

    [ParamField(0x58, ParamType.U16)]
    public ushort CumulateLotPoint05
    {
        get => _cumulateLotPoint05;
        set => WriteParamField(ref _cumulateLotPoint05, value);
    }
    private ushort _cumulateLotPoint05;

    [ParamField(0x5A, ParamType.U16)]
    public ushort CumulateLotPoint06
    {
        get => _cumulateLotPoint06;
        set => WriteParamField(ref _cumulateLotPoint06, value);
    }
    private ushort _cumulateLotPoint06;

    [ParamField(0x5C, ParamType.U16)]
    public ushort CumulateLotPoint07
    {
        get => _cumulateLotPoint07;
        set => WriteParamField(ref _cumulateLotPoint07, value);
    }
    private ushort _cumulateLotPoint07;

    [ParamField(0x5E, ParamType.U16)]
    public ushort CumulateLotPoint08
    {
        get => _cumulateLotPoint08;
        set => WriteParamField(ref _cumulateLotPoint08, value);
    }
    private ushort _cumulateLotPoint08;

    [ParamField(0x60, ParamType.I32)]
    public int GetItemFlagId01
    {
        get => _getItemFlagId01;
        set => WriteParamField(ref _getItemFlagId01, value);
    }
    private int _getItemFlagId01;

    [ParamField(0x64, ParamType.I32)]
    public int GetItemFlagId02
    {
        get => _getItemFlagId02;
        set => WriteParamField(ref _getItemFlagId02, value);
    }
    private int _getItemFlagId02;

    [ParamField(0x68, ParamType.I32)]
    public int GetItemFlagId03
    {
        get => _getItemFlagId03;
        set => WriteParamField(ref _getItemFlagId03, value);
    }
    private int _getItemFlagId03;

    [ParamField(0x6C, ParamType.I32)]
    public int GetItemFlagId04
    {
        get => _getItemFlagId04;
        set => WriteParamField(ref _getItemFlagId04, value);
    }
    private int _getItemFlagId04;

    [ParamField(0x70, ParamType.I32)]
    public int GetItemFlagId05
    {
        get => _getItemFlagId05;
        set => WriteParamField(ref _getItemFlagId05, value);
    }
    private int _getItemFlagId05;

    [ParamField(0x74, ParamType.I32)]
    public int GetItemFlagId06
    {
        get => _getItemFlagId06;
        set => WriteParamField(ref _getItemFlagId06, value);
    }
    private int _getItemFlagId06;

    [ParamField(0x78, ParamType.I32)]
    public int GetItemFlagId07
    {
        get => _getItemFlagId07;
        set => WriteParamField(ref _getItemFlagId07, value);
    }
    private int _getItemFlagId07;

    [ParamField(0x7C, ParamType.I32)]
    public int GetItemFlagId08
    {
        get => _getItemFlagId08;
        set => WriteParamField(ref _getItemFlagId08, value);
    }
    private int _getItemFlagId08;

    [ParamField(0x80, ParamType.I32)]
    public int GetItemFlagId
    {
        get => _getItemFlagId;
        set => WriteParamField(ref _getItemFlagId, value);
    }
    private int _getItemFlagId;

    [ParamField(0x84, ParamType.I32)]
    public int CumulateNumFlagId
    {
        get => _cumulateNumFlagId;
        set => WriteParamField(ref _cumulateNumFlagId, value);
    }
    private int _cumulateNumFlagId;

    [ParamField(0x88, ParamType.U8)]
    public byte CumulateNumMax
    {
        get => _cumulateNumMax;
        set => WriteParamField(ref _cumulateNumMax, value);
    }
    private byte _cumulateNumMax;

    [ParamField(0x89, ParamType.U8)]
    public byte LotItemRarity
    {
        get => _lotItemRarity;
        set => WriteParamField(ref _lotItemRarity, value);
    }
    private byte _lotItemRarity;

    [ParamField(0x8A, ParamType.U8)]
    public byte LotItemNum01
    {
        get => _lotItemNum01;
        set => WriteParamField(ref _lotItemNum01, value);
    }
    private byte _lotItemNum01;

    [ParamField(0x8B, ParamType.U8)]
    public byte LotItemNum02
    {
        get => _lotItemNum02;
        set => WriteParamField(ref _lotItemNum02, value);
    }
    private byte _lotItemNum02;

    [ParamField(0x8C, ParamType.U8)]
    public byte LotItemNum03
    {
        get => _lotItemNum03;
        set => WriteParamField(ref _lotItemNum03, value);
    }
    private byte _lotItemNum03;

    [ParamField(0x8D, ParamType.U8)]
    public byte LotItemNum04
    {
        get => _lotItemNum04;
        set => WriteParamField(ref _lotItemNum04, value);
    }
    private byte _lotItemNum04;

    [ParamField(0x8E, ParamType.U8)]
    public byte LotItemNum05
    {
        get => _lotItemNum05;
        set => WriteParamField(ref _lotItemNum05, value);
    }
    private byte _lotItemNum05;

    [ParamField(0x8F, ParamType.U8)]
    public byte LotItemNum06
    {
        get => _lotItemNum06;
        set => WriteParamField(ref _lotItemNum06, value);
    }
    private byte _lotItemNum06;

    [ParamField(0x90, ParamType.U8)]
    public byte LotItemNum07
    {
        get => _lotItemNum07;
        set => WriteParamField(ref _lotItemNum07, value);
    }
    private byte _lotItemNum07;

    [ParamField(0x91, ParamType.U8)]
    public byte LotItemNum08
    {
        get => _lotItemNum08;
        set => WriteParamField(ref _lotItemNum08, value);
    }
    private byte _lotItemNum08;

    #region BitField EnableLuck01Bitfield ==============================================================================

    [ParamField(0x92, ParamType.U16)]
    public ushort EnableLuck01Bitfield
    {
        get => _enableLuck01Bitfield;
        set => WriteParamField(ref _enableLuck01Bitfield, value);
    }
    private ushort _enableLuck01Bitfield;

    [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 0)]
    public ushort EnableLuck01
    {
        get => GetbitfieldValue(_enableLuck01Bitfield);
        set => SetBitfieldValue(ref _enableLuck01Bitfield, value);
    }

    [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 1)]
    public ushort EnableLuck02
    {
        get => GetbitfieldValue(_enableLuck01Bitfield);
        set => SetBitfieldValue(ref _enableLuck01Bitfield, value);
    }

    [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 2)]
    public ushort EnableLuck03
    {
        get => GetbitfieldValue(_enableLuck01Bitfield);
        set => SetBitfieldValue(ref _enableLuck01Bitfield, value);
    }

    [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 3)]
    public ushort EnableLuck04
    {
        get => GetbitfieldValue(_enableLuck01Bitfield);
        set => SetBitfieldValue(ref _enableLuck01Bitfield, value);
    }

    [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 4)]
    public ushort EnableLuck05
    {
        get => GetbitfieldValue(_enableLuck01Bitfield);
        set => SetBitfieldValue(ref _enableLuck01Bitfield, value);
    }

    [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 5)]
    public ushort EnableLuck06
    {
        get => GetbitfieldValue(_enableLuck01Bitfield);
        set => SetBitfieldValue(ref _enableLuck01Bitfield, value);
    }

    [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 6)]
    public ushort EnableLuck07
    {
        get => GetbitfieldValue(_enableLuck01Bitfield);
        set => SetBitfieldValue(ref _enableLuck01Bitfield, value);
    }

    [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 7)]
    public ushort EnableLuck08
    {
        get => GetbitfieldValue(_enableLuck01Bitfield);
        set => SetBitfieldValue(ref _enableLuck01Bitfield, value);
    }

    [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 8)]
    public ushort CumulateReset01
    {
        get => GetbitfieldValue(_enableLuck01Bitfield);
        set => SetBitfieldValue(ref _enableLuck01Bitfield, value);
    }

    [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 9)]
    public ushort CumulateReset02
    {
        get => GetbitfieldValue(_enableLuck01Bitfield);
        set => SetBitfieldValue(ref _enableLuck01Bitfield, value);
    }

    [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 10)]
    public ushort CumulateReset03
    {
        get => GetbitfieldValue(_enableLuck01Bitfield);
        set => SetBitfieldValue(ref _enableLuck01Bitfield, value);
    }

    [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 11)]
    public ushort CumulateReset04
    {
        get => GetbitfieldValue(_enableLuck01Bitfield);
        set => SetBitfieldValue(ref _enableLuck01Bitfield, value);
    }

    [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 12)]
    public ushort CumulateReset05
    {
        get => GetbitfieldValue(_enableLuck01Bitfield);
        set => SetBitfieldValue(ref _enableLuck01Bitfield, value);
    }

    [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 13)]
    public ushort CumulateReset06
    {
        get => GetbitfieldValue(_enableLuck01Bitfield);
        set => SetBitfieldValue(ref _enableLuck01Bitfield, value);
    }

    [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 14)]
    public ushort CumulateReset07
    {
        get => GetbitfieldValue(_enableLuck01Bitfield);
        set => SetBitfieldValue(ref _enableLuck01Bitfield, value);
    }

    [ParamBitField(nameof(EnableLuck01Bitfield), bits: 1, bitsOffset: 15)]
    public ushort CumulateReset08
    {
        get => GetbitfieldValue(_enableLuck01Bitfield);
        set => SetBitfieldValue(ref _enableLuck01Bitfield, value);
    }

    #endregion BitField EnableLuck01Bitfield

}
