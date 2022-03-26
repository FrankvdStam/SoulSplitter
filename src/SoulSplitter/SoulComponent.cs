using LiveSplit.Model;
using LiveSplit.UI;
using LiveSplit.UI.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Threading;
using System.Xml;
using System.Xml.Serialization;
using LiveSplit.Web;
using SoulSplitter.Splits;
using SoulSplitter.Splitters;
using SoulSplitter.UI;
using SoulSplitter.UI.ViewModel;

namespace SoulSplitter
{
    public class SoulComponent : IComponent
    {
        public const string Name = "SoulSplitter";

        public IDictionary<string, Action> ContextMenuControls => null;

        private LiveSplitState _liveSplitState;
        private readonly EldenRingSplitter _splitter;

        public SoulComponent(LiveSplitState state = null)
        {           
            _liveSplitState = state;
            _splitter = new EldenRingSplitter(state);
        }

        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            try
            {
                _splitter.Update(MainControlFormsWrapper.MainViewModel.EldenRingViewModel);
                
                _liveSplitState = state;


                if (_splitter.Exception != null)
                {
                    MainControlFormsWrapper.MainViewModel.Error = _splitter.Exception.Message;
                }
                else
                {
                    MainControlFormsWrapper.MainViewModel.Error = "";
                }
            }
            catch (Exception e)
            {
                MainControlFormsWrapper.MainViewModel.Error = e.Message;
            }
        }

        #region drawing ===================================================================================================================

        public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
        {
        }

        public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
        {
        }

        public string ComponentName => Name;
        public float HorizontalWidth { get; private set; } = 0;
        public float MinimumHeight { get; private set; } = 0;
        public float VerticalHeight { get; private set; } = 0;
        public float MinimumWidth { get; private set; } = 0;
        public float PaddingTop => 0;
        public float PaddingBottom => 0;
        public float PaddingLeft => 0;
        public float PaddingRight => 0;
        public void Dispose() { }
        #endregion

        #region Xml settings ==============================================================================================================
        public XmlNode GetSettings(XmlDocument document)
        {
            var viewModel = MainControlFormsWrapper.MainViewModel;
            var settings = new XmlWriterSettings()
            {
                OmitXmlDeclaration = true,
                Indent = true,
            };

            var xml = "";
            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, settings))
            {
                var serializer = new XmlSerializer(viewModel.GetType());
                serializer.Serialize(writer, viewModel);
                xml = stream.ToString();
            }

            XmlDocumentFragment fragment = document.CreateDocumentFragment();
            fragment.InnerXml = xml;

            XmlElement root = document.CreateElement("Settings");
            root.AppendChild(fragment);
            return root;
        }

        public void SetSettings(XmlNode settings)
        {
            try
            {
                var vm = settings.InnerXml.DeserializeXml<MainViewModel>();
                if (vm != null)
                {
                    MainControlFormsWrapper.MainViewModel = vm;
                }
            }
            catch
            {
                MainControlFormsWrapper.MainViewModel = new MainViewModel();
            }
        }

        public MainControlFormsWrapper MainControlFormsWrapper = new MainControlFormsWrapper();
        public System.Windows.Forms.Control GetSettingsControl(LayoutMode mode)
        {
            return MainControlFormsWrapper;
        }
        #endregion
    }
}
