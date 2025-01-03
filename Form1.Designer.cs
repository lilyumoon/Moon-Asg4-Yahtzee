namespace Moon_Asg4_Yahtzee
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageListDice = new System.Windows.Forms.ImageList(this.components);
            this.diceGroupBox = new System.Windows.Forms.GroupBox();
            this.rollsLeftCounterLabel = new System.Windows.Forms.Label();
            this.rollsLeftLabel = new System.Windows.Forms.Label();
            this.heldLabel5 = new System.Windows.Forms.Label();
            this.heldLabel4 = new System.Windows.Forms.Label();
            this.heldLabel3 = new System.Windows.Forms.Label();
            this.heldLabel2 = new System.Windows.Forms.Label();
            this.heldLabel1 = new System.Windows.Forms.Label();
            this.rollButton = new System.Windows.Forms.Button();
            this.diePictureBox5 = new System.Windows.Forms.PictureBox();
            this.diePictureBox4 = new System.Windows.Forms.PictureBox();
            this.diePictureBox3 = new System.Windows.Forms.PictureBox();
            this.diePictureBox2 = new System.Windows.Forms.PictureBox();
            this.diePictureBox1 = new System.Windows.Forms.PictureBox();
            this.scoreGroupBox = new System.Windows.Forms.GroupBox();
            this.setButton2 = new System.Windows.Forms.Button();
            this.setButton1 = new System.Windows.Forms.Button();
            this.gameTotalCounterLabel = new System.Windows.Forms.Label();
            this.lowerTotalCounterLabel = new System.Windows.Forms.Label();
            this.bonusCounterLabel = new System.Windows.Forms.Label();
            this.upperTotalCounterLabel = new System.Windows.Forms.Label();
            this.gameTotalLabel = new System.Windows.Forms.Label();
            this.lowerTotalLabel = new System.Windows.Forms.Label();
            this.bonusLabel = new System.Windows.Forms.Label();
            this.upperTotalLabel = new System.Windows.Forms.Label();
            this.lowerScoringListBox = new System.Windows.Forms.ListBox();
            this.upperScoringListBox = new System.Windows.Forms.ListBox();
            this.newGameButton = new System.Windows.Forms.Button();
            this.diceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox1)).BeginInit();
            this.scoreGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListDice
            // 
            this.imageListDice.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListDice.ImageStream")));
            this.imageListDice.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListDice.Images.SetKeyName(0, "1Die.bmp");
            this.imageListDice.Images.SetKeyName(1, "2Die.bmp");
            this.imageListDice.Images.SetKeyName(2, "3Die.bmp");
            this.imageListDice.Images.SetKeyName(3, "4Die.bmp");
            this.imageListDice.Images.SetKeyName(4, "5Die.bmp");
            this.imageListDice.Images.SetKeyName(5, "6Die.bmp");
            // 
            // diceGroupBox
            // 
            this.diceGroupBox.Controls.Add(this.rollsLeftCounterLabel);
            this.diceGroupBox.Controls.Add(this.rollsLeftLabel);
            this.diceGroupBox.Controls.Add(this.heldLabel5);
            this.diceGroupBox.Controls.Add(this.heldLabel4);
            this.diceGroupBox.Controls.Add(this.heldLabel3);
            this.diceGroupBox.Controls.Add(this.heldLabel2);
            this.diceGroupBox.Controls.Add(this.heldLabel1);
            this.diceGroupBox.Controls.Add(this.rollButton);
            this.diceGroupBox.Controls.Add(this.diePictureBox5);
            this.diceGroupBox.Controls.Add(this.diePictureBox4);
            this.diceGroupBox.Controls.Add(this.diePictureBox3);
            this.diceGroupBox.Controls.Add(this.diePictureBox2);
            this.diceGroupBox.Controls.Add(this.diePictureBox1);
            this.diceGroupBox.Location = new System.Drawing.Point(22, 22);
            this.diceGroupBox.Name = "diceGroupBox";
            this.diceGroupBox.Size = new System.Drawing.Size(680, 200);
            this.diceGroupBox.TabIndex = 0;
            this.diceGroupBox.TabStop = false;
            // 
            // rollsLeftCounterLabel
            // 
            this.rollsLeftCounterLabel.AutoSize = true;
            this.rollsLeftCounterLabel.Location = new System.Drawing.Point(620, 166);
            this.rollsLeftCounterLabel.Name = "rollsLeftCounterLabel";
            this.rollsLeftCounterLabel.Size = new System.Drawing.Size(0, 13);
            this.rollsLeftCounterLabel.TabIndex = 15;
            // 
            // rollsLeftLabel
            // 
            this.rollsLeftLabel.AutoSize = true;
            this.rollsLeftLabel.Location = new System.Drawing.Point(569, 166);
            this.rollsLeftLabel.Name = "rollsLeftLabel";
            this.rollsLeftLabel.Size = new System.Drawing.Size(54, 13);
            this.rollsLeftLabel.TabIndex = 14;
            this.rollsLeftLabel.Text = "Rolls Left:";
            // 
            // heldLabel5
            // 
            this.heldLabel5.AutoSize = true;
            this.heldLabel5.Location = new System.Drawing.Point(557, 138);
            this.heldLabel5.Name = "heldLabel5";
            this.heldLabel5.Size = new System.Drawing.Size(66, 13);
            this.heldLabel5.TabIndex = 10;
            this.heldLabel5.Text = "*** HELD ***";
            this.heldLabel5.Visible = false;
            // 
            // heldLabel4
            // 
            this.heldLabel4.AutoSize = true;
            this.heldLabel4.Location = new System.Drawing.Point(432, 138);
            this.heldLabel4.Name = "heldLabel4";
            this.heldLabel4.Size = new System.Drawing.Size(66, 13);
            this.heldLabel4.TabIndex = 9;
            this.heldLabel4.Text = "*** HELD ***";
            this.heldLabel4.Visible = false;
            // 
            // heldLabel3
            // 
            this.heldLabel3.AutoSize = true;
            this.heldLabel3.Location = new System.Drawing.Point(308, 138);
            this.heldLabel3.Name = "heldLabel3";
            this.heldLabel3.Size = new System.Drawing.Size(66, 13);
            this.heldLabel3.TabIndex = 8;
            this.heldLabel3.Text = "*** HELD ***";
            this.heldLabel3.Visible = false;
            // 
            // heldLabel2
            // 
            this.heldLabel2.AutoSize = true;
            this.heldLabel2.Location = new System.Drawing.Point(185, 138);
            this.heldLabel2.Name = "heldLabel2";
            this.heldLabel2.Size = new System.Drawing.Size(66, 13);
            this.heldLabel2.TabIndex = 7;
            this.heldLabel2.Text = "*** HELD ***";
            this.heldLabel2.Visible = false;
            // 
            // heldLabel1
            // 
            this.heldLabel1.AutoSize = true;
            this.heldLabel1.Location = new System.Drawing.Point(50, 138);
            this.heldLabel1.Name = "heldLabel1";
            this.heldLabel1.Size = new System.Drawing.Size(66, 13);
            this.heldLabel1.TabIndex = 6;
            this.heldLabel1.Text = "*** HELD ***";
            this.heldLabel1.Visible = false;
            // 
            // rollButton
            // 
            this.rollButton.Enabled = false;
            this.rollButton.Location = new System.Drawing.Point(40, 160);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(200, 25);
            this.rollButton.TabIndex = 5;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // diePictureBox5
            // 
            this.diePictureBox5.Location = new System.Drawing.Point(540, 35);
            this.diePictureBox5.Name = "diePictureBox5";
            this.diePictureBox5.Size = new System.Drawing.Size(100, 100);
            this.diePictureBox5.TabIndex = 4;
            this.diePictureBox5.TabStop = false;
            this.diePictureBox5.Click += new System.EventHandler(this.diePictureBox5_Click);
            // 
            // diePictureBox4
            // 
            this.diePictureBox4.Location = new System.Drawing.Point(415, 35);
            this.diePictureBox4.Name = "diePictureBox4";
            this.diePictureBox4.Size = new System.Drawing.Size(100, 100);
            this.diePictureBox4.TabIndex = 3;
            this.diePictureBox4.TabStop = false;
            this.diePictureBox4.Click += new System.EventHandler(this.diePictureBox4_Click);
            // 
            // diePictureBox3
            // 
            this.diePictureBox3.Location = new System.Drawing.Point(290, 35);
            this.diePictureBox3.Name = "diePictureBox3";
            this.diePictureBox3.Size = new System.Drawing.Size(100, 100);
            this.diePictureBox3.TabIndex = 2;
            this.diePictureBox3.TabStop = false;
            this.diePictureBox3.Click += new System.EventHandler(this.diePictureBox3_Click);
            // 
            // diePictureBox2
            // 
            this.diePictureBox2.Location = new System.Drawing.Point(165, 35);
            this.diePictureBox2.Name = "diePictureBox2";
            this.diePictureBox2.Size = new System.Drawing.Size(100, 100);
            this.diePictureBox2.TabIndex = 1;
            this.diePictureBox2.TabStop = false;
            this.diePictureBox2.Click += new System.EventHandler(this.diePictureBox2_Click);
            // 
            // diePictureBox1
            // 
            this.diePictureBox1.Location = new System.Drawing.Point(40, 35);
            this.diePictureBox1.Name = "diePictureBox1";
            this.diePictureBox1.Size = new System.Drawing.Size(100, 100);
            this.diePictureBox1.TabIndex = 0;
            this.diePictureBox1.TabStop = false;
            this.diePictureBox1.Click += new System.EventHandler(this.diePictureBox1_Click);
            // 
            // scoreGroupBox
            // 
            this.scoreGroupBox.Controls.Add(this.setButton2);
            this.scoreGroupBox.Controls.Add(this.setButton1);
            this.scoreGroupBox.Controls.Add(this.gameTotalCounterLabel);
            this.scoreGroupBox.Controls.Add(this.lowerTotalCounterLabel);
            this.scoreGroupBox.Controls.Add(this.bonusCounterLabel);
            this.scoreGroupBox.Controls.Add(this.upperTotalCounterLabel);
            this.scoreGroupBox.Controls.Add(this.gameTotalLabel);
            this.scoreGroupBox.Controls.Add(this.lowerTotalLabel);
            this.scoreGroupBox.Controls.Add(this.bonusLabel);
            this.scoreGroupBox.Controls.Add(this.upperTotalLabel);
            this.scoreGroupBox.Controls.Add(this.lowerScoringListBox);
            this.scoreGroupBox.Controls.Add(this.upperScoringListBox);
            this.scoreGroupBox.Location = new System.Drawing.Point(22, 228);
            this.scoreGroupBox.Name = "scoreGroupBox";
            this.scoreGroupBox.Size = new System.Drawing.Size(680, 200);
            this.scoreGroupBox.TabIndex = 1;
            this.scoreGroupBox.TabStop = false;
            // 
            // setButton2
            // 
            this.setButton2.Enabled = false;
            this.setButton2.Location = new System.Drawing.Point(600, 78);
            this.setButton2.Name = "setButton2";
            this.setButton2.Size = new System.Drawing.Size(50, 20);
            this.setButton2.TabIndex = 13;
            this.setButton2.Text = "Set";
            this.setButton2.UseVisualStyleBackColor = true;
            this.setButton2.Click += new System.EventHandler(this.lowerSetButton_Click);
            // 
            // setButton1
            // 
            this.setButton1.Enabled = false;
            this.setButton1.Location = new System.Drawing.Point(273, 78);
            this.setButton1.Name = "setButton1";
            this.setButton1.Size = new System.Drawing.Size(50, 20);
            this.setButton1.TabIndex = 12;
            this.setButton1.Text = "Set";
            this.setButton1.UseVisualStyleBackColor = true;
            this.setButton1.Click += new System.EventHandler(this.upperSetButton_Click);
            // 
            // gameTotalCounterLabel
            // 
            this.gameTotalCounterLabel.AutoSize = true;
            this.gameTotalCounterLabel.Location = new System.Drawing.Point(444, 171);
            this.gameTotalCounterLabel.Name = "gameTotalCounterLabel";
            this.gameTotalCounterLabel.Size = new System.Drawing.Size(13, 13);
            this.gameTotalCounterLabel.TabIndex = 11;
            this.gameTotalCounterLabel.Text = "0";
            // 
            // lowerTotalCounterLabel
            // 
            this.lowerTotalCounterLabel.AutoSize = true;
            this.lowerTotalCounterLabel.Location = new System.Drawing.Point(444, 147);
            this.lowerTotalCounterLabel.Name = "lowerTotalCounterLabel";
            this.lowerTotalCounterLabel.Size = new System.Drawing.Size(13, 13);
            this.lowerTotalCounterLabel.TabIndex = 10;
            this.lowerTotalCounterLabel.Text = "0";
            // 
            // bonusCounterLabel
            // 
            this.bonusCounterLabel.AutoSize = true;
            this.bonusCounterLabel.Location = new System.Drawing.Point(124, 171);
            this.bonusCounterLabel.Name = "bonusCounterLabel";
            this.bonusCounterLabel.Size = new System.Drawing.Size(13, 13);
            this.bonusCounterLabel.TabIndex = 9;
            this.bonusCounterLabel.Text = "0";
            // 
            // upperTotalCounterLabel
            // 
            this.upperTotalCounterLabel.AutoSize = true;
            this.upperTotalCounterLabel.Location = new System.Drawing.Point(124, 147);
            this.upperTotalCounterLabel.Name = "upperTotalCounterLabel";
            this.upperTotalCounterLabel.Size = new System.Drawing.Size(13, 13);
            this.upperTotalCounterLabel.TabIndex = 8;
            this.upperTotalCounterLabel.Text = "0";
            // 
            // gameTotalLabel
            // 
            this.gameTotalLabel.AutoSize = true;
            this.gameTotalLabel.Location = new System.Drawing.Point(351, 171);
            this.gameTotalLabel.Name = "gameTotalLabel";
            this.gameTotalLabel.Size = new System.Drawing.Size(65, 13);
            this.gameTotalLabel.TabIndex = 7;
            this.gameTotalLabel.Text = "Game Total:";
            // 
            // lowerTotalLabel
            // 
            this.lowerTotalLabel.AutoSize = true;
            this.lowerTotalLabel.Location = new System.Drawing.Point(351, 147);
            this.lowerTotalLabel.Name = "lowerTotalLabel";
            this.lowerTotalLabel.Size = new System.Drawing.Size(66, 13);
            this.lowerTotalLabel.TabIndex = 6;
            this.lowerTotalLabel.Text = "Lower Total:";
            // 
            // bonusLabel
            // 
            this.bonusLabel.AutoSize = true;
            this.bonusLabel.Location = new System.Drawing.Point(28, 171);
            this.bonusLabel.Name = "bonusLabel";
            this.bonusLabel.Size = new System.Drawing.Size(76, 13);
            this.bonusLabel.TabIndex = 5;
            this.bonusLabel.Text = "Bonus ( > 62 ):";
            // 
            // upperTotalLabel
            // 
            this.upperTotalLabel.AutoSize = true;
            this.upperTotalLabel.Location = new System.Drawing.Point(28, 147);
            this.upperTotalLabel.Name = "upperTotalLabel";
            this.upperTotalLabel.Size = new System.Drawing.Size(66, 13);
            this.upperTotalLabel.TabIndex = 4;
            this.upperTotalLabel.Text = "Upper Total:";
            // 
            // lowerScoringListBox
            // 
            this.lowerScoringListBox.Enabled = false;
            this.lowerScoringListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lowerScoringListBox.FormattingEnabled = true;
            this.lowerScoringListBox.ItemHeight = 15;
            this.lowerScoringListBox.Items.AddRange(new object[] {
            "Three of a Kind: ",
            "Four of a Kind: ",
            "Full House: ",
            "Small Straight: ",
            "Large Straight: ",
            "Yahtzee: ",
            "Chance: "});
            this.lowerScoringListBox.Location = new System.Drawing.Point(354, 19);
            this.lowerScoringListBox.Name = "lowerScoringListBox";
            this.lowerScoringListBox.Size = new System.Drawing.Size(240, 109);
            this.lowerScoringListBox.TabIndex = 1;
            this.lowerScoringListBox.SelectedIndexChanged += new System.EventHandler(this.lowerScoringListBox_SelectedIndexChanged);
            // 
            // upperScoringListBox
            // 
            this.upperScoringListBox.Enabled = false;
            this.upperScoringListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.upperScoringListBox.FormattingEnabled = true;
            this.upperScoringListBox.ItemHeight = 15;
            this.upperScoringListBox.Items.AddRange(new object[] {
            "Ones: ",
            "Twos: ",
            "Threes: ",
            "Fours: ",
            "Fives: ",
            "Sixes: "});
            this.upperScoringListBox.Location = new System.Drawing.Point(28, 19);
            this.upperScoringListBox.Name = "upperScoringListBox";
            this.upperScoringListBox.Size = new System.Drawing.Size(240, 109);
            this.upperScoringListBox.TabIndex = 0;
            this.upperScoringListBox.SelectedIndexChanged += new System.EventHandler(this.upperScoringListBox_SelectedIndexChanged);
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(709, 32);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(75, 23);
            this.newGameButton.TabIndex = 2;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.scoreGroupBox);
            this.Controls.Add(this.diceGroupBox);
            this.Name = "Form1";
            this.Text = "Moon Yahtzee";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.diceGroupBox.ResumeLayout(false);
            this.diceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox1)).EndInit();
            this.scoreGroupBox.ResumeLayout(false);
            this.scoreGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageListDice;
        private System.Windows.Forms.GroupBox diceGroupBox;
        private System.Windows.Forms.GroupBox scoreGroupBox;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.PictureBox diePictureBox5;
        private System.Windows.Forms.PictureBox diePictureBox4;
        private System.Windows.Forms.PictureBox diePictureBox3;
        private System.Windows.Forms.PictureBox diePictureBox2;
        private System.Windows.Forms.PictureBox diePictureBox1;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.ListBox upperScoringListBox;
        private System.Windows.Forms.ListBox lowerScoringListBox;
        private System.Windows.Forms.Label gameTotalCounterLabel;
        private System.Windows.Forms.Label lowerTotalCounterLabel;
        private System.Windows.Forms.Label bonusCounterLabel;
        private System.Windows.Forms.Label upperTotalCounterLabel;
        private System.Windows.Forms.Label gameTotalLabel;
        private System.Windows.Forms.Label lowerTotalLabel;
        private System.Windows.Forms.Label bonusLabel;
        private System.Windows.Forms.Label heldLabel1;
        private System.Windows.Forms.Label heldLabel5;
        private System.Windows.Forms.Label heldLabel4;
        private System.Windows.Forms.Label heldLabel3;
        private System.Windows.Forms.Label heldLabel2;
        private System.Windows.Forms.Button setButton1;
        private System.Windows.Forms.Button setButton2;
        private System.Windows.Forms.Label rollsLeftCounterLabel;
        private System.Windows.Forms.Label rollsLeftLabel;
        private System.Windows.Forms.Label upperTotalLabel;
    }
}

