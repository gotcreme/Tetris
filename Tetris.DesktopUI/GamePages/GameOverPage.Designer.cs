using System.Windows.Forms;
using Tetris.DesktopUI.Buttons;
using Tetris.DesktopUI.Properties;

namespace Tetris.DesktopUI.GamePages
{
    partial class GameOverPage
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
            this.GameOveLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.NewHighScoreLabel = new System.Windows.Forms.Label();
            this.OldHighScoreLabel = new System.Windows.Forms.Label();
            this.HighScoreLabel = new System.Windows.Forms.Label();
            this.ExitButton = new Tetris.DesktopUI.Buttons.UnfocusableButton();
            this.TryAgainButton = new Tetris.DesktopUI.Buttons.UnfocusableButton();
            this.SuspendLayout();
            // 
            // GameOveLabel
            // 
            this.GameOveLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameOveLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameOveLabel.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameOveLabel.ForeColor = global::Tetris.DesktopUI.Properties.Settings.Default.ThemeColor;
            this.GameOveLabel.Location = new System.Drawing.Point(27, 33);
            this.GameOveLabel.Name = "GameOveLabel";
            this.GameOveLabel.Size = new System.Drawing.Size(287, 55);
            this.GameOveLabel.TabIndex = 0;
            this.GameOveLabel.Text = "Game Over!";
            this.GameOveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ScoreLabel.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreLabel.ForeColor = global::Tetris.DesktopUI.Properties.Settings.Default.ThemeColor;
            this.ScoreLabel.Location = new System.Drawing.Point(65, 100);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(215, 35);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ScoreLabel.Visible = false;
            // 
            // NewHighScoreLabel
            // 
            this.NewHighScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NewHighScoreLabel.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewHighScoreLabel.ForeColor = global::Tetris.DesktopUI.Properties.Settings.Default.ThemeColor;
            this.NewHighScoreLabel.Location = new System.Drawing.Point(65, 178);
            this.NewHighScoreLabel.Name = "NewHighScoreLabel";
            this.NewHighScoreLabel.Size = new System.Drawing.Size(215, 35);
            this.NewHighScoreLabel.TabIndex = 5;
            this.NewHighScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OldHighScoreLabel
            // 
            this.OldHighScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OldHighScoreLabel.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OldHighScoreLabel.ForeColor = global::Tetris.DesktopUI.Properties.Settings.Default.ThemeColor;
            this.OldHighScoreLabel.Location = new System.Drawing.Point(65, 217);
            this.OldHighScoreLabel.Name = "OldHighScoreLabel";
            this.OldHighScoreLabel.Size = new System.Drawing.Size(215, 35);
            this.OldHighScoreLabel.TabIndex = 6;
            this.OldHighScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OldHighScoreLabel.Visible = false;
            // 
            // HighScoreLabel
            // 
            this.HighScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HighScoreLabel.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HighScoreLabel.ForeColor = global::Tetris.DesktopUI.Properties.Settings.Default.ThemeColor;
            this.HighScoreLabel.Location = new System.Drawing.Point(65, 139);
            this.HighScoreLabel.Name = "HighScoreLabel";
            this.HighScoreLabel.Size = new System.Drawing.Size(215, 35);
            this.HighScoreLabel.TabIndex = 7;
            this.HighScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HighScoreLabel.Visible = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = global::Tetris.DesktopUI.Properties.Settings.Default.ThemeColor;
            this.ExitButton.Location = new System.Drawing.Point(99, 319);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(150, 34);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TryAgainButton
            // 
            this.TryAgainButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TryAgainButton.BackColor = System.Drawing.Color.Transparent;
            this.TryAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TryAgainButton.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TryAgainButton.ForeColor = global::Tetris.DesktopUI.Properties.Settings.Default.ThemeColor;
            this.TryAgainButton.Location = new System.Drawing.Point(99, 265);
            this.TryAgainButton.Name = "TryAgainButton";
            this.TryAgainButton.Size = new System.Drawing.Size(150, 34);
            this.TryAgainButton.TabIndex = 8;
            this.TryAgainButton.Text = "TRY AGAIN";
            this.TryAgainButton.UseVisualStyleBackColor = false;
            this.TryAgainButton.Click += new System.EventHandler(this.TryAgainButton_Click);
            // 
            // GameOverPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = global::Tetris.DesktopUI.Properties.Settings.Default.BackgroundThemeColor;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TryAgainButton);
            this.Controls.Add(this.HighScoreLabel);
            this.Controls.Add(this.OldHighScoreLabel);
            this.Controls.Add(this.NewHighScoreLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.GameOveLabel);
            this.Name = "GameOverPage";
            this.Size = new System.Drawing.Size(335, 393);
            this.Load += new System.EventHandler(this.GameOverPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label GameOveLabel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label NewHighScoreLabel;
        private System.Windows.Forms.Label OldHighScoreLabel;
        private System.Windows.Forms.Label HighScoreLabel;
        private Tetris.DesktopUI.Buttons.UnfocusableButton TryAgainButton;
        private Tetris.DesktopUI.Buttons.UnfocusableButton ExitButton;
    }
}
