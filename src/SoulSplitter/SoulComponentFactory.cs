﻿// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
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
using LiveSplit.Model;
using LiveSplit.UI.Components;
using SoulSplitter;


[assembly: ComponentFactory(typeof(SoulComponentFactory))]

namespace SoulSplitter;

public class SoulComponentFactory : IComponentFactory
{
    public string ComponentName => SoulComponent.Name;

    public string Description => "Souls games plugin for IGT/RTA with load removal";

    public ComponentCategory Category => ComponentCategory.Control;

    public string UpdateName => SoulComponent.Name;
    
    public string XMLURL => $"{UpdateURL}/Components/Updates.xml";

    public string UpdateURL => "https://raw.githubusercontent.com/FrankvdStam/SoulSplitter/main/";

    public Version Version => VersionHelper.Version;

    public IComponent Create(LiveSplitState state)
    {
        return new SoulComponent(state);
    }
}
