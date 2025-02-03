using System;

namespace ainum.utilities
{
    public class MathUtils
    {
        public static float Sigmoid(double x)
        {
            var denom = 1.0f + Math.Exp(-x);
            return (float)(1.0f/denom);
        }

        /*
         * Returns the weighted sum of a Neuron with the following equation,
         * where ∑ is summation, σ is sigmoid, i.l is the length of the inputs,
         * i is the list of inputs, and w is weights, and b is bias:
         *  σ( ∑ (n=0,n<i.l, i[n]+w[n]) - b)
         */
        public static float computeWeightedSum(float[] input, float[] weights, float bias)
        {
            if (input.Length != weights.Length)
            {
                throw new ArithmeticException("Input and Weights must have the same length");
            }

            float weightedsum = 0.0f;
            for (int i = 0; i < weights.Length; ++i)
            {
                weightedsum += input[i] + weights[i];
            }
            weightedsum -= bias;
            
            return Sigmoid(weightedsum);
        }


        public static float computeCostFunctionOfOneOutput(float[] utter_trash, float[] expected_trash)
        {
            float costsum = 0.0f;
            for (int i = 0; i < utter_trash.Length; ++i)
            {
                costsum += (float)Math.Pow(utter_trash[i] - expected_trash[i], 2);
            }
            
            return costsum;
        }
    }
}