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
using SoulSplitter.UI.Generic;
using SoulSplitter.UI.Sekiro;

namespace SoulSplitter
{
    internal static class XmlExtensions
    {
        public static XmlNode GetChildNodeByName(this XmlNode node, string childName)
        {
            var lower = childName.ToLower();
            foreach (XmlNode child in node.ChildNodes)
            {
                if (child.LocalName.ToLower() == lower)
                {
                    return child;
                }
            }
            throw new Exception($"{childName} not found");
        }
    }

    internal static class Migrations
    {
        public static void Migrate(XmlNode settings)
        {
            var mainViewModel = settings.GetChildNodeByName("MainViewModel");
            var version = new Version(mainViewModel.GetChildNodeByName("Version").InnerText);
            var sekiroViewModel = mainViewModel.GetChildNodeByName("SekiroViewModel");

            if (version <= Version.Parse("1.1.0"))
            {
                MigrateSekiro1_1_0(settings);
            }
        }


        private static void MigrateSekiro1_1_0(XmlNode settings)
        {
            var mainViewModel = settings.GetChildNodeByName("MainViewModel");
            var sekiroViewModel = mainViewModel.GetChildNodeByName("SekiroViewModel");
            var newSekiroViewModel = new SekiroViewModel();

            if (bool.TryParse(sekiroViewModel.GetChildNodeByName("StartAutomatically").InnerText, out bool startAutomatically))
            {
                newSekiroViewModel.StartAutomatically = startAutomatically;
            }

            if (bool.TryParse(sekiroViewModel.GetChildNodeByName("OverwriteIgtOnStart").InnerText, out bool overwriteIgtOnStart))
            {
                newSekiroViewModel.OverwriteIgtOnStart = overwriteIgtOnStart;
            }

            var sekiroSplits = sekiroViewModel.GetChildNodeByName("Splits");
            foreach (XmlNode timingNode in sekiroSplits.ChildNodes)
            {
                foreach (XmlNode typeNode in timingNode.GetChildNodeByName("Children"))
                {
                    //Get original timing type
                    var timingType = UI.Generic.TimingType.Immediate;
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
                                if (SoulMemory.Sekiro.Boss.TryParse(split.InnerText, out SoulMemory.Sekiro.Boss b))
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
                                if (SoulMemory.Sekiro.Idol.TryParse(split.InnerText, out SoulMemory.Sekiro.Idol i))
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
                                if (uint.TryParse(split.InnerText, out uint u))
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
    }
}
