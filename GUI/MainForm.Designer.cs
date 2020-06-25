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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.maximStatusStrip1 = new MaximStyle.MaximStatusStrip();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WriteRegister = new MaximStyle.MaximButton();
            this.ReadRegister = new MaximStyle.MaximButton();
            this.RegisterValue = new System.Windows.Forms.TextBox();
            this.RegisterSelection = new MaximStyle.MaximComboBox();
            this.PartSelection = new MaximStyle.MaximComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.maximGroupBox2 = new MaximStyle.MaximGroupBox();
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
            this.maximStatusIndicator1 = new MaximStyle.MaximStatusIndicator();
            this.AlertEnable = new MaximStyle.MaximCheckBox();
            this.NtcEnable = new MaximStyle.MaximCheckBox();
            this.maximGroupBox1 = new MaximStyle.MaximGroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.IntIndicator = new MaximStyle.MaximStatusIndicator();
            this.SysOkIndicator = new MaximStyle.MaximStatusIndicator();
            this.CdirIndicator = new MaximStyle.MaximStatusIndicator();
            this.Fsus = new MaximStyle.MaximToggleButton();
            this.Fltin = new MaximStyle.MaximToggleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ChargeDoneRegister = new MaximStyle.MaximComboBox();
            this.Recharge = new MaximStyle.MaximComboBox();
            this.PrechargeRegister = new MaximStyle.MaximComboBox();
            this.BatRegister = new MaximStyle.MaximComboBox();
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
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.maximGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximStatusIndicator1)).BeginInit();
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
            this.maximStatusStrip1.Location = new System.Drawing.Point(0, 525);
            this.maximStatusStrip1.Name = "maximStatusStrip1";
            this.maximStatusStrip1.SectionsNumberOf = 3;
            this.maximStatusStrip1.SectionUseStatusProgressBar = false;
            this.maximStatusStrip1.Size = new System.Drawing.Size(782, 28);
            this.maximStatusStrip1.TabIndex = 2;
            this.maximStatusStrip1.Text = "maximStatusStrip1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.WriteRegister);
            this.tabPage2.Controls.Add(this.ReadRegister);
            this.tabPage2.Controls.Add(this.RegisterValue);
            this.tabPage2.Controls.Add(this.RegisterSelection);
            this.tabPage2.Controls.Add(this.PartSelection);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(771, 426);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Register Access";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Register Value (Hex)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Register Selection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Device Selection";
            // 
            // WriteRegister
            // 
            this.WriteRegister.Location = new System.Drawing.Point(490, 297);
            this.WriteRegister.Name = "WriteRegister";
            this.WriteRegister.Size = new System.Drawing.Size(102, 23);
            this.WriteRegister.TabIndex = 4;
            this.WriteRegister.Text = "Write";
            this.WriteRegister.UseVisualStyleBackColor = true;
            this.WriteRegister.Click += new System.EventHandler(this.WriteRegister_Click);
            // 
            // ReadRegister
            // 
            this.ReadRegister.Location = new System.Drawing.Point(329, 297);
            this.ReadRegister.Name = "ReadRegister";
            this.ReadRegister.Size = new System.Drawing.Size(102, 23);
            this.ReadRegister.TabIndex = 3;
            this.ReadRegister.Text = "Read";
            this.ReadRegister.UseVisualStyleBackColor = true;
            this.ReadRegister.Click += new System.EventHandler(this.ReadRegister_Click);
            // 
            // RegisterValue
            // 
            this.RegisterValue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RegisterValue.Location = new System.Drawing.Point(329, 227);
            this.RegisterValue.Name = "RegisterValue";
            this.RegisterValue.Size = new System.Drawing.Size(102, 25);
            this.RegisterValue.TabIndex = 2;
            // 
            // RegisterSelection
            // 
            this.RegisterSelection.BackColor = System.Drawing.Color.White;
            this.RegisterSelection.DropDownHeight = 200;
            this.RegisterSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RegisterSelection.DropDownWidth = 0;
            this.RegisterSelection.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterSelection.Location = new System.Drawing.Point(329, 150);
            this.RegisterSelection.Name = "RegisterSelection";
            this.RegisterSelection.Size = new System.Drawing.Size(263, 25);
            this.RegisterSelection.TabIndex = 1;
            this.RegisterSelection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RegisterSelection.TextAlignDropDownList = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PartSelection
            // 
            this.PartSelection.BackColor = System.Drawing.Color.White;
            this.PartSelection.DropDownHeight = 200;
            this.PartSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PartSelection.DropDownWidth = 0;
            this.PartSelection.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartSelection.Location = new System.Drawing.Point(329, 83);
            this.PartSelection.Name = "PartSelection";
            this.PartSelection.Size = new System.Drawing.Size(263, 25);
            this.PartSelection.TabIndex = 0;
            this.PartSelection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PartSelection.TextAlignDropDownList = System.Windows.Forms.HorizontalAlignment.Left;
            this.PartSelection.SelectedIndexChanged += new System.EventHandler(this.PartSelection_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.maximGroupBox2);
            this.tabPage1.Controls.Add(this.maximGroupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(771, 426);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Demo View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // maximGroupBox2
            // 
            this.maximGroupBox2.BackgroundColor = System.Drawing.Color.White;
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
            this.maximGroupBox2.Controls.Add(this.maximStatusIndicator1);
            this.maximGroupBox2.Controls.Add(this.AlertEnable);
            this.maximGroupBox2.Controls.Add(this.NtcEnable);
            this.maximGroupBox2.Location = new System.Drawing.Point(410, 20);
            this.maximGroupBox2.Name = "maximGroupBox2";
            this.maximGroupBox2.Size = new System.Drawing.Size(330, 380);
            this.maximGroupBox2.TabIndex = 1;
            this.maximGroupBox2.TabStop = false;
            this.maximGroupBox2.Text = "Feul Gauge (MAX17261)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(186, 216);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 17);
            this.label18.TabIndex = 15;
            this.label18.Text = "Current";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(186, 156);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 17);
            this.label17.TabIndex = 14;
            this.label17.Text = "Temp";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(186, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 17);
            this.label16.TabIndex = 13;
            this.label16.Text = "Vcell";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(32, 216);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 17);
            this.label15.TabIndex = 12;
            this.label15.Text = "FullCapRep";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 17);
            this.label14.TabIndex = 11;
            this.label14.Text = "RepCap";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "SOC";
            // 
            // CurrentValue
            // 
            this.CurrentValue.Location = new System.Drawing.Point(186, 236);
            this.CurrentValue.Name = "CurrentValue";
            this.CurrentValue.Size = new System.Drawing.Size(100, 25);
            this.CurrentValue.TabIndex = 9;
            // 
            // FullCapRepValue
            // 
            this.FullCapRepValue.Location = new System.Drawing.Point(32, 236);
            this.FullCapRepValue.Name = "FullCapRepValue";
            this.FullCapRepValue.Size = new System.Drawing.Size(100, 25);
            this.FullCapRepValue.TabIndex = 8;
            // 
            // TempValue
            // 
            this.TempValue.Location = new System.Drawing.Point(186, 176);
            this.TempValue.Name = "TempValue";
            this.TempValue.Size = new System.Drawing.Size(100, 25);
            this.TempValue.TabIndex = 7;
            // 
            // RepCapValue
            // 
            this.RepCapValue.Location = new System.Drawing.Point(32, 176);
            this.RepCapValue.Name = "RepCapValue";
            this.RepCapValue.Size = new System.Drawing.Size(100, 25);
            this.RepCapValue.TabIndex = 6;
            // 
            // VcellValue
            // 
            this.VcellValue.Location = new System.Drawing.Point(186, 116);
            this.VcellValue.Name = "VcellValue";
            this.VcellValue.Size = new System.Drawing.Size(100, 25);
            this.VcellValue.TabIndex = 5;
            // 
            // SocValue
            // 
            this.SocValue.Location = new System.Drawing.Point(32, 116);
            this.SocValue.Name = "SocValue";
            this.SocValue.Size = new System.Drawing.Size(100, 25);
            this.SocValue.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(69, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "ALERT";
            // 
            // maximStatusIndicator1
            // 
            this.maximStatusIndicator1.Image = ((System.Drawing.Image)(resources.GetObject("maximStatusIndicator1.Image")));
            this.maximStatusIndicator1.IndicatorColor = MaximStyle.StatusIndicatorColor.Gray;
            this.maximStatusIndicator1.IndicatorSize = MaximStyle.StatusIndicatorSize.Medium;
            this.maximStatusIndicator1.Location = new System.Drawing.Point(43, 291);
            this.maximStatusIndicator1.Name = "maximStatusIndicator1";
            this.maximStatusIndicator1.Size = new System.Drawing.Size(31, 29);
            this.maximStatusIndicator1.TabIndex = 2;
            this.maximStatusIndicator1.TabStop = false;
            // 
            // AlertEnable
            // 
            this.AlertEnable.AutoSize = true;
            this.AlertEnable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlertEnable.Location = new System.Drawing.Point(186, 58);
            this.AlertEnable.Name = "AlertEnable";
            this.AlertEnable.Size = new System.Drawing.Size(78, 20);
            this.AlertEnable.TabIndex = 1;
            this.AlertEnable.Text = "Alert En";
            this.AlertEnable.UseVisualStyleBackColor = true;
            // 
            // NtcEnable
            // 
            this.NtcEnable.AutoSize = true;
            this.NtcEnable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NtcEnable.Location = new System.Drawing.Point(33, 58);
            this.NtcEnable.Name = "NtcEnable";
            this.NtcEnable.Size = new System.Drawing.Size(78, 20);
            this.NtcEnable.TabIndex = 0;
            this.NtcEnable.Text = "NTC En";
            this.NtcEnable.UseVisualStyleBackColor = true;
            // 
            // maximGroupBox1
            // 
            this.maximGroupBox1.BackgroundColor = System.Drawing.Color.White;
            this.maximGroupBox1.Controls.Add(this.label11);
            this.maximGroupBox1.Controls.Add(this.label10);
            this.maximGroupBox1.Controls.Add(this.label9);
            this.maximGroupBox1.Controls.Add(this.IntIndicator);
            this.maximGroupBox1.Controls.Add(this.SysOkIndicator);
            this.maximGroupBox1.Controls.Add(this.CdirIndicator);
            this.maximGroupBox1.Controls.Add(this.Fsus);
            this.maximGroupBox1.Controls.Add(this.Fltin);
            this.maximGroupBox1.Controls.Add(this.label8);
            this.maximGroupBox1.Controls.Add(this.label7);
            this.maximGroupBox1.Controls.Add(this.label6);
            this.maximGroupBox1.Controls.Add(this.label5);
            this.maximGroupBox1.Controls.Add(this.ChargeDoneRegister);
            this.maximGroupBox1.Controls.Add(this.Recharge);
            this.maximGroupBox1.Controls.Add(this.PrechargeRegister);
            this.maximGroupBox1.Controls.Add(this.BatRegister);
            this.maximGroupBox1.Controls.Add(this.IntEnable);
            this.maximGroupBox1.Controls.Add(this.AiclEnable);
            this.maximGroupBox1.Controls.Add(this.Dcp3aEnable);
            this.maximGroupBox1.Controls.Add(this.ChargerEnable);
            this.maximGroupBox1.Location = new System.Drawing.Point(30, 20);
            this.maximGroupBox1.Name = "maximGroupBox1";
            this.maximGroupBox1.Size = new System.Drawing.Size(330, 380);
            this.maximGroupBox1.TabIndex = 0;
            this.maximGroupBox1.TabStop = false;
            this.maximGroupBox1.Text = "Charger (MAX14748)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(257, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "/INT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(157, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "SYSOK";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "CDIR";
            // 
            // IntIndicator
            // 
            this.IntIndicator.Image = ((System.Drawing.Image)(resources.GetObject("IntIndicator.Image")));
            this.IntIndicator.IndicatorColor = MaximStyle.StatusIndicatorColor.Gray;
            this.IntIndicator.IndicatorSize = MaximStyle.StatusIndicatorSize.Medium;
            this.IntIndicator.Location = new System.Drawing.Point(231, 291);
            this.IntIndicator.Name = "IntIndicator";
            this.IntIndicator.Size = new System.Drawing.Size(31, 29);
            this.IntIndicator.TabIndex = 16;
            this.IntIndicator.TabStop = false;
            // 
            // SysOkIndicator
            // 
            this.SysOkIndicator.Image = ((System.Drawing.Image)(resources.GetObject("SysOkIndicator.Image")));
            this.SysOkIndicator.IndicatorColor = MaximStyle.StatusIndicatorColor.Gray;
            this.SysOkIndicator.IndicatorSize = MaximStyle.StatusIndicatorSize.Medium;
            this.SysOkIndicator.Location = new System.Drawing.Point(131, 291);
            this.SysOkIndicator.Name = "SysOkIndicator";
            this.SysOkIndicator.Size = new System.Drawing.Size(31, 29);
            this.SysOkIndicator.TabIndex = 15;
            this.SysOkIndicator.TabStop = false;
            // 
            // CdirIndicator
            // 
            this.CdirIndicator.Image = ((System.Drawing.Image)(resources.GetObject("CdirIndicator.Image")));
            this.CdirIndicator.IndicatorColor = MaximStyle.StatusIndicatorColor.Gray;
            this.CdirIndicator.IndicatorSize = MaximStyle.StatusIndicatorSize.Medium;
            this.CdirIndicator.Location = new System.Drawing.Point(31, 291);
            this.CdirIndicator.Name = "CdirIndicator";
            this.CdirIndicator.Size = new System.Drawing.Size(31, 29);
            this.CdirIndicator.TabIndex = 14;
            this.CdirIndicator.TabStop = false;
            // 
            // Fsus
            // 
            this.Fsus.AutoSize = true;
            this.Fsus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fsus.Location = new System.Drawing.Point(198, 338);
            this.Fsus.Name = "Fsus";
            this.Fsus.Size = new System.Drawing.Size(78, 20);
            this.Fsus.TabIndex = 13;
            this.Fsus.Text = "FSUS";
            this.Fsus.UseVisualStyleBackColor = true;
            // 
            // Fltin
            // 
            this.Fltin.AutoSize = true;
            this.Fltin.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fltin.Location = new System.Drawing.Point(47, 338);
            this.Fltin.Name = "Fltin";
            this.Fltin.Size = new System.Drawing.Size(84, 20);
            this.Fltin.TabIndex = 12;
            this.Fltin.Text = "/FLTIN";
            this.Fltin.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(150, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Charge Done Reg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Recharge Reg";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Pre-charge Reg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "BAT Reg";
            // 
            // ChargeDoneRegister
            // 
            this.ChargeDoneRegister.BackColor = System.Drawing.Color.White;
            this.ChargeDoneRegister.DropDownHeight = 200;
            this.ChargeDoneRegister.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChargeDoneRegister.DropDownWidth = 0;
            this.ChargeDoneRegister.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChargeDoneRegister.Location = new System.Drawing.Point(153, 237);
            this.ChargeDoneRegister.Name = "ChargeDoneRegister";
            this.ChargeDoneRegister.Size = new System.Drawing.Size(159, 25);
            this.ChargeDoneRegister.TabIndex = 7;
            this.ChargeDoneRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChargeDoneRegister.TextAlignDropDownList = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Recharge
            // 
            this.Recharge.BackColor = System.Drawing.Color.White;
            this.Recharge.DropDownHeight = 200;
            this.Recharge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Recharge.DropDownWidth = 0;
            this.Recharge.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recharge.Location = new System.Drawing.Point(153, 177);
            this.Recharge.Name = "Recharge";
            this.Recharge.Size = new System.Drawing.Size(159, 25);
            this.Recharge.TabIndex = 6;
            this.Recharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Recharge.TextAlignDropDownList = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PrechargeRegister
            // 
            this.PrechargeRegister.BackColor = System.Drawing.Color.White;
            this.PrechargeRegister.DropDownHeight = 200;
            this.PrechargeRegister.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrechargeRegister.DropDownWidth = 0;
            this.PrechargeRegister.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrechargeRegister.Location = new System.Drawing.Point(153, 117);
            this.PrechargeRegister.Name = "PrechargeRegister";
            this.PrechargeRegister.Size = new System.Drawing.Size(159, 25);
            this.PrechargeRegister.TabIndex = 5;
            this.PrechargeRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PrechargeRegister.TextAlignDropDownList = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BatRegister
            // 
            this.BatRegister.BackColor = System.Drawing.Color.White;
            this.BatRegister.DropDownHeight = 200;
            this.BatRegister.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BatRegister.DropDownWidth = 0;
            this.BatRegister.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatRegister.Location = new System.Drawing.Point(153, 61);
            this.BatRegister.Name = "BatRegister";
            this.BatRegister.Size = new System.Drawing.Size(159, 25);
            this.BatRegister.TabIndex = 4;
            this.BatRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BatRegister.TextAlignDropDownList = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // IntEnable
            // 
            this.IntEnable.AutoSize = true;
            this.IntEnable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntEnable.Location = new System.Drawing.Point(16, 241);
            this.IntEnable.Name = "IntEnable";
            this.IntEnable.Size = new System.Drawing.Size(72, 20);
            this.IntEnable.TabIndex = 3;
            this.IntEnable.Text = "INT En";
            this.IntEnable.UseVisualStyleBackColor = true;
            // 
            // AiclEnable
            // 
            this.AiclEnable.AutoSize = true;
            this.AiclEnable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AiclEnable.Location = new System.Drawing.Point(16, 181);
            this.AiclEnable.Name = "AiclEnable";
            this.AiclEnable.Size = new System.Drawing.Size(81, 20);
            this.AiclEnable.TabIndex = 2;
            this.AiclEnable.Text = "AICL En";
            this.AiclEnable.UseVisualStyleBackColor = true;
            // 
            // Dcp3aEnable
            // 
            this.Dcp3aEnable.AutoSize = true;
            this.Dcp3aEnable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dcp3aEnable.Location = new System.Drawing.Point(16, 121);
            this.Dcp3aEnable.Name = "Dcp3aEnable";
            this.Dcp3aEnable.Size = new System.Drawing.Size(102, 20);
            this.Dcp3aEnable.TabIndex = 1;
            this.Dcp3aEnable.Text = "DCP/3A En";
            this.Dcp3aEnable.UseVisualStyleBackColor = true;
            // 
            // ChargerEnable
            // 
            this.ChargerEnable.AutoSize = true;
            this.ChargerEnable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChargerEnable.Location = new System.Drawing.Point(16, 61);
            this.ChargerEnable.Name = "ChargerEnable";
            this.ChargerEnable.Size = new System.Drawing.Size(102, 20);
            this.ChargerEnable.TabIndex = 0;
            this.ChargerEnable.Text = "Charger En";
            this.ChargerEnable.UseVisualStyleBackColor = true;
            // 
            // maximTabControl1
            // 
            this.maximTabControl1.Controls.Add(this.tabPage1);
            this.maximTabControl1.Controls.Add(this.tabPage2);
            this.maximTabControl1.Font = new System.Drawing.Font("Arial", 9F);
            this.maximTabControl1.Location = new System.Drawing.Point(0, 45);
            this.maximTabControl1.Name = "maximTabControl1";
            this.maximTabControl1.SelectedIndex = 0;
            this.maximTabControl1.Size = new System.Drawing.Size(779, 460);
            this.maximTabControl1.TabIndex = 1;
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // deviceToolStripMenuItem
            // 
            this.deviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.deviceToolStripMenuItem.Name = "deviceToolStripMenuItem";
            this.deviceToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.deviceToolStripMenuItem.Text = "&Device";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.connectToolStripMenuItem.Text = "&Connect Board";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.disconnectToolStripMenuItem.Text = "&Disconnect Board";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.maximStatusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.maximTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USB Charger";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.maximGroupBox2.ResumeLayout(false);
            this.maximGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximStatusIndicator1)).EndInit();
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
        private MaximStyle.MaximStatusStrip maximStatusStrip1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
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
        private MaximStyle.MaximStatusIndicator maximStatusIndicator1;
        private MaximStyle.MaximCheckBox AlertEnable;
        private MaximStyle.MaximCheckBox NtcEnable;
        private MaximStyle.MaximGroupBox maximGroupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private MaximStyle.MaximStatusIndicator IntIndicator;
        private MaximStyle.MaximStatusIndicator SysOkIndicator;
        private MaximStyle.MaximStatusIndicator CdirIndicator;
        private MaximStyle.MaximToggleButton Fsus;
        private MaximStyle.MaximToggleButton Fltin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private MaximStyle.MaximComboBox ChargeDoneRegister;
        private MaximStyle.MaximComboBox Recharge;
        private MaximStyle.MaximComboBox PrechargeRegister;
        private MaximStyle.MaximComboBox BatRegister;
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
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

