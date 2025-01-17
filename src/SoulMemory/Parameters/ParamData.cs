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

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SoulMemory.Parameters;

public static class ParamData
{
    public static readonly ReadOnlyDictionary<ParamType, int> ParamByteSize = new ReadOnlyDictionary<ParamType, int>(new Dictionary<ParamType, int>()
    {
        { ParamType.Dummy8, 1 },
        { ParamType.U8,     1 },
        { ParamType.I8,     1 },
        { ParamType.U16,    2 },
        { ParamType.I16,    2 },
        { ParamType.U32,    4 },
        { ParamType.I32,    4 },
        { ParamType.F32,    4 },
    });

    public static readonly ReadOnlyDictionary<ParamType, string> ParamToSharpTypeString = new ReadOnlyDictionary<ParamType, string>(new Dictionary<ParamType, string>()
    {
        { ParamType.Dummy8, "byte"   },
        { ParamType.U8,     "byte"   },
        { ParamType.I8,     "sbyte"  },
        { ParamType.U16,    "ushort" },
        { ParamType.I16,    "short"  },
        { ParamType.U32,    "uint"   },
        { ParamType.I32,    "int"    },
        { ParamType.F32,    "float"  },
    });

    public static readonly ReadOnlyDictionary<string, ParamType> ParamStrings = new ReadOnlyDictionary<string, ParamType>(new Dictionary<string, ParamType>()
    {
        { "dummy8", ParamType.Dummy8 },
        { "u8",     ParamType.U8     },
        { "s8",     ParamType.I8     },
        { "u16",    ParamType.U16    },
        { "s16",    ParamType.I16    },
        { "u32",    ParamType.U32    },
        { "s32",    ParamType.I32    },
        { "f32",    ParamType.F32    },
    });
}
