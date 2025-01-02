using System;
using System.Collections.Generic;
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
        public int RollsLeft { get; }

        public Hand(ImageList dieImages) {         
            this.dieImages = dieImages;

            dice = new Die[5];
            for (int i = 0; i < dice.Length; i++)
                dice[i] = new Die(dieImages);
        }

        /// <summary>
        /// Rolls any dice not marked as 'held'.
        /// </summary>
        /// <param name="diceToRoll">A bool array indicating which dice to roll. (true -> roll)</param>
        /// <param name="isNewRound">True if new round.</param>
        public void rollDice(bool[] diceToRoll, bool isNewRound)
        {
            // Iterate through the dice to roll, and roll the die at that index if it should be rolled

            //Enumerable.Range(0, 5).ToList().ForEach(n => {
            //    if (diceToRoll[n]) dice[n].rollDie(); 
            //});

            for (int i = 0; i < diceToRoll.Length; i++)
            {
                if (diceToRoll[i])
                    dice[i].rollDie();
            }
            if (isNewRound)
                rollsLeft = 2;
            else
                rollsLeft -= 1;
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

        

    }
}
