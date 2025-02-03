using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security;
using System.Windows.Forms;
using ainum.network;

namespace ainum.forms
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        public void SetupWindowForNetwork()
        {
            setupNetwork();

        }

        private void imageToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ImageTool = new ImageTool();
            ImageTool.ShowDialog();
        }


        private void createNewNeuralNetworkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form NCW = new NetworkCreationWindow();
            NCW.ShowDialog();
        }
        

        private void importImageToInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenImageToNetworkFileDialog = new OpenFileDialog();
                if (OpenImageToNetworkFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {

                        var fileStream = new FileStream(OpenImageToNetworkFileDialog.FileName, FileMode.Open);
                        Image image = Image.FromStream(fileStream);
                        Console.WriteLine("Importing Image To Network: " + OpenImageToNetworkFileDialog.FileName);
                        Console.WriteLine("Width: " + image.Width + "\nHeight: " + image.Height);
                        float[,] valtable = utilities.ImageUtil.ConvertImageTo2DArray((Bitmap)image);
                        float[] fullvals = new float[784];
                        int index = 0;
                        for (int y = 0; y < 28; y++)
                        {
                            for (int x = 0; x < 28; x++)
                            {
                                fullvals[index] = valtable[y,x];
                                index++;
                            }
                        }

                        importedImageBox.Image = image;
                        importedImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        Program.loadedImage = image;
                        Program.getLoadedNetwork().Layers[0].updateNeurons(fullvals);
                    }
                    catch (SecurityException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
        }

        private void cycleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.getLoadedNetwork().SimulateNetworkForOneCycle();
        }

        private void cyclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.getLoadedNetwork().SimulateNetworkForNCycles(5);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void manualUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManualPropationForm manPropForm = new ManualPropationForm();
            manPropForm.UpdateData();
            manPropForm.ShowDialog();
        }
    }
}