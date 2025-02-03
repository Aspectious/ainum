using System;
using System.Collections.Generic;

namespace ainum.network
{
    public class Layer
    {
        public Layer prevLayer;
        public Layer nextLayer;
        public Network ParentNetwork;
        public Neuron[] neurons;
        public float[,] deltaweights;
        public IList<float[,]> deltadeltaweights;

        public Layer(int NeuronCount, Network parentNetwork)
        {
            this.deltaweights = new float[neurons.Length, neurons[0].GetWeights().Length];
            this.deltadeltaweights = new List<float[,]>();
            this.ParentNetwork = parentNetwork;
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

        public bool propagate()
        {
            if (prevLayer == null) return true;
            else
            {
                for (int i = 0; i < neurons.Length; i++)
                {
                    float[] neurondata = neurons[i].calcualteDesiredWeightDelta();
                    for (int j = 0; j < neurondata.Length; j++)
                    {
                        deltaweights[i, j] = neurondata[j];
                    }
                }

                deltadeltaweights.Add(deltaweights);
                return prevLayer.propagate();
            }
        }
        public void commitPropagatedValues()
        {
            float[,] finalaveragedeltaweights = new float[neurons.Length, neurons[0].GetWeights().Length];
            for (int j = 0; j < neurons.Length; j++)
            {
                int times = 0;
                float[] weightedvalues = new float[neurons[j].GetWeights().Length];
                for (int i = 0; i < deltadeltaweights.Count; i++)
                {
                    for( int k =0; k< neurons[j].GetWeights().Length; k++)
                    {
                        weightedvalues[k] += deltadeltaweights[i][j, k];
                    }
                    for (int l=0; l<neurons[j].GetWeights().Length; l++)
                    {
                        finalaveragedeltaweights[j, l] = weightedvalues[l] / deltadeltaweights.Count;
                    }
                }   
            }
            for (int i = 0; i < neurons.Length; i++)
            {
                float[] finaldeltaForNeuron = new float[neurons[i].GetWeights().Length];
                for (int j = 0; j < neurons[i].GetWeights().Length; j++)
                {
                    finaldeltaForNeuron[j] = finalaveragedeltaweights[i, j];
                }
                neurons[i].commitPropagation(finaldeltaForNeuron);
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