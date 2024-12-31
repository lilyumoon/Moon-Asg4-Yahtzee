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
            this.imageListDice = new System.Windows.Forms.ImageList(this.components);
            this.diceGroupBox = new System.Windows.Forms.GroupBox();
            this.scoreGroupBox = new System.Windows.Forms.GroupBox();
            this.diePictureBox1 = new System.Windows.Forms.PictureBox();
            this.diePictureBox2 = new System.Windows.Forms.PictureBox();
            this.diePictureBox3 = new System.Windows.Forms.PictureBox();
            this.diePictureBox4 = new System.Windows.Forms.PictureBox();
            this.diePictureBox5 = new System.Windows.Forms.PictureBox();
            this.rollButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.scoreBlockLeftLB = new System.Windows.Forms.ListBox();
            this.scoreBlockRightLB = new System.Windows.Forms.ListBox();
            this.setButton1 = new System.Windows.Forms.Button();
            this.setButton2 = new System.Windows.Forms.Button();
            this.upperTotalLabel = new System.Windows.Forms.Label();
            this.bonusLabel = new System.Windows.Forms.Label();
            this.lowerTotalLabel = new System.Windows.Forms.Label();
            this.gameTotalLabel = new System.Windows.Forms.Label();
            this.upperTotalCounterLabel = new System.Windows.Forms.Label();
            this.bonusCounterLabel = new System.Windows.Forms.Label();
            this.lowerTotalCounterLabel = new System.Windows.Forms.Label();
            this.gameTotalCounterLabel = new System.Windows.Forms.Label();
            this.diceGroupBox.SuspendLayout();
            this.scoreGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // imageListDice
            // 
            this.imageListDice.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListDice.ImageSize = new System.Drawing.Size(100, 100);
            this.imageListDice.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // diceGroupBox
            // 
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
            // scoreGroupBox
            // 
            this.scoreGroupBox.Controls.Add(this.gameTotalCounterLabel);
            this.scoreGroupBox.Controls.Add(this.lowerTotalCounterLabel);
            this.scoreGroupBox.Controls.Add(this.bonusCounterLabel);
            this.scoreGroupBox.Controls.Add(this.upperTotalCounterLabel);
            this.scoreGroupBox.Controls.Add(this.gameTotalLabel);
            this.scoreGroupBox.Controls.Add(this.lowerTotalLabel);
            this.scoreGroupBox.Controls.Add(this.bonusLabel);
            this.scoreGroupBox.Controls.Add(this.upperTotalLabel);
            this.scoreGroupBox.Controls.Add(this.setButton2);
            this.scoreGroupBox.Controls.Add(this.setButton1);
            this.scoreGroupBox.Controls.Add(this.scoreBlockRightLB);
            this.scoreGroupBox.Controls.Add(this.scoreBlockLeftLB);
            this.scoreGroupBox.Location = new System.Drawing.Point(22, 228);
            this.scoreGroupBox.Name = "scoreGroupBox";
            this.scoreGroupBox.Size = new System.Drawing.Size(680, 200);
            this.scoreGroupBox.TabIndex = 1;
            this.scoreGroupBox.TabStop = false;
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
            // diePictureBox2
            // 
            this.diePictureBox2.Location = new System.Drawing.Point(165, 35);
            this.diePictureBox2.Name = "diePictureBox2";
            this.diePictureBox2.Size = new System.Drawing.Size(100, 100);
            this.diePictureBox2.TabIndex = 1;
            this.diePictureBox2.TabStop = false;
            this.diePictureBox2.Click += new System.EventHandler(this.diePictureBox2_Click);
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
            // diePictureBox4
            // 
            this.diePictureBox4.Location = new System.Drawing.Point(415, 35);
            this.diePictureBox4.Name = "diePictureBox4";
            this.diePictureBox4.Size = new System.Drawing.Size(100, 100);
            this.diePictureBox4.TabIndex = 3;
            this.diePictureBox4.TabStop = false;
            this.diePictureBox4.Click += new System.EventHandler(this.diePictureBox4_Click);
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
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(40, 160);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(200, 25);
            this.rollButton.TabIndex = 5;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
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
            // scoreBlockLeftLB
            // 
            this.scoreBlockLeftLB.FormattingEnabled = true;
            this.scoreBlockLeftLB.Location = new System.Drawing.Point(40, 19);
            this.scoreBlockLeftLB.Name = "scoreBlockLeftLB";
            this.scoreBlockLeftLB.Size = new System.Drawing.Size(225, 121);
            this.scoreBlockLeftLB.TabIndex = 0;
            // 
            // scoreBlockRightLB
            // 
            this.scoreBlockRightLB.FormattingEnabled = true;
            this.scoreBlockRightLB.Location = new System.Drawing.Point(366, 19);
            this.scoreBlockRightLB.Name = "scoreBlockRightLB";
            this.scoreBlockRightLB.Size = new System.Drawing.Size(225, 121);
            this.scoreBlockRightLB.TabIndex = 1;
            // 
            // setButton1
            // 
            this.setButton1.Location = new System.Drawing.Point(271, 71);
            this.setButton1.Name = "setButton1";
            this.setButton1.Size = new System.Drawing.Size(75, 23);
            this.setButton1.TabIndex = 2;
            this.setButton1.Text = "Set";
            this.setButton1.UseVisualStyleBackColor = true;
            // 
            // setButton2
            // 
            this.setButton2.Location = new System.Drawing.Point(597, 71);
            this.setButton2.Name = "setButton2";
            this.setButton2.Size = new System.Drawing.Size(75, 23);
            this.setButton2.TabIndex = 3;
            this.setButton2.Text = "Set";
            this.setButton2.UseVisualStyleBackColor = true;
            // 
            // upperTotalLabel
            // 
            this.upperTotalLabel.AutoSize = true;
            this.upperTotalLabel.Location = new System.Drawing.Point(40, 147);
            this.upperTotalLabel.Name = "upperTotalLabel";
            this.upperTotalLabel.Size = new System.Drawing.Size(66, 13);
            this.upperTotalLabel.TabIndex = 4;
            this.upperTotalLabel.Text = "Upper Total:";
            // 
            // bonusLabel
            // 
            this.bonusLabel.AutoSize = true;
            this.bonusLabel.Location = new System.Drawing.Point(40, 171);
            this.bonusLabel.Name = "bonusLabel";
            this.bonusLabel.Size = new System.Drawing.Size(76, 13);
            this.bonusLabel.TabIndex = 5;
            this.bonusLabel.Text = "Bonus ( > 62 ):";
            // 
            // lowerTotalLabel
            // 
            this.lowerTotalLabel.AutoSize = true;
            this.lowerTotalLabel.Location = new System.Drawing.Point(363, 147);
            this.lowerTotalLabel.Name = "lowerTotalLabel";
            this.lowerTotalLabel.Size = new System.Drawing.Size(66, 13);
            this.lowerTotalLabel.TabIndex = 6;
            this.lowerTotalLabel.Text = "Lower Total:";
            // 
            // gameTotalLabel
            // 
            this.gameTotalLabel.AutoSize = true;
            this.gameTotalLabel.Location = new System.Drawing.Point(363, 171);
            this.gameTotalLabel.Name = "gameTotalLabel";
            this.gameTotalLabel.Size = new System.Drawing.Size(65, 13);
            this.gameTotalLabel.TabIndex = 7;
            this.gameTotalLabel.Text = "Game Total:";
            // 
            // upperTotalCounterLabel
            // 
            this.upperTotalCounterLabel.AutoSize = true;
            this.upperTotalCounterLabel.Location = new System.Drawing.Point(136, 147);
            this.upperTotalCounterLabel.Name = "upperTotalCounterLabel";
            this.upperTotalCounterLabel.Size = new System.Drawing.Size(13, 13);
            this.upperTotalCounterLabel.TabIndex = 8;
            this.upperTotalCounterLabel.Text = "0";
            // 
            // bonusCounterLabel
            // 
            this.bonusCounterLabel.AutoSize = true;
            this.bonusCounterLabel.Location = new System.Drawing.Point(136, 171);
            this.bonusCounterLabel.Name = "bonusCounterLabel";
            this.bonusCounterLabel.Size = new System.Drawing.Size(13, 13);
            this.bonusCounterLabel.TabIndex = 9;
            this.bonusCounterLabel.Text = "0";
            // 
            // lowerTotalCounterLabel
            // 
            this.lowerTotalCounterLabel.AutoSize = true;
            this.lowerTotalCounterLabel.Location = new System.Drawing.Point(456, 147);
            this.lowerTotalCounterLabel.Name = "lowerTotalCounterLabel";
            this.lowerTotalCounterLabel.Size = new System.Drawing.Size(13, 13);
            this.lowerTotalCounterLabel.TabIndex = 10;
            this.lowerTotalCounterLabel.Text = "0";
            // 
            // gameTotalCounterLabel
            // 
            this.gameTotalCounterLabel.AutoSize = true;
            this.gameTotalCounterLabel.Location = new System.Drawing.Point(456, 171);
            this.gameTotalCounterLabel.Name = "gameTotalCounterLabel";
            this.gameTotalCounterLabel.Size = new System.Drawing.Size(13, 13);
            this.gameTotalCounterLabel.TabIndex = 11;
            this.gameTotalCounterLabel.Text = "0";
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
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.diceGroupBox.ResumeLayout(false);
            this.scoreGroupBox.ResumeLayout(false);
            this.scoreGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diePictureBox5)).EndInit();
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
        private System.Windows.Forms.ListBox scoreBlockLeftLB;
        private System.Windows.Forms.Button setButton2;
        private System.Windows.Forms.Button setButton1;
        private System.Windows.Forms.ListBox scoreBlockRightLB;
        private System.Windows.Forms.Label gameTotalCounterLabel;
        private System.Windows.Forms.Label lowerTotalCounterLabel;
        private System.Windows.Forms.Label bonusCounterLabel;
        private System.Windows.Forms.Label upperTotalCounterLabel;
        private System.Windows.Forms.Label gameTotalLabel;
        private System.Windows.Forms.Label lowerTotalLabel;
        private System.Windows.Forms.Label bonusLabel;
        private System.Windows.Forms.Label upperTotalLabel;
    }
}

