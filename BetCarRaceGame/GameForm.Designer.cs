namespace BetGame2
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.btnAction = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chooseCar = new System.Windows.Forms.NumericUpDown();
            this.SelectBetAmount = new System.Windows.Forms.NumericUpDown();
            this.labelCycleNo = new System.Windows.Forms.Label();
            this.labelBet = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxPunter3 = new System.Windows.Forms.TextBox();
            this.textBoxPunter2 = new System.Windows.Forms.TextBox();
            this.textBoxPunter1 = new System.Windows.Forms.TextBox();
            this.punter3Radio = new System.Windows.Forms.RadioButton();
            this.punter2Radio = new System.Windows.Forms.RadioButton();
            this.punter1Radio = new System.Windows.Forms.RadioButton();
            this.panelBet = new System.Windows.Forms.Panel();
            this.picCar4 = new System.Windows.Forms.PictureBox();
            this.picCar3 = new System.Windows.Forms.PictureBox();
            this.picCar2 = new System.Windows.Forms.PictureBox();
            this.picCar1 = new System.Windows.Forms.PictureBox();
            this.pictureTracks = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chooseCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectBetAmount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panelBet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTracks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAction.BackgroundImage = global::BetGame2.Properties.Resources.depositphotos_91357636_stock_illustration_car_racing_colored_vector_icon;
            this.btnAction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAction.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction.Location = new System.Drawing.Point(961, 722);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(508, 101);
            this.btnAction.TabIndex = 6;
            this.btnAction.Text = "Place Bet";
            this.btnAction.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAction.UseVisualStyleBackColor = false;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.chooseCar);
            this.groupBox1.Controls.Add(this.SelectBetAmount);
            this.groupBox1.Controls.Add(this.labelCycleNo);
            this.groupBox1.Controls.Add(this.labelBet);
            this.groupBox1.Controls.Add(this.labelMax);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 269);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Control:";
            // 
            // chooseCar
            // 
            this.chooseCar.Location = new System.Drawing.Point(198, 176);
            this.chooseCar.Name = "chooseCar";
            this.chooseCar.Size = new System.Drawing.Size(90, 38);
            this.chooseCar.TabIndex = 4;
            // 
            // SelectBetAmount
            // 
            this.SelectBetAmount.Location = new System.Drawing.Point(327, 97);
            this.SelectBetAmount.Name = "SelectBetAmount";
            this.SelectBetAmount.Size = new System.Drawing.Size(90, 38);
            this.SelectBetAmount.TabIndex = 3;
            // 
            // labelCycleNo
            // 
            this.labelCycleNo.AutoSize = true;
            this.labelCycleNo.Location = new System.Drawing.Point(22, 178);
            this.labelCycleNo.Name = "labelCycleNo";
            this.labelCycleNo.Size = new System.Drawing.Size(169, 31);
            this.labelCycleNo.TabIndex = 2;
            this.labelCycleNo.Text = "Bets on Car :";
            // 
            // labelBet
            // 
            this.labelBet.AutoSize = true;
            this.labelBet.Location = new System.Drawing.Point(22, 102);
            this.labelBet.Name = "labelBet";
            this.labelBet.Size = new System.Drawing.Size(238, 31);
            this.labelBet.TabIndex = 1;
            this.labelBet.Text = "Bets of Amount : $ ";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(22, 49);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(270, 31);
            this.labelMax.TabIndex = 0;
            this.labelMax.Text = "Max Bet Amount: $50";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox2.Controls.Add(this.textBoxPunter3);
            this.groupBox2.Controls.Add(this.textBoxPunter2);
            this.groupBox2.Controls.Add(this.textBoxPunter1);
            this.groupBox2.Controls.Add(this.punter3Radio);
            this.groupBox2.Controls.Add(this.punter2Radio);
            this.groupBox2.Controls.Add(this.punter1Radio);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(634, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(833, 269);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Narration:";
            // 
            // textBoxPunter3
            // 
            this.textBoxPunter3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPunter3.Location = new System.Drawing.Point(205, 213);
            this.textBoxPunter3.Name = "textBoxPunter3";
            this.textBoxPunter3.ReadOnly = true;
            this.textBoxPunter3.Size = new System.Drawing.Size(602, 42);
            this.textBoxPunter3.TabIndex = 12;
            // 
            // textBoxPunter2
            // 
            this.textBoxPunter2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPunter2.Location = new System.Drawing.Point(205, 132);
            this.textBoxPunter2.Name = "textBoxPunter2";
            this.textBoxPunter2.ReadOnly = true;
            this.textBoxPunter2.Size = new System.Drawing.Size(602, 42);
            this.textBoxPunter2.TabIndex = 11;
            // 
            // textBoxPunter1
            // 
            this.textBoxPunter1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPunter1.Location = new System.Drawing.Point(205, 51);
            this.textBoxPunter1.Name = "textBoxPunter1";
            this.textBoxPunter1.ReadOnly = true;
            this.textBoxPunter1.Size = new System.Drawing.Size(602, 42);
            this.textBoxPunter1.TabIndex = 10;
            // 
            // punter3Radio
            // 
            this.punter3Radio.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punter3Radio.Location = new System.Drawing.Point(26, 211);
            this.punter3Radio.Name = "punter3Radio";
            this.punter3Radio.Size = new System.Drawing.Size(159, 41);
            this.punter3Radio.TabIndex = 9;
            this.punter3Radio.TabStop = true;
            this.punter3Radio.Text = "Punter 3";
            this.punter3Radio.UseVisualStyleBackColor = true;
            // 
            // punter2Radio
            // 
            this.punter2Radio.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punter2Radio.Location = new System.Drawing.Point(26, 130);
            this.punter2Radio.Name = "punter2Radio";
            this.punter2Radio.Size = new System.Drawing.Size(159, 41);
            this.punter2Radio.TabIndex = 8;
            this.punter2Radio.TabStop = true;
            this.punter2Radio.Text = "Punter 2";
            this.punter2Radio.UseVisualStyleBackColor = true;
            // 
            // punter1Radio
            // 
            this.punter1Radio.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punter1Radio.Location = new System.Drawing.Point(26, 49);
            this.punter1Radio.Name = "punter1Radio";
            this.punter1Radio.Size = new System.Drawing.Size(159, 41);
            this.punter1Radio.TabIndex = 7;
            this.punter1Radio.TabStop = true;
            this.punter1Radio.Text = "Punter 1";
            this.punter1Radio.UseVisualStyleBackColor = true;
            // 
            // panelBet
            // 
            this.panelBet.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBet.Controls.Add(this.groupBox2);
            this.panelBet.Controls.Add(this.groupBox1);
            this.panelBet.Location = new System.Drawing.Point(1, 413);
            this.panelBet.Name = "panelBet";
            this.panelBet.Size = new System.Drawing.Size(1480, 304);
            this.panelBet.TabIndex = 5;
            // 
            // picCar4
            // 
            this.picCar4.Image = ((System.Drawing.Image)(resources.GetObject("picCar4.Image")));
            this.picCar4.Location = new System.Drawing.Point(-8, 322);
            this.picCar4.Name = "picCar4";
            this.picCar4.Size = new System.Drawing.Size(129, 66);
            this.picCar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCar4.TabIndex = 3;
            this.picCar4.TabStop = false;
            // 
            // picCar3
            // 
            this.picCar3.Image = ((System.Drawing.Image)(resources.GetObject("picCar3.Image")));
            this.picCar3.Location = new System.Drawing.Point(-8, 218);
            this.picCar3.Name = "picCar3";
            this.picCar3.Size = new System.Drawing.Size(129, 66);
            this.picCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCar3.TabIndex = 2;
            this.picCar3.TabStop = false;
            // 
            // picCar2
            // 
            this.picCar2.Image = ((System.Drawing.Image)(resources.GetObject("picCar2.Image")));
            this.picCar2.Location = new System.Drawing.Point(-8, 122);
            this.picCar2.Name = "picCar2";
            this.picCar2.Size = new System.Drawing.Size(129, 66);
            this.picCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCar2.TabIndex = 1;
            this.picCar2.TabStop = false;
            // 
            // picCar1
            // 
            this.picCar1.Image = ((System.Drawing.Image)(resources.GetObject("picCar1.Image")));
            this.picCar1.Location = new System.Drawing.Point(-8, 22);
            this.picCar1.Name = "picCar1";
            this.picCar1.Size = new System.Drawing.Size(129, 66);
            this.picCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCar1.TabIndex = 0;
            this.picCar1.TabStop = false;
            // 
            // pictureTracks
            // 
            this.pictureTracks.Image = global::BetGame2.Properties.Resources.tracck1;
            this.pictureTracks.Location = new System.Drawing.Point(1, 1);
            this.pictureTracks.Name = "pictureTracks";
            this.pictureTracks.Size = new System.Drawing.Size(1480, 406);
            this.pictureTracks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTracks.TabIndex = 4;
            this.pictureTracks.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 828);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.panelBet);
            this.Controls.Add(this.picCar4);
            this.Controls.Add(this.picCar3);
            this.Controls.Add(this.picCar2);
            this.Controls.Add(this.picCar1);
            this.Controls.Add(this.pictureTracks);
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home :: BET GAME";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chooseCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectBetAmount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelBet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTracks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCar1;
        private System.Windows.Forms.PictureBox picCar2;
        private System.Windows.Forms.PictureBox picCar3;
        private System.Windows.Forms.PictureBox picCar4;
        private System.Windows.Forms.PictureBox pictureTracks;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown chooseCar;
        private System.Windows.Forms.NumericUpDown SelectBetAmount;
        private System.Windows.Forms.Label labelCycleNo;
        private System.Windows.Forms.Label labelBet;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxPunter3;
        private System.Windows.Forms.TextBox textBoxPunter2;
        private System.Windows.Forms.TextBox textBoxPunter1;
        private System.Windows.Forms.RadioButton punter3Radio;
        private System.Windows.Forms.RadioButton punter2Radio;
        private System.Windows.Forms.RadioButton punter1Radio;
        private System.Windows.Forms.Panel panelBet;
    }
}

