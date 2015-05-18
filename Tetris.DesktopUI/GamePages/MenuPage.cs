using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tetris.DesktopUI.GamePages.Interfaces;

namespace Tetris.DesktopUI.GamePages
{
    public partial class MenuPage : UserControl, ILoadable
    {
        public event EventHandler<PageEventArgs> PageEventHandler;

        public MenuPage()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            PageEventHandler(this, new PageEventArgs(typeof(PlayingPage)));
            this.Dispose();
        }
        private void HelpButton_Click(object sender, EventArgs e)
        {
            PageEventHandler(this, new PageEventArgs(typeof(HelpPage)));
            this.Dispose();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            ((Form)this.Parent).Close();
            this.Dispose();
        }
    }
}
