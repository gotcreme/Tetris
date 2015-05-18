using System;

namespace Tetris.DesktopUI.GamePages
{
    public class PageEventArgs : EventArgs
    {
        public Type PageType { get; private set; }

        public PageEventArgs(Type pageType)
        {
            PageType = pageType;
        }
    }
}
