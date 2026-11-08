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

using SoulSplitter.Plugin.Ui.ViewModels;
using SoulSplitter.Plugin.Ui.ViewModels.MainViewModel;
using SoulSplitter.Plugin.Utils;
using SoulSplitter.SoulMemory.Enums;
using SoulSplitter.SoulMemory.Games.DarkSouls1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xaml;
using System.Xml;
using System.Xml.Serialization;

namespace SoulSplitter.Plugin.Serialization;

[XmlType(TypeName = "SoulSplitterSettings")]
public class SerializedModel
{
    public SerializedModel(MainViewModel vm) 
    {
        Version = vm.Version;
        Language = vm.Language;
        DropModType = vm.DropModType;
        StartAutomatically = vm.StartAutomatically;
        OverwriteIgtOnStart = vm.OverwriteIgtOnStart;
        FlagTrackerViewModel = vm.FlagTrackerViewModel;
        Splits = vm.Splits.Select(i => new SplitModel(i)).ToList();
    }

    public SerializedModel(){ }

    public void FillMainViewModel(MainViewModel mainViewModel)
    {
        mainViewModel.Language = Language;
        mainViewModel.DropModType = DropModType;
        mainViewModel.StartAutomatically = StartAutomatically;
        mainViewModel.OverwriteIgtOnStart = OverwriteIgtOnStart;
        mainViewModel.FlagTrackerViewModel = FlagTrackerViewModel;
        mainViewModel.Splits.Clear();
        mainViewModel.Splits.AddRange(Splits.Select(i => i.CreateSplitsViewModel()));
    }

    public string Version { get; set; } = null!;
    public Language Language { get; set; } = Language.English;
    public DropModType DropModType { get; set; } = DropModType.None;
    public bool StartAutomatically { get; set; } = true;
    public bool OverwriteIgtOnStart { get; set; } = false;
    public FlagTrackerViewModel FlagTrackerViewModel { get; set; } = null!;
    public List<SplitModel> Splits { get; set; } = new List<SplitModel>();

    public static string Serialize(SerializedModel model)
    {
        using var stringWriter = new StringWriter();
        using var writer = XmlWriter.Create(
            stringWriter,
            new XmlWriterSettings
            {
                Indent = true,
                OmitXmlDeclaration = true
            }
        );

        XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
        ns.Add("DarkSouls1", "SoulSplitter.SoulMemory.Games.DarkSouls1");
        ns.Add("DarkSouls2", "SoulSplitter.SoulMemory.Games.DarkSouls2");
        ns.Add("DarkSouls3", "SoulSplitter.SoulMemory.Games.DarkSouls3");
        ns.Add("Sekiro"    , "SoulSplitter.SoulMemory.Games.Sekiro");
        ns.Add("EldenRing" , "SoulMemory.Games.EldenRing");
        ns.Add("Nightreign", "SoulMemory.Games.Nightreign");

        var serializer = new XmlSerializer(typeof(SerializedModel));
        serializer.Serialize(writer, model, ns);
        return stringWriter.ToString();
    }

    public static SerializedModel Deserialize(string xml)
    {
        using var reader = new StringReader(xml);
        var serializer = new XmlSerializer(typeof(SerializedModel));
        return (SerializedModel)serializer.Deserialize(reader);
    }
}
