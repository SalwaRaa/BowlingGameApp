namespace BowlingClassLibrary
{
    public class Round
    {
            private int[] rolls = new int[21];
            private int[] frame = new int[10];
            int currentRoll = 0;
            
            public void Roll(int pins)
            {
                rolls[currentRoll++] = pins;
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
                    {
                        score += rolls[frameIndex] + rolls[frameIndex + 1];
                        frameIndex += 2;
                    }

                }

                return score;
            }
        }
}