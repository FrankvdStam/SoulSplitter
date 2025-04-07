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
using System.Collections;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows;

namespace SoulSplitter.Ui
{
    public class DataGridDragAndDropHelper
    {
        #region Datagrid property

        public static readonly DependencyProperty EnableRowReorderingProperty =
            DependencyProperty.RegisterAttached("EnableRowReordering", typeof(bool), typeof(DataGridDragAndDropHelper), new PropertyMetadata(false, EnableRowReorderingChanged));

        public static bool GetEnableRowReordering(DataGrid obj)
        {
            return (bool)obj.GetValue(EnableRowReorderingProperty);
        }

        public static void SetEnableRowReordering(DataGrid obj, bool value)
        {
            obj.SetValue(EnableRowReorderingProperty, value);
        }

        private static void EnableRowReorderingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGrid grid && e.NewValue is bool enableRowReordering)
            {
                if (enableRowReordering)
                {
                    grid.PreviewMouseLeftButtonDown += OnPreviewMouseLeftButtonDown;
                    grid.PreviewMouseLeftButtonUp += OnPreviewMouseLeftButtonUp;
                    grid.PreviewMouseMove += OnPreviewMouseMove;
                }
                else
                {
                    grid.PreviewMouseLeftButtonDown -= OnPreviewMouseLeftButtonDown;
                    grid.PreviewMouseLeftButtonUp -= OnPreviewMouseLeftButtonUp;
                    grid.PreviewMouseMove -= OnPreviewMouseMove;
                }
            }
        }

        #endregion

        #region dragged item property

        private static readonly DependencyProperty DraggedItemProperty =
            DependencyProperty.RegisterAttached("DraggedItem", typeof(object), typeof(DataGridDragAndDropHelper), new PropertyMetadata(null));


        private static object GetDraggedItem(DependencyObject obj)
        {
            return (object)obj.GetValue(DraggedItemProperty);
        }

        private static void SetDraggedItem(DependencyObject obj, object? value)
        {
            obj.SetValue(DraggedItemProperty, value);
        }

        #endregion

        #region Mouse events

        private static void OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var point = e.GetPosition((DataGrid)sender);
            var row = FindUiElementFromPoint<DataGridRow>((UIElement)sender, point);
            if (row != null)
            {
                SetDraggedItem((DataGrid)sender, row.Item);
            }
        }

        private static void OnPreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var draggedItem = GetDraggedItem((DependencyObject)sender);
            if (draggedItem != null && sender is DataGrid dataGrid)
            {
                MoveItems(dataGrid, dataGrid.SelectedItem);
                dataGrid.SelectedItem = draggedItem;
                SetDraggedItem(dataGrid, null);
            }
        }

        private static void OnPreviewMouseMove(object sender, MouseEventArgs e)
        {
            var draggedItem = GetDraggedItem((DependencyObject)sender);
            if (draggedItem != null)
            {
                var row = FindUiElementFromPoint<DataGridRow>((UIElement)sender, e.GetPosition((sender as DataGrid)));
                if (row != null)
                {
                    MoveItems(sender, row.Item);
                    Mouse.SetCursor(Cursors.ScrollNS);
                }
            }
        }

        #endregion

        private static void MoveItems(object sender, object targetItem)
        {
            var draggedItem = GetDraggedItem((DependencyObject)sender);
            if (
                draggedItem != null &&
                targetItem != null && 
                !ReferenceEquals(draggedItem, targetItem) && 
                sender is DataGrid dataGrid &&
                dataGrid.ItemsSource is IList iList)
            {
                var targetIndex = iList.IndexOf(targetItem);
                iList.Remove(draggedItem);
                iList.Insert(targetIndex, draggedItem);
            }
        }

        public static T FindUiElementFromPoint<T>(UIElement reference, Point point) where T : DependencyObject
        {
            try
            {
                var element = reference.InputHitTest(point);

                if (element is T result)
                {
                    return result;
                }

                if (element is DependencyObject d)
                {
                    var parentObject = VisualTreeHelper.GetParent(d);
                    for (var i = 0; i < 100 && parentObject != null; i++)
                    {
                        if (parentObject is T target)
                        {
                            return target;
                        }

                        parentObject = VisualTreeHelper.GetParent(parentObject);
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"exception in {nameof(FindUiElementFromPoint)}: " + e.ToString());
            }
            return null!;
        }
    }
}
