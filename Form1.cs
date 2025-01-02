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
        }

        private void resetGame()
        {
            // Iterate through each item in the scoring boxes, split the strings at the ':',
            //   and set the item to be the first half of the split string
            for (int i = 0; i < scoringListBox1.Items.Count; i++)
            {
                string resetText = scoringListBox1.Items[i].ToString().Split(':')[0];
                scoringListBox1.Items[i] = resetText;
            }
            for (int i = 0; i < scoringListBox2.Items.Count; i++)
            {
                string resetText = scoringListBox2.Items[i].ToString().Split(':')[0];
                scoringListBox2.Items[i] = resetText;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            resetGame();
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

        private void setButton1_Click(object sender, EventArgs e)
        {
            if (0 == scoringListBox1.SelectedIndex)
            {

            }
            else if (1 == scoringListBox1.SelectedIndex)
            {

            }
            else if (2 == scoringListBox1.SelectedIndex)
            {

            }
            else if (3 == scoringListBox1.SelectedIndex)
            {

            }
            else if (4 == scoringListBox1.SelectedIndex)
            {

            }
            else if (5 == scoringListBox1.SelectedIndex)
            {

            }
            else 
                throw new ArgumentOutOfRangeException(
                    nameof(scoringListBox1.SelectedIndex),
                    scoringListBox1.SelectedIndex,
                    "SelectedIndex of scoringListBox1 is outside the range of valid values (0-5)");
        }

        private void setButton2_Click(object sender, EventArgs e)
        {
            if (0 == scoringListBox2.SelectedIndex)
            {

            }
            else if (1 == scoringListBox2.SelectedIndex)
            {

            }
            else if (2 == scoringListBox2.SelectedIndex)
            {

            }
            else if (3 == scoringListBox2.SelectedIndex)
            {

            }
            else if (4 == scoringListBox2.SelectedIndex)
            {

            }
            else if (5 == scoringListBox2.SelectedIndex)
            {

            }
            else if (6 == scoringListBox2.SelectedIndex)
            {

            }
            else
                throw new ArgumentOutOfRangeException(
                    nameof(scoringListBox2.SelectedIndex),
                    scoringListBox2.SelectedIndex,
                    "SelectedIndex of scoringListBox2 is outside the range of valid values (0-6)");
        }
    }
}
