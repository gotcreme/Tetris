using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris.DesktopUI
{
    class Grid
    {
        private int _gridWidth;
        private int _gridHeight;
        private int _lx;
        private int _ly;

        private const int SIZE = 25;
        private const int SPACE = 1;
       //AD:Coding conventions,неправильна приватного поля.
        private Panel[,] grid;

        private Form _parentForm;

        public Grid(int w, int h, int x, int y, Form f)
        {
            _gridWidth = w;
            _gridHeight = h;
            this._lx = x;
            this._ly = y;
            this._parentForm = f;
            Initialize();
        }

        /**
         * Create grid and add to the GUI
         **/
        private void Initialize()
        {
            int x = _lx;
            int y = _ly;

            grid = new Panel[_gridHeight, _gridWidth];
            for (int i = 0; i < _gridHeight; i++)
            {
                for (int j = 0; j < _gridWidth; j++)
                {
                    grid[i, j] = new Panel();
                    grid[i, j].BackColor = Properties.Settings.Default.BackgroundThemeColor;
                    grid[i, j].Size = new Size(SIZE, SIZE);
                    grid[i, j].Location = new Point(x, y);
                    grid[i, j].BorderStyle = BorderStyle.None;
                    _parentForm.Controls.Add(grid[i, j]);
                    x += SIZE + SPACE;
                }
                y += SIZE + SPACE;
                x = _lx;
            }
        }

        /**
         * Clear the grid
         **/
        public void Clear()
        {
            for (int i = 0; i < _gridHeight; i++)
            {
                for (int j = 0; j < _gridWidth; j++)
                {
                    grid[i, j].BackColor = Properties.Settings.Default.BackgroundThemeColor;
                    grid[i, j].Enabled = true;
                }
            }
        }

        /**
         * Set the color of a specific tile (x,y) in the grid
         **/
        private void SetColor(int x, int y, Color c)
        {
            if (grid[x, y].BackColor != c)
            {
                grid[x, y].BackColor = c;
            }
        }

        public void Draw(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    switch (array[i, j])
                    {
                        case 1:
                            this.SetColor(i, j, Color.White);
                            break;
                        case 2:
                            this.SetColor(i, j, Color.Magenta);
                            break;
                        case 3:
                            this.SetColor(i, j, Color.Blue);
                            break;
                        case 4:
                            this.SetColor(i, j, Color.Green);
                            break;
                        case 5:
                            this.SetColor(i, j, Color.Yellow);
                            break;
                        case 6:
                            this.SetColor(i, j, Color.Red);
                            break;
                        case 7:
                            this.SetColor(i, j, Color.Cyan);
                            break;
                        case 8:
                            this.SetColor(i, j, Color.Gray);
                            break;
                        default:
                            this.SetColor(i, j, Properties.Settings.Default.BackgroundThemeColor);
                            break;
                    }
                }
            }
        }
    }
}
