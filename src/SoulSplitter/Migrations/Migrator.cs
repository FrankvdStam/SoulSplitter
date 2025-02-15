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
using System.Globalization;
using System.Xml;
using SoulMemory;
using SoulSplitter.UI.DarkSouls3;
using SoulSplitter.UI.Generic;
using SoulSplitter.UI.Sekiro;

namespace SoulSplitter.Migrations;

internal static class Migrator
{
    public static void Migrate(XmlNode settings)
    {
        var version = new Version(settings.GetChildNodeByName("MainViewModel").GetChildNodeByName("Version").InnerText);

        if (version <= Version.Parse("1.1.0"))
        {
            MigrateSekiro_1_1_0(settings);
        }

        if(version <= Version.Parse("1.1.9"))
        {
            MigrateDs3_1_1_9(settings);
        }
    }

    #region MigrateDs3_1_1_9 ============================================================================================================================================================
    private static void MigrateDs3_1_1_9(XmlNode settings)
    {
        var mainViewModel = settings.GetChildNodeByName("MainViewModel");
        var darkSouls3ViewModel = mainViewModel.GetChildNodeByName("DarkSouls3ViewModel");
        var newDarkSouls3ViewModel = new DarkSouls3ViewModel();

        if (bool.TryParse(darkSouls3ViewModel.GetChildNodeByName("StartAutomatically").InnerText, out var startAutomatically))
        {
            newDarkSouls3ViewModel.StartAutomatically = startAutomatically;
        }

        var splits = darkSouls3ViewModel.GetChildNodeByName("Splits");
        foreach (XmlNode timingNode in splits.ChildNodes)
        {
            foreach (XmlNode typeNode in timingNode.GetChildNodeByName("Children"))
            {
                //Get original timing type
                var timingType = TimingType.Immediate;
                var timingTypeText = timingNode.GetChildNodeByName("TimingType").InnerText;
                if (timingTypeText != "Immediate")
                {
                    timingType = TimingType.OnLoading;
                }

                var type = typeNode.GetChildNodeByName("SplitType");

                switch (type.InnerText)
                {
                    case "Boss":
                        foreach (XmlNode boss in typeNode.GetChildNodeByName("Children"))
                        {
                            var split = boss.GetChildNodeByName("Split");
                            if (Enum.TryParse(split.InnerText, out SoulMemory.DarkSouls3.Boss b))
                            {
                                newDarkSouls3ViewModel.NewSplitTimingType = timingType;
                                newDarkSouls3ViewModel.NewSplitType = SplitType.Boss;
                                newDarkSouls3ViewModel.NewSplitValue = b;
                                newDarkSouls3ViewModel.AddSplitCommand.Execute(null);
                            }
                        }
                        break;

                    case "Bonfire":
                        foreach (XmlNode bonfire in typeNode.GetChildNodeByName("Children"))
                        {
                            var split = bonfire.GetChildNodeByName("Split");
                            if (Enum.TryParse(split.InnerText, out SoulMemory.DarkSouls3.Bonfire b))
                            {
                                newDarkSouls3ViewModel.NewSplitTimingType = timingType;
                                newDarkSouls3ViewModel.NewSplitType = SplitType.Bonfire;
                                newDarkSouls3ViewModel.NewSplitValue = b;
                                newDarkSouls3ViewModel.AddSplitCommand.Execute(null);
                            }
                        }
                        break;

                    case "ItemPickup":
                        foreach (XmlNode itemPickup in typeNode.GetChildNodeByName("Children"))
                        {
                            var split = itemPickup.GetChildNodeByName("Split");
                            if (Enum.TryParse(split.InnerText, out SoulMemory.DarkSouls3.ItemPickup i))
                            {
                                newDarkSouls3ViewModel.NewSplitTimingType = timingType;
                                newDarkSouls3ViewModel.NewSplitType = SplitType.ItemPickup;
                                newDarkSouls3ViewModel.NewSplitValue = i;
                                newDarkSouls3ViewModel.AddSplitCommand.Execute(null);
                            }
                        }
                        break;

                    case "Attribute":
                        foreach (XmlNode attribute in typeNode.GetChildNodeByName("Children"))
                        {
                            var split = attribute.GetChildNodeByName("Split");
                            var attributeType = split.GetChildNodeByName("AttributeType");
                            var attributeLevel = split.GetChildNodeByName("Level");

                            if (
                                Enum.TryParse(attributeType.InnerText, out SoulMemory.DarkSouls3.Attribute attributeTypeParsed) &&
                                int.TryParse(attributeLevel.InnerText, out var attributeLevelParsed)
                                )
                            {
                                newDarkSouls3ViewModel.NewSplitTimingType = timingType;
                                newDarkSouls3ViewModel.NewSplitType = SplitType.Attribute;
                                newDarkSouls3ViewModel.NewSplitValue = new Splits.DarkSouls3.Attribute { AttributeType = attributeTypeParsed, Level = attributeLevelParsed };
                                newDarkSouls3ViewModel.AddSplitCommand.Execute(null);
                            }
                        }
                        break;

                    case "Flag":
                        foreach (XmlNode flag in typeNode.GetChildNodeByName("Children"))
                        {
                            var split = flag.GetChildNodeByName("Split");
                            if (uint.TryParse(split.InnerText, out var u))
                            {
                                newDarkSouls3ViewModel.NewSplitTimingType = timingType;
                                newDarkSouls3ViewModel.NewSplitType = SplitType.Flag;
                                newDarkSouls3ViewModel.FlagDescription = new FlagDescription() { Description = "", Flag = u };
                                newDarkSouls3ViewModel.AddSplitCommand.Execute(null);
                            }
                        }
                        break;
                }
            }
        }

        var xml = newDarkSouls3ViewModel.SerializeXml();
        var doc = new XmlDocument();
        doc.LoadXml(xml);
        var newText = doc.GetChildNodeByName("DarkSouls3ViewModel").InnerXml;
        darkSouls3ViewModel.InnerXml = newText;
    }
    #endregion

