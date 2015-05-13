using System;
using Tetris.GameEngine.Interfaces;
using Tetris.GameEngine;
using Tetris.ConsoleUI.Interfaces;

namespace TetrisConsoleUI
{
    class ConsoleDrawing : IDrawing
    {
        #region "Drawing" CONSTANTS
        private const string BLOCK = "█";
        private const string BAKER = "█";
        private const string EMPTY = " ";
        #endregion

        /// <summary>
        /// Field for the "Next" Block
        /// </summary>
        private static readonly int[,] clearBlock = {
            {0,0,0,0,0},
            {0,0,0,0,0},
            {0,0,0,0,0},
            {0,0,0,0,0}
        };

        public void DrawScene(Game game)
        {
            lock (game)
            {
                //Current Position
                int posX = Console.CursorLeft;
                int posY = Console.CursorTop;

                //Draw lines made
                ShowLines(game);

                //Draw score
                ShowScore(game);

                //Draw PlayField
                Console.SetCursorPosition(posX, posY);
                DrawArray(game.ActualBoard.ToArray(), true);

                //Draw next Block
                Console.CursorLeft = game.ActualBoard.Width + 4;
                Console.CursorTop = 2;
                DrawArray(clearBlock, false);
                if (game.NextPieceMode)
                {
                    Console.CursorLeft = game.ActualBoard.Width + 5;
                    Console.CursorTop = 3;
                    DrawArray(game.NextPiece.ToArray(), false);
                }

                //Back to the Future, err... Beginning
                Console.SetCursorPosition(posX, posY);
            }
        }

        #region Helpers

        //Intro
        public static void ShowControls()
        {
            Console.Write(@"C# Console Tetris
    =======================================

    Controls:
    [→]       Move Block Right
    [←]       Move Block Left
    [SPACE]   Smash Bloock down
    [↓]       Push block down 1 Unit
    [↑]       Turn Clockwise
    [G]       Turn ghost Block on and off (Default on)
    [N]       Turn Next Block on and off
    [P]       Pause Game
    [ESC]     Exit Game

    =======================================

    Press any Key to start...
    ");

        }

        public void ShowGameOver(Game game)
        {
            Console.Clear();
            Console.Write("GAME OVER!!! Your score is {0}. Press Esc to exit...", game.Score);
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                ;
            }
        }

        private static void ShowLines(Game game)
        {
            Console.CursorLeft = game.ActualBoard.Width + 4;
            Console.CursorTop = 7;
            Console.WriteLine("Lines: {0}", game.Lines);
        }

        private static void ShowScore(Game game)
        {
            Console.CursorLeft = game.ActualBoard.Width + 4;
            Console.CursorTop = 9;
            Console.WriteLine("Score: {0}", game.Score);
        }

        private void DrawArray(int[,] arr, bool border)
        {
            int x = Console.CursorLeft;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                if (border)
                {
                    Console.Write(BAKER);
                }
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    //Change color according to the Number
                    switch (arr[i, j])
                    {
                        case 1:
                            DrawColor(BLOCK, ConsoleColor.White);
                            break;
                        case 2:
                            DrawColor(BLOCK, ConsoleColor.Magenta);
                            break;
                        case 3:
                            DrawColor(BLOCK, ConsoleColor.Blue);
                            break;
                        case 4:
                            DrawColor(BLOCK, ConsoleColor.Green);
                            break;
                        case 5:
                            DrawColor(BLOCK, ConsoleColor.Yellow);
                            break;
                        case 6:
                            DrawColor(BLOCK, ConsoleColor.Red);
                            break;
                        case 7:
                            DrawColor(BLOCK, ConsoleColor.Cyan);
                            break;
                        case 8:
                            DrawColor(BLOCK, ConsoleColor.Gray);
                            break;
                        default:
                            Console.Write(EMPTY);
                            break;
                    }
                }
                if (border)
                {
                    Console.WriteLine(BAKER);
                }
                else
                {
                    Console.WriteLine();
                }
                Console.CursorLeft = x;
            }
            if (border)
            {
                for (int q = 0; q <= arr.GetUpperBound(1) + 2; q++)
                {
                    Console.Write(BAKER);
                }
            }
        }

        /// <summary>
        /// Writes a String in the Specified foreground color,
        /// then switches the Color back
        /// </summary>
        /// <param name="a">String</param>
        /// <param name="b">Color</param>
        private static void DrawColor(string a, ConsoleColor b)
        {
            ConsoleColor c = Console.ForegroundColor;
            Console.ForegroundColor = b;
            Console.Write(a);
            Console.ForegroundColor = c;
        }

        #endregion
    }
}