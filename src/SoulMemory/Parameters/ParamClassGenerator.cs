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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace SoulMemory.Parameters
{
    public static class ParamClassGenerator
    {
        public static string GenerateFromXml(string xml, string className, string classHeader)
        {
            var fields = ParseFromXml(xml);
            return GenerateCodeFromParsedFields(fields, className, classHeader);
        }


        #region Code generating ==============================================================================================================================================================================================

        private static string GenerateCodeFromParsedFields(List<BaseField> fields, string className, string classHeader)
        {
            var sb = new StringBuilder();
            sb.AppendLine(classHeader);
            sb.AppendLine($"    public class {className} : BaseParam");
            sb.AppendLine($"    {{");
            sb.AppendLine($"        public {className}(Pointer basePointer, ByteArrayMemory memory, long offset, ParamTableEntry paramTableEntry) : base(basePointer, memory, offset, paramTableEntry){{}}");
            sb.AppendLine();
            
            foreach (var baseField in fields)
            {
                if (baseField is Field field)
                {
                    if (field.ArraySize == null)
                    {
                        AppendField(field, sb);
                    }
                    else
                    {
                        AppendArrayField(field, sb);
                    }
                }
                else if (baseField is Bitfield bitfield)
                {
                    AppendBitfield(bitfield, sb);
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }

            sb.AppendLine($"    }}");
            sb.AppendLine($"}}");

            return sb.ToString();
        }


        private static void AppendField(Field field, StringBuilder stringBuilder)
        {
            var privateName = "_" + char.ToUpper(field.Name[0]) + field.Name.Substring(1);

            stringBuilder.AppendLine($"        [ParamField(0x{field.Offset:X}, ParamType.{field.ParamType})]");
            stringBuilder.AppendLine($"        public {ParamData.ParamToSharpTypeString[field.ParamType]} {field.Name}");
            stringBuilder.AppendLine($"        {{");
            stringBuilder.AppendLine($"            get => {privateName};");
            stringBuilder.AppendLine($"            set => WriteParamField(ref {privateName}, value);");
            stringBuilder.AppendLine($"        }}");
            stringBuilder.AppendLine($"        private {ParamData.ParamToSharpTypeString[field.ParamType]} {privateName};");
            stringBuilder.AppendLine();
        }

        private static void AppendArrayField(Field field, StringBuilder stringBuilder)
        {
            var privateName = "_" + char.ToUpper(field.Name[0]) + field.Name.Substring(1);

            stringBuilder.AppendLine($"        [ParamField(0x{field.Offset:X}, ParamType.{field.ParamType}, {field.ArraySize})]");
            stringBuilder.AppendLine($"        public {ParamData.ParamToSharpTypeString[field.ParamType]}[] {field.Name}");
            stringBuilder.AppendLine($"        {{");
            stringBuilder.AppendLine($"            get => {privateName};");
            stringBuilder.AppendLine($"            set => WriteParamField(ref {privateName}, value);");
            stringBuilder.AppendLine($"        }}");
            stringBuilder.AppendLine($"        private {ParamData.ParamToSharpTypeString[field.ParamType]}[] {privateName};");
            stringBuilder.AppendLine();
        }

        private static void AppendBitfield(Bitfield bitfield, StringBuilder stringBuilder)
        {
            var bitfieldName = bitfield.Bitfields.First().name + "Bitfield";
            var bitfieldPrivateName = "_" + char.ToUpper(bitfieldName[0]) + bitfieldName.Substring(1);

            stringBuilder.AppendLine($"        #region BitField {bitfieldName} ==============================================================================");
            stringBuilder.AppendLine();

            //Append a backing field
            AppendField(new Field( bitfield.Offset, bitfieldName, bitfield.ParamType), stringBuilder);

            //Append bitfields
            var bitOffset = 0;
            foreach(var b in bitfield.Bitfields) 
            {
                stringBuilder.AppendLine($"        [ParamBitField(nameof({bitfieldName}), bits: {b.size}, bitsOffset: {bitOffset})]");
                stringBuilder.AppendLine($"        public {ParamData.ParamToSharpTypeString[bitfield.ParamType]} {b.name}");
                stringBuilder.AppendLine($"        {{");
                stringBuilder.AppendLine($"            get => GetbitfieldValue({bitfieldPrivateName});");
                stringBuilder.AppendLine($"            set => SetBitfieldValue(ref {bitfieldPrivateName}, value);");
                stringBuilder.AppendLine($"        }}");
                stringBuilder.AppendLine();

                bitOffset += b.size;
            }

            stringBuilder.AppendLine($"        #endregion BitField {bitfieldName}");
            stringBuilder.AppendLine();
        }

        #endregion

        #region Parsing ==============================================================================================================================================================================================

        private static List<BaseField> ParseFromXml(string xml)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);
            var fieldNodes = xmlDoc.GetChildNodeByName("PARAMDEF").GetChildNodeByName("Fields");

            var fieldDefinitions = fieldNodes.ChildNodes.Enumerate().Select(i => i.Attributes?[0].InnerText).ToList();
            var preParsedFields = fieldDefinitions.Select(PreParseField).ToList();
            return ParseFields(preParsedFields);
        }

        private static PreParsedField PreParseField(string fieldLine)
        {
            var split = fieldLine.Split(' ');
            var type = ParamData.ParamStrings[split[0]];
            var paramName = split[1];

            //Make sure that the param name always starts with an uppercase letter
            if (char.IsLower(paramName[0]))
            {
                paramName = char.ToUpper(paramName[0]) + paramName.Substring(1);
            }

            //Arrays
            if (fieldLine.Contains('['))
            {
                var bracketIndex = paramName.IndexOf('[');
                var nameStr = paramName.Substring(0, bracketIndex);
                var arraySizeStr = paramName.Substring(bracketIndex+1, paramName.Length-bracketIndex-2);
                var arraySize = int.Parse(arraySizeStr);
                return new PreParsedField(nameStr, type, arraySize: arraySize);
            }

            //Bitfields
            if (paramName.Contains(':'))
            {
                var colonIndex = paramName.IndexOf(':');
                var nameStr = paramName.Substring(0, colonIndex);
                var bitStr = paramName.Substring(colonIndex + 1);
                var bits = int.Parse(bitStr);
                return new PreParsedField(nameStr, type, bits: bits);
            }
            
            //Everything else
            return new PreParsedField(paramName, type);
        }

      
        private static List<BaseField> ParseFields(List<PreParsedField> preParsedFields)
        {
            var result = new List<BaseField>();
            Bitfield currentBitfield = null;
            var offset = 0;

            for(int i = 0; i < preParsedFields.Count; i++)
            {
                //Grab current and next field if available
                var currentField = preParsedFields[i];
                PreParsedField? nextField = null;
                if (i + 1 < preParsedFields.Count)
                {
                    nextField = preParsedFields[i + 1];
                }

                //Detect start of bitfield
                if (currentBitfield == null && currentField.Bits != null)
                {
                    currentBitfield = new Bitfield(offset, currentField.ParamType);
                    offset += ParamData.ParamByteSize[currentField.ParamType];
                    currentBitfield.Bitfields.Add((currentField.Name, currentField.Bits.Value));
                    continue;
                }

                //detect ongoing bitfield
                if (currentBitfield != null && currentField.Bits != null)
                {
                    currentBitfield.Bitfields.Add((currentField.Name, currentField.Bits.Value));

                    //Check if this is the last bitfield in this sequence
                    if (nextField?.Bits == null)
                    {
                        result.Add(currentBitfield);
                        currentBitfield = null;
                        continue;
                    }

                    //Check if bitfield is out of storage, and next bitfield should start
                    if (currentBitfield.Bitfields.Sum(b => b.size) >= (ParamData.ParamByteSize[currentBitfield.ParamType] * 8))
                    {
                        result.Add(currentBitfield);
                        currentBitfield = null; 
                        continue;
                    }

                    continue;
                }

                //Otherwise it's a regular field, can just pass it along
                result.Add(new Field(offset, currentField.Name, currentField.ParamType, currentField.ArraySize));
                if(currentField.ArraySize != null)
                {
                    offset += (ParamData.ParamByteSize[currentField.ParamType] * currentField.ArraySize.Value);
                }
                else
                {
                    offset += ParamData.ParamByteSize[currentField.ParamType];
                }

            }

            return result; 
        }


        private struct PreParsedField
        {
            public PreParsedField(string name, ParamType paramType, int? bits = null, int? arraySize = null)
            {
                Name = name;
                ParamType = paramType;
                Bits = bits;
                ArraySize = arraySize;
            }

            public ParamType ParamType;
            public string Name;
            public int? Bits;
            public int? ArraySize;

            public override string ToString()
            {
                return $"{Name} {ParamType}";
            }
        }
        
        private class BaseField
        {
            public ParamType ParamType;
            public long Offset;
        }

        private class Field : BaseField
        {
            public Field(long offset, string name, ParamType paramType, int? arraySize = null)
            {
                Offset = offset;
                Name = name;
                ParamType = paramType;
                ArraySize = arraySize;
            }

            public string Name;
            public int? ArraySize;
        }

        private class Bitfield : BaseField
        {
            public Bitfield(long offset, ParamType paramType)
            {
                Offset = offset;
                ParamType = paramType;
            }

            public List<(string name, int size)> Bitfields = new List<(string name, int size)>();
        }
        
        #endregion
    }
}
