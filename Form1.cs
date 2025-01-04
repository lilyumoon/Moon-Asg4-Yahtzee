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

        /// <summary>
        /// Handles game logic for starting a new game and updates UI accordingly.
        /// </summary>
        private void startNewGame()
        {
            hand.resetRoundsRemaining();

            // Reset counters
            resetScore();

            if (gameOverLabel.Visible)
                gameOverLabel.Visible = false;

            startNewRound();
        }

        /// <summary>
        /// Handles game logic for starting a new round and updates UI accordingly.
        /// </summary>
        private void startNewRound()
        {
            hand.startNewRound();
            updateDiceImages();

            // Reset 'held' labels
            foreach (Label label in heldLabels)
                label.Visible = false;

            rollsLeftCounterLabel.Text = hand.RollsRemaining.ToString();
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
            rollsLeftCounterLabel.Text = hand.RollsRemaining.ToString();

            // If this was the last roll in the round, 'pause' for scoring
            if (hand.RollsRemaining == 0)
                pauseRoundForScoring();
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

        /// <summary>
        /// Updates the images displayed in each die picture box.
        /// </summary>
        private void updateDiceImages()
        {
            Image[] dieImages = hand.getDieImages();
            for (int i = 0; i < dicePictureBoxes.Length; i++)
            {
                dicePictureBoxes[i].Image = dieImages[i];
            }
        }

        /// <summary>
        /// Modifies UI interactability in order to force the player to select a scoring method before continuing.
        /// </summary>
        private void pauseRoundForScoring()
        {
            rollButton.Enabled = false;
            upperScoringListBox.Enabled = true;
            lowerScoringListBox.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the New Game button's Click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newGameButton_Click(object sender, EventArgs e)
        {
            startNewGame();
        }

        /// <summary>
        /// Event handler for the Roll button's click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rollButton_Click(object sender, EventArgs e)
        {
            rollDice();
            updateDiceImages();
        }

        /*
         * Event handlers for the dice picture boxes.
         */

        private void diePictureBox1_Click(object sender, EventArgs e) { toggleHoldState(0); }

        private void diePictureBox2_Click(object sender, EventArgs e) { toggleHoldState(1); }

        private void diePictureBox3_Click(object sender, EventArgs e) { toggleHoldState(2); }

        private void diePictureBox4_Click(object sender, EventArgs e) { toggleHoldState(3); }

        private void diePictureBox5_Click(object sender, EventArgs e) { toggleHoldState(4); }

        /// <summary>
        /// Toggles the 'held' state of a die, if the first roll has occurred
        /// and if there are any rolls remaining in the round.
        /// </summary>
        /// <param name="dieIndex">The index of the die to toggle</param>
        private void toggleHoldState(int dieIndex)
        {
            int rollsLeft = hand.RollsRemaining;

            if (rollsLeft < 3 && rollsLeft > 0)
                heldLabels[dieIndex].Visible = !heldLabels[dieIndex].Visible;
        }

        /// <summary>
        /// Event handler for the Upper Set button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private void upperSetButton_Click(object sender, EventArgs e)
        {
            int points = 0;
            int[] dieValues = hand.getDieValues();
            int selectedIndex = upperScoringListBox.SelectedIndex;

            // Determine the relevant scoring method to use and calculate points earned
            if (0 == selectedIndex)
                points = score.scoreOnes(dieValues);
            
            else if (1 == selectedIndex)
                points = score.scoreTwos(dieValues);
            
            else if (2 == selectedIndex)
                points = score.scoreThrees(dieValues);
            
            else if (3 == selectedIndex)
                points = score.scoreFours(dieValues);
            
            else if (4 == selectedIndex)
                points = score.scoreFives(dieValues);
            
            else if (5 == selectedIndex)
                points = score.scoreSixes(dieValues);
            
            else 
                throw new ArgumentOutOfRangeException(
                    nameof(upperScoringListBox.SelectedIndex),
                    upperScoringListBox.SelectedIndex,
                    "SelectedIndex of upperScoringListBox is outside the range of valid values (0-5)");

            // Update text in scoring box
            upperScoringListBox.Items[upperScoringListBox.SelectedIndex] += points.ToString();
            int newUpperTotal = int.Parse(upperTotalCounterLabel.Text) + points;
            upperTotalCounterLabel.Text = newUpperTotal.ToString();

            // If any points were earned this round, update game total points and check for bonus
            if (points > 0)
            {
                // Update game total
                increaseGameTotalPoints(points);

                // Check for bonus points
                checkForBonusPoints();
            }

            // If there are any rounds remaining in the game, start a new round.
            // Otherwise, show the 'game over' indicator.
            if (hand.RoundsRemaining > 0)
                startNewRound();
            else
                endGame();
        }

        private void endGame()
        {
            gameOverLabel.Visible = true;

            // If this game's score is higher than the highest score, update counter
            int gameTotalPoints = int.Parse(gameTotalCounterLabel.Text);
            int highScore = int.Parse(highScoreCounterLabel.Text);
            if (gameTotalPoints > highScore)
                highScoreCounterLabel.Text = gameTotalPoints.ToString();
        }

        /// <summary>
        /// Event handler for the Lower Set button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private void lowerSetButton_Click(object sender, EventArgs e)
        {
            int points = 0;
            int[] dieValues = hand.getDieValues();
            int selectedIndex = lowerScoringListBox.SelectedIndex;

            // Determine the relevant scoring method to use and calculate points earned
            if (0 == selectedIndex)
                points = score.scoreThreeOfAKind(dieValues);

            else if (1 == selectedIndex)
                points = score.scoreFourOfAKind(dieValues);

            else if (2 == selectedIndex)
                points = score.scoreFullHouse(dieValues);

            else if (3 == selectedIndex)
                points = score.scoreSmallStraight(dieValues);

            else if (4 == selectedIndex)
                points = score.scoreLargeStraight(dieValues);

            else if (5 == selectedIndex)
                points = score.scoreYahtzee(dieValues);

            else if (6 == selectedIndex)
                points = score.scoreChance(dieValues);

            else
                throw new ArgumentOutOfRangeException(
                    nameof(lowerScoringListBox.SelectedIndex),
                    lowerScoringListBox.SelectedIndex,
                    "SelectedIndex of lowerScoringListBox is outside the range of valid values (0-6)");

            // Update text in scoring box
            lowerScoringListBox.Items[lowerScoringListBox.SelectedIndex] += points.ToString();
            int newLowerTotal = int.Parse(lowerTotalCounterLabel.Text) + points;
            lowerTotalCounterLabel.Text = newLowerTotal.ToString();

            // If any points were earned this round, update game total points
            if (points > 0)
                increaseGameTotalPoints(points);

            // If there are any rounds remaining in the game, start a new round.
            // Otherwise, show the 'game over' indicator.
            if (hand.RoundsRemaining > 0)
                startNewRound();
            else
                endGame();
        }

        /// <summary>
        /// Checks the upper score to see if the bonus points should be added to the score.
        /// Adds (one-time only) 35 bonus points to the total game score if so.
        /// </summary>
        private void checkForBonusPoints()
        {
            // Only check for bonus points if they haven't already been added
            if (bonusCounterLabel.Text == "0")
            {
                // Get upper total. If 63 or greater, add bonus points
                int upperTotal = int.Parse(upperTotalCounterLabel.Text);
                if (upperTotal > 62)
                {
                    int bonusPoints = 35;
                    bonusCounterLabel.Text = bonusPoints.ToString();

                    increaseGameTotalPoints(bonusPoints);
                }
            }
        }

        /// <summary>
        /// Adds a specified number of points to game total points and updates the display.
        /// </summary>
        /// <param name="points">The number of points to add.</param>
        private void increaseGameTotalPoints(int points)
        {
            int gameTotalPoints = int.Parse(gameTotalCounterLabel.Text);
            gameTotalPoints += points;

            gameTotalCounterLabel.Text = gameTotalPoints.ToString();
        }

        /*
         * Event handlers for when the upper and lower listbox selected indices change.
         * 
         * Both:
         * Toggles the Enabled state of the related 'Set' button based on whether or not 
         * the scoring item has been used yet.
         */
        private void upperScoringListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (-1 != upperScoringListBox.SelectedIndex &&
                isSelectionAllowed(upperScoringListBox))
            {
                upperSetButton.Enabled = true;
            }
            else
                upperSetButton.Enabled = false;
        }

        private void lowerScoringListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (-1 != lowerScoringListBox.SelectedIndex &&
                isSelectionAllowed(lowerScoringListBox))
            {
                lowerSetButton.Enabled = true;
            }
            else
                lowerSetButton.Enabled = false;
        }

        /// <summary>
        /// Determines whether a selected scoring item can be used.
        /// </summary>
        /// <param name="parent">The listBox that the item belongs to (upper or lower)</param>
        /// <returns>True if scoring item has not yet been used.</returns>
        private bool isSelectionAllowed(ListBox parent)
        {
            bool isAllowed = false;
            int index = parent.SelectedIndex;

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
