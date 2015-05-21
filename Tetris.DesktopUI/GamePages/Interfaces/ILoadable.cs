using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.DesktopUI.GamePages.Interfaces
{
    interface ILoadable
    {
        //AD:General coding,при генерації всюди варто було перевіряти на null
        event EventHandler<PageEventArgs> PageEventHandler;
    }
}