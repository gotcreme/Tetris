namespace Tetris.DesktopUI.GamePages
{
    partial class HelpPage
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
            this.ControlsTitleLabel = new System.Windows.Forms.Label();
            this.KeyValueLabel = new System.Windows.Forms.Label();
            this.KeyActionLabel = new System.Windows.Forms.Label();
            this.BackButton = new Tetris.DesktopUI.Buttons.UnfocusableButton();
            this.SuspendLayout();
            // 
            // ControlsTitleLabel
            // 
            this.ControlsTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ControlsTitleLabel.AutoSize = true;
            this.ControlsTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.ControlsTitleLabel.Font = new System.Drawing.Font("Consolas", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ControlsTitleLabel.ForeColor = global::Tetris.DesktopUI.Properties.Settings.Default.ThemeColor;
            this.ControlsTitleLabel.Location = new System.Drawing.Point(72, 29);
            this.ControlsTitleLabel.Name = "ControlsTitleLabel";
            this.ControlsTitleLabel.Size = new System.Drawing.Size(188, 45);
            this.ControlsTitleLabel.TabIndex = 10;
            this.ControlsTitleLabel.Text = "Controls";
            this.ControlsTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KeyValueLabel
            // 
            this.KeyValueLabel.AutoSize = true;
            this.KeyValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.KeyValueLabel.Font = new System.Drawing.Font("Consolas", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyValueLabel.ForeColor = global::Tetris.DesktopUI.Properties.Settings.Default.ThemeColor;
            this.KeyValueLabel.Location = new System.Drawing.Point(85, 175);
            this.KeyValueLabel.Name = "KeyValueLabel";
            this.KeyValueLabel.Size = new System.Drawing.Size(0, 20);
            this.KeyValueLabel.TabIndex = 11;
            this.KeyValueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // KeyActionLabel
            // 
            this.KeyActionLabel.AutoSize = true;
            this.KeyActionLabel.BackColor = System.Drawing.Color.Transparent;
            this.KeyActionLabel.Font = new System.Drawing.Font("Consolas", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyActionLabel.ForeColor = global::Tetris.DesktopUI.Properties.Settings.Default.ThemeColor;
            this.KeyActionLabel.Location = new System.Drawing.Point(210, 175);
            this.KeyActionLabel.Name = "KeyActionLabel";
            this.KeyActionLabel.Size = new System.Drawing.Size(0, 20);
            this.KeyActionLabel.TabIndex = 12;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = global::Tetris.DesktopUI.Properties.Settings.Default.ThemeColor;
            this.BackButton.Location = new System.Drawing.Point(97, 363);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(150, 34);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // HelpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Tetris.DesktopUI.Properties.Settings.Default.BackgroundThemeColor;
            this.Controls.Add(this.KeyActionLabel);
            this.Controls.Add(this.KeyValueLabel);
            this.Controls.Add(this.ControlsTitleLabel);
            this.Controls.Add(this.BackButton);
            this.Name = "HelpPage";
            this.Size = new System.Drawing.Size(335, 430);
            this.Load += new System.EventHandler(this.HelpPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Buttons.UnfocusableButton BackButton;
        private System.Windows.Forms.Label ControlsTitleLabel;
        private System.Windows.Forms.Label KeyValueLabel;
        private System.Windows.Forms.Label KeyActionLabel;
    }
}
