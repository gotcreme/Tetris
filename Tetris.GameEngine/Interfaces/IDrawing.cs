using System;

namespace Tetris.GameEngine.Interfaces
{
    /*
     * Review VV: думаю, цей інтерфейс не повинен бути у зборці Tetris.GameEngine.
     * Оскільки ця зборка відповідає тільки за логіку гри і не повинна відповідати за відображення.
     */
    public interface IDrawing
    {
        void DrawScene(Game game);
    }
}
