namespace UsbChargerGui
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.maximStatusStrip1 = new MaximStyle.MaximStatusStrip();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WriteRegister = new MaximStyle.MaximButton();
            this.ReadRegister = new MaximStyle.MaximButton();
            this.RegisterValue = new System.Windows.Forms.TextBox();
            this.RegisterSelection = new MaximStyle.MaximComboBox();
            this.PartSelection = new MaximStyle.MaximComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.LegendDisabled = new MaximStyle.MaximCheckBox();
            this.LegendEnabled = new MaximStyle.MaximCheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.LegendSetLow = new MaximStyle.MaximToggleButton();
            this.LegendSetHigh = new MaximStyle.MaximToggleButton();
            this.LegendLowIndicator = new MaximStyle.MaximStatusIndicator();
            this.label2 = new System.Windows.Forms.Label();
            this.LegendHighIndicator = new MaximStyle.MaximStatusIndicator();
            this.label1 = new System.Windows.Forms.Label();
            this.maximGroupBox2 = new MaximStyle.MaximGroupBox();
            this.AlertIndicator = new MaximStyle.MaximStatusIndicator();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CurrentValue = new System.Windows.Forms.TextBox();
            this.FullCapRepValue = new System.Windows.Forms.TextBox();
            this.TempValue = new System.Windows.Forms.TextBox();
            this.RepCapValue = new System.Windows.Forms.TextBox();
            this.VcellValue = new System.Windows.Forms.TextBox();
            this.SocValue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.AlertEnable = new MaximStyle.MaximCheckBox();
            this.NtcEnable = new MaximStyle.MaximCheckBox();
            this.maximGroupBox1 = new MaximStyle.MaximGroupBox();
            this.ChargeDoneThreshold = new MaximStyle.MaximComboBox();
            this.BatRechargeThreshold = new MaximStyle.MaximComboBox();
            this.PrechargeThreshold = new MaximStyle.MaximComboBox();
            this.BatRegulationThreshold = new MaximStyle.MaximComboBox();
            this.FsusSet = new MaximStyle.MaximToggleButton();
            this.FltinSet = new MaximStyle.MaximToggleButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.IntIndicator = new MaximStyle.MaximStatusIndicator();
            this.SysOkIndicator = new MaximStyle.MaximStatusIndicator();
            this.CdirIndicator = new MaximStyle.MaximStatusIndicator();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IntEnable = new MaximStyle.MaximCheckBox();
            this.AiclEnable = new MaximStyle.MaximCheckBox();
            this.Dcp3aEnable = new MaximStyle.MaximCheckBox();
            this.ChargerEnable = new MaximStyle.MaximCheckBox();
            this.maximTabControl1 = new MaximStyle.MaximTabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LegendLowIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegendHighIndicator)).BeginInit();
            this.maximGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlertIndicator)).BeginInit();
            this.maximGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SysOkIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CdirIndicator)).BeginInit();
            this.maximTabControl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maximStatusStrip1
            // 
            this.maximStatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.maximStatusStrip1.Location = new System.Drawing.Point(0, 663);
            this.maximStatusStrip1.Name = "maximStatusStrip1";
            this.maximStatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.maximStatusStrip1.SectionsNumberOf = 3;
            this.maximStatusStrip1.SectionUseStatusProgressBar = false;
            this.maximStatusStrip1.Size = new System.Drawing.Size(990, 28);
            this.maximStatusStrip1.TabIndex = 2;
            this.maximStatusStrip1.Text = "maximStatusStrip1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.WriteRegister);
            this.tabPage2.Controls.Add(this.ReadRegister);
            this.tabPage2.Controls.Add(this.RegisterValue);
            this.tabPage2.Controls.Add(this.RegisterSelection);
            this.tabPage2.Controls.Add(this.PartSelection);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(982, 541);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Register Access";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Register Value (Hex)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Register Selection";
            // 
            // WriteRegister
            // 
            this.WriteRegister.Location = new System.Drawing.Point(675, 254);
            this.WriteRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WriteRegister.Name = "WriteRegister";
            this.WriteRegister.Size = new System.Drawing.Size(124, 29);
            this.WriteRegister.TabIndex = 4;
            this.WriteRegister.Text = "Write";
            this.WriteRegister.UseVisualStyleBackColor = true;
            this.WriteRegister.Click += new System.EventHandler(this.WriteRegister_Click);
            // 
            // ReadRegister
            // 
            this.ReadRegister.Location = new System.Drawing.Point(503, 254);
            this.ReadRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReadRegister.Name = "ReadRegister";
            this.ReadRegister.Size = new System.Drawing.Size(124, 29);
            this.ReadRegister.TabIndex = 3;
            this.ReadRegister.Text = "Read";
            this.ReadRegister.UseVisualStyleBackColor = true;
            this.ReadRegister.Click += new System.EventHandler(this.ReadRegister_Click);
            // 
            // RegisterValue
            // 
            this.RegisterValue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RegisterValue.Location = new System.Drawing.Point(335, 254);
            this.RegisterValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RegisterValue.Name = "RegisterValue";
            this.RegisterValue.Size = new System.Drawing.Size(137, 28);
            this.RegisterValue.TabIndex = 2;
            // 
            // RegisterSelection
            // 
            this.RegisterSelection.BackColor = System.Drawing.Color.White;
            this.RegisterSelection.DropDownHeight = 200;
            this.RegisterSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RegisterSelection.DropDownWidth = 0;
            this.RegisterSelection.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterSelection.Location = new System.Drawing.Point(503, 158);
            this.RegisterSelection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RegisterSelection.Name = "RegisterSelection";
            this.RegisterSelection.Size = new System.Drawing.Size(296, 31);
            this.RegisterSelection.TabIndex = 1;
            this.RegisterSelection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RegisterSelection.TextAlignDropDownList = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PartSelection
            // 
            this.PartSelection.BackColor = System.Drawing.Color.White;
            this.PartSelection.DropDownHeight = 200;
            this.PartSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PartSelection.DropDownWidth = 0;
            this.PartSelection.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartSelection.Location = new System.Drawing.Point(335, 158);
            this.PartSelection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PartSelection.Name = "PartSelection";
            this.PartSelection.Size = new System.Drawing.Size(137, 31);
            this.PartSelection.TabIndex = 0;
            this.PartSelection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PartSelection.TextAlignDropDownList = System.Windows.Forms.HorizontalAlignment.Center;
            this.PartSelection.SelectedIndexChanged += new System.EventHandler(this.PartSelection_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.maximGroupBox2);
            this.tabPage1.Controls.Add(this.maximGroupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(982, 541);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Demo View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.LegendDisabled);
            this.groupBox1.Controls.Add(this.LegendEnabled);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.LegendSetLow);
            this.groupBox1.Controls.Add(this.LegendSetHigh);
            this.groupBox1.Controls.Add(this.LegendLowIndicator);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LegendHighIndicator);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(792, 222);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(178, 278);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Legend";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(55, 78);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(96, 21);
            this.label22.TabIndex = 33;
            this.label22.Text = "= Disabled";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(55, 45);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(92, 21);
            this.label21.TabIndex = 32;
            this.label21.Text = "= Enabled";
            // 
            // LegendDisabled
            // 
            this.LegendDisabled.AutoSize = true;
            this.LegendDisabled.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LegendDisabled.Location = new System.Drawing.Point(8, 78);
            this.LegendDisabled.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LegendDisabled.Name = "LegendDisabled";
            this.LegendDisabled.Size = new System.Drawing.Size(19, 17);
            this.LegendDisabled.TabIndex = 31;
            this.LegendDisabled.UseVisualStyleBackColor = true;
            this.LegendDisabled.CheckedChanged += new System.EventHandler(this.LegendDisabled_CheckedChanged);
            // 
            // LegendEnabled
            // 
            this.LegendEnabled.AutoSize = true;
            this.LegendEnabled.Checked = true;
            this.LegendEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LegendEnabled.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LegendEnabled.Location = new System.Drawing.Point(8, 45);
            this.LegendEnabled.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LegendEnabled.Name = "LegendEnabled";
            this.LegendEnabled.Size = new System.Drawing.Size(19, 17);
            this.LegendEnabled.TabIndex = 22;
            this.LegendEnabled.UseVisualStyleBackColor = true;
            this.LegendEnabled.CheckedChanged += new System.EventHandler(this.LegendEnabled_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(55, 230);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(111, 21);
            this.label20.TabIndex = 30;
            this.label20.Text = "= Set to Low";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(55, 198);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(115, 21);
            this.label19.TabIndex = 29;
            this.label19.Text = "= Set to High";
            // 
            // LegendSetLow
            // 
            this.LegendSetLow.AutoSize = true;
            this.LegendSetLow.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LegendSetLow.Location = new System.Drawing.Point(8, 230);
            this.LegendSetLow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LegendSetLow.Name = "LegendSetLow";
            this.LegendSetLow.Size = new System.Drawing.Size(32, 17);
            this.LegendSetLow.TabIndex = 28;
            this.LegendSetLow.UseVisualStyleBackColor = true;
            this.LegendSetLow.CheckedChanged += new System.EventHandler(this.LegendSetLow_Clicked);
            // 
            // LegendSetHigh
            // 
            this.LegendSetHigh.AutoSize = true;
            this.LegendSetHigh.Checked = true;
            this.LegendSetHigh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LegendSetHigh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LegendSetHigh.Location = new System.Drawing.Point(8, 198);
            this.LegendSetHigh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LegendSetHigh.Name = "LegendSetHigh";
            this.LegendSetHigh.Size = new System.Drawing.Size(32, 17);
            this.LegendSetHigh.TabIndex = 27;
            this.LegendSetHigh.UseVisualStyleBackColor = true;
            this.LegendSetHigh.Click += new System.EventHandler(this.LegendSetHigh_Click);
            // 
            // LegendLowIndicator
            // 
            this.LegendLowIndicator.Image = ((System.Drawing.Image)(resources.GetObject("LegendLowIndicator.Image")));
            this.LegendLowIndicator.IndicatorColor = MaximStyle.StatusIndicatorColor.Green;
            this.LegendLowIndicator.IndicatorSize = MaximStyle.StatusIndicatorSize.Medium;
            this.LegendLowIndicator.Location = new System.Drawing.Point(8, 154);
            this.LegendLowIndicator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LegendLowIndicator.Name = "LegendLowIndicator";
            this.LegendLowIndicator.Size = new System.Drawing.Size(35, 36);
            this.LegendLowIndicator.TabIndex = 25;
            this.LegendLowIndicator.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "= Low";
            // 
            // LegendHighIndicator
            // 
            this.LegendHighIndicator.Image = ((System.Drawing.Image)(resources.GetObject("LegendHighIndicator.Image")));
            this.LegendHighIndicator.IndicatorColor = MaximStyle.StatusIndicatorColor.Red;
            this.LegendHighIndicator.IndicatorSize = MaximStyle.StatusIndicatorSize.Medium;
            this.LegendHighIndicator.Location = new System.Drawing.Point(8, 110);
            this.LegendHighIndicator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LegendHighIndicator.Name = "LegendHighIndicator";
            this.LegendHighIndicator.Size = new System.Drawing.Size(35, 36);
            this.LegendHighIndicator.TabIndex = 23;
            this.LegendHighIndicator.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "= High";
            // 
            // maximGroupBox2
            // 
            this.maximGroupBox2.BackgroundColor = System.Drawing.Color.White;
            this.maximGroupBox2.Controls.Add(this.AlertIndicator);
            this.maximGroupBox2.Controls.Add(this.label18);
            this.maximGroupBox2.Controls.Add(this.label17);
            this.maximGroupBox2.Controls.Add(this.label16);
            this.maximGroupBox2.Controls.Add(this.label15);
            this.maximGroupBox2.Controls.Add(this.label14);
            this.maximGroupBox2.Controls.Add(this.label13);
            this.maximGroupBox2.Controls.Add(this.CurrentValue);
            this.maximGroupBox2.Controls.Add(this.FullCapRepValue);
            this.maximGroupBox2.Controls.Add(this.TempValue);
            this.maximGroupBox2.Controls.Add(this.RepCapValue);
            this.maximGroupBox2.Controls.Add(this.VcellValue);
            this.maximGroupBox2.Controls.Add(this.SocValue);
            this.maximGroupBox2.Controls.Add(this.label12);
            this.maximGroupBox2.Controls.Add(this.AlertEnable);
            this.maximGroupBox2.Controls.Add(this.NtcEnable);
            this.maximGroupBox2.Location = new System.Drawing.Point(408, 25);
            this.maximGroupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maximGroupBox2.Name = "maximGroupBox2";
            this.maximGroupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maximGroupBox2.Size = new System.Drawing.Size(371, 475);
            this.maximGroupBox2.TabIndex = 1;
            this.maximGroupBox2.TabStop = false;
            this.maximGroupBox2.Text = "Feul Gauge (MAX17261)";
            // 
            // AlertIndicator
            // 
            this.AlertIndicator.Image = ((System.Drawing.Image)(resources.GetObject("AlertIndicator.Image")));
            this.AlertIndicator.IndicatorColor = MaximStyle.StatusIndicatorColor.Gray;
            this.AlertIndicator.IndicatorSize = MaximStyle.StatusIndicatorSize.Medium;
            this.AlertIndicator.Location = new System.Drawing.Point(18, 364);
            this.AlertIndicator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AlertIndicator.Name = "AlertIndicator";
            this.AlertIndicator.Size = new System.Drawing.Size(35, 36);
            this.AlertIndicator.TabIndex = 21;
            this.AlertIndicator.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(195, 270);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(112, 21);
            this.label18.TabIndex = 15;
            this.label18.Text = "Current (mA)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(195, 195);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 21);
            this.label17.TabIndex = 14;
            this.label17.Text = "Temp (°C)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(195, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 21);
            this.label16.TabIndex = 13;
            this.label16.Text = "Vcell (V)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 270);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(157, 21);
            this.label15.TabIndex = 12;
            this.label15.Text = "FullCapRep (mAh)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 21);
            this.label14.TabIndex = 11;
            this.label14.Text = "RepCap (mAh)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 21);
            this.label13.TabIndex = 10;
            this.label13.Text = "SOC (%)";
            // 
            // CurrentValue
            // 
            this.CurrentValue.Location = new System.Drawing.Point(195, 295);
            this.CurrentValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CurrentValue.Name = "CurrentValue";
            this.CurrentValue.ReadOnly = true;
            this.CurrentValue.Size = new System.Drawing.Size(157, 28);
            this.CurrentValue.TabIndex = 9;
            // 
            // FullCapRepValue
            // 
            this.FullCapRepValue.Location = new System.Drawing.Point(18, 295);
            this.FullCapRepValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FullCapRepValue.Name = "FullCapRepValue";
            this.FullCapRepValue.ReadOnly = true;
            this.FullCapRepValue.Size = new System.Drawing.Size(157, 28);
            this.FullCapRepValue.TabIndex = 8;
            // 
            // TempValue
            // 
            this.TempValue.Location = new System.Drawing.Point(195, 220);
            this.TempValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TempValue.Name = "TempValue";
            this.TempValue.ReadOnly = true;
            this.TempValue.Size = new System.Drawing.Size(157, 28);
            this.TempValue.TabIndex = 7;
            // 
            // RepCapValue
            // 
            this.RepCapValue.Location = new System.Drawing.Point(18, 220);
            this.RepCapValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RepCapValue.Name = "RepCapValue";
            this.RepCapValue.ReadOnly = true;
            this.RepCapValue.Size = new System.Drawing.Size(157, 28);
            this.RepCapValue.TabIndex = 6;
            // 
            // VcellValue
            // 
            this.VcellValue.Location = new System.Drawing.Point(195, 145);
            this.VcellValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VcellValue.Name = "VcellValue";
            this.VcellValue.ReadOnly = true;
            this.VcellValue.Size = new System.Drawing.Size(157, 28);
            this.VcellValue.TabIndex = 5;
            // 
            // SocValue
            // 
            this.SocValue.Location = new System.Drawing.Point(18, 145);
            this.SocValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SocValue.Name = "SocValue";
            this.SocValue.ReadOnly = true;
            this.SocValue.Size = new System.Drawing.Size(157, 28);
            this.SocValue.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 368);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 21);
            this.label12.TabIndex = 3;
            this.label12.Text = "ALERT";
            // 
            // AlertEnable
            // 
            this.AlertEnable.AutoSize = true;
            this.AlertEnable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlertEnable.Location = new System.Drawing.Point(195, 72);
            this.AlertEnable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AlertEnable.Name = "AlertEnable";
            this.AlertEnable.Size = new System.Drawing.Size(90, 24);
            this.AlertEnable.TabIndex = 1;
            this.AlertEnable.Text = "Alert En";
            this.AlertEnable.UseVisualStyleBackColor = true;
            this.AlertEnable.CheckedChanged += new System.EventHandler(this.AlertEnable_CheckedChanged);
            // 
            // NtcEnable
            // 
            this.NtcEnable.AutoSize = true;
            this.NtcEnable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NtcEnable.Location = new System.Drawing.Point(18, 72);
            this.NtcEnable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NtcEnable.Name = "NtcEnable";
            this.NtcEnable.Size = new System.Drawing.Size(90, 24);
            this.NtcEnable.TabIndex = 0;
            this.NtcEnable.Text = "NTC En";
            this.NtcEnable.UseVisualStyleBackColor = true;
            this.NtcEnable.CheckedChanged += new System.EventHandler(this.NtcEnable_CheckedChanged);
            // 
            // maximGroupBox1
            // 
            this.maximGroupBox1.BackgroundColor = System.Drawing.Color.White;
            this.maximGroupBox1.Controls.Add(this.ChargeDoneThreshold);
            this.maximGroupBox1.Controls.Add(this.BatRechargeThreshold);
            this.maximGroupBox1.Controls.Add(this.PrechargeThreshold);
            this.maximGroupBox1.Controls.Add(this.BatRegulationThreshold);
            this.maximGroupBox1.Controls.Add(this.FsusSet);
            this.maximGroupBox1.Controls.Add(this.FltinSet);
            this.maximGroupBox1.Controls.Add(this.label11);
            this.maximGroupBox1.Controls.Add(this.label10);
            this.maximGroupBox1.Controls.Add(this.label9);
            this.maximGroupBox1.Controls.Add(this.IntIndicator);
            this.maximGroupBox1.Controls.Add(this.SysOkIndicator);
            this.maximGroupBox1.Controls.Add(this.CdirIndicator);
            this.maximGroupBox1.Controls.Add(this.label8);
            this.maximGroupBox1.Controls.Add(this.label7);
            this.maximGroupBox1.Controls.Add(this.label6);
            this.maximGroupBox1.Controls.Add(this.label5);
            this.maximGroupBox1.Controls.Add(this.IntEnable);
            this.maximGroupBox1.Controls.Add(this.AiclEnable);
            this.maximGroupBox1.Controls.Add(this.Dcp3aEnable);
            this.maximGroupBox1.Controls.Add(this.ChargerEnable);
            this.maximGroupBox1.Location = new System.Drawing.Point(12, 25);
            this.maximGroupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maximGroupBox1.Name = "maximGroupBox1";
            this.maximGroupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maximGroupBox1.Size = new System.Drawing.Size(384, 475);
            this.maximGroupBox1.TabIndex = 0;
            this.maximGroupBox1.TabStop = false;
            this.maximGroupBox1.Text = "Charger (MAX14748)";
            // 
            // ChargeDoneThreshold
            // 
            this.ChargeDoneThreshold.BackColor = System.Drawing.Color.White;
            this.ChargeDoneThreshold.DropDownHeight = 200;
            this.ChargeDoneThreshold.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChargeDoneThreshold.DropDownWidth = 0;
            this.ChargeDoneThreshold.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChargeDoneThreshold.Location = new System.Drawing.Point(153, 295);
            this.ChargeDoneThreshold.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChargeDoneThreshold.Name = "ChargeDoneThreshold";
            this.ChargeDoneThreshold.Size = new System.Drawing.Size(217, 31);
            this.ChargeDoneThreshold.TabIndex = 26;
            this.ChargeDoneThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChargeDoneThreshold.TextAlignDropDownList = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChargeDoneThreshold.SelectedIndexChanged += new System.EventHandler(this.ChargeDoneThreshold_SelectedIndexChanged);
            // 
            // BatRechargeThreshold
            // 
            this.BatRechargeThreshold.BackColor = System.Drawing.Color.White;
            this.BatRechargeThreshold.DropDownHeight = 200;
            this.BatRechargeThreshold.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BatRechargeThreshold.DropDownWidth = 0;
            this.BatRechargeThreshold.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatRechargeThreshold.Location = new System.Drawing.Point(153, 222);
            this.BatRechargeThreshold.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BatRechargeThreshold.Name = "BatRechargeThreshold";
            this.BatRechargeThreshold.Size = new System.Drawing.Size(217, 31);
            this.BatRechargeThreshold.TabIndex = 25;
            this.BatRechargeThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BatRechargeThreshold.TextAlignDropDownList = System.Windows.Forms.HorizontalAlignment.Center;
            this.BatRechargeThreshold.SelectedIndexChanged += new System.EventHandler(this.BatRechargeThreshold_SelectedIndexChanged);
            // 
            // PrechargeThreshold
            // 
            this.PrechargeThreshold.BackColor = System.Drawing.Color.White;
            this.PrechargeThreshold.DropDownHeight = 200;
            this.PrechargeThreshold.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrechargeThreshold.DropDownWidth = 0;
            this.PrechargeThreshold.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrechargeThreshold.Location = new System.Drawing.Point(153, 149);
            this.PrechargeThreshold.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PrechargeThreshold.Name = "PrechargeThreshold";
            this.PrechargeThreshold.Size = new System.Drawing.Size(217, 31);
            this.PrechargeThreshold.TabIndex = 24;
            this.PrechargeThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PrechargeThreshold.TextAlignDropDownList = System.Windows.Forms.HorizontalAlignment.Center;
            this.PrechargeThreshold.SelectedIndexChanged += new System.EventHandler(this.PrechargeThreshold_SelectedIndexChanged);
            // 
            // BatRegulationThreshold
            // 
            this.BatRegulationThreshold.BackColor = System.Drawing.Color.White;
            this.BatRegulationThreshold.DropDownHeight = 200;
            this.BatRegulationThreshold.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BatRegulationThreshold.DropDownWidth = 0;
            this.BatRegulationThreshold.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatRegulationThreshold.Location = new System.Drawing.Point(153, 76);
            this.BatRegulationThreshold.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BatRegulationThreshold.Name = "BatRegulationThreshold";
            this.BatRegulationThreshold.Size = new System.Drawing.Size(217, 31);
            this.BatRegulationThreshold.TabIndex = 23;
            this.BatRegulationThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BatRegulationThreshold.TextAlignDropDownList = System.Windows.Forms.HorizontalAlignment.Center;
            this.BatRegulationThreshold.SelectedIndexChanged += new System.EventHandler(this.BatRegulationThreshold_SelectedIndexChanged);
            // 
            // FsusSet
            // 
            this.FsusSet.AutoSize = true;
            this.FsusSet.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FsusSet.Location = new System.Drawing.Point(197, 425);
            this.FsusSet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FsusSet.Name = "FsusSet";
            this.FsusSet.Size = new System.Drawing.Size(87, 24);
            this.FsusSet.TabIndex = 22;
            this.FsusSet.Text = "FSUS";
            this.FsusSet.UseVisualStyleBackColor = true;
            this.FsusSet.CheckedChanged += new System.EventHandler(this.FsusSet_CheckedChanged);
            // 
            // FltinSet
            // 
            this.FltinSet.AutoSize = true;
            this.FltinSet.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FltinSet.Location = new System.Drawing.Point(68, 425);
            this.FltinSet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FltinSet.Name = "FltinSet";
            this.FltinSet.Size = new System.Drawing.Size(94, 24);
            this.FltinSet.TabIndex = 21;
            this.FltinSet.Text = "/FLTIN";
            this.FltinSet.UseVisualStyleBackColor = true;
            this.FltinSet.CheckedChanged += new System.EventHandler(this.FltinSet_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(289, 368);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "/INT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(177, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "SYSOK";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "CDIR";
            // 
            // IntIndicator
            // 
            this.IntIndicator.Image = ((System.Drawing.Image)(resources.GetObject("IntIndicator.Image")));
            this.IntIndicator.IndicatorColor = MaximStyle.StatusIndicatorColor.Gray;
            this.IntIndicator.IndicatorSize = MaximStyle.StatusIndicatorSize.Medium;
            this.IntIndicator.Location = new System.Drawing.Point(260, 364);
            this.IntIndicator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IntIndicator.Name = "IntIndicator";
            this.IntIndicator.Size = new System.Drawing.Size(35, 36);
            this.IntIndicator.TabIndex = 16;
            this.IntIndicator.TabStop = false;
            // 
            // SysOkIndicator
            // 
            this.SysOkIndicator.Image = ((System.Drawing.Image)(resources.GetObject("SysOkIndicator.Image")));
            this.SysOkIndicator.IndicatorColor = MaximStyle.StatusIndicatorColor.Gray;
            this.SysOkIndicator.IndicatorSize = MaximStyle.StatusIndicatorSize.Medium;
            this.SysOkIndicator.Location = new System.Drawing.Point(147, 364);
            this.SysOkIndicator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SysOkIndicator.Name = "SysOkIndicator";
            this.SysOkIndicator.Size = new System.Drawing.Size(35, 36);
            this.SysOkIndicator.TabIndex = 15;
            this.SysOkIndicator.TabStop = false;
            // 
            // CdirIndicator
            // 
            this.CdirIndicator.Image = ((System.Drawing.Image)(resources.GetObject("CdirIndicator.Image")));
            this.CdirIndicator.IndicatorColor = MaximStyle.StatusIndicatorColor.Gray;
            this.CdirIndicator.IndicatorSize = MaximStyle.StatusIndicatorSize.Medium;
            this.CdirIndicator.Location = new System.Drawing.Point(35, 364);
            this.CdirIndicator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CdirIndicator.Name = "CdirIndicator";
            this.CdirIndicator.Size = new System.Drawing.Size(35, 36);
            this.CdirIndicator.TabIndex = 14;
            this.CdirIndicator.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Charge Done Threshold";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "BAT Recharge Threshold";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Pre-charge Threshold";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "BAT Regulation Threshold";
            // 
            // IntEnable
            // 
            this.IntEnable.AutoSize = true;
            this.IntEnable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntEnable.Location = new System.Drawing.Point(18, 301);
            this.IntEnable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IntEnable.Name = "IntEnable";
            this.IntEnable.Size = new System.Drawing.Size(82, 24);
            this.IntEnable.TabIndex = 3;
            this.IntEnable.Text = "INT En";
            this.IntEnable.UseVisualStyleBackColor = true;
            this.IntEnable.CheckedChanged += new System.EventHandler(this.IntEnable_CheckedChanged);
            // 
            // AiclEnable
            // 
            this.AiclEnable.AutoSize = true;
            this.AiclEnable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AiclEnable.Location = new System.Drawing.Point(18, 226);
            this.AiclEnable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AiclEnable.Name = "AiclEnable";
            this.AiclEnable.Size = new System.Drawing.Size(94, 24);
            this.AiclEnable.TabIndex = 2;
            this.AiclEnable.Text = "AICL En";
            this.AiclEnable.UseVisualStyleBackColor = true;
            this.AiclEnable.CheckedChanged += new System.EventHandler(this.AiclEnable_CheckedChanged);
            // 
            // Dcp3aEnable
            // 
            this.Dcp3aEnable.AutoSize = true;
            this.Dcp3aEnable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dcp3aEnable.Location = new System.Drawing.Point(18, 151);
            this.Dcp3aEnable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dcp3aEnable.Name = "Dcp3aEnable";
            this.Dcp3aEnable.Size = new System.Drawing.Size(119, 24);
            this.Dcp3aEnable.TabIndex = 1;
            this.Dcp3aEnable.Text = "DCP/3A En";
            this.Dcp3aEnable.UseVisualStyleBackColor = true;
            this.Dcp3aEnable.CheckedChanged += new System.EventHandler(this.Dcp3aEnable_CheckedChanged);
            // 
            // ChargerEnable
            // 
            this.ChargerEnable.AutoSize = true;
            this.ChargerEnable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChargerEnable.Location = new System.Drawing.Point(18, 76);
            this.ChargerEnable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChargerEnable.Name = "ChargerEnable";
            this.ChargerEnable.Size = new System.Drawing.Size(119, 24);
            this.ChargerEnable.TabIndex = 0;
            this.ChargerEnable.Text = "Charger En";
            this.ChargerEnable.UseVisualStyleBackColor = true;
            this.ChargerEnable.CheckedChanged += new System.EventHandler(this.ChargerEnable_CheckedChanged);
            // 
            // maximTabControl1
            // 
            this.maximTabControl1.Controls.Add(this.tabPage1);
            this.maximTabControl1.Controls.Add(this.tabPage2);
            this.maximTabControl1.Font = new System.Drawing.Font("Arial", 9F);
            this.maximTabControl1.Location = new System.Drawing.Point(0, 56);
            this.maximTabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maximTabControl1.Name = "maximTabControl1";
            this.maximTabControl1.SelectedIndex = 0;
            this.maximTabControl1.Size = new System.Drawing.Size(990, 575);
            this.maximTabControl1.TabIndex = 1;
            this.maximTabControl1.SelectedIndexChanged += new System.EventHandler(this.maximTabControl1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.deviceToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(990, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 30);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // deviceToolStripMenuItem
            // 
            this.deviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem});
            this.deviceToolStripMenuItem.Name = "deviceToolStripMenuItem";
            this.deviceToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.deviceToolStripMenuItem.Text = "&Device";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.connectToolStripMenuItem.Text = "&Connect Board";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 691);
            this.Controls.Add(this.maximStatusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.maximTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAXREFDES1260 2-Cell USB Charger & Fuel Gauge";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LegendLowIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegendHighIndicator)).EndInit();
            this.maximGroupBox2.ResumeLayout(false);
            this.maximGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlertIndicator)).EndInit();
            this.maximGroupBox1.ResumeLayout(false);
            this.maximGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SysOkIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CdirIndicator)).EndInit();
            this.maximTabControl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MaximStyle.MaximStatusStrip maximStatusStrip1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MaximStyle.MaximButton WriteRegister;
        private MaximStyle.MaximButton ReadRegister;
        private System.Windows.Forms.TextBox RegisterValue;
        private MaximStyle.MaximComboBox RegisterSelection;
        private MaximStyle.MaximComboBox PartSelection;
        private System.Windows.Forms.TabPage tabPage1;
        private MaximStyle.MaximGroupBox maximGroupBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox CurrentValue;
        private System.Windows.Forms.TextBox FullCapRepValue;
        private System.Windows.Forms.TextBox TempValue;
        private System.Windows.Forms.TextBox RepCapValue;
        private System.Windows.Forms.TextBox VcellValue;
        private System.Windows.Forms.TextBox SocValue;
        private System.Windows.Forms.Label label12;
        private MaximStyle.MaximCheckBox AlertEnable;
        private MaximStyle.MaximCheckBox NtcEnable;
        private MaximStyle.MaximGroupBox maximGroupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private MaximStyle.MaximStatusIndicator IntIndicator;
        private MaximStyle.MaximStatusIndicator SysOkIndicator;
        private MaximStyle.MaximStatusIndicator CdirIndicator;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private MaximStyle.MaximCheckBox IntEnable;
        private MaximStyle.MaximCheckBox AiclEnable;
        private MaximStyle.MaximCheckBox Dcp3aEnable;
        private MaximStyle.MaximCheckBox ChargerEnable;
        private MaximStyle.MaximTabControl maximTabControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private MaximStyle.MaximStatusIndicator AlertIndicator;
        private MaximStyle.MaximToggleButton FsusSet;
        private MaximStyle.MaximToggleButton FltinSet;
        private MaximStyle.MaximComboBox ChargeDoneThreshold;
        private MaximStyle.MaximComboBox BatRechargeThreshold;
        private MaximStyle.MaximComboBox PrechargeThreshold;
        private MaximStyle.MaximComboBox BatRegulationThreshold;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaximStyle.MaximToggleButton LegendSetLow;
        private MaximStyle.MaximToggleButton LegendSetHigh;
        private MaximStyle.MaximStatusIndicator LegendLowIndicator;
        private System.Windows.Forms.Label label2;
        private MaximStyle.MaximStatusIndicator LegendHighIndicator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private MaximStyle.MaximCheckBox LegendDisabled;
        private MaximStyle.MaximCheckBox LegendEnabled;
    }
}

