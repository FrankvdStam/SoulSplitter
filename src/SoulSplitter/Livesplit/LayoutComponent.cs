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

using System.Drawing;
using SoulSplitter.Abstractions;
using SoulSplitter.Ui.ViewModels.MainViewModel;

namespace SoulSplitter.Livesplit;

public class LayoutComponent : ISoulSplitterLayoutComponent
{
    private readonly MainViewModel _mainViewModel;

    public LayoutComponent(MainViewModel mainViewModel)
    {
        _mainViewModel = mainViewModel;
    }

    public float Width { get; set; }
    public float Height { get; set; }

    public void Update()
    {
    }

    public void Draw(Graphics g, float? width, float? height, Region clipRegion)
    {
        string drawString = _mainViewModel.Flag.ToString();
        var drawFont = new Font("Arial", 16);
        var drawBrush = new SolidBrush(System.Drawing.Color.Red);
        var drawFormat = new StringFormat();
        g.DrawString(drawString, drawFont, drawBrush, 0, 0, drawFormat);
        var size = g.MeasureString(drawString, drawFont, new SizeF(0, 0), drawFormat);
        Width = size.Width;
        Height = size.Height;
    }
}

