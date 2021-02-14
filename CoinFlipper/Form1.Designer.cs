namespace CoinFlipper
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.BalanceTXT = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.BetBox = new System.Windows.Forms.TextBox();
            this.BetTXT = new System.Windows.Forms.Label();
            this.headsTailsComboBox = new System.Windows.Forms.ComboBox();
            this.siteTXT = new System.Windows.Forms.Label();
            this.FlipBTN = new System.Windows.Forms.Button();
            this.RestartBTN = new System.Windows.Forms.Button();
            this.coinPicture = new System.Windows.Forms.PictureBox();
            this.HighScoreTXT = new System.Windows.Forms.Label();
            this.HighScoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coinPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BalanceTXT
            // 
            this.BalanceTXT.AutoSize = true;
            this.BalanceTXT.Location = new System.Drawing.Point(225, 22);
            this.BalanceTXT.Name = "BalanceTXT";
            this.BalanceTXT.Size = new System.Drawing.Size(76, 13);
            this.BalanceTXT.TabIndex = 2;
            this.BalanceTXT.Text = "Your balance: ";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Location = new System.Drawing.Point(307, 22);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(25, 13);
            this.BalanceLabel.TabIndex = 3;
            this.BalanceLabel.Text = "100";
            // 
            // BetBox
            // 
            this.BetBox.Location = new System.Drawing.Point(296, 63);
            this.BetBox.Name = "BetBox";
            this.BetBox.Size = new System.Drawing.Size(146, 20);
            this.BetBox.TabIndex = 4;
            // 
            // BetTXT
            // 
            this.BetTXT.AutoSize = true;
            this.BetTXT.Location = new System.Drawing.Point(225, 66);
            this.BetTXT.Name = "BetTXT";
            this.BetTXT.Size = new System.Drawing.Size(50, 13);
            this.BetTXT.TabIndex = 5;
            this.BetTXT.Text = "Your bet:";
            // 
            // headsTailsComboBox
            // 
            this.headsTailsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.headsTailsComboBox.FormattingEnabled = true;
            this.headsTailsComboBox.Items.AddRange(new object[] {
            "Heads",
            "Tails"});
            this.headsTailsComboBox.Location = new System.Drawing.Point(296, 111);
            this.headsTailsComboBox.Name = "headsTailsComboBox";
            this.headsTailsComboBox.Size = new System.Drawing.Size(146, 21);
            this.headsTailsComboBox.TabIndex = 6;
            this.headsTailsComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // siteTXT
            // 
            this.siteTXT.AutoSize = true;
            this.siteTXT.Location = new System.Drawing.Point(225, 114);
            this.siteTXT.Name = "siteTXT";
            this.siteTXT.Size = new System.Drawing.Size(65, 13);
            this.siteTXT.TabIndex = 7;
            this.siteTXT.Text = "Heads/Tails";
            // 
            // FlipBTN
            // 
            this.FlipBTN.Location = new System.Drawing.Point(228, 159);
            this.FlipBTN.Name = "FlipBTN";
            this.FlipBTN.Size = new System.Drawing.Size(104, 23);
            this.FlipBTN.TabIndex = 8;
            this.FlipBTN.Text = "Flip it!";
            this.FlipBTN.UseVisualStyleBackColor = true;
            this.FlipBTN.Click += new System.EventHandler(this.FlipBTN_Click);
            // 
            // RestartBTN
            // 
            this.RestartBTN.Location = new System.Drawing.Point(342, 159);
            this.RestartBTN.Name = "RestartBTN";
            this.RestartBTN.Size = new System.Drawing.Size(100, 23);
            this.RestartBTN.TabIndex = 9;
            this.RestartBTN.Text = "Restart";
            this.RestartBTN.UseVisualStyleBackColor = true;
            this.RestartBTN.Click += new System.EventHandler(this.RestartBTN_Click);
            // 
            // coinPicture
            // 
            this.coinPicture.BackColor = System.Drawing.Color.White;
            this.coinPicture.Image = global::CoinFlipper.Properties.Resources.coinBest__2_;
            this.coinPicture.Location = new System.Drawing.Point(12, 12);
            this.coinPicture.Name = "coinPicture";
            this.coinPicture.Size = new System.Drawing.Size(179, 179);
            this.coinPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.coinPicture.TabIndex = 1;
            this.coinPicture.TabStop = false;
            // 
            // HighScoreTXT
            // 
            this.HighScoreTXT.AutoSize = true;
            this.HighScoreTXT.Location = new System.Drawing.Point(350, 22);
            this.HighScoreTXT.Name = "HighScoreTXT";
            this.HighScoreTXT.Size = new System.Drawing.Size(61, 13);
            this.HighScoreTXT.TabIndex = 10;
            this.HighScoreTXT.Text = "High score:";
            // 
            // HighScoreLabel
            // 
            this.HighScoreLabel.AutoSize = true;
            this.HighScoreLabel.Location = new System.Drawing.Point(417, 22);
            this.HighScoreLabel.Name = "HighScoreLabel";
            this.HighScoreLabel.Size = new System.Drawing.Size(25, 13);
            this.HighScoreLabel.TabIndex = 11;
            this.HighScoreLabel.Text = "100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(481, 203);
            this.Controls.Add(this.HighScoreLabel);
            this.Controls.Add(this.HighScoreTXT);
            this.Controls.Add(this.RestartBTN);
            this.Controls.Add(this.FlipBTN);
            this.Controls.Add(this.siteTXT);
            this.Controls.Add(this.headsTailsComboBox);
            this.Controls.Add(this.BetTXT);
            this.Controls.Add(this.BetBox);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.BalanceTXT);
            this.Controls.Add(this.coinPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "CoinFlipper";
            ((System.ComponentModel.ISupportInitialize)(this.coinPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coinPicture;
        private System.Windows.Forms.Label BalanceTXT;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.TextBox BetBox;
        private System.Windows.Forms.Label BetTXT;
        private System.Windows.Forms.ComboBox headsTailsComboBox;
        private System.Windows.Forms.Label siteTXT;
        private System.Windows.Forms.Button FlipBTN;
        private System.Windows.Forms.Button RestartBTN;
        private System.Windows.Forms.Label HighScoreTXT;
        private System.Windows.Forms.Label HighScoreLabel;
    }
}

