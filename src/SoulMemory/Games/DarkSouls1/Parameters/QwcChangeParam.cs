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
public class QwcChangeParam(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : BaseParam(basePointer, memory, offset, paramTableEntry)
{
    [ParamField(0x0, ParamType.I16)]
    public short PcAttrB
    {
        get => _pcAttrB;
        set => WriteParamField(ref _pcAttrB, value);
    }
    private short _pcAttrB;

    [ParamField(0x2, ParamType.I16)]
    public short PcAttrW
    {
        get => _pcAttrW;
        set => WriteParamField(ref _pcAttrW, value);
    }
    private short _pcAttrW;

    [ParamField(0x4, ParamType.I16)]
    public short PcAttrL
    {
        get => _pcAttrL;
        set => WriteParamField(ref _pcAttrL, value);
    }
    private short _pcAttrL;

    [ParamField(0x6, ParamType.I16)]
    public short PcAttrR
    {
        get => _pcAttrR;
        set => WriteParamField(ref _pcAttrR, value);
    }
    private short _pcAttrR;

    [ParamField(0x8, ParamType.I16)]
    public short AreaAttrB
    {
        get => _areaAttrB;
        set => WriteParamField(ref _areaAttrB, value);
    }
    private short _areaAttrB;

    [ParamField(0xA, ParamType.I16)]
    public short AreaAttrW
    {
        get => _areaAttrW;
        set => WriteParamField(ref _areaAttrW, value);
    }
    private short _areaAttrW;

    [ParamField(0xC, ParamType.I16)]
    public short AreaAttrL
    {
        get => _areaAttrL;
        set => WriteParamField(ref _areaAttrL, value);
    }
    private short _areaAttrL;

    [ParamField(0xE, ParamType.I16)]
    public short AreaAttrR
    {
        get => _areaAttrR;
        set => WriteParamField(ref _areaAttrR, value);
    }
    private short _areaAttrR;

}
