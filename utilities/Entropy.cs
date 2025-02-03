using System;

namespace ainum.utilities
{
    public class Entropy
    {
        public static Random random;

        public static void assignRandom()
        {
            random = new Random();
        }
        public static float getEntropy()
        {
            return (float)random.NextDouble();
        }
    }
}