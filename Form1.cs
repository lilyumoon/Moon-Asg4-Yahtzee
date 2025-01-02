using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moon_Asg4_Yahtzee
{
    public partial class Form1 : Form
    {
        private Label[] heldLabels = new Label[5];

        public Form1()
        {
            InitializeComponent();
            setup();
        }

        private void setup()
        {
            heldLabels = new Label[] { heldLabel1,  heldLabel2, heldLabel3, heldLabel4, heldLabel5 };
            foreach (Label label in heldLabels)
                label.Visible = false;

            new ScoringItem(scoringListBox1, "Ones: ");
            new ScoringItem(scoringListBox1, "Twos: ");
            new ScoringItem(scoringListBox1, "Threes: ");
            new ScoringItem(scoringListBox1, "Fours: ");
            new ScoringItem(scoringListBox1, "Fives: ");
            new ScoringItem(scoringListBox1, "Sixes: ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newGameButton_Click(object sender, EventArgs e)
        {

        }

        private void rollButton_Click(object sender, EventArgs e)
        {

        }

        private void diePictureBox1_Click(object sender, EventArgs e) { toggleHoldState(0); }

        private void diePictureBox2_Click(object sender, EventArgs e) { toggleHoldState(1); }

        private void diePictureBox3_Click(object sender, EventArgs e) { toggleHoldState(2); }

        private void diePictureBox4_Click(object sender, EventArgs e) { toggleHoldState(3); }

        private void diePictureBox5_Click(object sender, EventArgs e) { toggleHoldState(4); }

        private void toggleHoldState(int dieIndex)
        {
            heldLabels[dieIndex].Visible = !heldLabels[dieIndex].Visible;
        }


    }
}
