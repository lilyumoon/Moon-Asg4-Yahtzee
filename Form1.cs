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
            upperSetButton.Enabled = false;
            lowerSetButton.Enabled = false;
            upperScoringListBox.Enabled = false;
            lowerScoringListBox.Enabled = false;
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

            // Tell hand to roll those dice.
            hand.rollDice(diceToRoll);

            // Update rolls left counter
            rollsLeftCounterLabel.Text = hand.RollsLeft.ToString();

            // If this was the last roll in the round, 'pause' for scoring
            if (hand.RollsLeft == 0)
                pauseRoundForScoring();
        }

        private void resetDice()
        {
            // Clear displayed dice images and enable the picturebox
            for (int i = 0; i < dicePictureBoxes.Length; i++)
            {
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
            for (int i = 0; i < upperScoringListBox.Items.Count; i++)
            {
                int splitIndex = upperScoringListBox.Items[i].ToString().IndexOf(':');
                string resetText = upperScoringListBox.Items[i].ToString().Substring(0, splitIndex + 2);
                upperScoringListBox.Items[i] = resetText;
            }
            for (int i = 0; i < lowerScoringListBox.Items.Count; i++)
            {
                int splitIndex = lowerScoringListBox.Items[i].ToString().IndexOf(':');
                string resetText = lowerScoringListBox.Items[i].ToString().Substring(0, splitIndex + 2);
                lowerScoringListBox.Items[i] = resetText;
            }

            // Reset score counters
            upperTotalCounterLabel.Text = "0";
            bonusCounterLabel.Text = "0";
            lowerTotalCounterLabel.Text = "0";
            gameTotalCounterLabel.Text = "0";
        }

        private void updateDiceImages()
        {
            Image[] dieImages = hand.getDieImages();
            for (int i = 0; i < dicePictureBoxes.Length; i++)
            {
                dicePictureBoxes[i].Image = dieImages[i];
            }
        }

        private void pauseRoundForScoring()
        {
            rollButton.Enabled = false;
            upperScoringListBox.Enabled = true;
            lowerScoringListBox.Enabled = true;
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
        }

        private void diePictureBox1_Click(object sender, EventArgs e) { toggleHoldState(0); }

        private void diePictureBox2_Click(object sender, EventArgs e) { toggleHoldState(1); }

        private void diePictureBox3_Click(object sender, EventArgs e) { toggleHoldState(2); }

        private void diePictureBox4_Click(object sender, EventArgs e) { toggleHoldState(3); }

        private void diePictureBox5_Click(object sender, EventArgs e) { toggleHoldState(4); }

        /// <summary>
        /// Toggles the 'held' state of a die, if the first roll has occurred,
        /// and if there are any rolls remaining in the round.
        /// </summary>
        /// <param name="dieIndex"></param>
        private void toggleHoldState(int dieIndex)
        {
            int rollsLeft = hand.RollsLeft;

            if (rollsLeft < 3 && rollsLeft > 0)
                heldLabels[dieIndex].Visible = !heldLabels[dieIndex].Visible;
        }

        /// <summary>
        /// Event handler for the Set button connected to the Upper portion of Yahtzee scoring.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private void upperSetButton_Click(object sender, EventArgs e)
        {
            int points = 0;
            int[] dieValues = hand.getDieValues();

            if (0 == upperScoringListBox.SelectedIndex)
                points = score.scoreOnes(dieValues);
            
            else if (1 == upperScoringListBox.SelectedIndex)
                points = score.scoreTwos(dieValues);
            
            else if (2 == upperScoringListBox.SelectedIndex)
                points = score.scoreThrees(dieValues);
            
            else if (3 == upperScoringListBox.SelectedIndex)
                points = score.scoreFours(dieValues);
            
            else if (4 == upperScoringListBox.SelectedIndex)
                points = score.scoreFives(dieValues);
            
            else if (5 == upperScoringListBox.SelectedIndex)
                points = score.scoreSixes(dieValues);
            
            else 
                throw new ArgumentOutOfRangeException(
                    nameof(upperScoringListBox.SelectedIndex),
                    upperScoringListBox.SelectedIndex,
                    "SelectedIndex of scoringListBox1 is outside the range of valid values (0-5)");


            upperScoringListBox.Items[upperScoringListBox.SelectedIndex] += points.ToString();
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
        private void lowerSetButton_Click(object sender, EventArgs e)
        {
            int points = 0;
            int[] dieValues = hand.getDieValues();
            
            if (0 == lowerScoringListBox.SelectedIndex)
                points = score.scoreThreeOfAKind(dieValues);

            else if (1 == lowerScoringListBox.SelectedIndex)
                points = score.scoreFourOfAKind(dieValues);

            else if (2 == lowerScoringListBox.SelectedIndex)
                points = score.scoreFullHouse(dieValues);

            else if (3 == lowerScoringListBox.SelectedIndex)
                points = score.scoreSmallStraight(dieValues);

            else if (4 == lowerScoringListBox.SelectedIndex)
                points = score.scoreLargeStraight(dieValues);
            
            else if (5 == lowerScoringListBox.SelectedIndex)
                points = score.scoreYahtzee(dieValues);

            else if (6 == lowerScoringListBox.SelectedIndex)
                points = score.scoreChance(dieValues);

            else
                throw new ArgumentOutOfRangeException(
                    nameof(lowerScoringListBox.SelectedIndex),
                    lowerScoringListBox.SelectedIndex,
                    "SelectedIndex of scoringListBox2 is outside the range of valid values (0-6)");

            lowerScoringListBox.Items[lowerScoringListBox.SelectedIndex] += points.ToString();
            int newLowerTotal = int.Parse(lowerTotalCounterLabel.Text) + points;
            lowerTotalCounterLabel.Text = newLowerTotal.ToString();

            startNewRound();
        }

        private void upperScoringListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (-1 != upperScoringListBox.SelectedIndex &&
                isSelectionAllowed(upperScoringListBox, upperScoringListBox.SelectedIndex))
            {
                upperSetButton.Enabled = true;
            }
            else
                upperSetButton.Enabled = false;
        }

        private void lowerScoringListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (-1 != lowerScoringListBox.SelectedIndex &&
                isSelectionAllowed(lowerScoringListBox, lowerScoringListBox.SelectedIndex))
            {
                lowerSetButton.Enabled = true;
            }
            else
                lowerSetButton.Enabled = false;
        }

        private bool isSelectionAllowed(ListBox parent, int index)
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
