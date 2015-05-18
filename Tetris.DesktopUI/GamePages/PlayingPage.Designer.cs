using Tetris.DesktopUI.Properties;

namespace Tetris.DesktopUI.GamePages
{
    partial class PlayingPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HighScoreValLabel = new System.Windows.Forms.Label();
            this.HighScoreLabel = new System.Windows.Forms.Label();
            this.Mlabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LinesValLabel = new System.Windows.Forms.Label();
            this.LinesLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.NextLabel = new System.Windows.Forms.Label();
            this.ScoreValLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel.ForeColor = global::Tetris.DesktopUI.Properties.Settings.Default.ThemeColor;
            this.StatusLabel.Location = new System.Drawing.Point(-22, 150);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 47);
            this.StatusLabel.TabIndex = 33;
            this.StatusLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = global::Tetris.DesktopUI.Properties.Settings.Default.ThemeColor;
            this.label1.Location = new System.Drawing.Point(50, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 47);
            this.label1.TabIndex = 43;
            this.label1.Visible = false;
            // 
            // HighScoreValLabel
            // 
            this.HighScoreValLabel.AutoSize = true;
            this.HighScoreValLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HighScoreValLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScoreValLabel.ForeColor = global::Tetris.DesktopUI.Properties.Settings.Default.ThemeColor;
            this.HighScoreValLabel.Location = new System.Drawing.Point(278, 328);
            this.HighScoreValLabel.Name = "HighScoreValLabel";
            this.HighScoreValLabel.Size = new System.Drawing.Size(25, 28);
            this.HighScoreValLabel.TabIndex = 42;
            this.HighScoreValLabel.Text = global::Tetris.DesktopUI.Properties.Settings.Default.HighScore.ToString();
            // 
            // HighScoreLabel
            // 
            this.HighScoreLabel.AutoSize = true;
            this.HighScoreLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HighScoreLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScoreLabel.ForeColor = global::Tetris.DesktopUI.Properties.Settings.Default.ThemeColor;
            this.HighScoreLabel.Location = new System.Drawing.Point(278, 301);
            this.HighScoreLabel.Name = "HighScoreLabel";
            this.HighScoreLabel.Size = new System.Drawing.Size(110, 22);
            this.HighScoreLabel.TabIndex = 41;
            this.HighScoreLabel.Text = "HighScore:";
            // 
            // Mlabel
            // 
            this.Mlabel.AutoSize = true;
            this.Mlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mlabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mlabel.ForeColor = global::Tetris.DesktopUI.Properties.Settings.Default.ThemeColor;
            this.Mlabel.Location = new System.Drawing.Point(278, 20);
            this.Mlabel.Name = "Mlabel";
            this.Mlabel.Size = new System.Drawing.Size(0, 19);
            this.Mlabel.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = global::Tetris.DesktopUI.Properties.Settings.Default.ThemeColor;
            this.panel1.ForeColor = global::Tetris.DesktopUI.Properties.Settings.Default.ThemeColor;
            this.panel1.Location = new System.Drawing.Point(257, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 575);
            this.panel1.TabIndex = 39;
            // 
            // LinesValLabel
            // 
            this.LinesValLabel.AutoSize = true;
            this.LinesValLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LinesValLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinesValLabel.ForeColor = global::Tetris.DesktopUI.Properties.Settings.Default.ThemeColor;
            this.LinesValLabel.Location = new System.Drawing.Point(278, 262);
            this.LinesValLabel.Name = "LinesValLabel";
            this.LinesValLabel.Size = new System.Drawing.Size(25, 28);
            this.LinesValLabel.TabIndex = 38;
            this.LinesValLabel.Text = "0";
            // 
            // LinesLabel
            // 
            this.LinesLabel.AutoSize = true;
            this.LinesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LinesLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinesLabel.ForeColor = global::Tetris.DesktopUI.Properties.Settings.Default.ThemeColor;
            this.LinesLabel.Location = new System.Drawing.Point(278, 235);
            this.LinesLabel.Name = "LinesLabel";
            this.LinesLabel.Size = new System.Drawing.Size(70, 22);
            this.LinesLabel.TabIndex = 37;
            this.LinesLabel.Text = "Lines:";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = global::Tetris.DesktopUI.Properties.Settings.Default.ThemeColor;
            this.ScoreLabel.Location = new System.Drawing.Point(278, 167);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(70, 22);
            this.ScoreLabel.TabIndex = 36;
            this.ScoreLabel.Text = "Score:";
            // 
            // NextLabel
            // 
            this.NextLabel.AutoSize = true;
            this.NextLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextLabel.ForeColor = global::Tetris.DesktopUI.Properties.Settings.Default.ThemeColor;
            this.NextLabel.Location = new System.Drawing.Point(278, 9);
            this.NextLabel.Name = "NextLabel";
            this.NextLabel.Size = new System.Drawing.Size(70, 24);
            this.NextLabel.TabIndex = 35;
            this.NextLabel.Text = "Next:";
            // 
            // ScoreValLabel
            // 
            this.ScoreValLabel.AutoSize = true;
            this.ScoreValLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreValLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreValLabel.ForeColor = global::Tetris.DesktopUI.Properties.Settings.Default.ThemeColor;
            this.ScoreValLabel.Location = new System.Drawing.Point(278, 194);
            this.ScoreValLabel.Name = "ScoreValLabel";
            this.ScoreValLabel.Size = new System.Drawing.Size(25, 28);
            this.ScoreValLabel.TabIndex = 34;
            this.ScoreValLabel.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(427, 655);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 20);
            this.textBox1.TabIndex = 44;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // PlayingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = Settings.Default.BackgroundThemeColor;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HighScoreValLabel);
            this.Controls.Add(this.HighScoreLabel);
            this.Controls.Add(this.Mlabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LinesValLabel);
            this.Controls.Add(this.LinesLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.NextLabel);
            this.Controls.Add(this.ScoreValLabel);
            this.Controls.Add(this.StatusLabel);
            this.DoubleBuffered = true;
            this.Name = "PlayingPage";
            this.Size = new System.Drawing.Size(427, 575);
            this.Load += new System.EventHandler(this.PlayingPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HighScoreValLabel;
        private System.Windows.Forms.Label HighScoreLabel;
        private System.Windows.Forms.Label Mlabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LinesValLabel;
        private System.Windows.Forms.Label LinesLabel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label NextLabel;
        private System.Windows.Forms.Label ScoreValLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}
