using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ainum.network;
using ainum.utilities;

namespace ainum.forms
{
    public partial class ManualPropationForm : Form
    {
        public ManualPropationForm()
        {
            InitializeComponent();
        }

        private DataTable table1;
        private DataTable table2;
        private float[,] correctionData;
        public void UpdateData()
        {
            float[,] outputData;

            Neuron[] last = Program.getLoadedNetwork().Layers[Program.getLoadedNetwork().Layers.Length-1].neurons;
            outputData = new float[last.Length,2];
            correctionData = new float[last.Length,2];
            for (int i = 0; i < last.Length; i++)
            {
                outputData[i,0] = i;
                correctionData[i,0] = i;
                outputData[i,1] = last[i].GetActivation();
            }

            table1 = DataUtils.TwoDFloatArrayToDataTable<float>(outputData);
            table2 = DataUtils.TwoDFloatArrayToDataTable<float>(correctionData);
            dataGrid1.DataSource = table1;
            dataGrid2.DataSource = table2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(dataGrid2[i,0] + " ");   
             Console.WriteLine(dataGrid2[i,1]);   
            }
        }
    }
}