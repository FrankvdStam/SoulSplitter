using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;

namespace SoulSplitter.UI
{
    public class ListViewDragOrder : ListView
    {

        public ListViewDragOrder()
        {
            var style = new Style(typeof(ListViewItem));
            style.Setters.Add(new EventSetter(ListViewItem.PreviewMouseLeftButtonDownEvent, new MouseButtonEventHandler(ListViewItem_PreviewMouseLeftButtonDown)));
            style.Setters.Add(new EventSetter(ListViewItem.PreviewMouseLeftButtonUpEvent  , new MouseButtonEventHandler(ListViewItem_PreviewMouseLeftButtonUp)));
            style.Setters.Add(new EventSetter(ListViewItem.MouseMoveEvent                 , new MouseEventHandler(ListViewItem_MouseMove)));
            style.Setters.Add(new EventSetter(ListViewItem.DropEvent                      , new DragEventHandler(ListViewItem_Drop)));
            style.Setters.Add(new EventSetter(ListViewItem.DragOverEvent                  , new DragEventHandler(ListViewItem_DragOver)));
            ItemContainerStyle = style;
        }


        private ListViewItem _draggedListViewItem;
        private DateTime? _dragStartDateTime;
        private bool _dragging = false;

       

        private void ListViewItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (_draggedListViewItem == null)
            {
                if (sender is ListViewItem item)
                {
                    _dragStartDateTime = DateTime.Now;
                    _draggedListViewItem = item;
                }
            }
        }

        private void ListViewItem_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            _dragStartDateTime = null;
            _draggedListViewItem = null;
            _dragging = false;
        }

        private void ListViewItem_MouseMove(object sender, MouseEventArgs e)
        {
            //If dragging for x milliseconds
            if (!_dragging && _draggedListViewItem != null && _dragStartDateTime != null && (DateTime.Now - _dragStartDateTime.Value).Milliseconds > 200)
            {
                _dragging = true;
                DragDrop.DoDragDrop(_draggedListViewItem, _draggedListViewItem.DataContext, DragDropEffects.Move);
            }
        }

        private double _insertBorderThickness = 3;
        private ListViewItem _target;
        private int _insertIndex = 0;
        private int _removeIndex = 0;
        private void ListViewItem_DragOver(object sender, DragEventArgs e)
        {
            if (_target != null)
            {
                _target.BorderThickness = new Thickness(0, 0, 0, 0);
            }

            _target = (ListViewItem)sender;
            var mouseY = e.GetPosition(_target).Y;
            var height = _target.ActualHeight;

            CalculateDragPlacement(_draggedListViewItem.DataContext, _target.DataContext, height, mouseY, out bool top, out _insertIndex, out _removeIndex);

            //This creates a visual line to indicate where the dragged item will appear when dropping it
            _target.BorderThickness = top ? new Thickness(0, _insertBorderThickness, 0, 0) : new Thickness(0, 0, 0, _insertBorderThickness);
            
            SelectedItem = _target.DataContext;
        }

        private void ListViewItem_Drop(object sender, DragEventArgs e)
        {
            var droppedItem = _draggedListViewItem.DataContext;
            
            //Assume itemsSource is bound to an ObservableCollection
            //Prepare for some evil reflection hackery

            var collection = Convert.ChangeType(ItemsSource, ItemsSource.GetType());

            var insertMethod = collection.GetType().GetMethod("Insert");
            insertMethod?.Invoke(collection, new object[]{ _insertIndex, droppedItem });

            var removeAtMethod = collection.GetType().GetMethod("RemoveAt");
            removeAtMethod?.Invoke(collection, new object[] { _removeIndex });
            
            SelectedItem = droppedItem;

            _dragStartDateTime = null;
            _draggedListViewItem = null;
            _dragging = false;
            if (_target != null)
            {
                _target.BorderThickness = new Thickness(0, 0, 0, 0);
            }
            _target = null;
        }

        private void CalculateDragPlacement(object source, object target, double height, double mouseY, out bool top, out int insertIndex, out int removeIndex)
        {
            var sourceIndex = Items.IndexOf(source);
            var targetIndex = Items.IndexOf(target);

            insertIndex = 0;
            removeIndex = 0;

            //Insert at top or at bottom?
            top = mouseY < (height / 2);

            //Inserting an item in the list will change all the indices. After inserting, we remove the original. Have to adjust it's index
            var removeOffset = sourceIndex < targetIndex ? 0 : 1;

            //Adjust to insert above or bellow the target element
            insertIndex = top ? targetIndex : targetIndex + 1;
            removeIndex = sourceIndex + removeOffset;
        }
    }
}
