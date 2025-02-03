using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ainum.forms;
using ainum.network;
using ainum.utilities;

namespace ainum
{
    internal class Program
    {
        private static Network LoadedNetwork;
        public static mainWindow mainForm;
        public static Image loadedImage;
        [STAThread]
        public static void Main(string[] args)
        {
            Entropy.assignRandom();
            mainForm = new mainWindow();
            mainForm.ShowDialog();
        }

        public static void loadNetwork(Network network)
        {
            LoadedNetwork = network;
            mainForm.SetupWindowForNetwork();
        }

        public static Network getLoadedNetwork()
        {
            return LoadedNetwork;
        }
    }
}