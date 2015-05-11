using System;
using System.Threading;
using Tetris.GameEngine;
using System.Timers;

namespace TetrisConsoleUI
{
    class TetrisConsoleUI
    {
        private static Game _game;
        private static  ConsoleDrawing _drawer;
        private static  System.Timers.Timer _gameTimer;
        private static int _timerCounter = 0;
        private static readonly int _timerStep = 10;

        static int Main(string[] args)
        {
            //preparing Console
            Console.Clear();
            Console.CursorVisible = false;

            _drawer = new ConsoleDrawing();

            ConsoleDrawing.ShowControls();

            Console.ReadKey(true);
            Console.Clear();

            _game = new Game();
            _game.Start();
            _gameTimer = new System.Timers.Timer(800);
            _gameTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            _gameTimer.Start();

            _drawer.DrawScene(_game);

            while (_game.Status != Game.GameStatus.Finished)
            {
                if (Console.KeyAvailable)
                {
                    KeyPressedHandler( Console.ReadKey(true) );
                    _drawer.DrawScene(_game);
                    _gameTimer.Enabled = true;
                }
            }
            _gameTimer.Stop();
            _drawer.ShowGameOver(_game);

            Console.ResetColor();
            Console.CursorVisible = true;
            return 0;
        }

        private static void KeyPressedHandler(ConsoleKeyInfo input_key)
        {
            switch (input_key.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (_game.Status != Game.GameStatus.Paused)
                        _game.MoveLeft();
                    break;
                case ConsoleKey.RightArrow:
                    if (_game.Status != Game.GameStatus.Paused)
                        _game.MoveRight();
                    break;
                case ConsoleKey.UpArrow:
                    if (_game.Status != Game.GameStatus.Paused)
                        _game.Rotate();
                    break;
                case ConsoleKey.DownArrow:
                    if (_game.Status != Game.GameStatus.Paused)
                    {
                        _game.MoveDown();
                        _gameTimer.Enabled = false;
                    }
                    break;
                case ConsoleKey.Spacebar:
                    if (_game.Status != Game.GameStatus.Paused)
                        _game.SmashDown();
                    break;
                case ConsoleKey.N:
                    _game.NextPieceMode = !_game.NextPieceMode;
                    break;
                case ConsoleKey.G:
                    _game.ShadowPieceMode = !_game.ShadowPieceMode;
                    break;
                case ConsoleKey.P:
                    _game.Pause();
                    break;
                case ConsoleKey.Escape:
                    _game.GameOver();
                    break;
                default:
                    break;
            }
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            if (_game.Status != Game.GameStatus.Finished)
            {
                if (_game.Status != Game.GameStatus.Paused)
                {
                    _timerCounter += _timerStep;
                    _game.MoveDown();
                    if (_game.Status == Game.GameStatus.Finished)
                    {
                        _gameTimer.Stop();
                    }
                    else
                    {
                        _drawer.DrawScene(_game);
                        if ( _timerCounter >= ( 1000 - (_game.Lines * 10) ) )
                        {
                            _gameTimer.Interval -= 50;
                            _timerCounter = 0;
                        }
                    }
                }
            }
        }
    }
}