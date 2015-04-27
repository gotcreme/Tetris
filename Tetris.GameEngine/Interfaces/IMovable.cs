using System;

namespace Tetris.GameEngine.Interfaces
{
    public interface IMovable
    {
        void MoveRight();
        void MoveLeft();
        void MoveDown();
        void SmashDown();
        void Rotate();
    }
}
