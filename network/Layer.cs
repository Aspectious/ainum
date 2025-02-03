using System;

namespace ainum.network
{
    public class Layer
    {
        public Layer prevLayer;
        public Layer nextLayer;
        public Neuron[] neurons;

        public Layer(int NeuronCount)
        {
            neurons = new Neuron[NeuronCount];
            for (int i = 0; i < NeuronCount; i++)
            {
                neurons[i] = new Neuron(this);
            }
        }

        public void linkPrevLayer(Layer prevL)
        {
            this.prevLayer = prevL;
        }

        public void linkNextLayer(Layer nextL)
        {
            this.nextLayer = nextL;
        }

        // DO NOT USE UNLESS IT IS INPUT LAYER
        public void updateNeurons(float[] inputs)
        {
            for (int i = 0; i < inputs.Length; i++)
            {
                neurons[i].setActivation(inputs[i]);
            }
        }

        public void InitializeConnections()
        {
            if (prevLayer == null)
            {
                
            }
            else
            {
                foreach (Neuron neuron in neurons)
                {
                    neuron.Initialize(prevLayer.neurons.Length);
                }
            }

        }
        public void randomInit()
        {
            for (int i = 0; i < neurons.Length; i++)
            {
                neurons[i].randomizeWeightsAndBias();
            }
        }

        public void simulate()
        {
            Console.WriteLine("Simulating Layer...");
            if (prevLayer == null)
            {
                // We know it is the first layer this way
                // Do nothing to simulate - values are already there
            }
            else
            {
                float[] inputvals = new float[prevLayer.neurons.Length];
                for (int j = 0; j < inputvals.Length; j++)
                {
                    inputvals[j] = prevLayer.neurons[j].GetActivation();
                }
                // For Each neuron, get the activation of the previous neurons, and calculate the weighed up and activation.
                for (int i = 0; i < neurons.Length; i++)
                {
                    Neuron neuron = neurons[i];
                    neuron.SetInputs(inputvals);
                    neuron.Simulate();
                }
            }
        }
    }
}