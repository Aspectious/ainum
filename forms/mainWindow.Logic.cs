using System.Windows.Forms;
using ainum.network;

namespace ainum.forms
{
    public partial class mainWindow
    {
        private void setupNetwork()
        {
            Network net = Program.getLoadedNetwork();
            
            // Update UI
            
            // Update Network Tab
            toolStripMenuItem2.Enabled = true;
            importImageToInputToolStripMenuItem.Enabled = true;
            step1SimulationCycleToolStripMenuItem.Enabled = true;
            cycleToolStripMenuItem.Enabled = true;
            cyclesToolStripMenuItem.Enabled = true;
            cyclesToolStripMenuItem1.Enabled = true;
            stepToolStripMenuItem.Enabled = true;
            manualUpdateToolStripMenuItem.Enabled = true;
            forceRandomReinitializationToolStripMenuItem.Enabled = true;
            editNetworkToolStripMenuItem.Enabled = true;
            wipeNetworkToolStripMenuItem.Enabled = true;
            
            
            playPauseAutopilotToolStripMenuItem.Enabled = true;

            simulationSpeedToolStripMenuItem.Enabled = true;
            toolStripMenuItem1.Enabled = true;
            simulationSettingsToolStripMenuItem.Enabled = true;
            networkSettingsToolStripMenuItem.Enabled = true;


            // Begin Updating Panels
            NVis_Tree.BeginUpdate();
            
            NVis_Tree.Nodes.Clear();
            int hiddenlayer_counter = 1;
            TreeNode[] LayerNodes = new TreeNode[net.getLayerCount()];
            for (int i = 0; i < net.getLayerCount(); i++)
            {
                if (i == 0)
                {
                    LayerNodes[i] = new TreeNode("Input Layer");
                    LayerNodes[i].Nodes.Add(new TreeNode("Neurons (" + net.getNeuronsPerLayer()[i] + ")"));
                    for (int j = 0; j < net.getNeuronsPerLayer()[i]; j++)
                    {
                        LayerNodes[i].Nodes[0].Nodes.Add("Neuron (" + j + ")");
                    }
                } else if (i == net.getLayerCount() - 1)
                {
                    LayerNodes[i] = new TreeNode("Output Layer");
                    LayerNodes[i].Nodes.Add(new TreeNode("Neurons (" + net.getNeuronsPerLayer()[i] + ")"));
                    for (int j = 0; j < net.getNeuronsPerLayer()[i]; j++)
                    {
                        LayerNodes[i].Nodes[0].Nodes.Add("Neuron " + j + "");
                    }
                }
                else
                {
                    LayerNodes[i] = new TreeNode("Hidden Layer"  + hiddenlayer_counter.ToString());
                    LayerNodes[i].Nodes.Add(new TreeNode("Neurons (" + net.getNeuronsPerLayer()[i] + ")"));
                    for (int j = 0; j < net.getNeuronsPerLayer()[i]; j++)
                    {
                        LayerNodes[i].Nodes[0].Nodes.Add("Neuron (" + j + ")");
                    }
                    hiddenlayer_counter++;
                }

            }

            foreach (TreeNode node in LayerNodes)
            {
                NVis_Tree.Nodes.Add(node);
            }
            
            NVis_Tree.EndUpdate();

            statusBar.Text = "Loaded Network " + net.getName();
        }

        public void setStatusText(string text)
        {
            this.statusBar.Text = text;
        }
        
    }
}