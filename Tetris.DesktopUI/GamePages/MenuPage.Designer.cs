using Tetris.DesktopUI.Properties;

namespace Tetris.DesktopUI.GamePages
{
    partial class MenuPage
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ExitButton = new Tetris.DesktopUI.Buttons.UnfocusableButton();
            this.NewGameButton = new Tetris.DesktopUI.Buttons.UnfocusableButton();
            this.HelpButton = new Tetris.DesktopUI.Buttons.UnfocusableButton();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Consolas", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.ForeColor = global::Tetris.DesktopUI.Properties.Settings.Default.ThemeColor;
            this.TitleLabel.Location = new System.Drawing.Point(137, 99);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(146, 45);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Tetris";
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = global::Tetris.DesktopUI.Properties.Settings.Default.ThemeColor;
            this.ExitButton.Location = new System.Drawing.Point(126, 377);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(175, 34);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // NewGameButton
            // 
            this.NewGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NewGameButton.BackColor = System.Drawing.Color.Transparent;
            this.NewGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewGameButton.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewGameButton.ForeColor = global::Tetris.DesktopUI.Properties.Settings.Default.ThemeColor;
            this.NewGameButton.Location = new System.Drawing.Point(126, 233);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(175, 34);
            this.NewGameButton.TabIndex = 10;
            this.NewGameButton.Text = "NEW GAME";
            this.NewGameButton.UseVisualStyleBackColor = false;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpButton.BackColor = System.Drawing.Color.Transparent;
            this.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpButton.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpButton.ForeColor = global::Tetris.DesktopUI.Properties.Settings.Default.ThemeColor;
            this.HelpButton.Location = new System.Drawing.Point(126, 303);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(175, 34);
            this.HelpButton.TabIndex = 12;
            this.HelpButton.Text = "HELP";
            this.HelpButton.UseVisualStyleBackColor = false;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Tetris.DesktopUI.Properties.Settings.Default.BackgroundThemeColor;
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.TitleLabel);
            this.Name = "MenuPage";
            this.Size = new System.Drawing.Size(423, 572);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private Buttons.UnfocusableButton ExitButton;
        private Buttons.UnfocusableButton NewGameButton;
        private Buttons.UnfocusableButton HelpButton;
    }
}
