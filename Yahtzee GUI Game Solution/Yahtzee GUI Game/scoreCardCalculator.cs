using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_GUI_Game
{
    public class scoreCardCalculator
    {
        public int onesScore { get; private set; }
        public int twosScore { get; private set; }
        public int threesScore { get; private set; }
        public int foursScore { get; private set; }
        public int fivesScore { get; private set; }
        public int sixesScore { get; private set; }
        public int threeOfAKindScore { get; private set; }
        public int fourOfAKindScore { get; private set; }
        public int fullHouseScore { get; private set; }
        public int smallStraightScore { get; private set; }
        public int largeStraightScore { get; private set; }
        public int chanceScore { get; private set; }
        public int yahtzeeScore { get; private set; }

        public scoreCardCalculator(diceInterface dice)
        {
            //start all scores off at zero
            onesScore = 0;
            twosScore = 0;
            threesScore = 0;
            foursScore = 0;
            fivesScore = 0;
            sixesScore = 0;
            threeOfAKindScore = 0;
            fourOfAKindScore = 0;
            fullHouseScore = 0;
            smallStraightScore = 0;
            largeStraightScore = 0;
            chanceScore = 0;
            yahtzeeScore = 0;

            //calculates onesScore, twosScore, ..., sixesScore
            int numOnes = 0;
            int numTwos = 0;
            int numThrees = 0;
            int numFours = 0;
            int numFives = 0;
            int numSixes = 0;

            for (int i = 0; i < 5; ++i)
            {
                switch (dice.diceNumbers[i])
                {
                    case 1:
                        ++numOnes;
                        break;
                    case 2:
                        ++numTwos;
                        break;
                    case 3:
                        ++numThrees;
                        break;
                    case 4:
                        ++numFours;
                        break;
                    case 5:
                        ++numFives;
                        break;
                    case 6:
                        ++numSixes;
                        break;
                }
            }

            onesScore = numOnes;
            twosScore = numTwos * 2;
            threesScore = numThrees * 3;
            foursScore = numFours * 4;
            fivesScore = numFives * 5;
            sixesScore = numSixes * 6;


            //calculate threeOfAKindScore
            if (numOnes >= 3 || numTwos >= 3 || numThrees >= 3 ||
                 numFours >= 3 || numFives >= 3 || numSixes >= 3)
            {
                int sum = 0;

                for (int i = 0; i < 5; ++i)
                {
                    sum += dice.diceNumbers[i];
                }

                threeOfAKindScore = sum;
            }

            //calculate fourOfAKindScore
            if (numOnes >= 4 || numTwos >= 4 || numThrees >= 4 ||
                 numFours >= 4 || numFives >= 4 || numSixes >= 4)
            {
                int sum = 0;

                for (int i = 0; i < 5; ++i)
                {
                    sum += dice.diceNumbers[i];
                }

                fourOfAKindScore = sum;
            }

            //calculate yahtzeeScore
            if (numOnes == 5 || numTwos == 5 || numThrees == 5 ||
                 numFours == 5 || numFives == 5 || numSixes == 5)
            {
                yahtzeeScore = 50;
            }

            //calculate chanceScore
            for (int i = 0; i < 5; ++i)
            {
                chanceScore += dice.diceNumbers[i];
            }

            //calculate small straight score
            if ((numOnes >= 1 && numTwos >= 1 && numThrees >= 1 && numFours >= 1) ||
                (numTwos >= 1 && numThrees >= 1 && numFours >= 1 && numFives >= 1) ||
                (numThrees >= 1 && numFours >= 1 && numFives >= 1 && numSixes >= 1))
            {
                smallStraightScore = 30;
            }

            //calculate large straight score
            if ((numOnes == 1 && numTwos == 1 && numThrees == 1 && numFours == 1 && numFives == 1) ||
                (numTwos == 1 && numThrees == 1 && numFours == 1 && numFives == 1 && numSixes == 1))
            {
                largeStraightScore = 40;
            }

            //calculate full house score
            int[] numberOfEachNumber = new int[6];
            numberOfEachNumber[0] = numOnes;
            numberOfEachNumber[1] = numTwos;
            numberOfEachNumber[2] = numThrees;
            numberOfEachNumber[3] = numFours;
            numberOfEachNumber[4] = numFives;
            numberOfEachNumber[5] = numSixes;

            for (int i = 0; i < 6; ++i)
            {
                if (numberOfEachNumber[i] == 3)
                {
                    for (int j = 0; j < 6; ++j)
                    {
                        if (numberOfEachNumber[j] == 2)
                        {
                            fullHouseScore = 25;
                        }
                    }
                }
            }

        }
    }
}