    #region MigrateSekiro_1_1_0 ============================================================================================================================================================
    private static void MigrateSekiro_1_1_0(XmlNode settings)
    {
        var mainViewModel = settings.GetChildNodeByName("MainViewModel");
        var sekiroViewModel = mainViewModel.GetChildNodeByName("SekiroViewModel");
        var newSekiroViewModel = new SekiroViewModel();

        if (bool.TryParse(sekiroViewModel.GetChildNodeByName("StartAutomatically").InnerText, out var startAutomatically))
        {
            newSekiroViewModel.StartAutomatically = startAutomatically;
        }

        if (bool.TryParse(sekiroViewModel.GetChildNodeByName("OverwriteIgtOnStart").InnerText, out var overwriteIgtOnStart))
        {
            newSekiroViewModel.OverwriteIgtOnStart = overwriteIgtOnStart;
        }

        var sekiroSplits = sekiroViewModel.GetChildNodeByName("Splits");
        foreach (XmlNode timingNode in sekiroSplits.ChildNodes)
        {
            foreach (XmlNode typeNode in timingNode.GetChildNodeByName("Children"))
            {
                //Get original timing type
                var timingType = TimingType.Immediate;
                var timingTypeText = timingNode.GetChildNodeByName("TimingType").InnerText;
                if (timingTypeText != "Immediate")
                {
                    timingType = TimingType.OnLoading;
                }

                //Get original type
                var type = typeNode.GetChildNodeByName("SplitType");

                switch (type.InnerText)
                {
                    case "Position":

                        foreach (XmlNode position in typeNode.GetChildNodeByName("Children"))
                        {
                            var split = position.GetChildNodeByName("Split");

                            var x = float.Parse(split.GetChildNodeByName("X").InnerText, CultureInfo.CurrentCulture);
                            var y = float.Parse(split.GetChildNodeByName("Y").InnerText, CultureInfo.CurrentCulture);
                            var z = float.Parse(split.GetChildNodeByName("Z").InnerText, CultureInfo.CurrentCulture);

                            newSekiroViewModel.NewSplitTimingType = timingType;
                            newSekiroViewModel.NewSplitType = SplitType.Position;
                            newSekiroViewModel.Position = new VectorSize() { Position = new Vector3f(x, y, z), Size = 5 };
                            newSekiroViewModel.AddSplitCommand.Execute(null);
                        }

                        break;

                    case "Boss":
                        foreach (XmlNode boss in typeNode.GetChildNodeByName("Children"))
                        {
                            var split = boss.GetChildNodeByName("Split");
                            if (Enum.TryParse(split.InnerText, out SoulMemory.Sekiro.Boss b))
                            {
                                newSekiroViewModel.NewSplitTimingType = timingType;
                                newSekiroViewModel.NewSplitType = SplitType.Boss;
                                newSekiroViewModel.NewSplitValue = b;
                                newSekiroViewModel.AddSplitCommand.Execute(null);
                            }
                        }
                        break;

                    case "Idol":
                        foreach (XmlNode idol in typeNode.GetChildNodeByName("Children"))
                        {
                            var split = idol.GetChildNodeByName("Split");
                            if (Enum.TryParse(split.InnerText, out SoulMemory.Sekiro.Idol i))
                            {
                                newSekiroViewModel.NewSplitTimingType = timingType;
                                newSekiroViewModel.NewSplitType = SplitType.Bonfire;
                                newSekiroViewModel.NewSplitValue = i;
                                newSekiroViewModel.AddSplitCommand.Execute(null);
                            }
                        }
                        break;

                    case "Flag":
                        foreach (XmlNode flag in typeNode.GetChildNodeByName("Children"))
                        {
                            var split = flag.GetChildNodeByName("Split");
                            if (uint.TryParse(split.InnerText, out var u))
                            {
                                newSekiroViewModel.NewSplitTimingType = timingType;
                                newSekiroViewModel.NewSplitType = SplitType.Flag;
                                newSekiroViewModel.FlagDescription = new FlagDescription() { Description = "", Flag = u };
                                newSekiroViewModel.AddSplitCommand.Execute(null);
                            }

                        }
                        break;
                }
            }
        }

        var xml = newSekiroViewModel.SerializeXml();
        var doc = new XmlDocument();
        doc.LoadXml(xml);
        var newText = doc.GetChildNodeByName("SekiroViewModel").InnerXml;
        sekiroViewModel.InnerXml = newText;
    }

    #endregion
}
