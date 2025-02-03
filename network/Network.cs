using System;
using ainum.forms;

namespace ainum.network
{
    public class Network
    {
        public Layer[] Layers;
        private float[] resultValues;
        private float[] inputValues;
        public float LearningRate;
        private NetworkSettings _settings;
        
        public Network(NetworkSettings networkSettings)
        {
            _settings = networkSettings;
            LearningRate = networkSettings.LearningRate;
            int LayerCount = networkSettings.LayerCount;
            int[] NeuronsPerLayer = networkSettings.NeuronsPerLayer;
            Layers = new Layer[LayerCount];
            
            // Create Layers
            for (int i = 0; i < LayerCount; i++)
            {
                Layers[i] = new Layer(NeuronsPerLayer[i], this);
            }
            
            // Link Layers
            for (int i = 0; i < LayerCount; i++)
            {
                if (i == 0)
                {
                    Layers[0].linkNextLayer(Layers[1]);
                } else if (i == LayerCount - 1)
                {
                    Layers[LayerCount - 1].linkPrevLayer(Layers[LayerCount - 2]);
                }
                else
                {
                    Layers[i].linkNextLayer(Layers[i + 1]);
                    Layers[i].linkPrevLayer(Layers[i - 1]);
                }
            }


            foreach (Layer layer in Layers)
            {
                layer.InitializeConnections();
            }
            // Randomize Values Layers, if asked

            if (_settings.RanndomizeValuesAtStartup == true)
            {
                randomzieAllWeightsAndBiases();
            }

            this.StepCount = Layers.Length;
        }

        public bool randomzieAllWeightsAndBiases()
        {
            for (int i = 0; i < Layers.Length; i++)
            {
                Layers[i].randomInit();
            }

            return true;
        }

        public int getLayerCount()
        {
            return Layers.Length;
        }

        public int[] getNeuronsPerLayer()
        {
            return _settings.NeuronsPerLayer;
        }

        public string getName()
        {
            return this._settings.NetworkName;
        }
        


        private int SimStep = 0;
        private int StepCount;
        public void SimulateNetworkForOneCycle()
        {
            this.SimStep = 0;
            Program.mainForm.setStatusText("Simulating Network...");
            Program.mainForm.progressBar1.Minimum = 0;
            Program.mainForm.progressBar1.Maximum = this.StepCount;
            SimStep++;
            Program.mainForm.progressBar1.Value = SimStep;
            Console.WriteLine("NETWORK SIMULATION INITIATED");
            Console.WriteLine("Simulating network...");
            for (int s = 0; s < Layers.Length; s++)
            {
                Program.mainForm.progressBar1.Value = SimStep;
                Console.WriteLine("Attemping Simulation of Layer, step " + s + " of " + StepCount);
                Layers[s].simulate();
                Console.WriteLine("Step Simulated.");
                SimStep++;
            }
            Program.mainForm.setStatusText("Network simulation completed.");
            Console.WriteLine("Network simulation finished");
            Console.WriteLine("Output: ");
            float[] outputValues = new float[Layers[Layers.Length-1].neurons.Length];
            for (int i = 0; i < Layers[Layers.Length - 1].neurons.Length; i++)
            {
                float value = Layers[Layers.Length - 1].neurons[i].GetActivation();
                Console.WriteLine(i + ": "  + value);
                outputValues[i] = value;
            }
        }

        public void SimulateNetworkForNCycles(int n)
        {
            for (int i = 0; i < n; i++)
            {
                SimulateNetworkForOneCycle();
            }
        }
    }
}