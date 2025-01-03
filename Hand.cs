using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Moon_Asg4_Yahtzee
{
    internal class Hand
    {

        private Die[] dice;
        private ImageList dieImages;

        private int rollsLeft = -1;
        public int RollsLeft { get => rollsLeft; }

        public Hand(ImageList dieImages) {
            this.dieImages = dieImages;

            // Instantiate 5 new Dice objects and populate the dice array with them
            dice = new Die[5];
            for (int i = 0; i < dice.Length; i++)
                dice[i] = new Die(dieImages);
        }

        /// <summary>
        /// Rolls any dice not marked as 'held'.
        /// </summary>
        /// <param name="diceToRoll">A bool array indicating which dice to roll. (true -> roll)</param>
        public void rollDice(bool[] diceToRoll)
        {
            // Iterate through the dice to roll, and roll the die at that index if it should be rolled
            for (int i = 0; i < diceToRoll.Length; i++)
            {
                if (diceToRoll[i])
                    dice[i].rollDie();
            }
            rollsLeft -= 1;
        }

        public void resetRollsLeft()
        {
            rollsLeft = 3;
        }

        /// <summary>
        /// Gets an int array representing the values currently displayed on the dice.
        /// </summary>
        /// <returns>An array representing the dice values.</returns>
        public int[] getDieValues()
        {
            //var dieValues = Enumerable.Range(0, 5).Select(n => dice[n].Value).ToArray();
            int[] dieValues = new int[5];
            for (int i = 0; i < dieValues.Length; i++)
                dieValues[i] = dice[i].Value;
            return dieValues;
        }

        public Image[] getCurrentDieImages()
        {
            Image[] dieImages = new Image[5];
            for (int i = 0; i < dice.Length; i++)
            {
                dieImages[i] = dice[i].DieImage;
            }
            return dieImages;
        }

        

    }
}
