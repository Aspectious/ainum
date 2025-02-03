using System.ComponentModel;

namespace ainum.forms
{
    partial class NetworkCreationWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.NetworkNameField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InitLayersWithRandomCheckbox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NeuronsPerLayerField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LayerCountUpDownn = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LayerCountUpDownn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.NetworkNameField);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.InitLayersWithRandomCheckbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.NeuronsPerLayerField);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LayerCountUpDownn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 192);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(253, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 27);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(382, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Create Network";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NetworkNameField
            // 
            this.NetworkNameField.Location = new System.Drawing.Point(227, 128);
            this.NetworkNameField.Name = "NetworkNameField";
            this.NetworkNameField.Size = new System.Drawing.Size(277, 20);
            this.NetworkNameField.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(3, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Neural Network Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InitLayersWithRandomCheckbox
            // 
            this.InitLayersWithRandomCheckbox.Location = new System.Drawing.Point(3, 95);
            this.InitLayersWithRandomCheckbox.Name = "InitLayersWithRandomCheckbox";
            this.InitLayersWithRandomCheckbox.Size = new System.Drawing.Size(501, 30);
            this.InitLayersWithRandomCheckbox.TabIndex = 5;
            this.InitLayersWithRandomCheckbox.Text = "Initialize All Neurons with Random Weights and Biases (Uncheck for all to be 0)";
            this.InitLayersWithRandomCheckbox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(501, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Neurons Per Layer, From Input to Output, Seperated by Commas (,)";
            // 
            // NeuronsPerLayerField
            // 
            this.NeuronsPerLayerField.Location = new System.Drawing.Point(3, 69);
            this.NeuronsPerLayerField.Name = "NeuronsPerLayerField";
            this.NeuronsPerLayerField.Size = new System.Drawing.Size(501, 20);
            this.NeuronsPerLayerField.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Layer Count (total)";
            // 
            // LayerCountUpDownn
            // 
            this.LayerCountUpDownn.Location = new System.Drawing.Point(400, 25);
            this.LayerCountUpDownn.Name = "LayerCountUpDownn";
            this.LayerCountUpDownn.Size = new System.Drawing.Size(104, 20);
            this.LayerCountUpDownn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Network Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NetworkCreationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 215);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NetworkCreationWindow";
            this.Text = "Create a New Neural Network";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LayerCountUpDownn)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.TextBox NetworkNameField;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.CheckBox InitLayersWithRandomCheckbox;

        private System.Windows.Forms.TextBox NeuronsPerLayerField;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.NumericUpDown LayerCountUpDownn;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}