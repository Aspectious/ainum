using System;
using System.Threading;
using System.Windows.Forms;
using ainum.network;

namespace ainum.forms
{
    public partial class NetworkCreationWindow : Form
    {
        public NetworkCreationWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int LayerCount = (int)LayerCountUpDownn.Value;
            if (LayerCount < 3)
            {
                MessageBox.Show("Must have at least 3 layers!", "Error");
                return;
            }
            int[] neuronsPerLayer = new int[LayerCount];
            string[] NPLFIELD_raw = NeuronsPerLayerField.Text.Split(',');
            if (NPLFIELD_raw.Length != LayerCount)
            {
                MessageBox.Show("NeuronsPerLayer field is invalid.", "Error");
                return;
            }
            for (int i = 0; i < LayerCount; i++)
            {
                string str = NPLFIELD_raw[i];
                if (!int.TryParse(str, out neuronsPerLayer[i]))
                {
                    MessageBox.Show("NeuronsPerLayer field is invalid.", "Error");
                    return;
                }
            }

            bool randomizeOnStart = InitLayersWithRandomCheckbox.Checked;
            if (NetworkNameField.Text.Length == 0)
            {
                MessageBox.Show("Network Must Be Named.", "Error");
                return;
            }
            string NetworkName = NetworkNameField.Text;
            
            NetworkSettings settings = new NetworkSettings();
            settings.NetworkName = NetworkName;
            settings.LayerCount = LayerCount;
            settings.NeuronsPerLayer = neuronsPerLayer;
            settings.RanndomizeValuesAtStartup = randomizeOnStart;
            settings.NetworkAge = 0;
            
            Console.WriteLine("Creating New Network " + NetworkName);
            Network network = new Network(settings);
            Program.loadNetwork(network);
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}