using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.DesktopUI.GamePages.Interfaces
{
    interface ILoadable
    {
        event EventHandler<PageEventArgs> PageEventHandler;
    }
}