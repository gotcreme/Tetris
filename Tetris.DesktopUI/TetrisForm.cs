using System;
using System.Drawing;
using System.Windows.Forms;
using Tetris.GameEngine;
using Tetris.DesktopUI.Properties;
using Tetris.DesktopUI.GamePages;
using Tetris.DesktopUI.GamePages.Interfaces;

namespace Tetris.DesktopUI
{
    public partial class TetrisForm : Form
    {
        public TetrisForm()
        {
            InitializeComponent();
        }

        private void TetrisForm_Load(object sender, EventArgs e)
        {
            OnLoadPage(this, new PageEventArgs(typeof(MenuPage)));
        }

        public void OnLoadPage(object sender, PageEventArgs e)
        {
            if (typeof(ILoadable).IsAssignableFrom(e.PageType))
            {
                ILoadable page = (ILoadable)Activator.CreateInstance(e.PageType);
                page.PageEventHandler += OnLoadPage;
                UserControl control = (UserControl)page;
                control.Parent = this;
                this.Controls.Add(control);
            }
        }
    }
}
