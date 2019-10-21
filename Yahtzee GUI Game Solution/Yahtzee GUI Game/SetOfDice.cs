using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_GUI_Game
{
    public interface diceInterface
    {
        void roll(List<int> diceNotToRoll);
        int[] diceNumbers { get; set; }
    }

    public class setOfDice : diceInterface
    {
        public int[] diceNumbers { get; set; }
        private Random RNG;

        public setOfDice()
        {
            diceNumbers = new int[5];
            RNG = new Random();
            for (int i = 0; i < 5; ++i) diceNumbers[i] = -1;
        }

        public void roll(List<int> diceNotToRoll)
        {
            for (int i = 0; i < 5; ++i)
            {
                if (!diceNotToRoll.Contains(i + 1))
                {
                    diceNumbers[i] = RNG.Next(1, 7);
                }
            }
        }
    }

    public class setOfDiceForTesting : diceInterface
    {
        public int[] diceNumbers { get; set; }

        public setOfDiceForTesting()
        {
            diceNumbers = new int[5];
            for (int i = 0; i < 5; ++i) diceNumbers[i] = -1;
        }

        public void roll(List<int> newDiceNumbers)
        {
            newDiceNumbers.CopyTo(diceNumbers);
        }
    }

}
