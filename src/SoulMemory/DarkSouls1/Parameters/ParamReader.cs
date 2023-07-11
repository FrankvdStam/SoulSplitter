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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using Pointer = SoulMemory.Memory.Pointer;

namespace SoulMemory.DarkSouls1.Parameters
{
    public static class ParamReader
    {
        

        public static List<T> ReadParam<T>(Pointer paramBasePointer) where T : BaseParam
        {
            var dataOffset = paramBasePointer.ReadUInt16(0x4);
            var rowCount = paramBasePointer.ReadUInt16(0xa);

            var rowSize = typeof(T)
                .GetProperties()
                .Where(i => i.IsDefined(typeof(ParamFieldAttribute)))
                .Sum(i => ParamByteSize[i.GetCustomAttribute<ParamFieldAttribute>().ParamType]);

            var paramTableBytes = paramBasePointer.ReadBytes(12 * rowCount, 0x30);
            var parameterRawBytes = paramBasePointer.ReadBytes(rowCount * rowSize, dataOffset);

            var parameters = new List<T>();

            for (int i = 0; i < rowCount; i++)
            {
                var offset = i * 12;

                var paramTableEntry = new ParamTableEntry
                {
                    Id = BitConverter.ToInt32(paramTableBytes, offset),
                    DataOffset = BitConverter.ToUInt32(paramTableBytes, offset + 0x4),
                    NameOffset = BitConverter.ToUInt32(paramTableBytes, offset + 0x8),
                };

                var rowBasePointer = paramBasePointer.Copy();
                rowBasePointer.Offsets.Clear();
                rowBasePointer.BaseAddress = paramBasePointer.BaseAddress + dataOffset + i * rowSize;

                parameters.Add(
                    (T)Activator.CreateInstance(typeof(T), 
                        rowBasePointer, 
                        new ArraySegment<byte>(parameterRawBytes, i * rowSize, rowSize),
                        paramTableEntry)
                    );
            }

            return parameters;
        }
        

        public static string GenerateFromXml(string xml)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);
            var fields = xmlDoc.GetChildNodeByName("PARAMDEF").GetChildNodeByName("Fields");
            var offset = 0;
            var sb = new StringBuilder();
            foreach (XmlNode field in fields.ChildNodes)
            {
                var split = field.Attributes[0].InnerText.Split(' ');

                if (split[0] == "dummy8")
                {
                    var temp = split[1].Substring(split[1].IndexOf('[')+1);
                    var num = int.Parse(temp.Substring(0, temp.Length - 1));
                    offset += num;
                    continue;
                }

                var paramType = ParamStrings[split[0]];
                var name = char.ToUpper(split[1][0]) + split[1].Substring(1);
                var privateName = "_" + split[1];

                sb.AppendLine($"[ParamField(0x{offset:X}, ParamType.{split[0].Replace('s', 'i').ToUpper()})]");
                sb.AppendLine($"public {ParamToSharpTypeString[paramType]} {name}");
                sb.AppendLine($"{{");
                sb.AppendLine($"    get => {privateName};");
                sb.AppendLine($"    set => WriteParamField(ref {privateName}, value);");
                sb.AppendLine($"}}");
                sb.AppendLine($"private {ParamToSharpTypeString[paramType]} {privateName};");
                sb.AppendLine();

                offset += ParamByteSize[paramType];
            }
            
            return sb.ToString();
        }

        private static readonly Dictionary<ParamType, int> ParamByteSize = new Dictionary<ParamType, int>()
        {
            { ParamType.U8,  1 },
            { ParamType.I8,  1 },
            { ParamType.U16, 2 },
            { ParamType.I16, 2 },
            { ParamType.U32, 4 },
            { ParamType.I32, 4 },
            { ParamType.F32, 4 },
        };

        private static readonly Dictionary<ParamType, string> ParamToSharpTypeString = new Dictionary<ParamType, string>()
        {
            { ParamType.U8,  "byte"   },
            { ParamType.I8,  "sbyte"  },
            { ParamType.U16, "ushort" },
            { ParamType.I16, "short"  },
            { ParamType.U32, "uint"   },
            { ParamType.I32, "int"    },
            { ParamType.F32, "f32"    },
        };

        private static readonly Dictionary<string, ParamType> ParamStrings = new Dictionary<string, ParamType>()
        {
            { "u8", ParamType.U8   },
            { "s8", ParamType.I8   },
            { "u16", ParamType.U16 },
            { "s16", ParamType.I16 },
            { "u32", ParamType.U32 },
            { "s32", ParamType.I32 },
            { "f32", ParamType.F32 },
        };
    }
}
