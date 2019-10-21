using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Yahtzee_GUI_Game;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOnesScore()
        {
            // Arrange
            List<int>[] listArray = new List<int>[6];
            setOfDiceForTesting[] diceArray = new setOfDiceForTesting[6];
            scoreCardCalculator[] calculatorArray = new scoreCardCalculator[6];

            listArray[0] = new List<int>();
            listArray[0].Add(1);
            listArray[0].Add(2);
            listArray[0].Add(2);
            listArray[0].Add(2);
            listArray[0].Add(2);
            diceArray[0] = new setOfDiceForTesting();
            //NOTE: This doesn't 'roll'. It sets what the dice actually are
            diceArray[0].roll(listArray[0]);

            listArray[1] = new List<int>();
            listArray[1].Add(1);
            listArray[1].Add(1);
            listArray[1].Add(2);
            listArray[1].Add(2);
            listArray[1].Add(2);
            diceArray[1] = new setOfDiceForTesting();
            diceArray[1].roll(listArray[1]);

            listArray[2] = new List<int>();
            listArray[2].Add(1);
            listArray[2].Add(1);
            listArray[2].Add(1);
            listArray[2].Add(2);
            listArray[2].Add(2);
            diceArray[2] = new setOfDiceForTesting();
            diceArray[2].roll(listArray[2]);

            listArray[3] = new List<int>();
            listArray[3].Add(1);
            listArray[3].Add(1);
            listArray[3].Add(1);
            listArray[3].Add(1);
            listArray[3].Add(2);
            diceArray[3] = new setOfDiceForTesting();
            diceArray[3].roll(listArray[3]);

            listArray[4] = new List<int>();
            listArray[4].Add(1);
            listArray[4].Add(1);
            listArray[4].Add(1);
            listArray[4].Add(1);
            listArray[4].Add(1);
            diceArray[4] = new setOfDiceForTesting();
            diceArray[4].roll(listArray[4]);

            listArray[5] = new List<int>();
            listArray[5].Add(2);
            listArray[5].Add(2);
            listArray[5].Add(2);
            listArray[5].Add(2);
            listArray[5].Add(2);
            diceArray[5] = new setOfDiceForTesting();
            diceArray[5].roll(listArray[5]);

            // Act
            calculatorArray[0] = new scoreCardCalculator(diceArray[0]);
            calculatorArray[1] = new scoreCardCalculator(diceArray[1]);
            calculatorArray[2] = new scoreCardCalculator(diceArray[2]);
            calculatorArray[3] = new scoreCardCalculator(diceArray[3]);
            calculatorArray[4] = new scoreCardCalculator(diceArray[4]);
            calculatorArray[5] = new scoreCardCalculator(diceArray[5]);

            //Assert
            Assert.AreEqual(calculatorArray[0].onesScore, 1);
            Assert.AreEqual(calculatorArray[1].onesScore, 2);
            Assert.AreEqual(calculatorArray[2].onesScore, 3);
            Assert.AreEqual(calculatorArray[3].onesScore, 4);
            Assert.AreEqual(calculatorArray[4].onesScore, 5);
            Assert.AreEqual(calculatorArray[5].onesScore, 0);
        }

        [TestMethod]
        public void TestTwosScore()
        {
            //Arange
            List<int>[] listArray = new List<int>[6];
            setOfDiceForTesting[] diceArray = new setOfDiceForTesting[6];
            scoreCardCalculator[] calculatorArray = new scoreCardCalculator[6];

            listArray[0] = new List<int>();
            listArray[0].Add(2);
            listArray[0].Add(1);
            listArray[0].Add(1);
            listArray[0].Add(1);
            listArray[0].Add(1);
            diceArray[0] = new setOfDiceForTesting();
            diceArray[0].roll(listArray[0]);

            listArray[1] = new List<int>();
            listArray[1].Add(2);
            listArray[1].Add(2);
            listArray[1].Add(1);
            listArray[1].Add(1);
            listArray[1].Add(1);
            diceArray[1] = new setOfDiceForTesting();
            diceArray[1].roll(listArray[1]);

            listArray[2] = new List<int>();
            listArray[2].Add(2);
            listArray[2].Add(2);
            listArray[2].Add(2);
            listArray[2].Add(1);
            listArray[2].Add(1);
            diceArray[2] = new setOfDiceForTesting();
            diceArray[2].roll(listArray[2]);

            listArray[3] = new List<int>();
            listArray[3].Add(2);
            listArray[3].Add(2);
            listArray[3].Add(2);
            listArray[3].Add(2);
            listArray[3].Add(1);
            diceArray[3] = new setOfDiceForTesting();
            diceArray[3].roll(listArray[3]);

            listArray[4] = new List<int>();
            listArray[4].Add(2);
            listArray[4].Add(2);
            listArray[4].Add(2);
            listArray[4].Add(2);
            listArray[4].Add(2);
            diceArray[4] = new setOfDiceForTesting();
            diceArray[4].roll(listArray[4]);

            listArray[5] = new List<int>();
            listArray[5].Add(1);
            listArray[5].Add(1);
            listArray[5].Add(1);
            listArray[5].Add(1);
            listArray[5].Add(1);
            diceArray[5] = new setOfDiceForTesting();
            diceArray[5].roll(listArray[5]);

            //Act
            calculatorArray[0] = new scoreCardCalculator(diceArray[0]);
            calculatorArray[1] = new scoreCardCalculator(diceArray[1]);
            calculatorArray[2] = new scoreCardCalculator(diceArray[2]);
            calculatorArray[3] = new scoreCardCalculator(diceArray[3]);
            calculatorArray[4] = new scoreCardCalculator(diceArray[4]);
            calculatorArray[5] = new scoreCardCalculator(diceArray[5]);

            //Assert
            Assert.AreEqual(calculatorArray[0].twosScore, 2);
            Assert.AreEqual(calculatorArray[1].twosScore, 4);
            Assert.AreEqual(calculatorArray[2].twosScore, 6);
            Assert.AreEqual(calculatorArray[3].twosScore, 8);
            Assert.AreEqual(calculatorArray[4].twosScore, 10);
            Assert.AreEqual(calculatorArray[5].twosScore, 0);

        }

        [TestMethod]
        public void TestThreesScore()
        {
            //Arrange
            List<int>[] listArray = new List<int>[6];
            setOfDiceForTesting[] diceArray = new setOfDiceForTesting[6];
            scoreCardCalculator[] calculatorArray = new scoreCardCalculator[6];

            listArray[0] = new List<int>();
            listArray[0].Add(3);
            listArray[0].Add(1);
            listArray[0].Add(1);
            listArray[0].Add(1);
            listArray[0].Add(1);
            diceArray[0] = new setOfDiceForTesting();
            diceArray[0].roll(listArray[0]);

            listArray[1] = new List<int>();
            listArray[1].Add(3);
            listArray[1].Add(3);
            listArray[1].Add(1);
            listArray[1].Add(1);
            listArray[1].Add(1);
            diceArray[1] = new setOfDiceForTesting();
            diceArray[1].roll(listArray[1]);

            listArray[2] = new List<int>();
            listArray[2].Add(3);
            listArray[2].Add(3);
            listArray[2].Add(3);
            listArray[2].Add(1);
            listArray[2].Add(1);
            diceArray[2] = new setOfDiceForTesting();
            diceArray[2].roll(listArray[2]);

            listArray[3] = new List<int>();
            listArray[3].Add(3);
            listArray[3].Add(3);
            listArray[3].Add(3);
            listArray[3].Add(3);
            listArray[3].Add(1);
            diceArray[3] = new setOfDiceForTesting();
            diceArray[3].roll(listArray[3]);

            listArray[4] = new List<int>();
            listArray[4].Add(3);
            listArray[4].Add(3);
            listArray[4].Add(3);
            listArray[4].Add(3);
            listArray[4].Add(3);
            diceArray[4] = new setOfDiceForTesting();
            diceArray[4].roll(listArray[4]);

            listArray[5] = new List<int>();
            listArray[5].Add(1);
            listArray[5].Add(1);
            listArray[5].Add(1);
            listArray[5].Add(1);
            listArray[5].Add(1);
            diceArray[5] = new setOfDiceForTesting();
            diceArray[5].roll(listArray[5]);

            //Act
            calculatorArray[0] = new scoreCardCalculator(diceArray[0]);
            calculatorArray[1] = new scoreCardCalculator(diceArray[1]);
            calculatorArray[2] = new scoreCardCalculator(diceArray[2]);
            calculatorArray[3] = new scoreCardCalculator(diceArray[3]);
            calculatorArray[4] = new scoreCardCalculator(diceArray[4]);
            calculatorArray[5] = new scoreCardCalculator(diceArray[5]);

            //Assert
            Assert.AreEqual(calculatorArray[0].threesScore, 3);
            Assert.AreEqual(calculatorArray[1].threesScore, 6);
            Assert.AreEqual(calculatorArray[2].threesScore, 9);
            Assert.AreEqual(calculatorArray[3].threesScore, 12);
            Assert.AreEqual(calculatorArray[4].threesScore, 15);
            Assert.AreEqual(calculatorArray[5].threesScore, 0);

        }

        [TestMethod]
        public void TestFoursScore()
        {
            //Arrange
            List<int>[] listArray = new List<int>[6];
            setOfDiceForTesting[] diceArray = new setOfDiceForTesting[6];
            scoreCardCalculator[] calculatorArray = new scoreCardCalculator[6];

            listArray[0] = new List<int>();
            listArray[0].Add(4);
            listArray[0].Add(1);
            listArray[0].Add(1);
            listArray[0].Add(1);
            listArray[0].Add(1);
            diceArray[0] = new setOfDiceForTesting();
            diceArray[0].roll(listArray[0]);

            listArray[1] = new List<int>();
            listArray[1].Add(4);
            listArray[1].Add(4);
            listArray[1].Add(1);
            listArray[1].Add(1);
            listArray[1].Add(1);
            diceArray[1] = new setOfDiceForTesting();
            diceArray[1].roll(listArray[1]);

            listArray[2] = new List<int>();
            listArray[2].Add(4);
            listArray[2].Add(4);
            listArray[2].Add(4);
            listArray[2].Add(1);
            listArray[2].Add(1);
            diceArray[2] = new setOfDiceForTesting();
            diceArray[2].roll(listArray[2]);

            listArray[3] = new List<int>();
            listArray[3].Add(4);
            listArray[3].Add(4);
            listArray[3].Add(4);
            listArray[3].Add(4);
            listArray[3].Add(1);
            diceArray[3] = new setOfDiceForTesting();
            diceArray[3].roll(listArray[3]);

            listArray[4] = new List<int>();
            listArray[4].Add(4);
            listArray[4].Add(4);
            listArray[4].Add(4);
            listArray[4].Add(4);
            listArray[4].Add(4);
            diceArray[4] = new setOfDiceForTesting();
            diceArray[4].roll(listArray[4]);

            listArray[5] = new List<int>();
            listArray[5].Add(1);
            listArray[5].Add(1);
            listArray[5].Add(1);
            listArray[5].Add(1);
            listArray[5].Add(1);
            diceArray[5] = new setOfDiceForTesting();
            diceArray[5].roll(listArray[5]);

            //Act
            calculatorArray[0] = new scoreCardCalculator(diceArray[0]);
            calculatorArray[1] = new scoreCardCalculator(diceArray[1]);
            calculatorArray[2] = new scoreCardCalculator(diceArray[2]);
            calculatorArray[3] = new scoreCardCalculator(diceArray[3]);
            calculatorArray[4] = new scoreCardCalculator(diceArray[4]);
            calculatorArray[5] = new scoreCardCalculator(diceArray[5]);

            //Assert
            //Note: I know these are backwards but I didn't feel like fixing them
            //once I realized they were. Numeric literals should be first.
            Assert.AreEqual(calculatorArray[0].foursScore, 4);
            Assert.AreEqual(calculatorArray[1].foursScore, 8);
            Assert.AreEqual(calculatorArray[2].foursScore, 12);
            Assert.AreEqual(calculatorArray[3].foursScore, 16);
            Assert.AreEqual(calculatorArray[4].foursScore, 20);
            Assert.AreEqual(calculatorArray[5].foursScore, 0);

        }

        [TestMethod]
        public void TestFivesScore()
        {
            //Arrange
            List<int>[] listArray = new List<int>[6];
            setOfDiceForTesting[] diceArray = new setOfDiceForTesting[6];
            scoreCardCalculator[] calculatorArray = new scoreCardCalculator[6];

            listArray[0] = new List<int>();
            listArray[0].Add(5);
            listArray[0].Add(1);
            listArray[0].Add(1);
            listArray[0].Add(1);
            listArray[0].Add(1);
            diceArray[0] = new setOfDiceForTesting();
            diceArray[0].roll(listArray[0]);

            listArray[1] = new List<int>();
            listArray[1].Add(5);
            listArray[1].Add(5);
            listArray[1].Add(1);
            listArray[1].Add(1);
            listArray[1].Add(1);
            diceArray[1] = new setOfDiceForTesting();
            diceArray[1].roll(listArray[1]);

            listArray[2] = new List<int>();
            listArray[2].Add(5);
            listArray[2].Add(5);
            listArray[2].Add(5);
            listArray[2].Add(1);
            listArray[2].Add(1);
            diceArray[2] = new setOfDiceForTesting();
            diceArray[2].roll(listArray[2]);

            listArray[3] = new List<int>();
            listArray[3].Add(5);
            listArray[3].Add(5);
            listArray[3].Add(5);
            listArray[3].Add(5);
            listArray[3].Add(1);
            diceArray[3] = new setOfDiceForTesting();
            diceArray[3].roll(listArray[3]);

            listArray[4] = new List<int>();
            listArray[4].Add(5);
            listArray[4].Add(5);
            listArray[4].Add(5);
            listArray[4].Add(5);
            listArray[4].Add(5);
            diceArray[4] = new setOfDiceForTesting();
            diceArray[4].roll(listArray[4]);

            listArray[5] = new List<int>();
            listArray[5].Add(1);
            listArray[5].Add(1);
            listArray[5].Add(1);
            listArray[5].Add(1);
            listArray[5].Add(1);
            diceArray[5] = new setOfDiceForTesting();
            diceArray[5].roll(listArray[5]);

            //Act
            calculatorArray[0] = new scoreCardCalculator(diceArray[0]);
            calculatorArray[1] = new scoreCardCalculator(diceArray[1]);
            calculatorArray[2] = new scoreCardCalculator(diceArray[2]);
            calculatorArray[3] = new scoreCardCalculator(diceArray[3]);
            calculatorArray[4] = new scoreCardCalculator(diceArray[4]);
            calculatorArray[5] = new scoreCardCalculator(diceArray[5]);

            //Assert
            Assert.AreEqual(calculatorArray[0].fivesScore, 5);
            Assert.AreEqual(calculatorArray[1].fivesScore, 10);
            Assert.AreEqual(calculatorArray[2].fivesScore, 15);
            Assert.AreEqual(calculatorArray[3].fivesScore, 20);
            Assert.AreEqual(calculatorArray[4].fivesScore, 25);
            Assert.AreEqual(calculatorArray[5].fivesScore, 0);

        }

        [TestMethod]
        public void TestSixesScore()
        {
            //Arrange
            List<int>[] listArray = new List<int>[6];
            setOfDiceForTesting[] diceArray = new setOfDiceForTesting[6];
            scoreCardCalculator[] calculatorArray = new scoreCardCalculator[6];

            listArray[0] = new List<int>();
            listArray[0].Add(6);
            listArray[0].Add(1);
            listArray[0].Add(1);
            listArray[0].Add(1);
            listArray[0].Add(1);
            diceArray[0] = new setOfDiceForTesting();
            diceArray[0].roll(listArray[0]);

            listArray[1] = new List<int>();
            listArray[1].Add(6);
            listArray[1].Add(6);
            listArray[1].Add(1);
            listArray[1].Add(1);
            listArray[1].Add(1);
            diceArray[1] = new setOfDiceForTesting();
            diceArray[1].roll(listArray[1]);

            listArray[2] = new List<int>();
            listArray[2].Add(6);
            listArray[2].Add(6);
            listArray[2].Add(6);
            listArray[2].Add(1);
            listArray[2].Add(1);
            diceArray[2] = new setOfDiceForTesting();
            diceArray[2].roll(listArray[2]);

            listArray[3] = new List<int>();
            listArray[3].Add(6);
            listArray[3].Add(6);
            listArray[3].Add(6);
            listArray[3].Add(6);
            listArray[3].Add(1);
            diceArray[3] = new setOfDiceForTesting();
            diceArray[3].roll(listArray[3]);

            listArray[4] = new List<int>();
            listArray[4].Add(6);
            listArray[4].Add(6);
            listArray[4].Add(6);
            listArray[4].Add(6);
            listArray[4].Add(6);
            diceArray[4] = new setOfDiceForTesting();
            diceArray[4].roll(listArray[4]);

            listArray[5] = new List<int>();
            listArray[5].Add(1);
            listArray[5].Add(1);
            listArray[5].Add(1);
            listArray[5].Add(1);
            listArray[5].Add(1);
            diceArray[5] = new setOfDiceForTesting();
            diceArray[5].roll(listArray[5]);

            //Act
            calculatorArray[0] = new scoreCardCalculator(diceArray[0]);
            calculatorArray[1] = new scoreCardCalculator(diceArray[1]);
            calculatorArray[2] = new scoreCardCalculator(diceArray[2]);
            calculatorArray[3] = new scoreCardCalculator(diceArray[3]);
            calculatorArray[4] = new scoreCardCalculator(diceArray[4]);
            calculatorArray[5] = new scoreCardCalculator(diceArray[5]);

            //Assert
            Assert.AreEqual(calculatorArray[0].sixesScore, 6);
            Assert.AreEqual(calculatorArray[1].sixesScore, 12);
            Assert.AreEqual(calculatorArray[2].sixesScore, 18);
            Assert.AreEqual(calculatorArray[3].sixesScore, 24);
            Assert.AreEqual(calculatorArray[4].sixesScore, 30);
            Assert.AreEqual(calculatorArray[5].sixesScore, 0);

        }


        [TestMethod]
        public void TestSmallStraightScore()
        {
            //Arrange
            List<int>[] listArray = new List<int>[5];
            setOfDiceForTesting[] diceArray = new setOfDiceForTesting[5];
            scoreCardCalculator[] calculatorArray = new scoreCardCalculator[5];

            listArray[0] = new List<int>();
            listArray[0].Add(1);
            listArray[0].Add(2);
            listArray[0].Add(3);
            listArray[0].Add(4);
            listArray[0].Add(1);
            diceArray[0] = new setOfDiceForTesting();
            diceArray[0].roll(listArray[0]);

            listArray[1] = new List<int>();
            listArray[1].Add(2);
            listArray[1].Add(3);
            listArray[1].Add(4);
            listArray[1].Add(5);
            listArray[1].Add(1);
            diceArray[1] = new setOfDiceForTesting();
            diceArray[1].roll(listArray[1]);

            listArray[2] = new List<int>();
            listArray[2].Add(3);
            listArray[2].Add(4);
            listArray[2].Add(5);
            listArray[2].Add(6);
            listArray[2].Add(1);
            diceArray[2] = new setOfDiceForTesting();
            diceArray[2].roll(listArray[2]);

            listArray[3] = new List<int>();
            listArray[3].Add(1);
            listArray[3].Add(1);
            listArray[3].Add(1);
            listArray[3].Add(1);
            listArray[3].Add(1);
            diceArray[3] = new setOfDiceForTesting();
            diceArray[3].roll(listArray[3]);

            listArray[4] = new List<int>();
            listArray[4].Add(1);
            listArray[4].Add(4);
            listArray[4].Add(3);
            listArray[4].Add(2);
            listArray[4].Add(1);
            diceArray[4] = new setOfDiceForTesting();
            diceArray[4].roll(listArray[4]);

            //Act
            calculatorArray[0] = new scoreCardCalculator(diceArray[0]);
            calculatorArray[1] = new scoreCardCalculator(diceArray[1]);
            calculatorArray[2] = new scoreCardCalculator(diceArray[2]);
            calculatorArray[3] = new scoreCardCalculator(diceArray[3]);
            calculatorArray[4] = new scoreCardCalculator(diceArray[4]);

            //Assert           
            Assert.AreEqual(30, calculatorArray[0].smallStraightScore);    
            Assert.AreEqual(0, calculatorArray[0].largeStraightScore);
            Assert.AreEqual(30, calculatorArray[1].smallStraightScore);
            Assert.AreEqual(30, calculatorArray[2].smallStraightScore);
            Assert.AreEqual(0, calculatorArray[3].smallStraightScore);
            Assert.AreEqual(30, calculatorArray[4].smallStraightScore);

        }

        [TestMethod]
        public void TestLargeStraightScore()
        {
            //Arrange
            List<int>[] listArray = new List<int>[4];
            setOfDiceForTesting[] diceArray = new setOfDiceForTesting[4];
            scoreCardCalculator[] calculatorArray = new scoreCardCalculator[4];

            listArray[0] = new List<int>();
            listArray[0].Add(1);
            listArray[0].Add(2);
            listArray[0].Add(3);
            listArray[0].Add(4);
            listArray[0].Add(5);
            diceArray[0] = new setOfDiceForTesting();
            diceArray[0].roll(listArray[0]);

            listArray[1] = new List<int>();
            listArray[1].Add(2);
            listArray[1].Add(3);
            listArray[1].Add(4);
            listArray[1].Add(5);
            listArray[1].Add(6);
            diceArray[1] = new setOfDiceForTesting();
            diceArray[1].roll(listArray[1]);

            listArray[2] = new List<int>();
            listArray[2].Add(1);
            listArray[2].Add(1);
            listArray[2].Add(1);
            listArray[2].Add(1);
            listArray[2].Add(1);
            diceArray[2] = new setOfDiceForTesting();
            diceArray[2].roll(listArray[2]);

            listArray[3] = new List<int>();
            listArray[3].Add(5);
            listArray[3].Add(4);
            listArray[3].Add(3);
            listArray[3].Add(2);
            listArray[3].Add(1);
            diceArray[3] = new setOfDiceForTesting();
            diceArray[3].roll(listArray[3]);

            //Act
            calculatorArray[0] = new scoreCardCalculator(diceArray[0]);
            calculatorArray[1] = new scoreCardCalculator(diceArray[1]);
            calculatorArray[2] = new scoreCardCalculator(diceArray[2]);
            calculatorArray[3] = new scoreCardCalculator(diceArray[3]);

            //Assert
            Assert.AreEqual(40, calculatorArray[0].largeStraightScore);
            Assert.AreEqual(30, calculatorArray[0].smallStraightScore);
            Assert.AreEqual(40, calculatorArray[1].largeStraightScore);
            Assert.AreEqual(30, calculatorArray[1].smallStraightScore);
            Assert.AreEqual(0, calculatorArray[2].largeStraightScore);
            Assert.AreEqual(40, calculatorArray[3].largeStraightScore);

        }

        [TestMethod]
        public void TestYahtzeeScore()
        {
            //Arrange
            List<int>[] listArray = new List<int>[7];
            setOfDiceForTesting[] diceArray = new setOfDiceForTesting[7];
            scoreCardCalculator[] calculatorArray = new scoreCardCalculator[7];

            listArray[0] = new List<int>();
            listArray[0].Add(1);
            listArray[0].Add(1);
            listArray[0].Add(1);
            listArray[0].Add(1);
            listArray[0].Add(1);
            diceArray[0] = new setOfDiceForTesting();
            diceArray[0].roll(listArray[0]);

            listArray[1] = new List<int>();
            listArray[1].Add(2);
            listArray[1].Add(2);
            listArray[1].Add(2);
            listArray[1].Add(2);
            listArray[1].Add(2);
            diceArray[1] = new setOfDiceForTesting();
            diceArray[1].roll(listArray[1]);

            listArray[2] = new List<int>();
            listArray[2].Add(3);
            listArray[2].Add(3);
            listArray[2].Add(3);
            listArray[2].Add(3);
            listArray[2].Add(3);
            diceArray[2] = new setOfDiceForTesting();
            diceArray[2].roll(listArray[2]);

            listArray[3] = new List<int>();
            listArray[3].Add(4);
            listArray[3].Add(4);
            listArray[3].Add(4);
            listArray[3].Add(4);
            listArray[3].Add(4);
            diceArray[3] = new setOfDiceForTesting();
            diceArray[3].roll(listArray[3]);

            listArray[4] = new List<int>();
            listArray[4].Add(5);
            listArray[4].Add(5);
            listArray[4].Add(5);
            listArray[4].Add(5);
            listArray[4].Add(5);
            diceArray[4] = new setOfDiceForTesting();
            diceArray[4].roll(listArray[4]);

            listArray[5] = new List<int>();
            listArray[5].Add(6);
            listArray[5].Add(6);
            listArray[5].Add(6);
            listArray[5].Add(6);
            listArray[5].Add(6);
            diceArray[5] = new setOfDiceForTesting();
            diceArray[5].roll(listArray[5]);

            listArray[6] = new List<int>();
            listArray[6].Add(1);
            listArray[6].Add(6);
            listArray[6].Add(6);
            listArray[6].Add(6);
            listArray[6].Add(6);
            diceArray[6] = new setOfDiceForTesting();
            diceArray[6].roll(listArray[6]);

            //Act
            calculatorArray[0] = new scoreCardCalculator(diceArray[0]);
            calculatorArray[1] = new scoreCardCalculator(diceArray[1]);
            calculatorArray[2] = new scoreCardCalculator(diceArray[2]);
            calculatorArray[3] = new scoreCardCalculator(diceArray[3]);
            calculatorArray[4] = new scoreCardCalculator(diceArray[4]);
            calculatorArray[5] = new scoreCardCalculator(diceArray[5]);
            calculatorArray[6] = new scoreCardCalculator(diceArray[6]);

            //Assert
            Assert.AreEqual(50, calculatorArray[0].yahtzeeScore);
            Assert.AreEqual(50, calculatorArray[1].yahtzeeScore);
            Assert.AreEqual(50, calculatorArray[2].yahtzeeScore);
            Assert.AreEqual(50, calculatorArray[3].yahtzeeScore);
            Assert.AreEqual(50, calculatorArray[4].yahtzeeScore);
            Assert.AreEqual(50, calculatorArray[5].yahtzeeScore);

            Assert.AreEqual(5, calculatorArray[0].onesScore);
            Assert.AreEqual(10, calculatorArray[1].twosScore);
            Assert.AreEqual(15, calculatorArray[2].threesScore);
            Assert.AreEqual(20, calculatorArray[3].foursScore);
            Assert.AreEqual(25, calculatorArray[4].fivesScore);
            Assert.AreEqual(30, calculatorArray[5].sixesScore);

            Assert.AreEqual(0, calculatorArray[6].yahtzeeScore);

        }

        [TestMethod]
        public void TestChanceScore()
        {
            //Arrange
            List<int> testDiceNumbers = new List<int>();
            setOfDiceForTesting dice = new setOfDiceForTesting();
            scoreCardCalculator calculator = null;

            testDiceNumbers.Add(2);
            testDiceNumbers.Add(3);
            testDiceNumbers.Add(4);
            testDiceNumbers.Add(2);
            testDiceNumbers.Add(3);
            dice.roll(testDiceNumbers);

            //Act
            calculator = new scoreCardCalculator(dice);

            //Assert
            Assert.AreEqual(14, calculator.chanceScore);

        }

        [TestMethod]
        public void TestThreeOfAKindScore()
        {
            //Arrange
            List<int>[] listArray = new List<int>[7];
            setOfDiceForTesting[] diceArray = new setOfDiceForTesting[7];
            scoreCardCalculator[] calculatorArray = new scoreCardCalculator[7];

            listArray[0] = new List<int>();
            listArray[0].Add(1);
            listArray[0].Add(1);
            listArray[0].Add(1);
            listArray[0].Add(4);
            listArray[0].Add(5);
            diceArray[0] = new setOfDiceForTesting();
            diceArray[0].roll(listArray[0]);

            listArray[1] = new List<int>();
            listArray[1].Add(2);
            listArray[1].Add(2);
            listArray[1].Add(2);
            listArray[1].Add(4);
            listArray[1].Add(5);
            diceArray[1] = new setOfDiceForTesting();
            diceArray[1].roll(listArray[1]);

            listArray[2] = new List<int>();
            listArray[2].Add(3);
            listArray[2].Add(3);
            listArray[2].Add(3);
            listArray[2].Add(4);
            listArray[2].Add(5);
            diceArray[2] = new setOfDiceForTesting();
            diceArray[2].roll(listArray[2]);

            listArray[3] = new List<int>();
            listArray[3].Add(4);
            listArray[3].Add(4);
            listArray[3].Add(4);
            listArray[3].Add(1);
            listArray[3].Add(2);
            diceArray[3] = new setOfDiceForTesting();
            diceArray[3].roll(listArray[3]);

            listArray[4] = new List<int>();
            listArray[4].Add(5);
            listArray[4].Add(5);
            listArray[4].Add(5);
            listArray[4].Add(1);
            listArray[4].Add(2);
            diceArray[4] = new setOfDiceForTesting();
            diceArray[4].roll(listArray[4]);

            listArray[5] = new List<int>();
            listArray[5].Add(6);
            listArray[5].Add(6);
            listArray[5].Add(6);
            listArray[5].Add(1);
            listArray[5].Add(2);
            diceArray[5] = new setOfDiceForTesting();
            diceArray[5].roll(listArray[5]);

            listArray[6] = new List<int>();
            listArray[6].Add(1);
            listArray[6].Add(1);
            listArray[6].Add(2);
            listArray[6].Add(2);
            listArray[6].Add(3);
            diceArray[6] = new setOfDiceForTesting();
            diceArray[6].roll(listArray[6]);

            //Act
            calculatorArray[0] = new scoreCardCalculator(diceArray[0]);
            calculatorArray[1] = new scoreCardCalculator(diceArray[1]);
            calculatorArray[2] = new scoreCardCalculator(diceArray[2]);
            calculatorArray[3] = new scoreCardCalculator(diceArray[3]);
            calculatorArray[4] = new scoreCardCalculator(diceArray[4]);
            calculatorArray[5] = new scoreCardCalculator(diceArray[5]);
            calculatorArray[6] = new scoreCardCalculator(diceArray[6]);

            //Assert
            Assert.AreEqual(12, calculatorArray[0].threeOfAKindScore);
            Assert.AreEqual(15, calculatorArray[1].threeOfAKindScore);
            Assert.AreEqual(18, calculatorArray[2].threeOfAKindScore);
            Assert.AreEqual(15, calculatorArray[3].threeOfAKindScore);
            Assert.AreEqual(18, calculatorArray[4].threeOfAKindScore);
            Assert.AreEqual(21, calculatorArray[5].threeOfAKindScore);
            Assert.AreEqual(0, calculatorArray[6].threeOfAKindScore);

        }

        [TestMethod]
        public void fourOfAKind()
        {
            //Arrange
            List<int>[] listArray = new List<int>[8];
            setOfDiceForTesting[] diceArray = new setOfDiceForTesting[8];
            scoreCardCalculator[] calculatorArray = new scoreCardCalculator[8];

            listArray[0] = new List<int>();
            listArray[0].Add(1);
            listArray[0].Add(1);
            listArray[0].Add(1);
            listArray[0].Add(1);
            listArray[0].Add(2);
            diceArray[0] = new setOfDiceForTesting();
            diceArray[0].roll(listArray[0]);

            listArray[1] = new List<int>();
            listArray[1].Add(2);
            listArray[1].Add(2);
            listArray[1].Add(2);
            listArray[1].Add(2);
            listArray[1].Add(1);
            diceArray[1] = new setOfDiceForTesting();
            diceArray[1].roll(listArray[1]);

            listArray[2] = new List<int>();
            listArray[2].Add(3);
            listArray[2].Add(3);
            listArray[2].Add(3);
            listArray[2].Add(3);
            listArray[2].Add(1);
            diceArray[2] = new setOfDiceForTesting();
            diceArray[2].roll(listArray[2]);

            listArray[3] = new List<int>();
            listArray[3].Add(4);
            listArray[3].Add(4);
            listArray[3].Add(4);
            listArray[3].Add(4);
            listArray[3].Add(1);
            diceArray[3] = new setOfDiceForTesting();
            diceArray[3].roll(listArray[3]);

            listArray[4] = new List<int>();
            listArray[4].Add(5);
            listArray[4].Add(5);
            listArray[4].Add(5);
            listArray[4].Add(5);
            listArray[4].Add(1);
            diceArray[4] = new setOfDiceForTesting();
            diceArray[4].roll(listArray[4]);

            listArray[5] = new List<int>();
            listArray[5].Add(6);
            listArray[5].Add(6);
            listArray[5].Add(6);
            listArray[5].Add(6);
            listArray[5].Add(1);
            diceArray[5] = new setOfDiceForTesting();
            diceArray[5].roll(listArray[5]);

            listArray[6] = new List<int>();
            listArray[6].Add(1);
            listArray[6].Add(6);
            listArray[6].Add(6);
            listArray[6].Add(6);
            listArray[6].Add(1);
            diceArray[6] = new setOfDiceForTesting();
            diceArray[6].roll(listArray[6]);

            //Act
            calculatorArray[0] = new scoreCardCalculator(diceArray[0]);
            calculatorArray[1] = new scoreCardCalculator(diceArray[1]);
            calculatorArray[2] = new scoreCardCalculator(diceArray[2]);
            calculatorArray[3] = new scoreCardCalculator(diceArray[3]);
            calculatorArray[4] = new scoreCardCalculator(diceArray[4]);
            calculatorArray[5] = new scoreCardCalculator(diceArray[5]);
            calculatorArray[6] = new scoreCardCalculator(diceArray[6]);

            //Assert
            Assert.AreEqual(6, calculatorArray[0].fourOfAKindScore);
            Assert.AreEqual(6, calculatorArray[0].threeOfAKindScore);
            Assert.AreEqual(9, calculatorArray[1].fourOfAKindScore);
            Assert.AreEqual(13, calculatorArray[2].fourOfAKindScore);
            Assert.AreEqual(17, calculatorArray[3].fourOfAKindScore);
            Assert.AreEqual(21, calculatorArray[4].fourOfAKindScore);
            Assert.AreEqual(25, calculatorArray[5].fourOfAKindScore);
            Assert.AreEqual(0, calculatorArray[6].fourOfAKindScore);

        }

        [TestMethod]
        public void TestFullHouseScore()
        {
            //Arrange
            List<int>[] listArray = new List<int>[31];
            setOfDiceForTesting[] diceArray = new setOfDiceForTesting[31];
            scoreCardCalculator[] calculatorArray = new scoreCardCalculator[31];

            listArray[0] = new List<int>();
            listArray[0].Add(2);
            listArray[0].Add(1);
            listArray[0].Add(1);
            listArray[0].Add(2);
            listArray[0].Add(1);
            diceArray[0] = new setOfDiceForTesting();
            diceArray[0].roll(listArray[0]);

            listArray[1] = new List<int>();
            listArray[1].Add(1);
            listArray[1].Add(1);
            listArray[1].Add(1);
            listArray[1].Add(3);
            listArray[1].Add(3);
            diceArray[1] = new setOfDiceForTesting();
            diceArray[1].roll(listArray[1]);

            listArray[2] = new List<int>();
            listArray[2].Add(1);
            listArray[2].Add(1);
            listArray[2].Add(1);
            listArray[2].Add(4);
            listArray[2].Add(4);
            diceArray[2] = new setOfDiceForTesting();
            diceArray[2].roll(listArray[2]);

            listArray[3] = new List<int>();
            listArray[3].Add(1);
            listArray[3].Add(1);
            listArray[3].Add(1);
            listArray[3].Add(5);
            listArray[3].Add(5);
            diceArray[3] = new setOfDiceForTesting();
            diceArray[3].roll(listArray[3]);

            listArray[4] = new List<int>();
            listArray[4].Add(1);
            listArray[4].Add(1);
            listArray[4].Add(1);
            listArray[4].Add(6);
            listArray[4].Add(6);
            diceArray[4] = new setOfDiceForTesting();
            diceArray[4].roll(listArray[4]);

            listArray[5] = new List<int>();
            listArray[5].Add(2);
            listArray[5].Add(2);
            listArray[5].Add(2);
            listArray[5].Add(1);
            listArray[5].Add(1);
            diceArray[5] = new setOfDiceForTesting();
            diceArray[5].roll(listArray[5]);

            listArray[6] = new List<int>();
            listArray[6].Add(2);
            listArray[6].Add(2);
            listArray[6].Add(2);
            listArray[6].Add(3);
            listArray[6].Add(3);
            diceArray[6] = new setOfDiceForTesting();
            diceArray[6].roll(listArray[6]);

            listArray[7] = new List<int>();
            listArray[7].Add(2);
            listArray[7].Add(2);
            listArray[7].Add(4);
            listArray[7].Add(2);
            listArray[7].Add(4);
            diceArray[7] = new setOfDiceForTesting();
            diceArray[7].roll(listArray[7]);

            listArray[8] = new List<int>();
            listArray[8].Add(2);
            listArray[8].Add(2);
            listArray[8].Add(2);
            listArray[8].Add(5);
            listArray[8].Add(5);
            diceArray[8] = new setOfDiceForTesting();
            diceArray[8].roll(listArray[8]);

            listArray[9] = new List<int>();
            listArray[9].Add(2);
            listArray[9].Add(2);
            listArray[9].Add(2);
            listArray[9].Add(6);
            listArray[9].Add(6);
            diceArray[9] = new setOfDiceForTesting();
            diceArray[9].roll(listArray[9]);

            listArray[10] = new List<int>();
            listArray[10].Add(3);
            listArray[10].Add(3);
            listArray[10].Add(3);
            listArray[10].Add(1);
            listArray[10].Add(1);
            diceArray[10] = new setOfDiceForTesting();
            diceArray[10].roll(listArray[10]);

            listArray[11] = new List<int>();
            listArray[11].Add(2);
            listArray[11].Add(3);
            listArray[11].Add(3);
            listArray[11].Add(2);
            listArray[11].Add(3);
            diceArray[11] = new setOfDiceForTesting();
            diceArray[11].roll(listArray[11]);

            listArray[12] = new List<int>();
            listArray[12].Add(3);
            listArray[12].Add(3);
            listArray[12].Add(3);
            listArray[12].Add(4);
            listArray[12].Add(4);
            diceArray[12] = new setOfDiceForTesting();
            diceArray[12].roll(listArray[12]);

            listArray[13] = new List<int>();
            listArray[13].Add(3);
            listArray[13].Add(3);
            listArray[13].Add(3);
            listArray[13].Add(5);
            listArray[13].Add(5);
            diceArray[13] = new setOfDiceForTesting();
            diceArray[13].roll(listArray[13]);

            listArray[14] = new List<int>();
            listArray[14].Add(3);
            listArray[14].Add(3);
            listArray[14].Add(3);
            listArray[14].Add(6);
            listArray[14].Add(6);
            diceArray[14] = new setOfDiceForTesting();
            diceArray[14].roll(listArray[14]);

            listArray[15] = new List<int>();
            listArray[15].Add(4);
            listArray[15].Add(4);
            listArray[15].Add(4);
            listArray[15].Add(1);
            listArray[15].Add(1);
            diceArray[15] = new setOfDiceForTesting();
            diceArray[15].roll(listArray[15]);

            listArray[16] = new List<int>();
            listArray[16].Add(4);
            listArray[16].Add(4);
            listArray[16].Add(4);
            listArray[16].Add(2);
            listArray[16].Add(2);
            diceArray[16] = new setOfDiceForTesting();
            diceArray[16].roll(listArray[16]);

            listArray[17] = new List<int>();
            listArray[17].Add(4);
            listArray[17].Add(4);
            listArray[17].Add(4);
            listArray[17].Add(3);
            listArray[17].Add(3);
            diceArray[17] = new setOfDiceForTesting();
            diceArray[17].roll(listArray[17]);

            listArray[18] = new List<int>();
            listArray[18].Add(4);
            listArray[18].Add(4);
            listArray[18].Add(4);
            listArray[18].Add(5);
            listArray[18].Add(5);
            diceArray[18] = new setOfDiceForTesting();
            diceArray[18].roll(listArray[18]);

            listArray[19] = new List<int>();
            listArray[19].Add(4);
            listArray[19].Add(6);
            listArray[19].Add(4);
            listArray[19].Add(4);
            listArray[19].Add(6);
            diceArray[19] = new setOfDiceForTesting();
            diceArray[19].roll(listArray[19]);

            listArray[20] = new List<int>();
            listArray[20].Add(5);
            listArray[20].Add(5);
            listArray[20].Add(5);
            listArray[20].Add(1);
            listArray[20].Add(1);
            diceArray[20] = new setOfDiceForTesting();
            diceArray[20].roll(listArray[20]);

            listArray[21] = new List<int>();
            listArray[21].Add(5);
            listArray[21].Add(5);
            listArray[21].Add(5);
            listArray[21].Add(2);
            listArray[21].Add(2);
            diceArray[21] = new setOfDiceForTesting();
            diceArray[21].roll(listArray[21]);

            listArray[22] = new List<int>();
            listArray[22].Add(5);
            listArray[22].Add(5);
            listArray[22].Add(3);
            listArray[22].Add(5);
            listArray[22].Add(3);
            diceArray[22] = new setOfDiceForTesting();
            diceArray[22].roll(listArray[22]);

            listArray[23] = new List<int>();
            listArray[23].Add(5);
            listArray[23].Add(5);
            listArray[23].Add(5);
            listArray[23].Add(4);
            listArray[23].Add(4);
            diceArray[23] = new setOfDiceForTesting();
            diceArray[23].roll(listArray[23]);

            listArray[24] = new List<int>();
            listArray[24].Add(5);
            listArray[24].Add(5);
            listArray[24].Add(5);
            listArray[24].Add(6);
            listArray[24].Add(6);
            diceArray[24] = new setOfDiceForTesting();
            diceArray[24].roll(listArray[24]);

            listArray[25] = new List<int>();
            listArray[25].Add(1);
            listArray[25].Add(6);
            listArray[25].Add(6);
            listArray[25].Add(6);
            listArray[25].Add(1);
            diceArray[25] = new setOfDiceForTesting();
            diceArray[25].roll(listArray[25]);

            listArray[26] = new List<int>();
            listArray[26].Add(6);
            listArray[26].Add(6);
            listArray[26].Add(6);
            listArray[26].Add(2);
            listArray[26].Add(2);
            diceArray[26] = new setOfDiceForTesting();
            diceArray[26].roll(listArray[26]);

            listArray[27] = new List<int>();
            listArray[27].Add(6);
            listArray[27].Add(6);
            listArray[27].Add(6);
            listArray[27].Add(3);
            listArray[27].Add(3);
            diceArray[27] = new setOfDiceForTesting();
            diceArray[27].roll(listArray[27]);

            listArray[28] = new List<int>();
            listArray[28].Add(6);
            listArray[28].Add(6);
            listArray[28].Add(6);
            listArray[28].Add(4);
            listArray[28].Add(4);
            diceArray[28] = new setOfDiceForTesting();
            diceArray[28].roll(listArray[28]);

            listArray[29] = new List<int>();
            listArray[29].Add(6);
            listArray[29].Add(6);
            listArray[29].Add(6);
            listArray[29].Add(5);
            listArray[29].Add(5);
            diceArray[29] = new setOfDiceForTesting();
            diceArray[29].roll(listArray[29]);

            listArray[30] = new List<int>();
            listArray[30].Add(1);
            listArray[30].Add(6);
            listArray[30].Add(6);
            listArray[30].Add(5);
            listArray[30].Add(5);
            diceArray[30] = new setOfDiceForTesting();
            diceArray[30].roll(listArray[30]);

            //Act
            calculatorArray[0] = new scoreCardCalculator(diceArray[0]);
            calculatorArray[1] = new scoreCardCalculator(diceArray[1]);
            calculatorArray[2] = new scoreCardCalculator(diceArray[2]);
            calculatorArray[3] = new scoreCardCalculator(diceArray[3]);
            calculatorArray[4] = new scoreCardCalculator(diceArray[4]);
            calculatorArray[5] = new scoreCardCalculator(diceArray[5]);
            calculatorArray[6] = new scoreCardCalculator(diceArray[6]);
            calculatorArray[7] = new scoreCardCalculator(diceArray[7]);
            calculatorArray[8] = new scoreCardCalculator(diceArray[8]);
            calculatorArray[9] = new scoreCardCalculator(diceArray[9]);
            calculatorArray[10] = new scoreCardCalculator(diceArray[10]);
            calculatorArray[11] = new scoreCardCalculator(diceArray[11]);
            calculatorArray[12] = new scoreCardCalculator(diceArray[12]);
            calculatorArray[13] = new scoreCardCalculator(diceArray[13]);
            calculatorArray[14] = new scoreCardCalculator(diceArray[14]);
            calculatorArray[15] = new scoreCardCalculator(diceArray[15]);
            calculatorArray[16] = new scoreCardCalculator(diceArray[16]);
            calculatorArray[17] = new scoreCardCalculator(diceArray[17]);
            calculatorArray[18] = new scoreCardCalculator(diceArray[18]);
            calculatorArray[19] = new scoreCardCalculator(diceArray[19]);
            calculatorArray[20] = new scoreCardCalculator(diceArray[20]);
            calculatorArray[21] = new scoreCardCalculator(diceArray[21]);
            calculatorArray[22] = new scoreCardCalculator(diceArray[22]);
            calculatorArray[23] = new scoreCardCalculator(diceArray[23]);
            calculatorArray[24] = new scoreCardCalculator(diceArray[24]);
            calculatorArray[25] = new scoreCardCalculator(diceArray[25]);
            calculatorArray[26] = new scoreCardCalculator(diceArray[26]);
            calculatorArray[27] = new scoreCardCalculator(diceArray[27]);
            calculatorArray[28] = new scoreCardCalculator(diceArray[28]);
            calculatorArray[29] = new scoreCardCalculator(diceArray[29]);
            calculatorArray[30] = new scoreCardCalculator(diceArray[30]);

            //Assert           
            Assert.AreEqual(25, calculatorArray[0].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[1].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[2].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[3].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[4].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[5].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[6].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[7].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[8].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[9].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[10].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[11].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[12].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[13].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[14].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[15].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[16].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[17].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[18].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[19].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[20].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[21].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[22].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[23].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[24].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[25].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[26].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[27].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[28].fullHouseScore);
            Assert.AreEqual(25, calculatorArray[29].fullHouseScore);
            Assert.AreEqual(0, calculatorArray[30].fullHouseScore);

        }
    }
}
