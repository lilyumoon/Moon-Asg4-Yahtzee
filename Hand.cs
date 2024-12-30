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

        private List<Die> dice;

        public Hand(ImageList dieImages)
        {
            dice = new List<Die>()
            {
                new Die(dieImages),
                new Die(dieImages),
                new Die(dieImages),
                new Die(dieImages),
                new Die(dieImages),
            };
        }

        /// <summary>
        /// Replaces the die at a specified position in dieList with a new die, given that there is already a die in that position.
        /// </summary>
        /// <param name="newDie">The new Card object to replace the old Card object with.</param>
        public void replaceDie(int dieIndex)
        {
            if (null != dice.ElementAtOrDefault(dieIndex))
                dice[dieIndex].rollDie();
        }

        //public int[] getDieArray()
        //{
        //    int[] dieArray = new int[5];
        //    for (int i = 0; i < dice.Count; i++)
        //        dieArray[i] = dice[i].Value;
        //    return dieArray;
        //}

    }
}
