using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using SoulSplitter.Splits;

namespace SoulSplitter.UI
{
    public partial class MainControlFormsWrapper : UserControl
    {
        public MainControlFormsWrapper()
        {
            _mainControl = new MainControl();
            Width = (int)_mainControl.Width + 15;
            Height = (int)_mainControl.Height + 15;

            AutoScaleMode = AutoScaleMode.Font; //Fix scaling issues (100%, 150%, etc, in windows display settings)

            SuspendLayout();
            _elementHost = new ElementHost();
            _elementHost.Location = new System.Drawing.Point(0, 0);
            _elementHost.Name = "ElementHost";
            _elementHost.Size = new System.Drawing.Size((int)_mainControl.Width, (int)_mainControl.Height);
            _elementHost.TabIndex = 0;
            _elementHost.Text = "ElementHost";
            _elementHost.Child = _mainControl;
            Controls.Add(_elementHost);

            ResumeLayout(false);
        }

        public MainViewModel MainViewModel
        {
            get => _mainControl.MainViewModel;
            set => _mainControl.MainViewModel = value;
        }
        
        private ElementHost _elementHost;
        private UI.MainControl _mainControl;
    }
}
