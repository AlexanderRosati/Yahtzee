using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_GUI_Game
{
    public partial class Yahtzee : Form
    {
        private player player;
        private bool canHold;
        private PictureBox[] pictureboxes;
        private bool sumAndBonusCalculated;

        public Yahtzee()
        {
            InitializeComponent();
            List<int> tmp = new List<int>();
            canHold = false;
            sumAndBonusCalculated = false;
            player = new player();
            player.playersSetOfDice.roll(tmp);
            pictureboxes = new PictureBox[5];
            pictureboxes[0] = dice1;
            pictureboxes[1] = dice2;
            pictureboxes[2] = dice3;
            pictureboxes[3] = dice4;
            pictureboxes[4] = dice5;

            for (int i = 0; i < 5; ++i)
            {
                switch (player.playersSetOfDice.diceNumbers[i])
                {
                    case 1:
                        pictureboxes[i].Image = Properties.Resources.D1;
                        break;
                    case 2:
                        pictureboxes[i].Image = Properties.Resources.D2;
                        break;
                    case 3:
                        pictureboxes[i].Image = Properties.Resources.D3;
                        break;
                    case 4:
                        pictureboxes[i].Image = Properties.Resources.D4;
                        break;
                    case 5:
                        pictureboxes[i].Image = Properties.Resources.D5;
                        break;
                    case 6:
                        pictureboxes[i].Image = Properties.Resources.D6;
                        break;
                }
            }
           
            onesLable.Text = String.Empty;
            twosLabel.Text = String.Empty;
            threesLabel.Text = String.Empty;
            foursLabel.Text = String.Empty;
            fivesLabel.Text = String.Empty;
            sixesLabel.Text = String.Empty;
            threeOfAKindLabel.Text = String.Empty;
            fourOfAKindLabel.Text = String.Empty;
            fullHouseLabel.Text = String.Empty;
            smallStraightLabel.Text = String.Empty;
            largeStraightLabel.Text = String.Empty;
            yahtzeeLabel.Text = String.Empty;
            sumLabel.Text = String.Empty;
            bonusLabel.Text = String.Empty;
            chanceLabel.Text = String.Empty;
            totalScoreLabel.Text = String.Empty;
            endMessageLabel.Text = String.Empty;
            
            
        }

        private void moveDiceOut()
        {
            Point diceLocation = new Point();
            diceLocation.X = 74;
            diceLocation.Y = 257;
            dice1.Location = diceLocation;

            diceLocation.X = 150;
            dice2.Location = diceLocation;

            diceLocation.X = 226;
            dice3.Location = diceLocation;

            diceLocation.X = 302;
            dice4.Location = diceLocation;

            diceLocation.X = 378;
            dice5.Location = diceLocation;
        }

        private void testForSumAndBonus()
        {
            if (player.playersOnesScoreIsSet && player.playersTwosScoreIsSet &&
                player.playersThreesScoreIsSet && player.playersFoursScoreIsSet &&
                player.playersFivesScoreIsSet && player.playersSixesScoreIsSet &&
                !sumAndBonusCalculated)
            {
                player.playersSum += player.playersOnesScore;
                player.playersSum += player.playersTwosScore;
                player.playersSum += player.playersThreesScore;
                player.playersSum += player.playersFoursScore;
                player.playersSum += player.playersFivesScore;
                player.playersSum += player.playersSixesScore;

                if (player.playersSum >= 63)
                {
                    player.playersBonus = 35;
                }

                sumLabel.Text = $"{player.playersSum}";
                bonusLabel.Text = $"{player.playersBonus}";
                sumAndBonusCalculated = true;
            }
        }

        private void testToSeeIfGameIsOver()
        {
            if (player.playersOnesScoreIsSet && player.playersTwosScoreIsSet &&
                player.playersThreesScoreIsSet && player.playersFoursScoreIsSet &&
                player.playersFivesScoreIsSet && player.playersSixesScoreIsSet &&
                player.playersThreeOfAKindScoreIsSet && player.playersFourOfAKindScoreIsSet &&
                player.playersChanceScoreIsSet && player.playersYahtzeeScoreIsSet &&
                player.playersSmallStraightScoreIsSet && player.playersLargeStraightScoreIsSet &&
                player.playersFullHouseScoreIsSet)
            {
                moveDiceIn();
                player.calculateTotalScore();
                endMessageLabel.Text = $"Thank you\nfor playing\nmy game!!!\nTotal Score: {player.playersTotalScore}";
                totalScoreLabel.Text = $"{player.playersTotalScore}";
                player.rollsLeft = 0;
                canHold = false;
            }
        }

        private void moveDiceIn()
        {
            Point diceLocation = new Point();
            diceLocation.X = 74;
            diceLocation.Y = 457;
            dice1.Location = diceLocation;

            diceLocation.X = 150;
            dice2.Location = diceLocation;

            diceLocation.X = 226;
            dice3.Location = diceLocation;

            diceLocation.X = 302;
            dice4.Location = diceLocation;

            diceLocation.X = 378;
            dice5.Location = diceLocation;
        }
    

        private void rollButton_Click(object sender, EventArgs e)
        {
            if (player.rollsLeft > 0)
            {              
                //stop player from rolling if they are holding all of their dice
                if (player.diceThatareHeld.Contains(1) && player.diceThatareHeld.Contains(2) &&
                    player.diceThatareHeld.Contains(3) && player.diceThatareHeld.Contains(4) &&
                    player.diceThatareHeld.Contains(5))
                {
                    MessageBox.Show("You cannot roll if you are holding all of the dice.");
                    return;
                }

                //move all dice to indicate they are not being held
                if (player.rollsLeft == 3)
                {
                    moveDiceOut();
                }

                //decrement counters
                --player.rollsLeft;

                //allow player to hold dice
                if (canHold == false)
                {
                    canHold = true;
                }

                //roll dice that are not held
                player.playersSetOfDice.roll(player.diceThatareHeld);

                for (int i = 0; i < 5; ++i)
                {
                    switch (player.playersSetOfDice.diceNumbers[i])
                    {
                        case 1:
                            pictureboxes[i].Image = Properties.Resources.D1;
                            break;
                        case 2:
                            pictureboxes[i].Image = Properties.Resources.D2;
                            break;
                        case 3:
                            pictureboxes[i].Image = Properties.Resources.D3;
                            break;
                        case 4:
                            pictureboxes[i].Image = Properties.Resources.D4;
                            break;
                        case 5:
                            pictureboxes[i].Image = Properties.Resources.D5;
                            break;
                        case 6:
                            pictureboxes[i].Image = Properties.Resources.D6;
                            break;
                    }
                }

                player.playersScoreCardCalculator = new scoreCardCalculator(player.playersSetOfDice); 

                if (!player.playersOnesScoreIsSet) onesLable.Text = $"{player.playersScoreCardCalculator.onesScore}";
                if (!player.playersTwosScoreIsSet) twosLabel.Text = $"{player.playersScoreCardCalculator.twosScore}";
                if (!player.playersThreesScoreIsSet) threesLabel.Text = $"{player.playersScoreCardCalculator.threesScore}";
                if (!player.playersFoursScoreIsSet) foursLabel.Text = $"{player.playersScoreCardCalculator.foursScore}";
                if (!player.playersFivesScoreIsSet) fivesLabel.Text = $"{player.playersScoreCardCalculator.fivesScore}";
                if (!player.playersSixesScoreIsSet) sixesLabel.Text = $"{player.playersScoreCardCalculator.sixesScore}";
                if (!player.playersThreeOfAKindScoreIsSet) threeOfAKindLabel.Text = $"{player.playersScoreCardCalculator.threeOfAKindScore}";
                if (!player.playersFourOfAKindScoreIsSet) fourOfAKindLabel.Text = $"{player.playersScoreCardCalculator.fourOfAKindScore}";
                if (!player.playersFullHouseScoreIsSet) fullHouseLabel.Text = $"{player.playersScoreCardCalculator.fullHouseScore}";
                if (!player.playersYahtzeeScoreIsSet) yahtzeeLabel.Text = $"{player.playersScoreCardCalculator.yahtzeeScore}";
                if (!player.playersChanceScoreIsSet) chanceLabel.Text = $"{player.playersScoreCardCalculator.chanceScore}";
                if (!player.playersSmallStraightScoreIsSet) smallStraightLabel.Text = $"{player.playersScoreCardCalculator.smallStraightScore}";
                if (!player.playersLargeStraightScoreIsSet) largeStraightLabel.Text = $"{player.playersScoreCardCalculator.largeStraightScore}";
            }
        }

        private void dice5_Click(object sender, EventArgs e)
        {
            if (canHold && player.rollsLeft != 3)
            {
                Point diceLocation = new Point();
                diceLocation.X = 378;

                if (dice5.Location.Y == 257)
                {
                    diceLocation.Y = 457;
                    dice5.Location = diceLocation;
                    player.diceThatareHeld.Add(5);
                }

                else
                {
                    diceLocation.Y = 257;
                    dice5.Location = diceLocation;
                    player.diceThatareHeld.Remove(5);
                }
            }
        }

        private void dice1_Click(object sender, EventArgs e)
        {
            if (canHold && player.rollsLeft != 3)
            {
                Point diceLocation = new Point();
                diceLocation.X = 74;

                if (dice1.Location.Y == 257)
                { 
                    diceLocation.Y = 457;
                    dice1.Location = diceLocation;
                    player.diceThatareHeld.Add(1);
                }

                else
                {
                    diceLocation.Y = 257;
                    dice1.Location = diceLocation;
                    player.diceThatareHeld.Remove(1);
                }
            }
        }

        private void dice2_Click(object sender, EventArgs e)
        {
            if (canHold && player.rollsLeft != 3)
            {
                Point diceLocation = new Point();
                diceLocation.X = 150;

                if (dice2.Location.Y == 257)
                {
                    diceLocation.Y = 457;
                    dice2.Location = diceLocation;
                    player.diceThatareHeld.Add(2);
                }

                else
                {
                    diceLocation.Y = 257;
                    dice2.Location = diceLocation;
                    player.diceThatareHeld.Remove(2);
                }
            }
        }

        private void dice3_Click(object sender, EventArgs e)
        {
            if (canHold && player.rollsLeft != 3)
            {
                Point diceLocation = new Point();
                diceLocation.X = 226;

                if (dice3.Location.Y == 257)
                {
                    diceLocation.Y = 457;
                    dice3.Location = diceLocation;
                    player.diceThatareHeld.Add(3);
                }

                else
                {
                    diceLocation.Y = 257;
                    dice3.Location = diceLocation;
                    player.diceThatareHeld.Remove(3);
                }
            }
        }

        private void dice4_Click(object sender, EventArgs e)
        {
            if (canHold && player.rollsLeft != 3)
            {
                Point diceLocation = new Point();
                diceLocation.X = 302;

                if (dice4.Location.Y == 257)
                {
                    diceLocation.Y = 457;
                    dice4.Location = diceLocation;
                    player.diceThatareHeld.Add(4);
                }

                else
                {
                    diceLocation.Y = 257;
                    dice4.Location = diceLocation;
                    player.diceThatareHeld.Remove(4);
                }
            }
        }

        private void onesLable_Click(object sender, EventArgs e)
        {
            if (player.rollsLeft < 3 && !player.playersOnesScoreIsSet)
            {
                moveDiceIn(); 
                onesLable.ForeColor = Color.Black;
                player.rollsLeft = 3;
                player.playersOnesScore = player.playersScoreCardCalculator.onesScore;
                player.playersOnesScoreIsSet = true;

                if (!player.playersOnesScoreIsSet) onesLable.Text = String.Empty;
                if (!player.playersTwosScoreIsSet) twosLabel.Text = String.Empty;
                if (!player.playersThreesScoreIsSet) threesLabel.Text = String.Empty;
                if (!player.playersFoursScoreIsSet) foursLabel.Text = String.Empty;
                if (!player.playersFivesScoreIsSet) fivesLabel.Text = String.Empty;
                if (!player.playersSixesScoreIsSet) sixesLabel.Text = String.Empty;
                if (!player.playersThreeOfAKindScoreIsSet) threeOfAKindLabel.Text = String.Empty;
                if (!player.playersFourOfAKindScoreIsSet) fourOfAKindLabel.Text = String.Empty;
                if (!player.playersFullHouseScoreIsSet) fullHouseLabel.Text = String.Empty;
                if (!player.playersYahtzeeScoreIsSet) yahtzeeLabel.Text = String.Empty;
                if (!player.playersChanceScoreIsSet) chanceLabel.Text = String.Empty;
                if (!player.playersSmallStraightScoreIsSet) smallStraightLabel.Text = String.Empty;
                if (!player.playersLargeStraightScoreIsSet) largeStraightLabel.Text = String.Empty;

                player.diceThatareHeld.Clear();
                testForSumAndBonus();
                testToSeeIfGameIsOver();
            }
        }

        private void twosLabel_Click(object sender, EventArgs e)
        {
            if (player.rollsLeft < 3 && !player.playersTwosScoreIsSet)
            {
                moveDiceIn();
                twosLabel.ForeColor = Color.Black;
                player.rollsLeft = 3;
                player.playersTwosScore = player.playersScoreCardCalculator.twosScore;
                player.playersTwosScoreIsSet = true;

                if (!player.playersOnesScoreIsSet) onesLable.Text = String.Empty;
                if (!player.playersTwosScoreIsSet) twosLabel.Text = String.Empty;
                if (!player.playersThreesScoreIsSet) threesLabel.Text = String.Empty;
                if (!player.playersFoursScoreIsSet) foursLabel.Text = String.Empty;
                if (!player.playersFivesScoreIsSet) fivesLabel.Text = String.Empty;
                if (!player.playersSixesScoreIsSet) sixesLabel.Text = String.Empty;
                if (!player.playersThreeOfAKindScoreIsSet) threeOfAKindLabel.Text = String.Empty;
                if (!player.playersFourOfAKindScoreIsSet) fourOfAKindLabel.Text = String.Empty;
                if (!player.playersFullHouseScoreIsSet) fullHouseLabel.Text = String.Empty;
                if (!player.playersYahtzeeScoreIsSet) yahtzeeLabel.Text = String.Empty;
                if (!player.playersChanceScoreIsSet) chanceLabel.Text = String.Empty;
                if (!player.playersSmallStraightScoreIsSet) smallStraightLabel.Text = String.Empty;
                if (!player.playersLargeStraightScoreIsSet) largeStraightLabel.Text = String.Empty;

                player.diceThatareHeld.Clear();
                testForSumAndBonus();
                testToSeeIfGameIsOver();
            }
        }

        private void threesLabel_Click(object sender, EventArgs e)
        {
            if (player.rollsLeft < 3 && !player.playersThreesScoreIsSet)
            {
                moveDiceIn();
                threesLabel.ForeColor = Color.Black;
                player.rollsLeft = 3;
                player.playersThreesScore = player.playersScoreCardCalculator.threesScore;
                player.playersThreesScoreIsSet = true;

                if (!player.playersOnesScoreIsSet) onesLable.Text = String.Empty;
                if (!player.playersTwosScoreIsSet) twosLabel.Text = String.Empty;
                if (!player.playersThreesScoreIsSet) threesLabel.Text = String.Empty;
                if (!player.playersFoursScoreIsSet) foursLabel.Text = String.Empty;
                if (!player.playersFivesScoreIsSet) fivesLabel.Text = String.Empty;
                if (!player.playersSixesScoreIsSet) sixesLabel.Text = String.Empty;
                if (!player.playersThreeOfAKindScoreIsSet) threeOfAKindLabel.Text = String.Empty;
                if (!player.playersFourOfAKindScoreIsSet) fourOfAKindLabel.Text = String.Empty;
                if (!player.playersFullHouseScoreIsSet) fullHouseLabel.Text = String.Empty;
                if (!player.playersYahtzeeScoreIsSet) yahtzeeLabel.Text = String.Empty;
                if (!player.playersChanceScoreIsSet) chanceLabel.Text = String.Empty;
                if (!player.playersSmallStraightScoreIsSet) smallStraightLabel.Text = String.Empty;
                if (!player.playersLargeStraightScoreIsSet) largeStraightLabel.Text = String.Empty;

                player.diceThatareHeld.Clear();
                testForSumAndBonus();
                testToSeeIfGameIsOver();
            }
        }

        private void foursLabel_Click(object sender, EventArgs e)
        {
            if (player.rollsLeft < 3 && !player.playersFoursScoreIsSet)
            {
                moveDiceIn();
                foursLabel.ForeColor = Color.Black;
                player.rollsLeft = 3;
                player.playersFoursScore = player.playersScoreCardCalculator.foursScore;
                player.playersFoursScoreIsSet = true;

                if (!player.playersOnesScoreIsSet) onesLable.Text = String.Empty;
                if (!player.playersTwosScoreIsSet) twosLabel.Text = String.Empty;
                if (!player.playersThreesScoreIsSet) threesLabel.Text = String.Empty;
                if (!player.playersFoursScoreIsSet) foursLabel.Text = String.Empty;
                if (!player.playersFivesScoreIsSet) fivesLabel.Text = String.Empty;
                if (!player.playersSixesScoreIsSet) sixesLabel.Text = String.Empty;
                if (!player.playersThreeOfAKindScoreIsSet) threeOfAKindLabel.Text = String.Empty;
                if (!player.playersFourOfAKindScoreIsSet) fourOfAKindLabel.Text = String.Empty;
                if (!player.playersFullHouseScoreIsSet) fullHouseLabel.Text = String.Empty;
                if (!player.playersYahtzeeScoreIsSet) yahtzeeLabel.Text = String.Empty;
                if (!player.playersChanceScoreIsSet) chanceLabel.Text = String.Empty;
                if (!player.playersSmallStraightScoreIsSet) smallStraightLabel.Text = String.Empty;
                if (!player.playersLargeStraightScoreIsSet) largeStraightLabel.Text = String.Empty;

                player.diceThatareHeld.Clear();
                testForSumAndBonus();
                testToSeeIfGameIsOver();
            }
        }

        private void fivesLabel_Click(object sender, EventArgs e)
        {
            if (player.rollsLeft < 3 && !player.playersFivesScoreIsSet)
            {
                moveDiceIn();
                fivesLabel.ForeColor = Color.Black;
                player.rollsLeft = 3;
                player.playersFivesScore = player.playersScoreCardCalculator.fivesScore;
                player.playersFivesScoreIsSet = true;

                if (!player.playersOnesScoreIsSet) onesLable.Text = String.Empty;
                if (!player.playersTwosScoreIsSet) twosLabel.Text = String.Empty;
                if (!player.playersThreesScoreIsSet) threesLabel.Text = String.Empty;
                if (!player.playersFoursScoreIsSet) foursLabel.Text = String.Empty;
                if (!player.playersFivesScoreIsSet) fivesLabel.Text = String.Empty;
                if (!player.playersSixesScoreIsSet) sixesLabel.Text = String.Empty;
                if (!player.playersThreeOfAKindScoreIsSet) threeOfAKindLabel.Text = String.Empty;
                if (!player.playersFourOfAKindScoreIsSet) fourOfAKindLabel.Text = String.Empty;
                if (!player.playersFullHouseScoreIsSet) fullHouseLabel.Text = String.Empty;
                if (!player.playersYahtzeeScoreIsSet) yahtzeeLabel.Text = String.Empty;
                if (!player.playersChanceScoreIsSet) chanceLabel.Text = String.Empty;
                if (!player.playersSmallStraightScoreIsSet) smallStraightLabel.Text = String.Empty;
                if (!player.playersLargeStraightScoreIsSet) largeStraightLabel.Text = String.Empty;

                player.diceThatareHeld.Clear();
                testForSumAndBonus();
                testToSeeIfGameIsOver();
            }
        }

        private void sixesLabel_Click(object sender, EventArgs e)
        {
            if (player.rollsLeft < 3 && !player.playersSixesScoreIsSet)
            {
                moveDiceIn();
                sixesLabel.ForeColor = Color.Black;
                player.rollsLeft = 3;
                player.playersSixesScore = player.playersScoreCardCalculator.sixesScore;
                player.playersSixesScoreIsSet = true;

                if (!player.playersOnesScoreIsSet) onesLable.Text = String.Empty;
                if (!player.playersTwosScoreIsSet) twosLabel.Text = String.Empty;
                if (!player.playersThreesScoreIsSet) threesLabel.Text = String.Empty;
                if (!player.playersFoursScoreIsSet) foursLabel.Text = String.Empty;
                if (!player.playersFivesScoreIsSet) fivesLabel.Text = String.Empty;
                if (!player.playersSixesScoreIsSet) sixesLabel.Text = String.Empty;
                if (!player.playersThreeOfAKindScoreIsSet) threeOfAKindLabel.Text = String.Empty;
                if (!player.playersFourOfAKindScoreIsSet) fourOfAKindLabel.Text = String.Empty;
                if (!player.playersFullHouseScoreIsSet) fullHouseLabel.Text = String.Empty;
                if (!player.playersYahtzeeScoreIsSet) yahtzeeLabel.Text = String.Empty;
                if (!player.playersChanceScoreIsSet) chanceLabel.Text = String.Empty;
                if (!player.playersSmallStraightScoreIsSet) smallStraightLabel.Text = String.Empty;
                if (!player.playersLargeStraightScoreIsSet) largeStraightLabel.Text = String.Empty;

                player.diceThatareHeld.Clear();
                testForSumAndBonus();
                testToSeeIfGameIsOver();
            }
        }

        private void threeOfAKindLabel_Click(object sender, EventArgs e)
        {
            if (player.rollsLeft < 3 && !player.playersThreeOfAKindScoreIsSet)
            {
                moveDiceIn();
                threeOfAKindLabel.ForeColor = Color.Black;
                player.rollsLeft = 3;
                player.playersThreeOfAKindScore = player.playersScoreCardCalculator.threeOfAKindScore;
                player.playersThreeOfAKindScoreIsSet = true;

                if (!player.playersOnesScoreIsSet) onesLable.Text = String.Empty;
                if (!player.playersTwosScoreIsSet) twosLabel.Text = String.Empty;
                if (!player.playersThreesScoreIsSet) threesLabel.Text = String.Empty;
                if (!player.playersFoursScoreIsSet) foursLabel.Text = String.Empty;
                if (!player.playersFivesScoreIsSet) fivesLabel.Text = String.Empty;
                if (!player.playersSixesScoreIsSet) sixesLabel.Text = String.Empty;
                if (!player.playersThreeOfAKindScoreIsSet) threeOfAKindLabel.Text = String.Empty;
                if (!player.playersFourOfAKindScoreIsSet) fourOfAKindLabel.Text = String.Empty;
                if (!player.playersFullHouseScoreIsSet) fullHouseLabel.Text = String.Empty;
                if (!player.playersYahtzeeScoreIsSet) yahtzeeLabel.Text = String.Empty;
                if (!player.playersChanceScoreIsSet) chanceLabel.Text = String.Empty;
                if (!player.playersSmallStraightScoreIsSet) smallStraightLabel.Text = String.Empty;
                if (!player.playersLargeStraightScoreIsSet) largeStraightLabel.Text = String.Empty;

                player.diceThatareHeld.Clear();
                testForSumAndBonus();
                testToSeeIfGameIsOver();
            }
        }

        private void fourOfAKindLabel_Click(object sender, EventArgs e)
        {
            if (player.rollsLeft < 3 && !player.playersFourOfAKindScoreIsSet)
            {
                moveDiceIn();
                fourOfAKindLabel.ForeColor = Color.Black;
                player.rollsLeft = 3;
                player.playersFourOfAKindScore = player.playersScoreCardCalculator.fourOfAKindScore;
                player.playersFourOfAKindScoreIsSet = true;

                if (!player.playersOnesScoreIsSet) onesLable.Text = String.Empty;
                if (!player.playersTwosScoreIsSet) twosLabel.Text = String.Empty;
                if (!player.playersThreesScoreIsSet) threesLabel.Text = String.Empty;
                if (!player.playersFoursScoreIsSet) foursLabel.Text = String.Empty;
                if (!player.playersFivesScoreIsSet) fivesLabel.Text = String.Empty;
                if (!player.playersSixesScoreIsSet) sixesLabel.Text = String.Empty;
                if (!player.playersThreeOfAKindScoreIsSet) threeOfAKindLabel.Text = String.Empty;
                if (!player.playersFourOfAKindScoreIsSet) fourOfAKindLabel.Text = String.Empty;
                if (!player.playersFullHouseScoreIsSet) fullHouseLabel.Text = String.Empty;
                if (!player.playersYahtzeeScoreIsSet) yahtzeeLabel.Text = String.Empty;
                if (!player.playersChanceScoreIsSet) chanceLabel.Text = String.Empty;
                if (!player.playersSmallStraightScoreIsSet) smallStraightLabel.Text = String.Empty;
                if (!player.playersLargeStraightScoreIsSet) largeStraightLabel.Text = String.Empty;

                player.diceThatareHeld.Clear();
                testForSumAndBonus();
                testToSeeIfGameIsOver();
            }
        }

        private void fullHouseLabel_Click(object sender, EventArgs e)
        {
            if (player.rollsLeft < 3 && !player.playersFullHouseScoreIsSet)
            {
                moveDiceIn();
                fullHouseLabel.ForeColor = Color.Black;
                player.rollsLeft = 3;
                player.playersFullHouseScore = player.playersScoreCardCalculator.fullHouseScore;
                player.playersFullHouseScoreIsSet = true;

                if (!player.playersOnesScoreIsSet) onesLable.Text = String.Empty;
                if (!player.playersTwosScoreIsSet) twosLabel.Text = String.Empty;
                if (!player.playersThreesScoreIsSet) threesLabel.Text = String.Empty;
                if (!player.playersFoursScoreIsSet) foursLabel.Text = String.Empty;
                if (!player.playersFivesScoreIsSet) fivesLabel.Text = String.Empty;
                if (!player.playersSixesScoreIsSet) sixesLabel.Text = String.Empty;
                if (!player.playersThreeOfAKindScoreIsSet) threeOfAKindLabel.Text = String.Empty;
                if (!player.playersFourOfAKindScoreIsSet) fourOfAKindLabel.Text = String.Empty;
                if (!player.playersFullHouseScoreIsSet) fullHouseLabel.Text = String.Empty;
                if (!player.playersYahtzeeScoreIsSet) yahtzeeLabel.Text = String.Empty;
                if (!player.playersChanceScoreIsSet) chanceLabel.Text = String.Empty;
                if (!player.playersSmallStraightScoreIsSet) smallStraightLabel.Text = String.Empty;
                if (!player.playersLargeStraightScoreIsSet) largeStraightLabel.Text = String.Empty;

                player.diceThatareHeld.Clear();
                testForSumAndBonus();
                testToSeeIfGameIsOver();
            }
        }

        private void smallStraightLabel_Click(object sender, EventArgs e)
        {
            if (player.rollsLeft < 3 && !player.playersSmallStraightScoreIsSet)
            {
                moveDiceIn();
                smallStraightLabel.ForeColor = Color.Black;
                player.rollsLeft = 3;
                player.playersSmallStraightScore = player.playersScoreCardCalculator.smallStraightScore;
                player.playersSmallStraightScoreIsSet = true;

                if (!player.playersOnesScoreIsSet) onesLable.Text = String.Empty;
                if (!player.playersTwosScoreIsSet) twosLabel.Text = String.Empty;
                if (!player.playersThreesScoreIsSet) threesLabel.Text = String.Empty;
                if (!player.playersFoursScoreIsSet) foursLabel.Text = String.Empty;
                if (!player.playersFivesScoreIsSet) fivesLabel.Text = String.Empty;
                if (!player.playersSixesScoreIsSet) sixesLabel.Text = String.Empty;
                if (!player.playersThreeOfAKindScoreIsSet) threeOfAKindLabel.Text = String.Empty;
                if (!player.playersFourOfAKindScoreIsSet) fourOfAKindLabel.Text = String.Empty;
                if (!player.playersFullHouseScoreIsSet) fullHouseLabel.Text = String.Empty;
                if (!player.playersYahtzeeScoreIsSet) yahtzeeLabel.Text = String.Empty;
                if (!player.playersChanceScoreIsSet) chanceLabel.Text = String.Empty;
                if (!player.playersSmallStraightScoreIsSet) smallStraightLabel.Text = String.Empty;
                if (!player.playersLargeStraightScoreIsSet) largeStraightLabel.Text = String.Empty;

                player.diceThatareHeld.Clear();
                testForSumAndBonus();
                testToSeeIfGameIsOver();
            }
        }

        private void largeStraightLabel_Click(object sender, EventArgs e)
        {
            if (player.rollsLeft < 3 && !player.playersLargeStraightScoreIsSet)
            {
                moveDiceIn();
                largeStraightLabel.ForeColor = Color.Black;
                player.rollsLeft = 3;
                player.playersLargeStraightScore = player.playersScoreCardCalculator.largeStraightScore;
                player.playersLargeStraightScoreIsSet = true;

                if (!player.playersOnesScoreIsSet) onesLable.Text = String.Empty;
                if (!player.playersTwosScoreIsSet) twosLabel.Text = String.Empty;
                if (!player.playersThreesScoreIsSet) threesLabel.Text = String.Empty;
                if (!player.playersFoursScoreIsSet) foursLabel.Text = String.Empty;
                if (!player.playersFivesScoreIsSet) fivesLabel.Text = String.Empty;
                if (!player.playersSixesScoreIsSet) sixesLabel.Text = String.Empty;
                if (!player.playersThreeOfAKindScoreIsSet) threeOfAKindLabel.Text = String.Empty;
                if (!player.playersFourOfAKindScoreIsSet) fourOfAKindLabel.Text = String.Empty;
                if (!player.playersFullHouseScoreIsSet) fullHouseLabel.Text = String.Empty;
                if (!player.playersYahtzeeScoreIsSet) yahtzeeLabel.Text = String.Empty;
                if (!player.playersChanceScoreIsSet) chanceLabel.Text = String.Empty;
                if (!player.playersSmallStraightScoreIsSet) smallStraightLabel.Text = String.Empty;
                if (!player.playersLargeStraightScoreIsSet) largeStraightLabel.Text = String.Empty;

                player.diceThatareHeld.Clear();
                testForSumAndBonus();
                testToSeeIfGameIsOver();
            }
        }

        private void chanceLabel_Click(object sender, EventArgs e)
        {
            if (player.rollsLeft < 3 && !player.playersChanceScoreIsSet)
            {
                moveDiceIn();
                chanceLabel.ForeColor = Color.Black;
                player.rollsLeft = 3;
                player.playersChanceScore = player.playersScoreCardCalculator.chanceScore;
                player.playersChanceScoreIsSet = true;

                if (!player.playersOnesScoreIsSet) onesLable.Text = String.Empty;
                if (!player.playersTwosScoreIsSet) twosLabel.Text = String.Empty;
                if (!player.playersThreesScoreIsSet) threesLabel.Text = String.Empty;
                if (!player.playersFoursScoreIsSet) foursLabel.Text = String.Empty;
                if (!player.playersFivesScoreIsSet) fivesLabel.Text = String.Empty;
                if (!player.playersSixesScoreIsSet) sixesLabel.Text = String.Empty;
                if (!player.playersThreeOfAKindScoreIsSet) threeOfAKindLabel.Text = String.Empty;
                if (!player.playersFourOfAKindScoreIsSet) fourOfAKindLabel.Text = String.Empty;
                if (!player.playersFullHouseScoreIsSet) fullHouseLabel.Text = String.Empty;
                if (!player.playersYahtzeeScoreIsSet) yahtzeeLabel.Text = String.Empty;
                if (!player.playersChanceScoreIsSet) chanceLabel.Text = String.Empty;
                if (!player.playersSmallStraightScoreIsSet) smallStraightLabel.Text = String.Empty;
                if (!player.playersLargeStraightScoreIsSet) largeStraightLabel.Text = String.Empty;

                player.diceThatareHeld.Clear();
                testForSumAndBonus();
                testToSeeIfGameIsOver();
            }
        }

        private void yahtzeeLabel_Click(object sender, EventArgs e)
        {
            if (player.rollsLeft < 3 && !player.playersYahtzeeScoreIsSet)
            {
                moveDiceIn();
                yahtzeeLabel.ForeColor = Color.Black;
                player.rollsLeft = 3;
                player.playersYahtzeeScore = player.playersScoreCardCalculator.yahtzeeScore;
                player.playersYahtzeeScoreIsSet = true;

                if (!player.playersOnesScoreIsSet) onesLable.Text = String.Empty;
                if (!player.playersTwosScoreIsSet) twosLabel.Text = String.Empty;
                if (!player.playersThreesScoreIsSet) threesLabel.Text = String.Empty;
                if (!player.playersFoursScoreIsSet) foursLabel.Text = String.Empty;
                if (!player.playersFivesScoreIsSet) fivesLabel.Text = String.Empty;
                if (!player.playersSixesScoreIsSet) sixesLabel.Text = String.Empty;
                if (!player.playersThreeOfAKindScoreIsSet) threeOfAKindLabel.Text = String.Empty;
                if (!player.playersFourOfAKindScoreIsSet) fourOfAKindLabel.Text = String.Empty;
                if (!player.playersFullHouseScoreIsSet) fullHouseLabel.Text = String.Empty;
                if (!player.playersYahtzeeScoreIsSet) yahtzeeLabel.Text = String.Empty;
                if (!player.playersChanceScoreIsSet) chanceLabel.Text = String.Empty;
                if (!player.playersSmallStraightScoreIsSet) smallStraightLabel.Text = String.Empty;
                if (!player.playersLargeStraightScoreIsSet) largeStraightLabel.Text = String.Empty;

                player.diceThatareHeld.Clear();
                testForSumAndBonus();
                testToSeeIfGameIsOver();
            }
        }
    }
}