namespace UsbChargerGui
{
    partial class SplashScreenForm
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
            this.maximSplashScreen1 = new MaximStyle.MaximSplashScreen();
            this.AboutOK = new MaximStyle.MaximButton();
            this.SuspendLayout();
            // 
            // maximSplashScreen1
            // 
            this.maximSplashScreen1.ApplicationIconImage = null;
            this.maximSplashScreen1.ApplicationName = "2-Cell USB Charger and Fuel Gauge";
            this.maximSplashScreen1.BackColor = System.Drawing.Color.White;
            this.maximSplashScreen1.Checked = false;
            this.maximSplashScreen1.CopyrightString = "© Maxim Integrated Products, Inc. All rights reserved.";
            this.maximSplashScreen1.DescriptionString = "MAXREFDES1260";
            this.maximSplashScreen1.DismissTime = 5;
            this.maximSplashScreen1.Font = new System.Drawing.Font("Arial", 11F);
            this.maximSplashScreen1.Location = new System.Drawing.Point(0, 0);
            this.maximSplashScreen1.Margin = new System.Windows.Forms.Padding(4);
            this.maximSplashScreen1.Name = "maximSplashScreen1";
            this.maximSplashScreen1.NonMaximCopyrightHeight = -1;
            this.maximSplashScreen1.NonMaximCopyrightScrollbar = false;
            this.maximSplashScreen1.NonMaximCopyrightString = "";
            this.maximSplashScreen1.Size = new System.Drawing.Size(400, 279);
            this.maximSplashScreen1.TabIndex = 0;
            this.maximSplashScreen1.VersionString = "Version 1.01";
            // 
            // AboutOK
            // 
            this.AboutOK.Location = new System.Drawing.Point(328, 247);
            this.AboutOK.Name = "AboutOK";
            this.AboutOK.Size = new System.Drawing.Size(60, 23);
            this.AboutOK.TabIndex = 1;
            this.AboutOK.Text = "OK";
            this.AboutOK.UseVisualStyleBackColor = true;
            this.AboutOK.Visible = false;
            this.AboutOK.Click += new System.EventHandler(this.AboutOK_Click);
            // 
            // SplashScreenForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.ControlBox = false;
            this.Controls.Add(this.AboutOK);
            this.Controls.Add(this.maximSplashScreen1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreenForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal MaximStyle.MaximSplashScreen maximSplashScreen1;
        internal MaximStyle.MaximButton AboutOK;
    }
}