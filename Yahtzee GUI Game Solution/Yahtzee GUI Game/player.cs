using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_GUI_Game
{
    public class player
    {
        public setOfDice playersSetOfDice;
        public scoreCardCalculator playersScoreCardCalculator;
        public int rollsLeft;
        public int turnsLeft;
        public List<int> diceThatareHeld;
        public int playersOnesScore;
        public bool playersOnesScoreIsSet;
        public int playersTwosScore;
        public bool playersTwosScoreIsSet;
        public int playersThreesScore;
        public bool playersThreesScoreIsSet;
        public int playersFoursScore;
        public bool playersFoursScoreIsSet;
        public int playersFivesScore;
        public bool playersFivesScoreIsSet;
        public int playersSixesScore;
        public bool playersSixesScoreIsSet;
        public int playersThreeOfAKindScore;
        public bool playersThreeOfAKindScoreIsSet;
        public int playersFourOfAKindScore;
        public bool playersFourOfAKindScoreIsSet;
        public int playersFullHouseScore;
        public bool playersFullHouseScoreIsSet;
        public int playersSmallStraightScore;
        public bool playersSmallStraightScoreIsSet;
        public int playersLargeStraightScore;
        public bool playersLargeStraightScoreIsSet;
        public int playersChanceScore;
        public bool playersChanceScoreIsSet;
        public int playersYahtzeeScore;
        public bool playersYahtzeeScoreIsSet;
        public int playersSum;
        public int playersBonus;
        public int playersTotalScore;

        public player()
        {
            playersSetOfDice = new setOfDice();
            playersScoreCardCalculator = new scoreCardCalculator(playersSetOfDice);
            rollsLeft = 3;
            diceThatareHeld = new List<int>();
            playersOnesScore = 0;
            playersOnesScoreIsSet = false;
            playersTwosScore = 0;
            playersTwosScoreIsSet = false;
            playersThreesScore = 0;
            playersThreesScoreIsSet = false;
            playersFoursScore = 0;
            playersFoursScoreIsSet = false;
            playersFivesScore = 0;
            playersFivesScoreIsSet = false;
            playersSixesScore = 0;
            playersSixesScoreIsSet = false;
            playersThreeOfAKindScore = 0;
            playersThreeOfAKindScoreIsSet = false;
            playersFourOfAKindScore = 0;
            playersFourOfAKindScoreIsSet = false;
            playersFullHouseScore = 0;
            playersFullHouseScoreIsSet = false;
            playersSmallStraightScore = 0;
            playersSmallStraightScoreIsSet = false;
            playersLargeStraightScore = 0;
            playersLargeStraightScoreIsSet = false;
            playersChanceScore = 0;
            playersChanceScoreIsSet = false;
            playersYahtzeeScore = 0;
            playersYahtzeeScoreIsSet = false;
            playersTotalScore = 0;
            playersSum = 0;
            playersBonus = 0;
        }

        public void calculateTotalScore()
        {
            playersTotalScore = playersOnesScore + playersTwosScore + playersThreesScore
            + playersFoursScore + playersFivesScore + playersSixesScore + playersBonus
            + playersThreeOfAKindScore + playersFourOfAKindScore + playersFullHouseScore
            + playersSmallStraightScore + playersLargeStraightScore + playersChanceScore
            + playersYahtzeeScore;
        }
    }
}
