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

using System.Collections;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace SoulSplitter.UI.Generic;

//https://stackoverflow.com/questions/2001842/dynamic-filter-of-wpf-combobox-based-on-text-input/41986141#41986141
public class FilteredComboBox : ComboBox
{
    private string _oldFilter = string.Empty;

    private string _currentFilter = string.Empty;

    protected TextBox EditableTextBox => (GetTemplateChild("PART_EditableTextBox") as TextBox)!;
    
    protected override void OnItemsSourceChanged(IEnumerable oldValue, IEnumerable newValue)
    {
        var newView = CollectionViewSource.GetDefaultView(newValue);
        newView.Filter += FilterItem;
    
        var oldView = CollectionViewSource.GetDefaultView(oldValue);
        oldView.Filter -= FilterItem;
    

        base.OnItemsSourceChanged(oldValue, newValue);
    }

    protected override void OnSelectionChanged(SelectionChangedEventArgs e)
    {
        if (SelectedIndex != -1)
        {
            Text = string.Empty;
            ClearFilter();
        }
        base.OnSelectionChanged(e);
    }

    protected override void OnPreviewKeyDown(KeyEventArgs e)
    {
        switch (e.Key)
        {
            case Key.Tab:
            case Key.Enter:
                IsDropDownOpen = false;
                break;
            case Key.Escape:
                IsDropDownOpen = false;
                SelectedIndex = -1;
                Text = _currentFilter;
                break;
            default:
                if (e.Key == Key.Down) IsDropDownOpen = true;

                base.OnPreviewKeyDown(e);
                break;
        }

        // Cache text
        _oldFilter = Text;
    }

    protected override void OnKeyUp(KeyEventArgs e)
    {
        switch (e.Key)
        {
            case Key.Up:
            case Key.Down:
                break;
            case Key.Tab:
            case Key.Enter:

                ClearFilter();
                break;
            default:
                var typedText = Text;
                if (Text != _oldFilter)
                {
                    RefreshFilter();
                    IsDropDownOpen = true;

                    EditableTextBox.SelectionStart = int.MaxValue;
                }

                base.OnKeyUp(e);
                _currentFilter = typedText;
                Text = typedText;
                EditableTextBox.SelectionStart = int.MaxValue;

                if (typedText == string.Empty)
                {
                    SelectedValue = null;
                    SelectedIndex = -1;
                }
                break;
        }
    }

    protected override void OnPreviewLostKeyboardFocus(KeyboardFocusChangedEventArgs e)
    {
        ClearFilter();
        var temp = SelectedIndex;
        SelectedIndex = -1;
        Text = string.Empty;
        SelectedIndex = temp;
        base.OnPreviewLostKeyboardFocus(e);
    }

    private void RefreshFilter()
    {
        if (ItemsSource == null) return;

        var view = CollectionViewSource.GetDefaultView(ItemsSource);
        view.Refresh();
    }

    private void ClearFilter()
    {
        _currentFilter = string.Empty;
        RefreshFilter();
    }

    private bool FilterItem(object value)
    {
        if (Text.Length == 0) return true;

        var words = Text.ToLower().Split(' ');
        var lower = value.ToString().ToLower();
        return words.All(lower.Contains);
    }
}