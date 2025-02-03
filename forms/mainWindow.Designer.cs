using System.ComponentModel;

namespace ainum.forms
{
    public partial class mainWindow
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.imageImporterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSavedNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCurrentNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewNeuralNetworkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.networkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.importImageToInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.step1SimulationCycleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cycleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyclesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.forceRandomReinitializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wipeNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playPauseAutopilotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autopilotModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullAutopilotModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataReviewModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autopilotOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.autopilotSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.simulationSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.simulationSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_loadednet = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.networkGraphBox = new System.Windows.Forms.PictureBox();
            this.importedImageBox = new System.Windows.Forms.PictureBox();
            this.Panel_NetworkVis = new System.Windows.Forms.Panel();
            this.panel_Netvis_settings = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NVis_DV = new System.Windows.Forms.DataGrid();
            this.NVis_Tree = new System.Windows.Forms.TreeView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.SaveNetworkToFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenNetworkFromFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenImageToNetworkFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.miniToolStrip.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panel_loadednet.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.networkGraphBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importedImageBox)).BeginInit();
            this.Panel_NetworkVis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NVis_DV)).BeginInit();
            this.SuspendLayout();
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripButton1, this.toolStripDropDownButton1 });
            this.miniToolStrip.Location = new System.Drawing.Point(0, 0);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(724, 25);
            this.miniToolStrip.TabIndex = 2;
            this.miniToolStrip.Visible = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(98, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.imageImporterToolStripMenuItem });
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(48, 22);
            this.toolStripDropDownButton1.Text = "Tools";
            // 
            // imageImporterToolStripMenuItem
            // 
            this.imageImporterToolStripMenuItem.Name = "imageImporterToolStripMenuItem";
            this.imageImporterToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.imageImporterToolStripMenuItem.Text = "Image Importer";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.LimeGreen;
            this.progressBar1.Location = new System.Drawing.Point(300, 447);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(412, 21);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fileToolStripMenuItem, this.networkToolStripMenuItem, this.toolsToolStripMenuItem, this.viewToolStripMenuItem });
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(724, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.openSavedNetworkToolStripMenuItem, this.saveCurrentNetworkToolStripMenuItem, this.createNewNeuralNetworkToolStripMenuItem1, this.toolStripSeparator1 });
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openSavedNetworkToolStripMenuItem
            // 
            this.openSavedNetworkToolStripMenuItem.Name = "openSavedNetworkToolStripMenuItem";
            this.openSavedNetworkToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.openSavedNetworkToolStripMenuItem.Text = "Open Saved Network...";
            // 
            // saveCurrentNetworkToolStripMenuItem
            // 
            this.saveCurrentNetworkToolStripMenuItem.Name = "saveCurrentNetworkToolStripMenuItem";
            this.saveCurrentNetworkToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.saveCurrentNetworkToolStripMenuItem.Text = "Save Current Network";
            // 
            // createNewNeuralNetworkToolStripMenuItem1
            // 
            this.createNewNeuralNetworkToolStripMenuItem1.Name = "createNewNeuralNetworkToolStripMenuItem1";
            this.createNewNeuralNetworkToolStripMenuItem1.Size = new System.Drawing.Size(221, 22);
            this.createNewNeuralNetworkToolStripMenuItem1.Text = "Create New Neural Network";
            this.createNewNeuralNetworkToolStripMenuItem1.Click += new System.EventHandler(this.createNewNeuralNetworkToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(218, 6);
            // 
            // networkToolStripMenuItem
            // 
            this.networkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripMenuItem2, this.playPauseAutopilotToolStripMenuItem, this.autopilotModeToolStripMenuItem, this.toolStripSeparator4, this.simulationSpeedToolStripMenuItem, this.toolStripMenuItem1, this.toolStripSeparator6, this.simulationSettingsToolStripMenuItem, this.networkSettingsToolStripMenuItem });
            this.networkToolStripMenuItem.Name = "networkToolStripMenuItem";
            this.networkToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.networkToolStripMenuItem.Text = "Network";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.importImageToInputToolStripMenuItem, this.step1SimulationCycleToolStripMenuItem, this.manualUpdateToolStripMenuItem, this.toolStripSeparator3, this.forceRandomReinitializationToolStripMenuItem, this.editNetworkToolStripMenuItem, this.wipeNetworkToolStripMenuItem });
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItem2.Text = "Manual Controls";
            // 
            // importImageToInputToolStripMenuItem
            // 
            this.importImageToInputToolStripMenuItem.Enabled = false;
            this.importImageToInputToolStripMenuItem.Name = "importImageToInputToolStripMenuItem";
            this.importImageToInputToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.importImageToInputToolStripMenuItem.Text = "Import Image to Input";
            this.importImageToInputToolStripMenuItem.Click += new System.EventHandler(this.importImageToInputToolStripMenuItem_Click);
            // 
            // step1SimulationCycleToolStripMenuItem
            // 
            this.step1SimulationCycleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.cycleToolStripMenuItem, this.cyclesToolStripMenuItem, this.cyclesToolStripMenuItem1, this.toolStripSeparator2, this.stepToolStripMenuItem });
            this.step1SimulationCycleToolStripMenuItem.Enabled = false;
            this.step1SimulationCycleToolStripMenuItem.Name = "step1SimulationCycleToolStripMenuItem";
            this.step1SimulationCycleToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.step1SimulationCycleToolStripMenuItem.Text = "Progress Simulation...";
            // 
            // cycleToolStripMenuItem
            // 
            this.cycleToolStripMenuItem.Enabled = false;
            this.cycleToolStripMenuItem.Name = "cycleToolStripMenuItem";
            this.cycleToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.cycleToolStripMenuItem.Text = "1 Cycle";
            this.cycleToolStripMenuItem.Click += new System.EventHandler(this.cycleToolStripMenuItem_Click);
            // 
            // cyclesToolStripMenuItem
            // 
            this.cyclesToolStripMenuItem.Enabled = false;
            this.cyclesToolStripMenuItem.Name = "cyclesToolStripMenuItem";
            this.cyclesToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.cyclesToolStripMenuItem.Text = "5 Cycles";
            this.cyclesToolStripMenuItem.Click += new System.EventHandler(this.cyclesToolStripMenuItem_Click);
            // 
            // cyclesToolStripMenuItem1
            // 
            this.cyclesToolStripMenuItem1.Enabled = false;
            this.cyclesToolStripMenuItem1.Name = "cyclesToolStripMenuItem1";
            this.cyclesToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.cyclesToolStripMenuItem1.Text = "20 Cycles";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(120, 6);
            // 
            // stepToolStripMenuItem
            // 
            this.stepToolStripMenuItem.Enabled = false;
            this.stepToolStripMenuItem.Name = "stepToolStripMenuItem";
            this.stepToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.stepToolStripMenuItem.Text = "1 Step";
            // 
            // manualUpdateToolStripMenuItem
            // 
            this.manualUpdateToolStripMenuItem.Name = "manualUpdateToolStripMenuItem";
            this.manualUpdateToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.manualUpdateToolStripMenuItem.Text = "Manual Propagation...";
            this.manualUpdateToolStripMenuItem.Click += new System.EventHandler(this.manualUpdateToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(228, 6);
            // 
            // forceRandomReinitializationToolStripMenuItem
            // 
            this.forceRandomReinitializationToolStripMenuItem.Enabled = false;
            this.forceRandomReinitializationToolStripMenuItem.Name = "forceRandomReinitializationToolStripMenuItem";
            this.forceRandomReinitializationToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.forceRandomReinitializationToolStripMenuItem.Text = "Force Random Reinitialization";
            // 
            // editNetworkToolStripMenuItem
            // 
            this.editNetworkToolStripMenuItem.Enabled = false;
            this.editNetworkToolStripMenuItem.Name = "editNetworkToolStripMenuItem";
            this.editNetworkToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.editNetworkToolStripMenuItem.Text = "Edit Network";
            // 
            // wipeNetworkToolStripMenuItem
            // 
            this.wipeNetworkToolStripMenuItem.Enabled = false;
            this.wipeNetworkToolStripMenuItem.Name = "wipeNetworkToolStripMenuItem";
            this.wipeNetworkToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.wipeNetworkToolStripMenuItem.Text = "Wipe Network";
            // 
            // playPauseAutopilotToolStripMenuItem
            // 
            this.playPauseAutopilotToolStripMenuItem.Enabled = false;
            this.playPauseAutopilotToolStripMenuItem.Name = "playPauseAutopilotToolStripMenuItem";
            this.playPauseAutopilotToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.playPauseAutopilotToolStripMenuItem.Text = "Play/Pause Autopilot";
            // 
            // autopilotModeToolStripMenuItem
            // 
            this.autopilotModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fullAutopilotModeToolStripMenuItem, this.trainingModeToolStripMenuItem, this.dataReviewModeToolStripMenuItem, this.autopilotOffToolStripMenuItem, this.toolStripSeparator5, this.autopilotSettingsToolStripMenuItem });
            this.autopilotModeToolStripMenuItem.Name = "autopilotModeToolStripMenuItem";
            this.autopilotModeToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.autopilotModeToolStripMenuItem.Text = "Autopilot Mode...";
            // 
            // fullAutopilotModeToolStripMenuItem
            // 
            this.fullAutopilotModeToolStripMenuItem.Name = "fullAutopilotModeToolStripMenuItem";
            this.fullAutopilotModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fullAutopilotModeToolStripMenuItem.Text = "Full Autopilot Mode";
            // 
            // trainingModeToolStripMenuItem
            // 
            this.trainingModeToolStripMenuItem.Name = "trainingModeToolStripMenuItem";
            this.trainingModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trainingModeToolStripMenuItem.Text = "Training Mode";
            // 
            // dataReviewModeToolStripMenuItem
            // 
            this.dataReviewModeToolStripMenuItem.Name = "dataReviewModeToolStripMenuItem";
            this.dataReviewModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataReviewModeToolStripMenuItem.Text = "Data Review Mode";
            // 
            // autopilotOffToolStripMenuItem
            // 
            this.autopilotOffToolStripMenuItem.Checked = true;
            this.autopilotOffToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autopilotOffToolStripMenuItem.Name = "autopilotOffToolStripMenuItem";
            this.autopilotOffToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autopilotOffToolStripMenuItem.Text = "Autopilot Off";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // autopilotSettingsToolStripMenuItem
            // 
            this.autopilotSettingsToolStripMenuItem.Name = "autopilotSettingsToolStripMenuItem";
            this.autopilotSettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autopilotSettingsToolStripMenuItem.Text = "Autopilot Settings...";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(182, 6);
            // 
            // simulationSpeedToolStripMenuItem
            // 
            this.simulationSpeedToolStripMenuItem.Enabled = false;
            this.simulationSpeedToolStripMenuItem.Name = "simulationSpeedToolStripMenuItem";
            this.simulationSpeedToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.simulationSpeedToolStripMenuItem.Text = "Simulation Speed";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItem1.Text = "Simulation Timer";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(182, 6);
            // 
            // simulationSettingsToolStripMenuItem
            // 
            this.simulationSettingsToolStripMenuItem.Enabled = false;
            this.simulationSettingsToolStripMenuItem.Name = "simulationSettingsToolStripMenuItem";
            this.simulationSettingsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.simulationSettingsToolStripMenuItem.Text = "Simulation Settings...";
            // 
            // networkSettingsToolStripMenuItem
            // 
            this.networkSettingsToolStripMenuItem.Enabled = false;
            this.networkSettingsToolStripMenuItem.Name = "networkSettingsToolStripMenuItem";
            this.networkSettingsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.networkSettingsToolStripMenuItem.Text = "Network Settings...";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.imageToolToolStripMenuItem });
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // imageToolToolStripMenuItem
            // 
            this.imageToolToolStripMenuItem.Name = "imageToolToolStripMenuItem";
            this.imageToolToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.imageToolToolStripMenuItem.Text = "Image Tool";
            this.imageToolToolStripMenuItem.Click += new System.EventHandler(this.imageToolToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.statisticsToolStripMenuItem });
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // panel_loadednet
            // 
            this.panel_loadednet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_loadednet.Controls.Add(this.panel2);
            this.panel_loadednet.Controls.Add(this.panel1);
            this.panel_loadednet.Controls.Add(this.Panel_NetworkVis);
            this.panel_loadednet.Location = new System.Drawing.Point(12, 27);
            this.panel_loadednet.Name = "panel_loadednet";
            this.panel_loadednet.Size = new System.Drawing.Size(700, 414);
            this.panel_loadednet.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(442, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 155);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.networkGraphBox);
            this.panel1.Controls.Add(this.importedImageBox);
            this.panel1.Location = new System.Drawing.Point(3, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 158);
            this.panel1.TabIndex = 1;
            // 
            // networkGraphBox
            // 
            this.networkGraphBox.Location = new System.Drawing.Point(162, 3);
            this.networkGraphBox.Name = "networkGraphBox";
            this.networkGraphBox.Size = new System.Drawing.Size(271, 152);
            this.networkGraphBox.TabIndex = 1;
            this.networkGraphBox.TabStop = false;
            // 
            // importedImageBox
            // 
            this.importedImageBox.Location = new System.Drawing.Point(4, 3);
            this.importedImageBox.Name = "importedImageBox";
            this.importedImageBox.Size = new System.Drawing.Size(152, 152);
            this.importedImageBox.TabIndex = 0;
            this.importedImageBox.TabStop = false;
            // 
            // Panel_NetworkVis
            // 
            this.Panel_NetworkVis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_NetworkVis.Controls.Add(this.panel_Netvis_settings);
            this.Panel_NetworkVis.Controls.Add(this.label1);
            this.Panel_NetworkVis.Controls.Add(this.NVis_DV);
            this.Panel_NetworkVis.Controls.Add(this.NVis_Tree);
            this.Panel_NetworkVis.Location = new System.Drawing.Point(3, 3);
            this.Panel_NetworkVis.Name = "Panel_NetworkVis";
            this.Panel_NetworkVis.Size = new System.Drawing.Size(692, 242);
            this.Panel_NetworkVis.TabIndex = 0;
            // 
            // panel_Netvis_settings
            // 
            this.panel_Netvis_settings.Location = new System.Drawing.Point(429, 21);
            this.panel_Netvis_settings.Name = "panel_Netvis_settings";
            this.panel_Netvis_settings.Size = new System.Drawing.Size(258, 210);
            this.panel_Netvis_settings.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Network Visualization";
            // 
            // NVis_DV
            // 
            this.NVis_DV.DataMember = "";
            this.NVis_DV.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.NVis_DV.Location = new System.Drawing.Point(202, 21);
            this.NVis_DV.Name = "NVis_DV";
            this.NVis_DV.Size = new System.Drawing.Size(221, 211);
            this.NVis_DV.TabIndex = 1;
            // 
            // NVis_Tree
            // 
            this.NVis_Tree.Location = new System.Drawing.Point(3, 20);
            this.NVis_Tree.Name = "NVis_Tree";
            this.NVis_Tree.Size = new System.Drawing.Size(193, 211);
            this.NVis_Tree.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 447);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(724, 21);
            this.statusBar.TabIndex = 7;
            this.statusBar.Text = "No Network Loaded.";
            // 
            // OpenNetworkFromFileDialog
            // 
            this.OpenNetworkFromFileDialog.FileName = "openFileDialog1";
            // 
            // OpenImageToNetworkFileDialog
            // 
            this.OpenImageToNetworkFileDialog.FileName = "openFileDialog1";
            // 
            // mainWindow
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(724, 468);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.panel_loadednet);
            this.Controls.Add(this.miniToolStrip);
            this.Controls.Add(this.menuStrip2);
            this.Location = new System.Drawing.Point(15, 15);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "mainWindow";
            this.Text = "AI Network Control Panel";
            this.miniToolStrip.ResumeLayout(false);
            this.miniToolStrip.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel_loadednet.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.networkGraphBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importedImageBox)).EndInit();
            this.Panel_NetworkVis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NVis_DV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox importedImageBox;
        private System.Windows.Forms.PictureBox networkGraphBox;
        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Panel panel_Netvis_settings;

        private System.Windows.Forms.DataGrid NVis_DV;
        private System.Windows.Forms.Panel Panel_NetworkVis;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.StatusBar statusBar;
        private System.Windows.Forms.SaveFileDialog SaveNetworkToFileDialog;
        private System.Windows.Forms.OpenFileDialog OpenNetworkFromFileDialog;
        private System.Windows.Forms.OpenFileDialog OpenImageToNetworkFileDialog;
        private System.Windows.Forms.TreeView NVis_Tree;

        private System.Windows.Forms.ToolStripMenuItem simulationSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem networkSettingsToolStripMenuItem;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

        private System.Windows.Forms.ToolStripMenuItem simulationSpeedToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem autopilotSettingsToolStripMenuItem;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

        private System.Windows.Forms.ToolStripMenuItem autopilotModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullAutopilotModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataReviewModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainingModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autopilotOffToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playPauseAutopilotToolStripMenuItem;

        private System.Windows.Forms.CheckBox checkBox1;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem forceRandomReinitializationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNetworkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wipeNetworkToolStripMenuItem;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem stepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualUpdateToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem cycleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyclesToolStripMenuItem1;

        private System.Windows.Forms.ToolStripMenuItem step1SimulationCycleToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem importImageToInputToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        private System.Windows.Forms.ToolStripMenuItem openSavedNetworkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCurrentNetworkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewNeuralNetworkToolStripMenuItem1;

        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem networkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolToolStripMenuItem;

        private System.Windows.Forms.Panel panel_loadednet;

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem imageImporterToolStripMenuItem;

        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;

        private System.Windows.Forms.ToolStripButton toolStripButton1;

        private System.Windows.Forms.ToolStrip miniToolStrip;
        public System.Windows.Forms.ProgressBar progressBar1;
    }
}