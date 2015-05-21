using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tetris.GameEngine;
using Tetris.DesktopUI.Properties;
using Tetris.DesktopUI.GamePages.Interfaces;

namespace Tetris.DesktopUI.GamePages
{
    public partial class PlayingPage : UserControl, ILoadable
    {
        public event EventHandler<PageEventArgs> PageEventHandler;

        private Grid _mainGrid;
        private Grid _nextGrid;
        private Game _game = new Game();
        private Timer _gameTimer;
        private static int _timerCounter = 0;
        //AD:Coding conventions,неправильна назва константи.
        private const int _timerStep = 10;

        public PlayingPage()
        {
            InitializeComponent();
        }

        private void PlayingPage_Load(object sender, EventArgs e)
        {
            this.Size = this.Parent.ClientSize;
            _gameTimer = new Timer();
            _gameTimer.Interval = 800;
            _gameTimer.Tick += new EventHandler(t_Tick);
            _mainGrid = new Grid(_game.ActualBoard.Width, _game.ActualBoard.Height, 0, 0, this);
            _nextGrid = new Grid(4, 4, 288, 42, this);
            StartNewGame();
        }

        /**
         * Moves currentblock 1 line down every 800ms
         **/
        private void t_Tick(object sender, EventArgs e)
        {
            if (_game.Status != Game.GameStatus.Finished)
            {
                if (_game.Status != Game.GameStatus.Paused)
                {
                    _timerCounter += _timerStep;
                    _game.MoveDown();
                    if (_game.Status == Game.GameStatus.Finished)
                    {
                        OnGameOver();
                    }
                    else
                    {
                        DrawScene();
                        if (_timerCounter >= (1000 - (_game.Lines * 10)))
                        {
                            _gameTimer.Interval -= 30;
                            _timerCounter = 0;
                        }
                    }
                }
            }
            else
            {
                OnGameOver();
            }
        }

        private void DrawScene()
        {
            ScoreValLabel.Text = _game.Score.ToString();
            LinesValLabel.Text = _game.Lines.ToString();

            _mainGrid.Draw(_game.ActualBoard.ToArray);

            if (_game.NextPieceMode)
            {
                _nextGrid.Clear();
                _nextGrid.Draw(_game.NextPiece.ToArray);
            }
            else
            {
                _nextGrid.Clear();
            }
        }

        /**
         * Handles all key events
         **/
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((_game.Status == Game.GameStatus.Finished) && (e.KeyCode != Keys.S) && (e.KeyCode != Keys.Escape))
            {
                return;
            }
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (_game.Status != Game.GameStatus.Paused)
                        _game.MoveLeft();
                    break;
                case Keys.Right:
                    if (_game.Status != Game.GameStatus.Paused)
                        _game.MoveRight();
                    break;
                case Keys.Up:
                    if (_game.Status != Game.GameStatus.Paused)
                        _game.Rotate();
                    break;
                case Keys.Down:
                    if (_game.Status != Game.GameStatus.Paused)
                    {
                        _game.MoveDown();
                        _gameTimer.Enabled = false;
                    }
                    break;
                case Keys.Space:
                    if (_game.Status != Game.GameStatus.Paused)
                        _game.SmashDown();
                    break;
                case Keys.N:
                    _game.NextPieceMode = !_game.NextPieceMode;
                    break;
                case Keys.G:
                    _game.ShadowPieceMode = !_game.ShadowPieceMode;
                    break;
                case Keys.P:
                    _game.Pause();
                    this.OnPause();
                    break;
                case Keys.Escape:
                    ((Form)this.Parent).Close();
                    break;
                case Keys.S:
                    StartNewGame();
                    break;
                default:
                    break;
            }
            DrawScene();
            _gameTimer.Enabled = true;
        }

        /**
         * Reset all counters and grids and start a new game
         **/
        private void StartNewGame()
        {
            _mainGrid.Clear();
            _nextGrid.Clear();
            HighScoreLabel.Visible = true;
            HighScoreValLabel.Visible = true;
            HighScoreValLabel.Text = Properties.Settings.Default.HighScore.ToString();
            NextLabel.Visible = true;
            ScoreLabel.Visible = true;
            LinesLabel.Visible = true;
            ScoreValLabel.Visible = true;
            LinesValLabel.Visible = true;
            StatusLabel.Visible = false;
            ScoreValLabel.Text = "0";
            LinesValLabel.Text = "0";
            StatusLabel.Text = "";
            Mlabel.Text = "";
            _game = new Game();
            _game.Start();
            _gameTimer.Interval = 800;
            _gameTimer.Start();
        }

        private void OnGameOver()
        {
            _gameTimer.Stop();
            Settings.Default.Score = _game.Score;
            PageEventHandler(this, new PageEventArgs(typeof(GameOverPage)));
            this.Dispose();
        }

        private void OnPause()
        {
            if (_game.Status == Game.GameStatus.Paused)
            {
                StatusLabel.Location = new System.Drawing.Point(53, 235);
                StatusLabel.Text = "PAUSED";
                StatusLabel.Visible = true;
            }
            else
            {
                StatusLabel.Text = "";
                StatusLabel.Visible = false;
            }
        }
    }
}
