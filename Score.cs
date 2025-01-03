using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moon_Asg4_Yahtzee
{
    internal class Score
    {

        public Score()
        {

        }

        public int scoreOnes(int[] diceValues)
        {
            int points = 0;

            foreach (int i in diceValues)
            {
                if (1 == i)
                    points += i;
            }

            return points;
        }

        public int scoreTwos(int[] diceValues)
        {
            int points = 0;

            foreach (int i in diceValues)
            {
                if (2 == i)
                    points += i;
            }

            return points;
        }

        public int scoreThrees(int[] diceValues)
        {
            int points = 0;

            foreach (int i in diceValues)
            {
                if (3 == i)
                    points += i;
            }

            return points;
        }

        public int scoreFours(int[] diceValues)
        {
            int points = 0;

            foreach (int i in diceValues)
            {
                if (4 == i)
                    points += i;
            }

            return points;
        }

        public int scoreFives(int[] diceValues)
        {
            int points = 1;

            foreach (int i in diceValues)
            {
                if (5 == i)
                    points += i;
            }

            return points;
        }

        public int scoreSixes(int[] diceValues)
        {
            int points = 0;

            foreach (int i in diceValues)
            {
                if (6 == i)
                    points += i;
            }

            return points;
        }

        public int scoreThreeOfAKind(int[] diceValues)
        {
            int points = 0;

            int[] numberOfEachDice = getNumberOfEachDice(diceValues);

            foreach (int i in numberOfEachDice)
            {
                if (i >= 3)
                    points = getSumOfAllDice(diceValues);
            }

            return points;
        }

        private int[] getNumberOfEachDice(int[] diceValues)
        {
            int[] numberOfEachDice = new int[6];

            for (int i = 1; i < 7; i++)
            {
                int count = 0;
                foreach (int dieValue in diceValues)
                {
                    if (dieValue == i)
                        count++;
                }
                numberOfEachDice[i - 1] = count;
            }

            return numberOfEachDice;
        }

        private int getSumOfAllDice(int[] diceValues)
        {
            int sum = 0;

            foreach (int dieValue in diceValues)
            {
                sum += dieValue;
            }

            return sum;
        }

        public int scoreFourOfAKind(int[] diceValues)
        {
            int points = 0;

            return points;
        }

        public int scoreFullHouse(int[] diceValues)
        {
            int points = 0;

            return points;
        }

        public int scoreSmallStraight(int[] diceValues)
        {
            int points = 0;

            return points;
        }

        public int scoreLargeStraight(int[] diceValues)
        {
            int points = 0;

            return points;
        }

        public int scoreYahtzee(int[] diceValues)
        {
            int points = 0;

            return points;
        }

        public int scoreChance(int[] diceValues)
        {
            int points = 0;

            return points;
        }
    }
}
