using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moon_Asg4_Yahtzee
{
    public partial class Form1 : Form
    {
        private Label[] heldLabels = new Label[5];

        private Hand hand;

        public Form1()
        {
            InitializeComponent();
            setup();
        }

        private void setup()
        {
            heldLabels = new Label[] { heldLabel1, heldLabel2, heldLabel3, heldLabel4, heldLabel5 };
            clearHeldDice();
        }

        private void clearHeldDice()
        {
            foreach (Label label in heldLabels)
                label.Visible = false;
        }

        private void resetGame()
        {
            // Iterate through each item in the scoring boxes and save
            // the portion before and including the ': '. Discaard the rest.
            for (int i = 0; i < scoringListBox1.Items.Count; i++)
            {
                int splitIndex = scoringListBox1.Items[i].ToString().IndexOf(':');
                string resetText = scoringListBox1.Items[i].ToString().Substring(0, splitIndex + 2);
                scoringListBox1.Items[i] = resetText;
            }
            for (int i = 0; i < scoringListBox2.Items.Count; i++)
            {
                int splitIndex = scoringListBox2.Items[i].ToString().IndexOf(':');
                string resetText = scoringListBox2.Items[i].ToString().Substring(0, splitIndex + 2);
                scoringListBox2.Items[i] = resetText;
            }

            // Reset any 'held' labels and counters.
            clearHeldDice();
            upperTotalCounterLabel.Text = "0";
            bonusCounterLabel.Text = "0";
            lowerTotalCounterLabel.Text = "0";
            gameTotalCounterLabel.Text = "0";
        }

        private void rollDice(bool isNewRound)
        {
            // Find which dice should be rolled.
            bool[] diceToRoll = new bool[5];
            for (int i = 0; i < heldLabels.Length; i++)
            {
                // If the die is not being held, it should be rolled
                if (!heldLabels[i].Visible)
                    diceToRoll[i] = true;
            }
            // Tell the hand to roll those dice.
            hand.rollDice(diceToRoll, isNewRound);
        }

        private void updateDiceImages()
        {

        }

        private void newRound()
        {
            clearHeldDice();
            rollDice(true);
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
            rollDice(false);
            updateDiceImages();

            // disable the roll button if there are no more rolls left in round
            if (0 == hand.RollsLeft)
                rollButton.Enabled = false;
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
            rollButton.Enabled = true;
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
            rollButton.Enabled = true;
        }

        private void scoringListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (-1 != scoringListBox1.SelectedIndex &&
                isItemAllowed(scoringListBox1, scoringListBox1.SelectedIndex))
            {
                setButton1.Enabled = true;
            }
            else
                setButton1.Enabled = false;
        }

        private void scoringListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (-1 != scoringListBox2.SelectedIndex &&
                isItemAllowed(scoringListBox2, scoringListBox2.SelectedIndex))
            {
                setButton2.Enabled = true;
            }
            else
                setButton2.Enabled = false;
        }

        private bool isItemAllowed(ListBox parent, int index)
        {
            bool isAllowed = false;

            int splitIndex = parent.Items[index].ToString().IndexOf(':');
            string resetText = parent.Items[index].ToString().Substring(0, splitIndex + 2);

            // If the current item's text matches what the text would be in the item's 'reset state',
            // it should be allowed
            if (parent.Items[index].ToString().Length == resetText.Length)
                isAllowed = true;

            return isAllowed;
        }
    }
}
