using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace SoulSplitterUIv2.Ui.View.Controls
{
    //https://stackoverflow.com/questions/2001842/dynamic-filter-of-wpf-combobox-based-on-text-input/41986141#41986141
    public class FilteredComboBox : ComboBox
    {
        private string _oldFilter = string.Empty;

        private string _currentFilter = string.Empty;

        protected TextBox EditableTextBox => (TextBox)GetTemplateChild("PART_EditableTextBox")!;

        protected override void OnItemsSourceChanged(IEnumerable? oldValue, IEnumerable? newValue)
        {
            if (newValue != null)
            {
                var view = CollectionViewSource.GetDefaultView(newValue);
                view.Filter += FilterItem;
            }

            if (oldValue != null)
            {
                var view = CollectionViewSource.GetDefaultView(oldValue);
                if (view != null) view.Filter -= FilterItem;
            }

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
                //case Key.Tab:
                //case Key.Enter:
                //    IsDropDownOpen = false;
                //    break;
                case Key.Escape:
                    IsDropDownOpen = false;
                //    SelectedIndex = -1;
                //    Text = _currentFilter;
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

                    //if (typedText == string.Empty)
                    //{
                    //    SelectedValue = null;
                    //    SelectedIndex = -1;
                    //}
                    break;
            }
        }

        //protected override void OnPreviewLostKeyboardFocus(KeyboardFocusChangedEventArgs e)
        //{
        //    ClearFilter();
        //    var temp = SelectedIndex;
        //    SelectedIndex = -1;
        //    Text = string.Empty;
        //    SelectedIndex = temp;
        //    base.OnPreviewLostKeyboardFocus(e);
        //}

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

            var filterTex = value is IFilterableItem filterableItem ? filterableItem.GetFilterValue() : value.ToString();
            
            if (string.IsNullOrWhiteSpace(filterTex))
            {
                return true;
            }

            var words = Text.ToLower().Split(' ');
            var lower = filterTex.ToLower();
            return words.All(lower.Contains);
        }
    }
}
