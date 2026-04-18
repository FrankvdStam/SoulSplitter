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

using SoulSplitter.Plugin.Ui.ViewModels.MainViewModel;
using SoulSplitter.SoulMemory.Enums;
using SoulSplitter.SoulMemory.Games.DarkSouls1;
using System.Collections.Generic;
using System.Linq;
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
        Splits = vm.Splits.Select(i => new SplitModel(i)).ToList();
    }

    public SerializedModel(){ }

    public string Version { get; set; } = null!;
    public Language Language { get; set; } = Language.English;
    public DropModType DropModType { get; set; } = DropModType.None;
    public bool StartAutomatically { get; set; } = true;
    public bool OverwriteIgtOnStart { get; set; } = false;
    public List<SplitModel> Splits { get; set; } = new List<SplitModel>();
}
