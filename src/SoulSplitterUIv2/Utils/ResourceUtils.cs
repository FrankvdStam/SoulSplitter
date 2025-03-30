using SoulMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

