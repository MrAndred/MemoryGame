using System;

namespace MemoryGameUI
{
    partial class MemoryGame
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoryGame));
            this.CurrentPlayer = new System.Windows.Forms.Label();
            this.Player1Name = new System.Windows.Forms.Label();
            this.Player2Name = new System.Windows.Forms.Label();
            this.TileButton = new System.Windows.Forms.Button();
            this.PicTimer = new System.Windows.Forms.Timer(this.components);
            this.ComputerTimer = new System.Windows.Forms.Timer(this.components);
            this.cfStyles1 = new Memo.CFStyles(this.components);
            this.yt_Button1 = new Memo.yt_Button();
            this.SuspendLayout();
            // 
            // CurrentPlayer
            // 
            this.CurrentPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CurrentPlayer.AutoSize = true;
            this.CurrentPlayer.BackColor = System.Drawing.Color.PaleGreen;
            this.CurrentPlayer.Location = new System.Drawing.Point(50, 345);
            this.CurrentPlayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentPlayer.Name = "CurrentPlayer";
            this.CurrentPlayer.Size = new System.Drawing.Size(94, 16);
            this.CurrentPlayer.TabIndex = 0;
            this.CurrentPlayer.Text = "Current Player:";
            // 
            // Player1Name
            // 
            this.Player1Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Player1Name.AutoSize = true;
            this.Player1Name.BackColor = System.Drawing.Color.PaleGreen;
            this.Player1Name.Location = new System.Drawing.Point(50, 383);
            this.Player1Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player1Name.Name = "Player1Name";
            this.Player1Name.Size = new System.Drawing.Size(90, 16);
            this.Player1Name.TabIndex = 1;
            this.Player1Name.Text = "Player1Name";
            // 
            // Player2Name
            // 
            this.Player2Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Player2Name.AutoSize = true;
            this.Player2Name.BackColor = System.Drawing.Color.Plum;
            this.Player2Name.Location = new System.Drawing.Point(50, 417);
            this.Player2Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player2Name.Name = "Player2Name";
            this.Player2Name.Size = new System.Drawing.Size(90, 16);
            this.Player2Name.TabIndex = 2;
            this.Player2Name.Text = "Player2Name";
            // 
            // TileButton
            // 
            this.TileButton.Location = new System.Drawing.Point(38, 25);
            this.TileButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TileButton.Name = "TileButton";
            this.TileButton.Size = new System.Drawing.Size(114, 105);
            this.TileButton.TabIndex = 3;
            this.TileButton.UseVisualStyleBackColor = true;
            // 
            // PicTimer
            // 
            this.PicTimer.Interval = 1000;
            this.PicTimer.Tick += new System.EventHandler(this.PicTimer_Tick);
            // 
            // ComputerTimer
            // 
            this.ComputerTimer.Interval = 1000;
            this.ComputerTimer.Tick += new System.EventHandler(this.ComputerTimer_Tick);
            // 
            // cfStyles1
            // 
            this.cfStyles1.AllowUserResize = false;
            this.cfStyles1.BackColor = System.Drawing.Color.White;
            this.cfStyles1.ContextMenuForm = null;
            this.cfStyles1.ControlBoxButtonsWidth = 20;
            this.cfStyles1.EnableControlBoxIconsLight = false;
            this.cfStyles1.EnableControlBoxMouseLight = false;
            this.cfStyles1.Form = this;
            this.cfStyles1.FormStyle = Memo.CFStyles.fStyle.None;
            this.cfStyles1.HeaderColor = System.Drawing.SystemColors.Highlight;
            this.cfStyles1.HeaderColorAdditional = System.Drawing.Color.White;
            this.cfStyles1.HeaderColorGradientEnable = false;
            this.cfStyles1.HeaderColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.cfStyles1.HeaderHeight = 20;
            this.cfStyles1.HeaderImage = null;
            this.cfStyles1.HeaderTextColor = System.Drawing.Color.White;
            this.cfStyles1.HeaderTextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            // 
            // yt_Button1
            // 
            this.yt_Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.yt_Button1.BackColor = System.Drawing.Color.RosyBrown;
            this.yt_Button1.BackColorAdditional = System.Drawing.Color.Gray;
            this.yt_Button1.BackColorGradientEnabled = false;
            this.yt_Button1.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.yt_Button1.BorderColor = System.Drawing.Color.Tomato;
            this.yt_Button1.BorderColorEnabled = false;
            this.yt_Button1.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.yt_Button1.BorderColorOnHoverEnabled = false;
            this.yt_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yt_Button1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.yt_Button1.ForeColor = System.Drawing.Color.White;
            this.yt_Button1.Location = new System.Drawing.Point(406, 345);
            this.yt_Button1.Name = "yt_Button1";
            this.yt_Button1.RippleColor = System.Drawing.Color.Black;
            this.yt_Button1.RoundingEnable = false;
            this.yt_Button1.Size = new System.Drawing.Size(222, 79);
            this.yt_Button1.TabIndex = 4;
            this.yt_Button1.Text = "Узнать правила";
            this.yt_Button1.TextHover = null;
            this.yt_Button1.UseDownPressEffectOnClick = false;
            this.yt_Button1.UseRippleEffect = true;
            this.yt_Button1.UseZoomEffectOnHover = false;
            this.yt_Button1.Click += new System.EventHandler(this.yt_Button1_Click);
            // 
            // MemoryGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(709, 463);
            this.Controls.Add(this.yt_Button1);
            this.Controls.Add(this.TileButton);
            this.Controls.Add(this.Player2Name);
            this.Controls.Add(this.Player1Name);
            this.Controls.Add(this.CurrentPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "MemoryGame";
            this.Text = "Игра на соответствия";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentPlayer;
        private System.Windows.Forms.Label Player1Name;
        private System.Windows.Forms.Label Player2Name;
        private System.Windows.Forms.Button TileButton;
        private System.Windows.Forms.Timer PicTimer;
        private System.Windows.Forms.Timer ComputerTimer;
        private Memo.CFStyles cfStyles1;
        private Memo.yt_Button yt_Button1;
    }
}