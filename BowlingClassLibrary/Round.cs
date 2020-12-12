using System.Collections.Generic;
namespace BowlingClassLibrary
{
 
    public class Round
    {
        private int[] rolls = new int[21];
        private int[] frame = new int[10];
        int currentRoll = 0;
        public int _personScore;

        private bool IsSpare(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1] == 10;
        }

        private bool IsStrike(int frameIndex)
        {
            return rolls[frameIndex] == 10;
        }

        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
            _personScore += pins;
        }

        public void Roll(int[] pins)
        {
            for (int i = 0; i < pins.Length; i++)
            {
                rolls[currentRoll++] = pins[i];
            }
        }
      
        public int Score()
        {
            int score = 0;
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (IsSpare(frameIndex))
                {
                    score += 10 + rolls[frameIndex + 2];
                    frameIndex += 2;
                }
                else if (IsStrike(frameIndex))
                {
                    score += 10 + rolls[frameIndex + 1] + rolls[frameIndex + 2];
                    frameIndex++;
                }
                else
                {
                    score += rolls[frameIndex] + rolls[frameIndex + 1];
                    frameIndex += 2;
                }

            }

            return score;
        }

        public int PersonScore()
        {
            return _personScore;
        }

    }
}
