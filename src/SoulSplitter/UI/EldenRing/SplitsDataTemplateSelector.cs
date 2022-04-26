using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using SoulSplitter.Splits.EldenRing;

namespace SoulSplitter.UI.EldenRing
{
    public class EldenRingSplitsDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate BossTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            //if (item is SplitViewModel splitViewModel)
            //{
            //    ////If the split type changes, the data template has to be re-selected
            //    //PropertyChangedEventHandler splitTypeChanged = null;
            //    //splitTypeChanged = (o, args) =>
            //    //{
            //    //    if (args.PropertyName == "SplitType")
            //    //    {
            //    //        splitViewModel.PropertyChanged -= splitTypeChanged;
            //    //        var cp = (ContentPresenter)container;
            //    //        cp.ContentTemplateSelector = null;
            //    //        cp.ContentTemplateSelector = this;
            //    //    }
            //    //};
            //    //splitViewModel.PropertyChanged += splitTypeChanged;
            //
            //    //Return correct data template
            //    switch (splitViewModel.SplitType)
            //    {
            //        default:
            //            throw new Exception($"{nameof(EldenRingSplitsDataTemplateSelector)} Unsupported split type {splitViewModel.SplitType}");
            //
            //        case SplitType.Boss:
            //            return BossTemplate;
            //    }
            //}
            return null;
        }
    }
}
