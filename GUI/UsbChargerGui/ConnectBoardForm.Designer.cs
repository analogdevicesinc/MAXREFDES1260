namespace UsbChargerGui
{
    partial class ConnectBoardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectBoardForm));
            this.PortList = new MaximStyle.MaximComboBox();
            this.SearchPort = new MaximStyle.MaximButton();
            this.ConnectPort = new MaximStyle.MaximButton();
            this.DisconnectPort = new MaximStyle.MaximButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ConnectBoardOK = new MaximStyle.MaximButton();
            this.SuspendLayout();
            // 
            // PortList
            // 
            this.PortList.BackColor = System.Drawing.Color.White;
            this.PortList.DropDownHeight = 200;
            this.PortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortList.DropDownWidth = 0;
            this.PortList.Location = new System.Drawing.Point(104, 67);
            this.PortList.Name = "PortList";
            this.PortList.Size = new System.Drawing.Size(111, 26);
            this.PortList.TabIndex = 0;
            this.PortList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PortList.TextAlignDropDownList = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SearchPort
            // 
            this.SearchPort.Location = new System.Drawing.Point(248, 67);
            this.SearchPort.Name = "SearchPort";
            this.SearchPort.Size = new System.Drawing.Size(111, 26);
            this.SearchPort.TabIndex = 1;
            this.SearchPort.Text = "Search";
            this.SearchPort.UseVisualStyleBackColor = true;
            this.SearchPort.Click += new System.EventHandler(this.SearchPort_Click);
            // 
            // ConnectPort
            // 
            this.ConnectPort.Location = new System.Drawing.Point(104, 129);
            this.ConnectPort.Name = "ConnectPort";
            this.ConnectPort.Size = new System.Drawing.Size(111, 26);
            this.ConnectPort.TabIndex = 2;
            this.ConnectPort.Text = "Connect";
            this.ConnectPort.UseVisualStyleBackColor = true;
            this.ConnectPort.Click += new System.EventHandler(this.ConnectPort_Click);
            // 
            // DisconnectPort
            // 
            this.DisconnectPort.Location = new System.Drawing.Point(248, 129);
            this.DisconnectPort.Name = "DisconnectPort";
            this.DisconnectPort.Size = new System.Drawing.Size(111, 26);
            this.DisconnectPort.TabIndex = 3;
            this.DisconnectPort.Text = "Disconnect";
            this.DisconnectPort.UseVisualStyleBackColor = true;
            this.DisconnectPort.Click += new System.EventHandler(this.DisconnectPort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Port Selection";
            // 
            // ConnectBoardOK
            // 
            this.ConnectBoardOK.Location = new System.Drawing.Point(383, 198);
            this.ConnectBoardOK.Name = "ConnectBoardOK";
            this.ConnectBoardOK.Size = new System.Drawing.Size(75, 23);
            this.ConnectBoardOK.TabIndex = 5;
            this.ConnectBoardOK.Text = "OK";
            this.ConnectBoardOK.UseVisualStyleBackColor = true;
            this.ConnectBoardOK.Click += new System.EventHandler(this.ConnectBoardOK_Click);
            // 
            // ConnectBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.ConnectBoardOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisconnectPort);
            this.Controls.Add(this.ConnectPort);
            this.Controls.Add(this.SearchPort);
            this.Controls.Add(this.PortList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectBoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect Board";
            this.Load += new System.EventHandler(this.ConnectBoardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaximStyle.MaximComboBox PortList;
        private MaximStyle.MaximButton SearchPort;
        private MaximStyle.MaximButton ConnectPort;
        private MaximStyle.MaximButton DisconnectPort;
        private System.Windows.Forms.Label label1;
        private MaximStyle.MaximButton ConnectBoardOK;
    }
}