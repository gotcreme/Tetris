using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris.DesktopUI.Buttons
{
    public partial class UnfocusableButton : Button
    {
        public UnfocusableButton()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.Selectable, false);
        }
    }
}
