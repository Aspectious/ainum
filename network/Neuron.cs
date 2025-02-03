using System;
using ainum.utilities;

namespace ainum.network
{
    public class Neuron : INeuron
    {
        private float activation;
        private float[] inputs;
        private float[] weights;
        private float bias;
        private Layer parentLayer;

        public Neuron(Layer parentLayer)
        {

                weights = new float[] { 0 };
                inputs = new float[] { 0 };
                bias = 0;
                activation = 0;
                this.parentLayer = parentLayer;
        }

        public void Initialize(int numWeight)
        {
            weights = new float[numWeight];
            return;
        }
        public void Simulate()
        {
            float weightedsum = utilities.MathUtils.computeWeightedSum(inputs, weights, bias);
            Console.Write("Neuron Simulated, result: " + weightedsum + ", bias: " + bias + ", weights: ");
            for (int i = 0; i < weights.Length; i++)
            {
                Console.Write("{0} ", weights[i]);
            }
            Console.WriteLine();
            this.activation = weightedsum;
        }

        public void setActivation(float activation)
        {
            this.activation = activation;
        }
        public float[] GetWeights()
        {
            return weights;
        }

        public float GetActivation()
        {
            return activation;
        }

        public void SetInputs(float[] inputs)
        {
            this.inputs = inputs;
        }
        public float GetBias()
        {
            return bias;
        }

        public bool setWeights(float[] weights)
        {
            this.weights = weights;
            return true;
        }

        public float[,] calcualteDesiredWABDelta()
        {
            float[,] wabDeltas = new float[inputs.Length,3];
            for (int i = 0; i < weights.Length; i++)
            {
                wabDeltas[0, i] = weights[i] + inputs[i];
                wabDeltas[1, i] = inputs[i] + weights[i];
                wabDeltas
            }
        }

        public bool randomizeWeightsAndBias()
        {
            for (int i = 0; i < weights.Length; ++i)
            {
                weights[i] = Entropy.getEntropy();
            }

            bias = (Entropy.getEntropy()*40);
            return true;
        }

        public bool setBias(float bias)
        {
            this.bias = bias;
            return true;
        }
    }
}