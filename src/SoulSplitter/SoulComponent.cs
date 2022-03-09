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
using Brushes = System.Drawing.Brushes;

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

                //HorizontalWidth = width;
                //VerticalHeight = height;
                //if (mode == LayoutMode.Vertical)
                //{
                //    HorizontalWidth = width;
                //    VerticalHeight = 0;
                //}
                //else
                //{
                //    HorizontalWidth = 0;
                //    VerticalHeight = height;
                //}

                _liveSplitState = state;

                if (_splitter.Exception != null)
                {
                    WriteDebug(_splitter.Exception.Message);
                }
                else
                {
                    WriteDebug("");
                }

                if (_redraw)
                {
                    invalidator?.Invalidate(0, 0, 1, 1);
                }
            }
            catch (Exception e)
            {
                WriteDebug(e.Message);
            }
        }



        #region drawing ===================================================================================================================

        public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
        {
            Draw(g);
        }

        public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
        {
            Draw(g);
        }
        
        private void WriteDebug(string s)
        {
            if (_debugOutput != s)
            {
                _redraw = true;
                _debugOutput = s;
            }
        }

        private string _debugOutput = "";
        private bool _redraw = true;

        private DispatcherTimer _clearDebugOutputTimer = new DispatcherTimer();

        public void Draw(Graphics g)
        {
            if (string.IsNullOrWhiteSpace(_debugOutput))
            {
                VerticalHeight = 0;
                HorizontalWidth = 0;
            }
            else
            {
                VerticalHeight = g.MeasureString(_debugOutput, _liveSplitState.LayoutSettings.TextFont).Height + 2 * InternalPadding;

                //Get longest string to base the width on
                var longestStr = _debugOutput.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList().OrderByDescending(i => i.Length).FirstOrDefault();
                HorizontalWidth = g.MeasureString(longestStr, _liveSplitState.LayoutSettings.TextFont).Width + 2 * InternalPadding;

                g.FillRectangle(new SolidBrush(_liveSplitState.LayoutSettings.BackgroundColor), 0, 0, HorizontalWidth, VerticalHeight);
                g.DrawString(_debugOutput, _liveSplitState.LayoutSettings.TextFont, Brushes.Crimson, InternalPadding, InternalPadding);
            }
            
            _redraw = false;
        }
        

        private const float InternalPadding = 7f;

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
            var vm = settings.InnerXml.DeserializeXml<MainViewModel>();
            if (vm != null)
            {
                MainControlFormsWrapper.MainViewModel = vm;
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
