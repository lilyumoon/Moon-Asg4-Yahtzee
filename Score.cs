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
            bool hasThreeOfAKind = false;

            int[] numberOfEachDice = getNumberOfEachDice(diceValues);

            foreach (int i in numberOfEachDice)
            {
                if (i >= 3)
                    hasThreeOfAKind = true;
            }

            if (hasThreeOfAKind)
                points = getSumOfAllDice(diceValues);

            return points;
        }

        public int scoreFourOfAKind(int[] diceValues)
        {
            int points = 0;
            bool hasFourOfAKind = false;

            int[] numberOfEachDice = getNumberOfEachDice(diceValues);

            foreach (int i in numberOfEachDice)
            {
                if (i >= 4)
                    hasFourOfAKind = true;
            }

            if (hasFourOfAKind)
                points = getSumOfAllDice(diceValues);

            return points;
        }

        public int scoreFullHouse(int[] diceValues)
        {
            int points = 0;
            int[] numberOfEachDice = getNumberOfEachDice(diceValues);

            bool hasThreeOfAKind = false;
            bool hasTwoOfAKind = false;

            // If there are 3 of one kind and 2 of another kind, it's a full house
            foreach (int i in numberOfEachDice)
            {
                if (i == 3)
                    hasThreeOfAKind = true;
            }

            // Only check if there is a pair if there is already 3 of a kind
            if (hasThreeOfAKind)
            {
                foreach (int i in numberOfEachDice)
                {
                    if (i == 2)
                        hasTwoOfAKind = true;
                }
            }

            if (hasThreeOfAKind && hasTwoOfAKind)
                points += 25;

            return points;
        }

        public int scoreSmallStraight(int[] diceValues)
        {
            int points = 0;
            bool isSmallStraight = false;

            // Define small straight patterns
            int[] lowerSmallStraight = { 1, 2, 3, 4 };
            int[] middleSmallStraight = { 2, 3, 4, 5 };
            int[] upperSmallStraight = { 3, 4, 5, 6 };
            int[][] matchingPatterns = { lowerSmallStraight, middleSmallStraight, upperSmallStraight };

            // Ignore duplicate dice and arrange the values in ascending order
            int[] sortedUniqueDiceValues = diceValues.Distinct().OrderBy(x => x).ToArray();

            // Check if any small straight pattern is a subset of sorted dice values
            foreach (int[] pattern in matchingPatterns)
            {
                bool isMatch = true;
                
                foreach (int number in pattern)
                {
                    if (!sortedUniqueDiceValues.Contains(number))
                    {
                        isMatch = false;
                        break;
                    }
                }

                // If any pattern is a subset of sorted dice values, it's a small straight
                if (isMatch)
                    isSmallStraight = true;
            }

            if (isSmallStraight)
                points += 30;
            return points;
        }

        public int scoreLargeStraight(int[] diceValues)
        {
            int points = 0;
            bool isLargeStraight = false;

            // Define large straight patterns
            int[] lowerLargeStraight = { 1, 2, 3, 4, 5 };
            int[] upperLargeStraight = { 2, 3, 4, 5, 6 };
            int[][] matchingPatterns = { lowerLargeStraight, upperLargeStraight };

            // Ignore duplicate dice and arrange the values in ascending order
            int[] sortedUniqueDiceValues = diceValues.Distinct().OrderBy(x => x).ToArray();

            // Check if any large straight pattern matches the sorted dice values
            if (lowerLargeStraight.SequenceEqual(sortedUniqueDiceValues) ||
                upperLargeStraight.SequenceEqual(sortedUniqueDiceValues))
            {
                isLargeStraight = true;
            }

            if (isLargeStraight)
                points += 40;
            return points;
        }

        public int scoreYahtzee(int[] diceValues)
        {
            int points = 0;
            bool isYahtzee = false;

            int[] numberOfEachDice = getNumberOfEachDice(diceValues);

            // If there are 5 of any one die value, it's a Yahtzee
            foreach (int number in numberOfEachDice)
            {
                if (number == 5)
                    isYahtzee = true;
            }

            if (isYahtzee)
                points += 50;
            return points;
        }

        public int scoreChance(int[] diceValues)
        {
            int points = 0;

            int sumOfAllDice = getSumOfAllDice(diceValues);
            points += sumOfAllDice;

            return points;
        }

        private int[] getNumberOfEachDice(int[] diceValues)
        {
            // Create an array to map potential die values to
            // the number of current dice which match that value
            int[] numberOfEachDice = new int[6];

            // Iterate through each potential value of a die (1-6)
            for (int i = 1; i < 7; i++)
            {
                int count = 0;
                foreach (int dieValue in diceValues)
                {
                    // If the die value matches, increment count
                    if (dieValue == i)
                        count++;
                }

                // Store the number of dice that match the value of the current iteration
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

    }
}
