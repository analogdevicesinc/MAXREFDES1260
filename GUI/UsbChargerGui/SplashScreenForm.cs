/*******************************************************************************
* Copyright (C) Maxim Integrated Products, Inc., All Rights Reserved.
*
* Permission is hereby granted, free of charge, to any person obtaining a
* copy of this software and associated documentation files (the "Software"),
* to deal in the Software without restriction, including without limitation
* the rights to use, copy, modify, merge, publish, distribute, sublicense,
* and/or sell copies of the Software, and to permit persons to whom the
* Software is furnished to do so, subject to the following conditions:
*
* The above copyright notice and this permission notice shall be included
* in all copies or substantial portions of the Software.
*
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
* OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
* MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
* IN NO EVENT SHALL MAXIM INTEGRATED BE LIABLE FOR ANY CLAIM, DAMAGES
* OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
* ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
* OTHER DEALINGS IN THE SOFTWARE.
*
* Except as contained in this notice, the name of Maxim Integrated
* Products, Inc. shall not be used except as stated in the Maxim Integrated
* Products, Inc. Branding Policy.
*
* The mere transfer of this software does not imply any licenses
* of trade secrets, proprietary technology, copyrights, patents,
* trademarks, maskwork rights, or any other form of intellectual
* property whatsoever. Maxim Integrated Products, Inc. retains all
* ownership rights.
*******************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsbChargerGui
{
    public partial class SplashScreenForm : Form
    {
        private Timer timer = new Timer();
        internal bool EnableTimer = true;

        public SplashScreenForm()
        {
            InitializeComponent();

            //create event handler for timer event
            maximSplashScreen1.ConfigureTimer(timer, new EventHandler(timer_Tick));

            //create event handlers for the links and disable checkbox
            maximSplashScreen1.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkClicked);
            maximSplashScreen1.DisableSplashScreenClicked += new EventHandler(DisableSplashScreenClicked);
        }

        public SplashScreenForm(int numberOfSeconds)
        {
            InitializeComponent();
            maximSplashScreen1.DismissTime = numberOfSeconds;

            //create event handler for timer event
            maximSplashScreen1.ConfigureTimer(timer, new EventHandler(timer_Tick));

            //create event handlers for the links and disable checkbox
            maximSplashScreen1.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkClicked);
            maximSplashScreen1.DisableSplashScreenClicked += new EventHandler(DisableSplashScreenClicked);
        }
        public SplashScreenForm(string applicationName, string versionString, string copyrightString,
            string nonMaximCopyrightString, Image applicationIconImage, int numberOfSeconds)
        {
            InitializeComponent();
            maximSplashScreen1.DismissTime = numberOfSeconds;
            maximSplashScreen1.ApplicationName = applicationName;
            maximSplashScreen1.VersionString = versionString;
            maximSplashScreen1.CopyrightString = copyrightString;
            maximSplashScreen1.NonMaximCopyrightString = nonMaximCopyrightString;

            //create event handler for timer event
            maximSplashScreen1.ConfigureTimer(timer, new EventHandler(timer_Tick));

            //create event handlers for the links and disable checkbox
            maximSplashScreen1.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkClicked);
            maximSplashScreen1.DisableSplashScreenClicked += new EventHandler(DisableSplashScreenClicked);
        }


   

        

        /// This function is triggerd upon the Form load event.
        /// It will start the timer and create event handlers
        protected void SplashScreen_Load(object sender, EventArgs e)
        {
            if (EnableTimer)//start timer if enabled
                timer.Start();
            else
                timer.Stop();
        }

        /// This is the timer event. It will execute when the timers delay is up
        /// to stop the timer and close the splash screen
        /// @param[in] sender = timer  
        /// @param[in] e = event data
        protected void timer_Tick(object sender, EventArgs e)
        {
            //stop timer and close splash screen when time is up
            timer.Stop();
            this.Hide();
        }

        /// This event will execute when a link has been clicked
        /// It will launch the website clicked
        /// @param[in] sender = links that were clicked
        /// @param[in] e = event data
        protected void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //get the linkLabel that was clicked
            LinkLabel linkLabel = (LinkLabel)sender;

            //Launch link in browser
            //System.Diagnostics.Process.Start("http://" + linkLabel.Text);
            //The link for support is changed
            if (linkLabel.Text == "support.maximintegrated.com")
            {
                System.Diagnostics.Process.Start("http://maximsupport.microsoftcrmportals.com/en-US/support-center");
            }
            if (linkLabel.Text == "www.maximintegrated.com")
            {
                System.Diagnostics.Process.Start("http://www.maximintegrated.com");
            }


        }
        /// This event will execute when the disable splash screen checkbox has changed
        /// It will save the status of disabling the splash screen in an xml file
        /// @param[in] sender = checkbox that was clicked
        /// @param[in] e = event data
        protected void DisableSplashScreenClicked(object sender, EventArgs e)
        {
            //get the checkbox that was clicked
            CheckBox checkBox = (CheckBox)sender;

            //save the checked status in the app settings
            Properties.Settings.Default.DisableSplashScreen = checkBox.Checked;
            Properties.Settings.Default.Save();
        }

        /// This event will execute when the OK button is clicked
        /// It will close the splash screen
        /// @param[in] sender = button that was clicked
        /// @param[in] e = event data
        private void AboutOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
