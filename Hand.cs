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
        /// Re-rolls all dice and sets 'rolls left' to 2.
        /// </summary>
        private void startNewRound()
        {
            for (int i = 0; i < dice.Length; i++)
                dice[i].rollDie();
            rollsLeft = 2;
        }

        /// <summary>
        /// Re-rolls any dice not marked as 'held'.
        /// </summary>
        /// <param name="heldStates">An array of bools indicating which dice should be held. (true -> hold)</param>
        public void rollDice(bool[] heldStates)
        {
            //Enumerable.Range(0, 5).ToList().ForEach(n => {
            //    if (!heldStates[n]) dice[n].rollDie(); 
            //});

            for (int i = 0; i < heldStates.Length; i++)
            {
                bool shouldReroll = !heldStates[i];
                if (shouldReroll)
                    dice[i].rollDie();
            }
            rollsLeft--;
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
