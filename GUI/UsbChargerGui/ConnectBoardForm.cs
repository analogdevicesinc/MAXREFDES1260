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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace UsbChargerGui
{
    public partial class ConnectBoardForm : Form
    {
        private SerialPort cbfSerialPort;
        public MainForm theMainForm;


        public ConnectBoardForm(SerialPort sp)
        {
            InitializeComponent();
            cbfSerialPort = sp;
        }

        private void ConnectBoardForm_Load(object sender, EventArgs e)
        {
            /// Get the Serial Port list, and show it in the combobox
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);

            PortList.Items.Clear();
            PortList.Items.AddRange(ports);
            PortList.SelectedIndex = (PortList.Items.Count > 0) ? 0 : -1;
        }

        private void SearchPort_Click(object sender, EventArgs e)
        {
            /// Get the Serial Port list, and show it in the combobox
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);

            PortList.Items.Clear();
            PortList.Items.AddRange(ports);
            PortList.SelectedIndex = (PortList.Items.Count > 0) ? 0 : -1;
        }

        private void ConnectPort_Click(object sender, EventArgs e)
        {
            if (cbfSerialPort.IsOpen)
            {
                MessageBox.Show("Port Already Opened.");
                return;
            }

            if(PortList.SelectedIndex <0)
            {
                MessageBox.Show("No Port Available.");
                return;
            }

            cbfSerialPort.PortName = PortList.Text;
            cbfSerialPort.BaudRate = 115200;
            cbfSerialPort.Parity = System.IO.Ports.Parity.None;
            cbfSerialPort.DataBits = 8;
            cbfSerialPort.StopBits = System.IO.Ports.StopBits.One;
            cbfSerialPort.Handshake = System.IO.Ports.Handshake.None;
            cbfSerialPort.RtsEnable = true;
            cbfSerialPort.DtrEnable = true;



            cbfSerialPort.Open();


            theMainForm.maximStatusStrip1.Items[2].Text = PortList.Text + " Connected @ 115200";

            theMainForm.maximStatusStrip1.Items[1].Text = theMainForm.ReadVersions();

            theMainForm.maximStatusStrip1.Items[0].Text = theMainForm.ReadMax17261Sn();

            if((theMainForm.maximStatusStrip1.Items[0].Text != "No MAX17261 SN") && (theMainForm.maximStatusStrip1.Items[1].Text != "No Hardware"))
            {
                theMainForm.EnableGuiControls();
                theMainForm.InitializaionDemo(0x01, 0x00);
            }

        }

        private void DisconnectPort_Click(object sender, EventArgs e)
        {
            if (cbfSerialPort.IsOpen)
            {
                cbfSerialPort.Close();

                theMainForm.maximStatusStrip1.Items[0].Text = "No MAX17261 SN";
                theMainForm.maximStatusStrip1.Items[1].Text = "No Hardware";
                theMainForm.maximStatusStrip1.Items[2].Text = "No COM Port Connected";

                theMainForm.DisableGuiControls();
                theMainForm.StopDemo();
            }
            else
            {
                MessageBox.Show("Port Already closed.");
                return;
            }
        }

        private void ConnectBoardOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
