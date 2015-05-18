using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tetris.DesktopUI.GamePages.Interfaces;

namespace Tetris.DesktopUI.GamePages
{
    public partial class HelpPage : UserControl, ILoadable
    {
        public event EventHandler<PageEventArgs> PageEventHandler;

        public HelpPage()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void HelpPage_Load(object sender, EventArgs e)
        {
            StringBuilder controlsValStr = new StringBuilder();
            StringBuilder controlsStr = new StringBuilder();
            controlsValStr.Append("Left Arrow");
            controlsStr.Append("Move Block Left");
            controlsValStr.Append("\nRight Arrow");
            controlsStr.Append("\nMove Block Right");
            controlsValStr.Append("\nDown Arrow");
            controlsStr.Append("\nSoft Drop");
            controlsValStr.Append("\nUp Arrow");
            controlsStr.Append("\nTurn Clockwise");
            controlsValStr.Append("\nSpace");
            controlsStr.Append("\nHard Drop");
            controlsValStr.Append("\nG");
            controlsStr.Append("\nGhost Block (On/Off)");
            controlsValStr.Append("\nN");
            controlsStr.Append("\nNext Block (On/Off)");
            controlsValStr.Append("\nP");
            controlsStr.Append("\nPause Game");
            controlsValStr.Append("\nS");
            controlsStr.Append("\nStart New Game");
            controlsValStr.Append("\nEsc");
            controlsStr.Append("\nQuit Game");
            KeyValueLabel.Text = controlsValStr.ToString();
            KeyActionLabel.Text = controlsStr.ToString();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            PageEventHandler(this, new PageEventArgs(typeof(MenuPage)));
            this.Dispose();
        }
    }
}
