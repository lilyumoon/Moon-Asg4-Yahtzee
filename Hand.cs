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

        private void startNewRound()
        {
            for (int i = 0; i < dice.Length; i++)
                dice[i].rollDie();
            rollsLeft = 2;
        }

        /// <summary>
        /// Re-rolls any dice not marked as 'held'.
        /// </summary>
        /// <param name="dieIndices">An array containing the indices of dice to replace</param>
        public void rollDice(int[] dieIndices)
        {
            if (0 != dieIndices.Length)
                foreach (int i in dieIndices)
                    dice[i].rollDie();
            rollsLeft--;
        }
        
        /// <summary>
        /// Replaces the die at a specified position in dieList with a new die, given that there is already a die in that position.
        /// </summary>
        /// <param name="newDie">The new Card object to replace the old Card object with.</param>
        public void rollDie(int dieIndex)
        {
            if (null != dice.ElementAtOrDefault(dieIndex))
                dice[dieIndex].rollDie();
        }

        public int[] getDieValues()
        {
            int[] dieValues = new int[5];
            for (int i = 0; i < dieValues.Length; i++)
                dieValues[i] = dice[i].Value;
            return dieValues;
        }

        

    }
}
