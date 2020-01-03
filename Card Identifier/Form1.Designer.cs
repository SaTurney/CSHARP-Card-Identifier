namespace Card_Identifier
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clickCardText = new System.Windows.Forms.Label();
            this.queenHeartsCard = new System.Windows.Forms.PictureBox();
            this.twoDiamondsCard = new System.Windows.Forms.PictureBox();
            this.fiveClubsCard = new System.Windows.Forms.PictureBox();
            this.kingSpadesCard = new System.Windows.Forms.PictureBox();
            this.eightSpadesCard = new System.Windows.Forms.PictureBox();
            this.cardIdentifyBox = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.queenHeartsCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoDiamondsCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiveClubsCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingSpadesCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eightSpadesCard)).BeginInit();
            this.SuspendLayout();
            // 
            // clickCardText
            // 
            this.clickCardText.AutoSize = true;
            this.clickCardText.Location = new System.Drawing.Point(189, 26);
            this.clickCardText.Name = "clickCardText";
            this.clickCardText.Size = new System.Drawing.Size(185, 17);
            this.clickCardText.TabIndex = 0;
            this.clickCardText.Text = "Click a Card to see Its Name";
            // 
            // queenHeartsCard
            // 
            this.queenHeartsCard.Image = ((System.Drawing.Image)(resources.GetObject("queenHeartsCard.Image")));
            this.queenHeartsCard.Location = new System.Drawing.Point(12, 66);
            this.queenHeartsCard.Name = "queenHeartsCard";
            this.queenHeartsCard.Size = new System.Drawing.Size(100, 138);
            this.queenHeartsCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.queenHeartsCard.TabIndex = 1;
            this.queenHeartsCard.TabStop = false;
            this.queenHeartsCard.Click += new System.EventHandler(this.QueenHeartsCard_Click);
            // 
            // twoDiamondsCard
            // 
            this.twoDiamondsCard.Image = ((System.Drawing.Image)(resources.GetObject("twoDiamondsCard.Image")));
            this.twoDiamondsCard.Location = new System.Drawing.Point(118, 66);
            this.twoDiamondsCard.Name = "twoDiamondsCard";
            this.twoDiamondsCard.Size = new System.Drawing.Size(100, 138);
            this.twoDiamondsCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.twoDiamondsCard.TabIndex = 2;
            this.twoDiamondsCard.TabStop = false;
            this.twoDiamondsCard.Click += new System.EventHandler(this.TwoDiamondsCard_Click);
            // 
            // fiveClubsCard
            // 
            this.fiveClubsCard.Image = ((System.Drawing.Image)(resources.GetObject("fiveClubsCard.Image")));
            this.fiveClubsCard.Location = new System.Drawing.Point(224, 66);
            this.fiveClubsCard.Name = "fiveClubsCard";
            this.fiveClubsCard.Size = new System.Drawing.Size(100, 138);
            this.fiveClubsCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fiveClubsCard.TabIndex = 3;
            this.fiveClubsCard.TabStop = false;
            this.fiveClubsCard.Click += new System.EventHandler(this.FiveClubsCard_Click);
            // 
            // kingSpadesCard
            // 
            this.kingSpadesCard.Image = ((System.Drawing.Image)(resources.GetObject("kingSpadesCard.Image")));
            this.kingSpadesCard.Location = new System.Drawing.Point(330, 66);
            this.kingSpadesCard.Name = "kingSpadesCard";
            this.kingSpadesCard.Size = new System.Drawing.Size(100, 138);
            this.kingSpadesCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kingSpadesCard.TabIndex = 4;
            this.kingSpadesCard.TabStop = false;
            this.kingSpadesCard.Click += new System.EventHandler(this.KingSpadesCard_Click);
            // 
            // eightSpadesCard
            // 
            this.eightSpadesCard.Image = ((System.Drawing.Image)(resources.GetObject("eightSpadesCard.Image")));
            this.eightSpadesCard.Location = new System.Drawing.Point(436, 66);
            this.eightSpadesCard.Name = "eightSpadesCard";
            this.eightSpadesCard.Size = new System.Drawing.Size(100, 138);
            this.eightSpadesCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eightSpadesCard.TabIndex = 5;
            this.eightSpadesCard.TabStop = false;
            this.eightSpadesCard.Click += new System.EventHandler(this.EightSpadesCard_Click);
            // 
            // cardIdentifyBox
            // 
            this.cardIdentifyBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardIdentifyBox.Location = new System.Drawing.Point(12, 233);
            this.cardIdentifyBox.Name = "cardIdentifyBox";
            this.cardIdentifyBox.Size = new System.Drawing.Size(514, 36);
            this.cardIdentifyBox.TabIndex = 6;
            this.cardIdentifyBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cardIdentifyBox.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(224, 293);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 31);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 346);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.cardIdentifyBox);
            this.Controls.Add(this.eightSpadesCard);
            this.Controls.Add(this.kingSpadesCard);
            this.Controls.Add(this.fiveClubsCard);
            this.Controls.Add(this.twoDiamondsCard);
            this.Controls.Add(this.queenHeartsCard);
            this.Controls.Add(this.clickCardText);
            this.Name = "Form1";
            this.Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.queenHeartsCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoDiamondsCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiveClubsCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingSpadesCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eightSpadesCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clickCardText;
        private System.Windows.Forms.PictureBox queenHeartsCard;
        private System.Windows.Forms.PictureBox twoDiamondsCard;
        private System.Windows.Forms.PictureBox fiveClubsCard;
        private System.Windows.Forms.PictureBox kingSpadesCard;
        private System.Windows.Forms.PictureBox eightSpadesCard;
        private System.Windows.Forms.Label cardIdentifyBox;
        private System.Windows.Forms.Button exitButton;
    }
}

