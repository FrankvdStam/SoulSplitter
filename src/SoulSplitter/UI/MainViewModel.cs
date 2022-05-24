using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Xml;
using System.Xml.Serialization;
using SoulSplitter.UI.DarkSouls1;
using SoulSplitter.UI.DarkSouls2;
using SoulSplitter.UI.EldenRing;

namespace SoulSplitter.UI
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public void Update(MainViewModel mainViewModel)
        {
            SelectedGameIndex = mainViewModel.SelectedGameIndex;
            EldenRingViewModel = mainViewModel.EldenRingViewModel;
            DarkSouls1ViewModel = mainViewModel.DarkSouls1ViewModel;
            DarkSouls2ViewModel = mainViewModel.DarkSouls2ViewModel;
        }

        [XmlIgnore]
        public string Error
        {
            get => _error;
            set
            {
                _error = value;
                OnPropertyChanged();
            }
        }
        private string _error;

        public string Version { get; set; } = VersionHelper.Version.ToString();

        public int SelectedGameIndex
        {
            get => _selectedGameIndex;
            set
            {
                _selectedGameIndex = value;
                OnPropertyChanged();
            }
        }
        private int _selectedGameIndex = 2;



        public EldenRingViewModel EldenRingViewModel
        {
            get => _eldenRingViewModel;
            set
            {
                _eldenRingViewModel = value;
                OnPropertyChanged();
            }
        }

        private EldenRingViewModel _eldenRingViewModel = new EldenRingViewModel();



        public DarkSouls1ViewModel DarkSouls1ViewModel
        {
            get => _darkSouls1ViewModel;
            set
            {
                _darkSouls1ViewModel = value;
                OnPropertyChanged();
            }
        }

        private DarkSouls1ViewModel _darkSouls1ViewModel = new DarkSouls1ViewModel();



        public DarkSouls2ViewModel DarkSouls2ViewModel
        {
            get => _darkSouls2ViewModel;
            set
            {
                _darkSouls2ViewModel = value;
                OnPropertyChanged();
            }
        }

        private DarkSouls2ViewModel _darkSouls2ViewModel = new DarkSouls2ViewModel();



        #region Serializing

        public string Serialize()
        {
            var settings = new XmlWriterSettings()
            {
                OmitXmlDeclaration = true,
                Indent = true,
            };

            var xml = "";
            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, settings))
            {
                var serializer = new XmlSerializer(GetType());
                serializer.Serialize(writer, this);
                xml = stream.ToString();
            }
            return xml;
        }

        public static MainViewModel Deserialize(string xml)
        {
            var vm = xml.DeserializeXml<MainViewModel>();
            vm.EldenRingViewModel.RestoreHierarchy();
            return vm;
        }


        #endregion



        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
