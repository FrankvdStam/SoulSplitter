using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using SoulSplitterUIv2.Ui.ViewModels;

namespace SoulSplitterUIv2.Ui.View.SplitControls
{
    /// <summary>
    /// Interaction logic for SplitsList.xaml
    /// </summary>
    [ExcludeFromCodeCoverage]
    public partial class SplitsList : UserControl
    {
        public SplitsList()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty SplitsDependencyProperty =
            DependencyProperty.Register(nameof(Splits), typeof(ObservableCollection<SplitViewModel>), typeof(SplitsList),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.None));


        public ObservableCollection<SplitViewModel> Splits { get; set; } = new ObservableCollection<SplitViewModel>();

        //public static readonly DependencyProperty SelectedValueDependencyProperty =
        //    DependencyProperty.Register(nameof(SelectedEventFlag), typeof(Enum), typeof(SplitsList),
        //        new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.None));
    }
}
