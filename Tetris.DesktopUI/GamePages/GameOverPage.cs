using System;
using System.Drawing;
using System.Windows.Forms;
using Tetris.DesktopUI.GamePages.Interfaces;
using Tetris.DesktopUI.Properties;

namespace Tetris.DesktopUI.GamePages
{
    public partial class GameOverPage : UserControl, ILoadable
    {
        public event EventHandler<PageEventArgs> PageEventHandler;

        public GameOverPage()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void GameOverPage_Load(object sender, EventArgs e)
        {
            if (Settings.Default.Score > Settings.Default.HighScore)
            {
                ScoreLabel.Location = new Point(65, 110);
                NewHighScoreLabel.Location = new Point(65, 150);
                OldHighScoreLabel.Location = new Point(65, 190);
                ScoreLabel.Visible = true;
                NewHighScoreLabel.Visible = true;
                OldHighScoreLabel.Visible = true;
                ScoreLabel.Text = "Score: " + Settings.Default.Score.ToString();
                NewHighScoreLabel.Text = "New HighScore: " + Settings.Default.Score.ToString();
                OldHighScoreLabel.Text = "Old HighScore: " + Settings.Default.HighScore.ToString();
                HighScoreLabel.Visible = false;
                Properties.Settings.Default.HighScore = Settings.Default.Score;
                Properties.Settings.Default.Save();
            }
            else
            {
                ScoreLabel.Location = new Point(65, 110);
                HighScoreLabel.Location = new Point(65, 160);
                ScoreLabel.Text = "Score: " + Settings.Default.Score.ToString();
                HighScoreLabel.Text = "HighScore: " + Settings.Default.HighScore.ToString();
                ScoreLabel.Visible = true;
                HighScoreLabel.Visible = true;
                NewHighScoreLabel.Visible = false;
                OldHighScoreLabel.Visible = false;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ((Form)this.Parent).Close();
            this.Dispose();
        }

        private void TryAgainButton_Click(object sender, EventArgs e)
        {
            PageEventHandler(this, new PageEventArgs(typeof(PlayingPage)));
            this.Dispose();
        }
    }
}
