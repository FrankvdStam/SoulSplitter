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

using SoulMemory;
using System;
using System.Linq;
using System.Text;

namespace SoulSplitterUIv2.Utils;

public class ResourceUtils
{
    private static string GenerateResourceDictionaryForEventFlag(Type eventFlagType)
    {
        var values = Enum.GetValues(eventFlagType).Cast<Enum>().ToList();

        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("<ResourceDictionary xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"");
        stringBuilder.AppendLine("                    xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\"");
        stringBuilder.AppendLine("                    xmlns:r=\"clr-namespace:SoulSplitterUIv2.Resources;assembly=\"");
        stringBuilder.AppendLine($"                    xmlns:soulmemory=\"clr-namespace:{eventFlagType.Namespace};assembly=SoulMemory\">");

        foreach (var value in values)
        {
            var attrib = value.GetAttribute<AnnotationAttribute>();

            var name = attrib.Name;
            //var split = temp.Split(new[]{ " - " }, StringSplitOptions.None);
            //
            //var name = split[0];
            //
            //

            stringBuilder.AppendLine();
            stringBuilder.AppendLine($"    <r:EventFlag x:Key=\"{{x:Static soulmemory:{eventFlagType.Name}.{value.ToString()}}}\">");
            stringBuilder.AppendLine($"        <r:EventFlag.Name>{name}</r:EventFlag.Name>");
            //stringBuilder.AppendLine($"        <r:EventFlag.Description>{attrib.Description}</r:EventFlag.Description>");
            //stringBuilder.AppendLine($"        <r:EventFlag.Location>{location}</r:EventFlag.Location>");
            //if (split.Length == 2)
            //{
            //    stringBuilder.AppendLine($"        <r:EventFlag.Location>{split[1]}</r:EventFlag.Location>");
            //}
            stringBuilder.AppendLine("    </r:EventFlag>");
        }

        stringBuilder.AppendLine("</ResourceDictionary>");
        return stringBuilder.ToString();
    }
}

