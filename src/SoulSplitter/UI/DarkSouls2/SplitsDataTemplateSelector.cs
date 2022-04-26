using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using SoulSplitter.Splits.DarkSouls2;

namespace SoulSplitter.UI.DarkSouls2
{
    public class DarkSouls2SplitsDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate BossTemplate { get; set; }
        public DataTemplate ItemTemplate { get; set; }
        public DataTemplate BoxTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is SplitViewModel splitViewModel)
            {
                //If the split type changes, the data template has to be re-selected
                PropertyChangedEventHandler splitTypeChanged = null;
                splitTypeChanged = (o, args) =>
                {
                    if (args.PropertyName == "SplitType")
                    {
                        splitViewModel.PropertyChanged -= splitTypeChanged;
                        var cp = (ContentPresenter)container;
                        cp.ContentTemplateSelector = null;
                        cp.ContentTemplateSelector = this;
                    }
                };
                splitViewModel.PropertyChanged += splitTypeChanged;

                //Return correct data template
                switch (splitViewModel.SplitType)
                {
                    case SplitType.Boss:
                        return BossTemplate;
                    case SplitType.Item:
                        return ItemTemplate;
                    case SplitType.Box:
                        return BoxTemplate;
                }
            }
            return null;
        }
    }
}
