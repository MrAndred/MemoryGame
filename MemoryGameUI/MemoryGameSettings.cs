using System;
using System.Windows.Forms;
using System.Drawing;
using Memo;

namespace MemoryGameUI
{
    public class MemoryGameSettings : Form
    {
        private Label SecondPlayerName;
        private Label BoardSizeLabel;
        private ButtonBoardSize BoardSizeButton;
        private Memo.yt_Button StartGameButton;
        private ToggleSwitch AgainstFriendButton;
        private CustomInput FirstPlayerTextBox;
        private CustomInput SecondPlayerTextBox;
        private CFStyles cfStyles1;
        private System.ComponentModel.IContainer components;
        private Label FirstPLayerName;

        public MemoryGameSettings()
        {
            InitializeComponent();

            Animator.Start();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoryGameSettings));
            this.FirstPLayerName = new System.Windows.Forms.Label();
            this.SecondPlayerName = new System.Windows.Forms.Label();
            this.BoardSizeLabel = new System.Windows.Forms.Label();
            this.SecondPlayerTextBox = new Memo.CustomInput();
            this.FirstPlayerTextBox = new Memo.CustomInput();
            this.AgainstFriendButton = new Memo.ToggleSwitch();
            this.StartGameButton = new Memo.yt_Button();
            this.BoardSizeButton = new MemoryGameUI.ButtonBoardSize();
            this.cfStyles1 = new Memo.CFStyles(this.components);
            this.SuspendLayout();
            // 
            // FirstPLayerName
            // 
            this.FirstPLayerName.AutoSize = true;
            this.FirstPLayerName.Location = new System.Drawing.Point(14, 20);
            this.FirstPLayerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstPLayerName.Name = "FirstPLayerName";
            this.FirstPLayerName.Size = new System.Drawing.Size(145, 16);
            this.FirstPLayerName.TabIndex = 0;
            this.FirstPLayerName.Text = "Имя Первого Игрока:";
            // 
            // SecondPlayerName
            // 
            this.SecondPlayerName.AutoSize = true;
            this.SecondPlayerName.Location = new System.Drawing.Point(14, 58);
            this.SecondPlayerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SecondPlayerName.Name = "SecondPlayerName";
            this.SecondPlayerName.Size = new System.Drawing.Size(143, 16);
            this.SecondPlayerName.TabIndex = 2;
            this.SecondPlayerName.Text = "Имя Второго Игрока:";
            // 
            // BoardSizeLabel
            // 
            this.BoardSizeLabel.AutoSize = true;
            this.BoardSizeLabel.Location = new System.Drawing.Point(14, 100);
            this.BoardSizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BoardSizeLabel.Name = "BoardSizeLabel";
            this.BoardSizeLabel.Size = new System.Drawing.Size(76, 16);
            this.BoardSizeLabel.TabIndex = 5;
            this.BoardSizeLabel.Text = "Board Size:";
            // 
            // SecondPlayerTextBox
            // 
            this.SecondPlayerTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SecondPlayerTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.SecondPlayerTextBox.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.SecondPlayerTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SecondPlayerTextBox.Enabled = false;
            this.SecondPlayerTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondPlayerTextBox.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.SecondPlayerTextBox.ForeColor = System.Drawing.Color.Black;
            this.SecondPlayerTextBox.Location = new System.Drawing.Point(164, 42);
            this.SecondPlayerTextBox.Name = "SecondPlayerTextBox";
            this.SecondPlayerTextBox.Size = new System.Drawing.Size(272, 39);
            this.SecondPlayerTextBox.TabIndex = 13;
            this.SecondPlayerTextBox.TextInput = "- Компьютер -";
            this.SecondPlayerTextBox.TextPreview = "- Игрок 2 -";
            this.SecondPlayerTextBox.UseSystemPasswordChar = false;
            // 
            // FirstPlayerTextBox
            // 
            this.FirstPlayerTextBox.BackColor = System.Drawing.Color.White;
            this.FirstPlayerTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.FirstPlayerTextBox.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.FirstPlayerTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FirstPlayerTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstPlayerTextBox.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.FirstPlayerTextBox.ForeColor = System.Drawing.Color.Black;
            this.FirstPlayerTextBox.Location = new System.Drawing.Point(164, -4);
            this.FirstPlayerTextBox.Name = "FirstPlayerTextBox";
            this.FirstPlayerTextBox.Size = new System.Drawing.Size(272, 40);
            this.FirstPlayerTextBox.TabIndex = 12;
            this.FirstPlayerTextBox.TextInput = "Игрок 1";
            this.FirstPlayerTextBox.TextPreview = "Игрок 1";
            this.FirstPlayerTextBox.UseSystemPasswordChar = false;
            // 
            // AgainstFriendButton
            // 
            this.AgainstFriendButton.BackColor = System.Drawing.Color.White;
            this.AgainstFriendButton.BackColorOFF = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.AgainstFriendButton.BackColorON = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.AgainstFriendButton.Checked = false;
            this.AgainstFriendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgainstFriendButton.Font = new System.Drawing.Font("Verdana", 9F);
            this.AgainstFriendButton.Location = new System.Drawing.Point(280, 93);
            this.AgainstFriendButton.Name = "AgainstFriendButton";
            this.AgainstFriendButton.Size = new System.Drawing.Size(156, 23);
            this.AgainstFriendButton.TabIndex = 11;
            this.AgainstFriendButton.Text = "Против Друга";
            this.AgainstFriendButton.TextOnChecked = "";
            this.AgainstFriendButton.Click += new System.EventHandler(this.AgainstFriendButton_Click);
            // 
            // StartGameButton
            // 
            this.StartGameButton.BackColor = System.Drawing.Color.LimeGreen;
            this.StartGameButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.StartGameButton.BackColorGradientEnabled = false;
            this.StartGameButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.StartGameButton.BorderColor = System.Drawing.Color.Tomato;
            this.StartGameButton.BorderColorEnabled = false;
            this.StartGameButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.StartGameButton.BorderColorOnHoverEnabled = false;
            this.StartGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartGameButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGameButton.ForeColor = System.Drawing.Color.Black;
            this.StartGameButton.Location = new System.Drawing.Point(323, 189);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.RippleColor = System.Drawing.Color.Black;
            this.StartGameButton.RoundingEnable = false;
            this.StartGameButton.Size = new System.Drawing.Size(122, 33);
            this.StartGameButton.TabIndex = 9;
            this.StartGameButton.Text = "Играть!";
            this.StartGameButton.TextHover = null;
            this.StartGameButton.UseDownPressEffectOnClick = false;
            this.StartGameButton.UseRippleEffect = true;
            this.StartGameButton.UseZoomEffectOnHover = false;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click_1);
            // 
            // BoardSizeButton
            // 
            this.BoardSizeButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BoardSizeButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.BoardSizeButton.BackColorGradientEnabled = false;
            this.BoardSizeButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.BoardSizeButton.BorderColor = System.Drawing.Color.Tomato;
            this.BoardSizeButton.BorderColorEnabled = false;
            this.BoardSizeButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.BoardSizeButton.BorderColorOnHoverEnabled = false;
            this.BoardSizeButton.CurrentTextIndex = 0;
            this.BoardSizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BoardSizeButton.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.BoardSizeButton.ForeColor = System.Drawing.Color.Black;
            this.BoardSizeButton.Location = new System.Drawing.Point(18, 125);
            this.BoardSizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.BoardSizeButton.Name = "BoardSizeButton";
            this.BoardSizeButton.RippleColor = System.Drawing.Color.Black;
            this.BoardSizeButton.RoundingEnable = false;
            this.BoardSizeButton.Size = new System.Drawing.Size(142, 94);
            this.BoardSizeButton.TabIndex = 8;
            this.BoardSizeButton.Text = this.BoardSizeButton.CurrentSizeString;
            this.BoardSizeButton.TextHover = null;
            this.BoardSizeButton.UseDownPressEffectOnClick = false;
            this.BoardSizeButton.UseRippleEffect = true;
            this.BoardSizeButton.UseZoomEffectOnHover = false;
            this.BoardSizeButton.Click += new System.EventHandler(this.BoardSizeButton_Click);
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
            this.cfStyles1.HeaderColor = System.Drawing.Color.DimGray;
            this.cfStyles1.HeaderColorAdditional = System.Drawing.Color.White;
            this.cfStyles1.HeaderColorGradientEnable = false;
            this.cfStyles1.HeaderColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.cfStyles1.HeaderHeight = 38;
            this.cfStyles1.HeaderImage = null;
            this.cfStyles1.HeaderTextColor = System.Drawing.Color.White;
            this.cfStyles1.HeaderTextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            // 
            // MemoryGameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(457, 233);
            this.Controls.Add(this.SecondPlayerTextBox);
            this.Controls.Add(this.FirstPlayerTextBox);
            this.Controls.Add(this.AgainstFriendButton);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.BoardSizeButton);
            this.Controls.Add(this.BoardSizeLabel);
            this.Controls.Add(this.SecondPlayerName);
            this.Controls.Add(this.FirstPLayerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MemoryGameSettings";
            this.ShowInTaskbar = false;
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void AgainstFriendButton_Click(object i_Sender, EventArgs i_E)
        {
            if (SecondPlayerTextBox.Enabled == false) 
            {
                SecondPlayerTextBox.Text = string.Empty;
                SecondPlayerTextBox.BackColor = FirstPlayerTextBox.BackColor;
            }
            else
            {
                SecondPlayerTextBox.Text = "- Компьютер -";
                SecondPlayerTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            }

            SecondPlayerTextBox.Enabled = !SecondPlayerTextBox.Enabled;
        }

        private void BoardSizeButton_Click(object i_Sender, EventArgs i_E)
        {
            ButtonBoardSize buttonBoardSize = i_Sender as ButtonBoardSize;
            buttonBoardSize.ChangeSize();
        }

        public Point BoardSize
        {
            get
            {
                return BoardSizeButton.CurrentSize;
            }
        }

        public string Player1Name
        {
            get
            {
                return FirstPlayerTextBox.TextInput;
            }
        }

        public string Player2Name
        {
            get
            {
                string player2Name;

                if(SecondPlayerTextBox.Enabled == true)
                {
                    player2Name = SecondPlayerTextBox.TextInput;
                }
                else
                {
                    player2Name = "Компьютер";
                }

                return player2Name;
            }
        }

        public bool IsPvP
        {
            get
            {
                return !SecondPlayerTextBox.Enabled;
            }
        }

        private void StartGameButton_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            ButtonBoardSize buttonBoardSize = sender as ButtonBoardSize;
            buttonBoardSize.ChangeSize();
        }

        private void AgainstFriendButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
