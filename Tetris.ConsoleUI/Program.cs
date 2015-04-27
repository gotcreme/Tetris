using System;
using System.Threading;
using Tetris.GameEngine;
using System.Timers;

namespace TetrisConsoleUI
{
    class TetrisConsoleUI
    {
        static Game game;
        static ConsoleDrawing drawer;
        static System.Timers.Timer game_timer;
        static int _timerCounter = 0;
        static readonly int _timerStep = 10;

        static int Main(string[] args)
        {
            //preparing Console
            Console.Clear();
            Console.CursorVisible = false;

            drawer = new ConsoleDrawing();

            ConsoleDrawing.ShowControls();

            Console.ReadKey(true);
            Console.Clear();

            game = new Game();
            game.Start();
            game_timer = new System.Timers.Timer(800);
            game_timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            game_timer.Start();

            drawer.DrawScene(game);

            while (game.Status != Game.GameStatus.Finished)
            {
                if (Console.KeyAvailable)
                {
                    KeyPressedHandler( Console.ReadKey(true) );
                    drawer.DrawScene(game);
                    game_timer.Enabled = true;
                }
            }
            game_timer.Stop();
            drawer.ShowGameOver(game);

            Console.ResetColor();
            Console.CursorVisible = true;
            return 0;
        }

        private static void KeyPressedHandler(ConsoleKeyInfo input_key)
        {
            switch (input_key.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (game.Status != Game.GameStatus.Paused)
                        game.MoveLeft();
                    break;
                case ConsoleKey.RightArrow:
                    if (game.Status != Game.GameStatus.Paused)
                        game.MoveRight();
                    break;
                case ConsoleKey.UpArrow:
                    if (game.Status != Game.GameStatus.Paused)
                        game.Rotate();
                    break;
                case ConsoleKey.DownArrow:
                    if (game.Status != Game.GameStatus.Paused)
                    {
                        game.MoveDown();
                        game_timer.Enabled = false;
                    }
                    break;
                case ConsoleKey.Spacebar:
                    if (game.Status != Game.GameStatus.Paused)
                        game.SmashDown();
                    break;
                case ConsoleKey.N:
                    game.NextPieceMode = !game.NextPieceMode;
                    break;
                case ConsoleKey.G:
                    game.ShadowPieceMode = !game.ShadowPieceMode;
                    break;
                case ConsoleKey.P:
                    game.Pause();
                    break;
                case ConsoleKey.Escape:
                    game.GameOver();
                    break;
                default:
                    break;
            }
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            if (game.Status != Game.GameStatus.Finished)
            {
                if (game.Status != Game.GameStatus.Paused)
                {
                    _timerCounter += _timerStep;
                    game.MoveDown();
                    if (game.Status == Game.GameStatus.Finished)
                    {
                        game_timer.Stop();
                    }
                    else
                    {
                        drawer.DrawScene(game);
                        if (_timerCounter >= 1000 - (game.Lines * 10))
                        {
                            game_timer.Interval -= 50;
                            _timerCounter = 0;
                        }
                    }
                }
            }
        }
    }
}