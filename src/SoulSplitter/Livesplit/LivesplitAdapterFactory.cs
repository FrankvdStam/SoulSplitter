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
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LiveSplit.Model;
using LiveSplit.UI.Components;
using SoulSplitter.Livesplit;
using SoulSplitter.Utils;


[assembly: InternalsVisibleTo("SoulSplitter.Tests")]
[assembly: ComponentFactory(typeof(LivesplitAdapterFactory))]

namespace SoulSplitter.Livesplit;

public class LivesplitAdapterFactory : IComponentFactory
{
    public string ComponentName => LivesplitAdapter.Name;

    public string Description => "Souls games plugin for IGT/RTA with load removal";

    public ComponentCategory Category => ComponentCategory.Control;

    public string UpdateName => LivesplitAdapter.Name;

    public string XMLURL => $"{UpdateURL}/Components/Updates.xml";

    public string UpdateURL => "https://raw.githubusercontent.com/FrankvdStam/SoulSplitter/main/";

    public Version Version => VersionHelper.Version;

    public IComponent Create(LiveSplitState state)
    {
        //This is high quality code to detect layout/splitter mode. There is absolutely nothing wrong with this code.
        var stackTrace = new StackTrace();
        var caller = stackTrace.GetFrame(1).GetMethod().Name;
        var componentMode = caller == "AddComponent" ? ComponentMode.Layout : ComponentMode.AutoSplitter;
        return new LivesplitAdapter(state, componentMode);
    }
}
