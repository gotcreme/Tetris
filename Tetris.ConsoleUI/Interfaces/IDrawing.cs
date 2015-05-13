using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tetris.GameEngine;

namespace Tetris.ConsoleUI.Interfaces
{
    interface IDrawing
    {
        void DrawScene(Game game);
    }
}
