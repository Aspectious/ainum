using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security;
using System.Windows.Forms;
using ainum.utilities;

namespace ainum.forms
{
    public class ImageTool : Form
    {
        public ImageTool()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 392);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(442, 12);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.Size = new System.Drawing.Size(392, 392);
            this.dataGrid1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveFileButton);
            this.panel1.Controls.Add(this.openFileButton);
            this.panel1.Location = new System.Drawing.Point(12, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 33);
            this.panel1.TabIndex = 2;
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(554, 3);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(204, 25);
            this.saveFileButton.TabIndex = 1;
            this.saveFileButton.Text = "Save Generated Output to File...";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(94, 3);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(196, 25);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "Open Image From File...";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // ImageTool
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(847, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ImageTool";
            this.Text = "Image Tool";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button saveFileButton;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGrid dataGrid1;

        private DataTable loadedValTableValues;
        private void openFileButton_Click(object sender, EventArgs e)
        {
            this.openFileDialog1 = new OpenFileDialog();
            try
            {

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {

                        var fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open);
                        Image image = Image.FromStream(fileStream);
                        pictureBox1.Image = image;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        Console.WriteLine("Width: " + image.Width + "\n Height: " + image.Height);
                        float[,] valtable = utilities.ImageUtil.ConvertImageTo2DArray((Bitmap)image);
                        DataTable table = utilities.DataUtils.TwoDFloatArrayToDataTable<float>(valtable);
                        this.loadedValTableValues = table;
                        dataGrid1.DataSource = table;
                    }
                    catch (SecurityException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            if (loadedValTableValues == null)
            {
                MessageBox.Show("Please load values first.", "Error");
            }
            else
            {
                saveFileDialog1.Filter = "Comma-Seperated Value files (*.csv)|*.csv";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    String csvToWriteOut = DataUtils.ConvertDataTableToCSV(loadedValTableValues);
                    File.WriteAllText(saveFileDialog1.FileName, csvToWriteOut);   
                }
            }
        }
    }
}