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

using LiveSplit.Model;
using LiveSplit.UI;
using LiveSplit.UI.Components;
using SoulSplitter.Plugin.Ui.View;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace SoulSplitter.Plugin.Livesplit;

public class LivesplitAdapter : IComponent
{
    public readonly MainWindow MainWindow;

    public LivesplitAdapter(LiveSplitState liveSplitState)
    {
        MainWindow = new MainWindow();       
    }

    /// <summary>
    /// Called by livesplit every frame
    /// </summary>
    public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
    {
    }

    #region drawing ===================================================================================================================
    public IDictionary<string, Action> ContextMenuControls => new Dictionary<string, Action>();
    public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
    {
    }

    public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
    {
    }

    public string ComponentName => "asdf";
    public float HorizontalWidth { get; private set; } = 0;
    public float MinimumHeight { get; private set; } = 0;
    public float VerticalHeight { get; private set; } = 0;
    public float MinimumWidth { get; private set; } = 0;
    public float PaddingTop => 0;
    public float PaddingBottom => 0;
    public float PaddingLeft => 0;
    public float PaddingRight => 0;


    public void Dispose()
    {
    }
    #endregion

    #region Xml settings ==============================================================================================================
    
    /// <summary>
    /// Called when loading the settings from livesplit into the component
    /// </summary>
    public void SetSettings(System.Xml.XmlNode settings)
    {
       
    }

    /// <summary>
    /// Called when saving the component
    /// </summary>
    public System.Xml.XmlNode GetSettings(System.Xml.XmlDocument document)
    {
        return document;
    }
    
    public Control GetSettingsControl(LayoutMode mode)
    {
        var stackTrace = new StackTrace();
        var caller = stackTrace.GetFrame(1).GetMethod().Name;
        if (caller == "AddComponent")
        {
            MainWindow!.ShowDialog();
        }

        return new Button();
    }
    #endregion

}

