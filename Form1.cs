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
        private PictureBox[] dicePictureBoxes;
        private Label[] heldLabels;

        private Hand hand;
        private Score score;

        public Form1()
        {
            InitializeComponent();
            setup();
        }

        private void setup()
        {
            dicePictureBoxes = new PictureBox[] { diePictureBox1, diePictureBox2, diePictureBox3, diePictureBox4, diePictureBox5 };
            heldLabels = new Label[] { heldLabel1, heldLabel2, heldLabel3, heldLabel4, heldLabel5 };
            hand = new Hand(imageListDice);
            score = new Score();
        }

        private void startNewGame()
        {
            // Reset counters
            resetScore();

            startNewRound();
        }

        private void startNewRound()
        {
            // Reset # of rolls left and update counter
            hand.resetRollsLeft();
            rollsLeftCounterLabel.Text = hand.RollsLeft.ToString();

            resetDice();
            rollButton.Enabled = true;
            setButton1.Enabled = false;
            setButton2.Enabled = false;
            scoringListBox1.Enabled = false;
            scoringListBox2.Enabled = false;
        }

        private void rollDice()
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
            hand.rollDice(diceToRoll);
            // Update rolls left counter
            rollsLeftCounterLabel.Text = hand.RollsLeft.ToString();
        }

        private void resetDice()
        {
            // Clear displayed dice images and enable the picturebox
            for (int i = 0; i < dicePictureBoxes.Length; i++)
            {
                if (!dicePictureBoxes[i].Enabled)
                    dicePictureBoxes[i].Enabled = true;
                // TODO: dispose does not actually clear the image. Instead, set to empty die (or skip this entirely)
                if (null != dicePictureBoxes[i].Image)
                    dicePictureBoxes[i].Image.Dispose();
            }

            // Reset 'held' labels
            foreach (Label label in heldLabels)
                label.Visible = false;
        }

        private void resetScore()
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

            // Reset score counters
            upperTotalCounterLabel.Text = "0";
            bonusCounterLabel.Text = "0";
            lowerTotalCounterLabel.Text = "0";
            gameTotalCounterLabel.Text = "0";
        }

        private void updateDiceImages()
        {
            Image[] dieImages = hand.getCurrentDieImages();
            for (int i = 0; i < dicePictureBoxes.Length; i++)
            {
                dicePictureBoxes[i].Image = dieImages[i];
            }
        }

        private void pauseRoundForScoring()
        {
            rollButton.Enabled = false;
            scoringListBox1.Enabled = true;
            scoringListBox2.Enabled = true;

            // disable picture boxes so the 'held' labels cannot be toggled during scoring
            foreach (PictureBox dicePictureBox in dicePictureBoxes)
                dicePictureBox.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            startNewGame();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            rollDice();
            updateDiceImages();

            // disable the roll button if there are no more rolls left in current round
            if (0 == hand.RollsLeft)
                pauseRoundForScoring();
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

        /// <summary>
        /// Event handler for the Set button connected to the Upper portion of Yahtzee scoring.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private void setButton1_Click(object sender, EventArgs e)
        {
            int points = 0;
            int[] diceValues = hand.getDieValues();

            if (0 == scoringListBox1.SelectedIndex)
            {
                points = score.scoreOnes(diceValues);
            }
            else if (1 == scoringListBox1.SelectedIndex)
            {
                points = score.scoreTwos(diceValues);
            }
            else if (2 == scoringListBox1.SelectedIndex)
            {
                points = score.scoreThrees(diceValues);
            }
            else if (3 == scoringListBox1.SelectedIndex)
            {
                points = score.scoreFours(diceValues);
            }
            else if (4 == scoringListBox1.SelectedIndex)
            {
                points = score.scoreFives(diceValues);
            }
            else if (5 == scoringListBox1.SelectedIndex)
            {
                points = score.scoreSixes(diceValues);
            }
            else 
                throw new ArgumentOutOfRangeException(
                    nameof(scoringListBox1.SelectedIndex),
                    scoringListBox1.SelectedIndex,
                    "SelectedIndex of scoringListBox1 is outside the range of valid values (0-5)");


            scoringListBox1.Items[scoringListBox1.SelectedIndex] += points.ToString();
            int newUpperTotal = int.Parse(upperTotalCounterLabel.Text) + points;
            upperTotalCounterLabel.Text = newUpperTotal.ToString();

            startNewRound();
        }

        /// <summary>
        /// Event handler for the Set button connected to the Lower portion of Yahtzee scoring.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private void setButton2_Click(object sender, EventArgs e)
        {
            int points = 0;
            int[] diceValues = hand.getDieValues();
            
            if (0 == scoringListBox2.SelectedIndex)
            {
                points = score.scoreThreeOfAKind(diceValues);
            }
            else if (1 == scoringListBox2.SelectedIndex)
            {
                points = score.scoreFourOfAKind(diceValues);
            }
            else if (2 == scoringListBox2.SelectedIndex)
            {
                points = score.scoreFullHouse(diceValues);
            }
            else if (3 == scoringListBox2.SelectedIndex)
            {
                points = score.scoreSmallStraight(diceValues);
            }
            else if (4 == scoringListBox2.SelectedIndex)
            {
                points = score.scoreLargeStraight(diceValues);
            }
            else if (5 == scoringListBox2.SelectedIndex)
            {
                points = score.scoreYahtzee(diceValues);
            }
            else if (6 == scoringListBox2.SelectedIndex)
            {
                points = score.scoreChance(diceValues);
            }
            else
                throw new ArgumentOutOfRangeException(
                    nameof(scoringListBox2.SelectedIndex),
                    scoringListBox2.SelectedIndex,
                    "SelectedIndex of scoringListBox2 is outside the range of valid values (0-6)");

            scoringListBox2.Items[scoringListBox2.SelectedIndex] += points.ToString();
            int newLowerTotal = int.Parse(lowerTotalCounterLabel.Text) + points;
            lowerTotalCounterLabel.Text = newLowerTotal.ToString();

            startNewRound();
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
