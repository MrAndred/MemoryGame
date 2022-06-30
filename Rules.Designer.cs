namespace Memo
{
    partial class Rules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rules));
            this.egoldsCard1 = new Memo.EgoldsCard();
            this.cfStyles1 = new Memo.CFStyles(this.components);
            this.SuspendLayout();
            // 
            // egoldsCard1
            // 
            this.egoldsCard1.BackColor = System.Drawing.Color.White;
            this.egoldsCard1.BackColorCurtain = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.egoldsCard1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.egoldsCard1.Font = new System.Drawing.Font("Verdana", 9F);
            this.egoldsCard1.FontDescrition = new System.Drawing.Font("Verdana", 8.25F);
            this.egoldsCard1.FontHeader = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.egoldsCard1.ForeColorDescrition = System.Drawing.Color.Black;
            this.egoldsCard1.ForeColorHeader = System.Drawing.Color.White;
            this.egoldsCard1.Location = new System.Drawing.Point(-1, 0);
            this.egoldsCard1.Name = "egoldsCard1";
            this.egoldsCard1.Size = new System.Drawing.Size(510, 344);
            this.egoldsCard1.TabIndex = 0;
            this.egoldsCard1.Text = "Наведи на меня";
            this.egoldsCard1.TextDescrition = "Каждый игрок переворачивает две карты. Если они одинаковвые, то перевернувший пол" +
    "учает одно очко, если нет, то ход переходит оппоненту. Побеждает игрок с большим" +
    " количеством найденных пар";
            this.egoldsCard1.TextHeader = "Правила";
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
            this.cfStyles1.FormStyle = Memo.CFStyles.fStyle.SimpleDark;
            this.cfStyles1.HeaderColor = System.Drawing.Color.DimGray;
            this.cfStyles1.HeaderColorAdditional = System.Drawing.Color.White;
            this.cfStyles1.HeaderColorGradientEnable = false;
            this.cfStyles1.HeaderColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.cfStyles1.HeaderHeight = 38;
            this.cfStyles1.HeaderImage = null;
            this.cfStyles1.HeaderTextColor = System.Drawing.Color.White;
            this.cfStyles1.HeaderTextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            // 
            // Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 341);
            this.Controls.Add(this.egoldsCard1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rules";
            this.Text = "Правила";
            this.ResumeLayout(false);

        }

        #endregion

        private EgoldsCard egoldsCard1;
        private CFStyles cfStyles1;
    }
}