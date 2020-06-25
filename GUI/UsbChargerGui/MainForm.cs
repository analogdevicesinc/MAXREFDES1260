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
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaximStyle;
using System.IO.Ports;


namespace UsbChargerGui
{


    public partial class MainForm : Form
    {
        
        
        public SerialPortEx spex;
        public SerialCommand scmd;

        private SplashScreenForm splashScreen;
        private ConnectBoardForm connectBoard;

        public bool isRunning;


        string[] PartList = { "MAX14748", "MAX17261" };

        string[] Max14748RegisterList =
        {
            "CHIP_ID          , 0x00",
            "CHIP_REV         , 0x01",
            "DEV_STATUS1      , 0x02",
            "AICL_STATUS      , 0x03",
            "DEV_STATUS2      , 0x04",
            "CHG_STATUS       , 0x05",
            "JEITA_STATUS     , 0x06",
            "BC_STATUS        , 0x07",
            "CC_STATUS1       , 0x09",
            "CC_STATUS2       , 0x0A",
            "DEV_INT1         , 0x0B",
            "AICL_INT         , 0x0C",
            "DEV_INT2         , 0x0D",
            "CHG_INT          , 0x0E",
            "JETIA_INT        , 0x0F",
            "BC_INT           , 0x10",
            "CC_INT           , 0x11",
            "DEV_INT1_MASK    , 0x12",
            "AICL_INT_MASK    , 0x13",
            "DEV_INT2_MASK    , 0x14",
            "CHG_INT_MASK     , 0x15",
            "JETIA_INT_MASK   , 0x16",
            "BC_INT_MAKS      , 0x17",
            "CC_INT_MASK      , 0x18",
            "LED_CTRL         , 0x19",
            "THERMA_CFG1      , 0x1A",
            "THERMA_CFG2      , 0x1B",
            "THERMA_CFG3      , 0x1C",
            "CHARGER_CTRL1    , 0x1D",
            "CHARGER_CTRL2    , 0x1E",
            "CHARGER_CTRL3    , 0x1F",
            "CHARGER_CTRL4    , 0x20",
            "CUR_LIM_CTRL     , 0x21",
            "CUR_LIM_STATUS   , 0x22",
            "BB_CFG1          , 0x23",
            "BB_CFG2          , 0x24",
            "BC_CTRL1         , 0x25",
            "CC_CTRL1         , 0x27",
            "CC_CTRL2         , 0x28",
            "CC_CTRL3         , 0x29",
            "CHG_INI_LIM1     , 0x2A",
            "CHG_INI_LIM2     , 0x2B",
            "AICL_CFG1        , 0x2C",
            "AICL_CFG2        , 0x2D",
            "AICL_CFG3        , 0x2E",
            "DP_DN_SW         , 0x2F",
            "OTHERS           , 0x30",
            "LOW_POW          , 0x33",
            "FLT_SEL          , 0x35"
        };

        string[] Max17261RegisterList =
        {
            "STATUS           , 0x00",
            "VALRTTH          , 0x01",
            "TALRTTH          , 0x02",
            "SALRTTH          , 0x03",
            "ATRATE           , 0x04",
            "REPCAP           , 0x05",
            "REPSOC           , 0x06",
            "AGE              , 0x07",
            "TEMP             , 0x08",
            "VCELL            , 0x09",
            "CURRENT          , 0x0A",
            "AVGCURRENT       , 0x0B",
            "QRESIDUAL        , 0x0C",
            "MIXSOC           , 0x0D",
            "AVSOC            , 0x0E",
            "REMCAP           , 0x0F",
            "FULLCAPREP       , 0x10",
            "TTE              , 0x11",
            "QRTABLE00        , 0x12",
            "FULLSOCTHR       , 0x13",
            "RCELL            , 0x14",
            "AVGTA            , 0x16",
            "CYCLES           , 0x17",
            "DESIGNCAP        , 0x18",
            "AVGVCELL         , 0x19",
            "MAXMINTEMP       , 0x1A",
            "MAXMINVOLT       , 0x1B",
            "MAXMINCURR       , 0x1C",
            "CONFIG           , 0x1D",
            "ICHGTERM         , 0x1E",
            "AVCAP            , 0x1F",
            "TTF              , 0x20",
            "DEVNAME          , 0x21",
            "QRTABLE10        , 0x22",
            "FULLCAPNOM       , 0x23",
            "AIN              , 0x27",
            "LEARNCFG         , 0x28",
            "FLITERCFG        , 0x29",
            "RELAXCFG         , 0x2A",
            "MISCCFG          , 0x2B",
            "TGAIN            , 0x2C",
            "TOFF             , 0x2D",
            "CGAIN            , 0x2E",
            "COFF             , 0x2F",
            "QRTABLE20        , 0x32",
            "DIETEMP          , 0x34",
            "FULLCAP          , 0x35",
            "RCOMP0           , 0x38",
            "TEMPCO           , 0x39",
            "VEMPTY           , 0x3A",
            "FSTAT            , 0x3D",
            "TIMER            , 0x3E",
            "SHDNTIMER        , 0x3F",
            "QRTABLE30        , 0x42",
            "RGAIN            , 0x43",
            "DQACC            , 0x45",
            "DPACC            , 0x46",
            "CONVGCFG         , 0x49",
            "VFREMCAP         , 0x4A",
            "QH               , 0x4D",
            "MODELDATA0_STAR  , 0x80",
            "MODELDATA1_STAR  , 0x90",
            "STATUS2          , 0xB0",
            "POWER            , 0xB1",
            "ID_USERMEM2      , 0xB2",
            "AVGPOWER         , 0xB3",
            "IALRTTH          , 0xB4",
            "TTFCFG           , 0xB5",
            "CVMIXCAP         , 0xB6",
            "CVHALFIME        , 0xB7",
            "CGTEMPCO         , 0xB8",
            "CURVE            , 0xB9",
            "HIBCFG           , 0xBA",
            "CONFIG2          , 0xBB",
            "VRIPPLE          , 0xBC",
            "RIPPLECFG        , 0xBD",
            "TIMERH           , 0xBE",
            "RSENSE_USERMEM3  , 0xD0",
            "SCOCVLIM         , 0xD1",
            "VGAIN            , 0xD2",
            "SOCHOLD          , 0xD3",
            "MAXPEAKPOWER     , 0xD4",
            "SUSPEAKPOWER     , 0xD5",
            "PACKRESISTANCE   , 0xD6",
            "SYSRESISTANCE    , 0xD7",
            "MINSYSVOLTAGE    , 0xD8",
            "MPPCURRENT       , 0xD9",
            "SPPCURRENT       , 0xDA",
            "MODELCFG         , 0xDB",
            "ATQRESIDUAL      , 0xDC",
            "ATTTE            , 0xDD",
            "ATAVSOC          , 0xDE",
            "ATAVCAP          , 0xDF",
            "VFOCV            , 0xFB",
            "VFSOC            , 0xFF",
            /*
            "SERIALNUM0       , 0xD4",
            "SERIALNUM1       , 0xD5",
            "SERIALNUM2       , 0xD9",
            "SERIALNUM3       , 0xDA",
            "SERIALNUM4       , 0xDC",
            "SERIALNUM5       , 0xDD",
            "SERIALNUM6       , 0xDE",
            "SERIALNUM7       , 0xDF"
            */
        };

        string[] BatRegulationThresholdList =
        {
            "8.3V", // Reg[0x1D].bit[2:1] = 00
            "8.4V", // Reg[0x1D].bit[2:1] = 01
            "8.5V", // Reg[0x1D].bit[2:1] = 10
            "8.6V", // Reg[0x1D].bit[2:1] = 11

        };

        string[] PrechargeThresholdList =
        {
            "5.7V", // Reg[0x1E].bit[6:4] = 000
            "5.8V", // Reg[0x1E].bit[6:4] = 001
            "5.9V", // Reg[0x1E].bit[6:4] = 010
            "6.0V", // Reg[0x1E].bit[6:4] = 011
            "6.1V", // Reg[0x1E].bit[6:4] = 100
            "6.2V", // Reg[0x1E].bit[6:4] = 101
            "6.3V", // Reg[0x1E].bit[6:4] = 110
            "6.4V", // Reg[0x1E].bit[6:4] = 111

        };

        string[] BatRechargeThresholdList =
        {
            "200mV", // Reg[0x1D].bit[6:5] = 00
            "300mV", // Reg[0x1D].bit[6:5] = 01
            "400mV", // Reg[0x1D].bit[6:5] = 10
            "500mV", // Reg[0x1D].bit[6:5] = 11
        };

        string[] ChargeDoneThresholdList =
        {
            "0.05 * IFChg", // Reg[0x1E].bit[1:0] = 00
            "0.1 * IFChg",  // Reg[0x1E].bit[1:0] = 01
            "0.2 * IFChg",  // Reg[0x1E].bit[1:0] = 10

        };

        public delegate void UpdateUiDelegate(byte[] InputBuf);
        public UpdateUiDelegate update_ui_delegate;

        public MainForm()
        {
            InitializeComponent();


            spex = new SerialPortEx();
            splashScreen = new SplashScreenForm(3);
            connectBoard = new ConnectBoardForm(spex.Port);
            scmd = new SerialCommand();

            spex.AsyncDataReceiveHandler += new SerialPortAsyncDataReceiveHandler(ComReceiveDataEvent);

            spex.DisableSerialPortAsycnReceive();

            update_ui_delegate = new UpdateUiDelegate(UpdateUiEvent);

        }

        public void ComReceiveDataEvent(Object sender, SerialPortEventArgs e)
        {

            int n = spex.Port.BytesToRead; 
            byte[] buf = new byte[n];
            
            spex.Port.Read(buf, 0, n);  

            this.Invoke(update_ui_delegate, buf);
        }

        public void UpdateUiEvent(byte[] InputBuf)
        {
            // add actions here if you want to update the GUI asynchronously
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            isRunning = false;

            /// Initialize the form controls
            /// 

            maximStatusStrip1.Items[0].Width = 310;
            maximStatusStrip1.Items[0].TextAlign = ContentAlignment.MiddleCenter;
            maximStatusStrip1.Items[0].Text = "No MAX17261 SN";

            maximStatusStrip1.Items[1].Width = 130;
            maximStatusStrip1.Items[1].TextAlign = ContentAlignment.MiddleCenter;
            maximStatusStrip1.Items[1].Text = "No Hardware";

            maximStatusStrip1.Items[2].Width = 170;
            maximStatusStrip1.Items[2].TextAlign = ContentAlignment.MiddleCenter;
            maximStatusStrip1.Items[2].Text = "No COM Port Connected";

            PartSelection.Items.AddRange(PartList);
            PartSelection.SelectedIndex = 0;



            BatRegulationThreshold.Items.AddRange(BatRegulationThresholdList);
            BatRegulationThreshold.SelectedIndex = 0;

            PrechargeThreshold.Items.AddRange(PrechargeThresholdList);
            PrechargeThreshold.SelectedIndex = 0;

            BatRechargeThreshold.Items.AddRange(BatRechargeThresholdList);
            BatRechargeThreshold.SelectedIndex = 0;

            ChargeDoneThreshold.Items.AddRange(ChargeDoneThresholdList);
            ChargeDoneThreshold.SelectedIndex = 0;

            DisableGuiControls();


            //Show splash screen if not disabled
            splashScreen.maximSplashScreen1.Checked = Properties.Settings.Default.DisableSplashScreen;
            if (!Properties.Settings.Default.DisableSplashScreen)
            {
                splashScreen.ShowDialog();
            }

            //Show connect board form
            connectBoard.theMainForm = this;
            connectBoard.ShowDialog();


            

            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Stop();
            
        }

        




        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splashScreen.EnableTimer = false; //disable timer for the splach screen timeout         
            splashScreen.AboutOK.Visible = true;//enable ok button
            splashScreen.Show();//show about form
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connectBoard.ShowDialog();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Exits the application
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (spex.Port.IsOpen)
            {
                spex.Port.Close();
            }
        }

        private void ReadRegister_Click(object sender, EventArgs e)
        {

            
            string saddr = RegisterSelection.SelectedItem.ToString();

            switch (PartSelection.SelectedIndex)
            {
                case SerialCommand.MAX14748_REG:
                    RegisterValue.Text = ReadMax14748Reg(saddr);
                    break;

                case SerialCommand.MAX17261_REG:
                    RegisterValue.Text = ReadMax17261Reg(saddr);
                    break;

                default:

                    return;

            }




        }

        private void WriteRegister_Click(object sender, EventArgs e)
        {
            string saddr = RegisterSelection.SelectedItem.ToString();
            string svalue = RegisterValue.Text;


            switch (PartSelection.SelectedIndex)
            {
                case SerialCommand.MAX14748_REG:
                    WriteMax14748Reg(saddr, svalue);
                    break;

                case SerialCommand.MAX17261_REG:
                    WriteMax17261Reg(saddr, svalue);
                    break;

                default:
                    
                    return;

            }


            
        }

        private void PartSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegisterSelection.Items.Clear();
            RegisterSelection.SelectedIndex = -1;

            if (PartSelection.SelectedIndex == 0)
            {
                RegisterSelection.Items.AddRange(Max14748RegisterList);
            }
            else if(PartSelection.SelectedIndex == 1)
            {
                RegisterSelection.Items.AddRange(Max17261RegisterList);
            }

            RegisterSelection.SelectedIndex = 0;
        }

        public void EnableGuiControls()
        {
            WriteRegister.Enabled = true;
            ReadRegister.Enabled = true;
            AlertEnable.Enabled = true;
            NtcEnable.Enabled = true;
            IntEnable.Enabled = true;
            AiclEnable.Enabled = true;
            Dcp3aEnable.Enabled = true;
            ChargerEnable.Enabled = true;
            FsusSet.Enabled = true;
            FltinSet.Enabled = true;
            ChargeDoneThreshold.Enabled = true;
            BatRechargeThreshold.Enabled = true;
            PrechargeThreshold.Enabled = true;
            BatRegulationThreshold.Enabled = true;
            
    }

        public void DisableGuiControls()
        {
            WriteRegister.Enabled = false;
            ReadRegister.Enabled = false;
            AlertEnable.Enabled = false;
            NtcEnable.Enabled = false;
            IntEnable.Enabled = false;
            AiclEnable.Enabled = false;
            Dcp3aEnable.Enabled = false;
            ChargerEnable.Enabled = false;
            FsusSet.Enabled = false;
            FltinSet.Enabled = false;
            ChargeDoneThreshold.Enabled = false;
            BatRechargeThreshold.Enabled = false;
            PrechargeThreshold.Enabled = false;
            BatRegulationThreshold.Enabled = false;
            
        }

        private void ChargerEnable_CheckedChanged(object sender, EventArgs e)
        {
            int reg_value;

            if(!isRunning)
            {
                return;
            }
            timer1.Stop();
            isRunning = false;
        

            reg_value = ReadMax14748Reg(0x1D);


            if (ChargerEnable.Checked)
            {
                WriteMax14748Reg(0x1D, (byte)(reg_value | 0x01));
            }
            else
            {
                WriteMax14748Reg(0x1D, (byte)(reg_value & 0xFE));
            }

            
            isRunning = true;
            timer1.Start();

        }

        private void Dcp3aEnable_CheckedChanged(object sender, EventArgs e)
        {
            int reg_value;

            if (!isRunning)
            {
                return;
            }
            timer1.Stop();
            isRunning = false;


            reg_value = ReadMax14748Reg(0x25);


            if (Dcp3aEnable.Checked)
            {
                WriteMax14748Reg(0x25, (byte)(reg_value | 0x10));
            }
            else
            {
                WriteMax14748Reg(0x25, (byte)(reg_value & 0xEF));
            }


            isRunning = true;
            timer1.Start();


        }

        private void AiclEnable_CheckedChanged(object sender, EventArgs e)
        {



            if (!isRunning)
            {
                return;
            }
            timer1.Stop();
            isRunning = false;



            if (AiclEnable.Checked)
            {
                WriteMax14748Reg(0x2C, 0x80);
            }
            else
            {
                WriteMax14748Reg(0x2C, 0x01);
            }


            isRunning = true;
            timer1.Start();

            
        }

        private void IntEnable_CheckedChanged(object sender, EventArgs e)
        {


            if (!isRunning)
            {
                return;
            }
            timer1.Stop();
            isRunning = false;


            if (IntEnable.Checked)
            {
                WriteMax14748Reg(0x12, 0x00);
                WriteMax14748Reg(0x13, 0x00);
                WriteMax14748Reg(0x14, 0x20);
                WriteMax14748Reg(0x15, 0x10);
                WriteMax14748Reg(0x16, 0x00);
                WriteMax14748Reg(0x17, 0x60);
                WriteMax14748Reg(0x18, 0x10);

            }
            else
            {
                WriteMax14748Reg(0x12, 0xFF);
                WriteMax14748Reg(0x13, 0x40);
                WriteMax14748Reg(0x14, 0x7F);
                WriteMax14748Reg(0x15, 0xF1);
                WriteMax14748Reg(0x16, 0x19);
                WriteMax14748Reg(0x17, 0xFF);
                WriteMax14748Reg(0x18, 0x7F);
            }


            isRunning = true;
            timer1.Start();

        }

        private void BatRegulationThreshold_SelectedIndexChanged(object sender, EventArgs e)
        {


            int reg_value;

            if (!isRunning)
            {
                return;
            }
            timer1.Stop();
            isRunning = false;


            reg_value = ReadMax14748Reg(0x1D);


            reg_value = reg_value & 0xF9;

            
            switch (BatRegulationThreshold.SelectedIndex)
            {
                case 0:
                    WriteMax14748Reg(0x1D, (byte)(reg_value | 0x00));
                    break;

                case 1:
                    WriteMax14748Reg(0x1D, (byte)(reg_value | 0x02));
                    break;

                case 2:
                    WriteMax14748Reg(0x1D, (byte)(reg_value | 0x04));
                    break;

                case 3:
                    WriteMax14748Reg(0x1D, (byte)(reg_value | 0x06));
                    break;

                default:
                    
                    break;


            }

            isRunning = true;
            timer1.Start();



        }

        private void PrechargeThreshold_SelectedIndexChanged(object sender, EventArgs e)
        {
            int reg_value;

            if (!isRunning)
            {
                return;
            }
            timer1.Stop();
            isRunning = false;


            reg_value = ReadMax14748Reg(0x1E);

            reg_value = reg_value & 0x8F;

            switch (PrechargeThreshold.SelectedIndex)
            {
                case 0:
                    WriteMax14748Reg(0x1E, (byte)(reg_value | 0x00));
                    break;

                case 1:
                    WriteMax14748Reg(0x1E, (byte)(reg_value | 0x10));
                    break;

                case 2:
                    WriteMax14748Reg(0x1E, (byte)(reg_value | 0x20));
                    break;

                case 3:
                    WriteMax14748Reg(0x1E, (byte)(reg_value | 0x30));
                    break;

                case 4:
                    WriteMax14748Reg(0x1E, (byte)(reg_value | 0x40));
                    break;

                case 5:
                    WriteMax14748Reg(0x1E, (byte)(reg_value | 0x50));
                    break;

                case 6:
                    WriteMax14748Reg(0x1E, (byte)(reg_value | 0x60));
                    break;

                case 7:
                    WriteMax14748Reg(0x1E, (byte)(reg_value | 0x70));
                    break;

                default:
                    
                    break;


            }

            isRunning = true;
            timer1.Start();


        }

        private void BatRechargeThreshold_SelectedIndexChanged(object sender, EventArgs e)
        {


            int reg_value;

            if (!isRunning)
            {
                return;
            }
            timer1.Stop();
            isRunning = false;


            reg_value = ReadMax14748Reg(0x1D);


            reg_value = reg_value & 0x9F;


            switch (BatRechargeThreshold.SelectedIndex)
            {
                case 0:
                    WriteMax14748Reg(0x1D, (byte)(reg_value | 0x00));
                    break;

                case 1:
                    WriteMax14748Reg(0x1D, (byte)(reg_value | 0x20));
                    break;

                case 2:
                    WriteMax14748Reg(0x1D, (byte)(reg_value | 0x40));
                    break;

                case 3:
                    WriteMax14748Reg(0x1D, (byte)(reg_value | 0x60));
                    break;

                default:

                    break;


            }

            isRunning = true;
            timer1.Start();


            
        }

        private void ChargeDoneThreshold_SelectedIndexChanged(object sender, EventArgs e)
        {
            int reg_value;

            if (!isRunning)
            {
                return;
            }
            timer1.Stop();
            isRunning = false;


            reg_value = ReadMax14748Reg(0x1E);


            reg_value = reg_value & 0xFC;


            switch (ChargeDoneThreshold.SelectedIndex)
            {
                case 0:
                    WriteMax14748Reg(0x1E, (byte)(reg_value | 0x00));
                    break;

                case 1:
                    WriteMax14748Reg(0x1E, (byte)(reg_value | 0x01));
                    break;

                case 2:
                    WriteMax14748Reg(0x1E, (byte)(reg_value | 0x02));
                    break;


                default:

                    break;


            }

            isRunning = true;
            timer1.Start();



            
        }

        private void FltinSet_CheckedChanged(object sender, EventArgs e)
        {




            if (!isRunning)
            {
                return;
            }
            timer1.Stop();
            isRunning = false;


            if (FltinSet.Checked)
            {
                WriteIoControl(SerialCommand.FLTIN_SET, 0x01);
            }
            else
            {
                //WriteIoControl(SerialCommand.FLTIN_SET, 0x00);

                // note: set FLTIN low will reset the registers for MAX14748
                //       so, need to refresh the status of all controls
                InitializaionDemo(0x00, 0x00);
            }


            isRunning = true;
            timer1.Start();

            
        }

        private void FsusSet_CheckedChanged(object sender, EventArgs e)
        {

            if (!isRunning)
            {
                return;
            }
            timer1.Stop();
            isRunning = false;


            if (FsusSet.Checked)
            {
                WriteIoControl(SerialCommand.FSUS_SET, 0x01);
            }
            else
            {
                WriteIoControl(SerialCommand.FSUS_SET, 0x00);
            }


            isRunning = true;
            timer1.Start();


        }

        private void NtcEnable_CheckedChanged(object sender, EventArgs e)
        {
            int reg_value;

            if (!isRunning)
            {
                return;
            }
            timer1.Stop();
            isRunning = false;


            reg_value = ReadMax17261Reg(0x1D);


            if (NtcEnable.Checked)
            {
                WriteMax17261Reg(0x1D, (reg_value | 0x8000));
            }
            else
            {
                WriteMax17261Reg(0x1D, (reg_value & 0x7FFF));
            }


            isRunning = true;
            timer1.Start();


            
        }

        private void AlertEnable_CheckedChanged(object sender, EventArgs e)
        {
            int reg_value;

            if (!isRunning)
            {
                return;
            }
            timer1.Stop();
            isRunning = false;


            reg_value = ReadMax17261Reg(0x1D);


            if (AlertEnable.Checked)
            {
                WriteMax17261Reg(0x1D, (reg_value | 0x04));
            }
            else
            {
                WriteMax17261Reg(0x1D, (reg_value & 0xFB));
            }


            isRunning = true;
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int reg_value;
            byte io_control_value;
            float display_value;

            if (!isRunning)
            {
                return;
            }
            timer1.Stop();
            isRunning = false;


            io_control_value = ReadIoControl(SerialCommand.INT_INDICATOR);
            if (io_control_value == 0x01)
            {
                IntIndicator.IndicatorColor = StatusIndicatorColor.Green;
            }
            else
            {
                IntIndicator.IndicatorColor = StatusIndicatorColor.Red;
            }



            io_control_value = ReadIoControl(SerialCommand.SYSOK_INDICATOR);
            if (io_control_value == 0x01)
            {
                SysOkIndicator.IndicatorColor = StatusIndicatorColor.Green;
            }
            else
            {
                SysOkIndicator.IndicatorColor = StatusIndicatorColor.Red;
            }



            io_control_value = ReadIoControl(SerialCommand.CDIR_INDICATOR);
            if (io_control_value == 0x01)
            {
                CdirIndicator.IndicatorColor = StatusIndicatorColor.Green;
            }
            else
            {
                CdirIndicator.IndicatorColor = StatusIndicatorColor.Red;
            }




            io_control_value = ReadIoControl(SerialCommand.ALERT_INDICATOR);
            if (io_control_value == 0x01)
            {
                AlertIndicator.IndicatorColor = StatusIndicatorColor.Green;
            }
            else
            {
                AlertIndicator.IndicatorColor = StatusIndicatorColor.Red;
            }



            // SOC
            reg_value = ReadMax17261Reg(0x06);
            display_value = (float)reg_value / 256.0f;
            SocValue.Text = display_value.ToString("F1");




            // Vcell
            reg_value = ReadMax17261Reg(0x09);
            display_value = (float)reg_value * 0.00015625f;
            VcellValue.Text = display_value.ToString("F3");


            // RepCap
            reg_value = ReadMax17261Reg(0x05);
            display_value = (float)reg_value * 0.5f;
            RepCapValue.Text = display_value.ToString("F1");



            // Temp
            reg_value = ReadMax17261Reg(0x08);
            if (reg_value > 32768)
            {
                reg_value = reg_value - 65536;
            }
            display_value = (float)reg_value / 256.0f;
            TempValue.Text = display_value.ToString("F1");



            // FullCapRep
            reg_value = ReadMax17261Reg(0x10);
            display_value = (float)reg_value *0.5f;
            FullCapRepValue.Text = display_value.ToString("F1");




            // Current
            reg_value = ReadMax17261Reg(0x0A);
            if (reg_value > 32768)
            {
                reg_value = reg_value - 65536;
            }
            display_value = (float)reg_value * 0.15625f;

            CurrentValue.Text = display_value.ToString("F3");



            isRunning = true;
            timer1.Start();

        }

        private void maximTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (maximTabControl1.SelectedIndex == 0)
            {
                if (ChargerEnable.Enabled)  // the controls is enabled only when the COM port is connected successfully.
                {
                    isRunning = true;
                    timer1.Start();
                }
            }
            else if (maximTabControl1.SelectedIndex == 1)
            {
                timer1.Stop();
                isRunning = false;
            }
        }


        /////////////////////////////////////////////////////////////////////////////////
        public void StopDemo()
        {
            timer1.Stop();
            isRunning = false;
        }


        public void InitializaionDemo(byte fltin_state, byte fsus_state)
        {
            int reg_value;

            timer1.Stop();
            isRunning = false;


            // note: set FLTIN low will reset the registers for MAX14748
            WriteIoControl(SerialCommand.FLTIN_SET, fltin_state);
            if(fltin_state == 0x01)
            {
                FltinSet.Checked = true;
            }
            else
            {
                FltinSet.Checked =false;
            }


            WriteIoControl(SerialCommand.FSUS_SET, fsus_state);
            if (fsus_state == 0x01)
            {
                FsusSet.Checked = true;
            }
            else
            {
                FsusSet.Checked = false;
            }


            reg_value = ReadMax14748Reg(0x1D);
            if((reg_value & 0x01) == 0x01)
            {
                ChargerEnable.Checked = true;
            }
            else
            {
                ChargerEnable.Checked = false;
            }

            BatRegulationThreshold.SelectedIndex = (reg_value & 0x06) >> 1;

            BatRechargeThreshold.SelectedIndex = (reg_value & 0x60) >> 5;
            


            reg_value = ReadMax14748Reg(0x25);
            if ((reg_value & 0x10) == 0x10)
            {
                Dcp3aEnable.Checked = true;
            }
            else
            {
                Dcp3aEnable.Checked = false;
            }


            reg_value = ReadMax14748Reg(0x2C);
            if (reg_value == 0x01)
            {
                AiclEnable.Checked = false;
            }
            else
            {
                AiclEnable.Checked = true;
            }

            reg_value = ReadMax14748Reg(0x12);
            if (reg_value == 0xFF)
            {
                IntEnable.Checked = false;
            }
            else
            {
                IntEnable.Checked = true;
            }


            reg_value = ReadMax14748Reg(0x1E);
            PrechargeThreshold.SelectedIndex = (reg_value & 0x70) >> 4;

            ChargeDoneThreshold.SelectedIndex = (reg_value & 0x03);


            reg_value = ReadMax17261Reg(0x1D);
            if ((reg_value & 0x80) == 0x80)
            {
                NtcEnable.Checked = true;
            }
            else
            {
                NtcEnable.Checked = false;
            }

            if ((reg_value & 0x04) == 0x04)
            {
                AlertEnable.Checked = true;
            }
            else
            {
                AlertEnable.Checked = false;
            }


            isRunning = true;
            timer1.Start();
        }


        public void WriteMax17261Reg(byte address, int value)
        {
            scmd.Packet[SerialCommand.TYPE] = SerialCommand.WRITE;
            scmd.Packet[SerialCommand.ADDR1] = SerialCommand.MAX17261_REG;
            scmd.Packet[SerialCommand.ADDR2] = address;
            scmd.Packet[SerialCommand.DATA1] = (byte) ((value >> 8) & 0xFF);
            scmd.Packet[SerialCommand.DATA2] = (byte) (value & 0xFF);

            spex.SerialPortWrite(scmd.Packet, 0, 8);
            spex.SerialPortRead(scmd.Packet, 0, 8);
        }

        public int ReadMax17261Reg(byte address)
        {
            int value;

            scmd.Packet[SerialCommand.TYPE] = SerialCommand.READ;
            scmd.Packet[SerialCommand.ADDR1] = SerialCommand.MAX17261_REG;
            scmd.Packet[SerialCommand.ADDR2] = address;
            scmd.Packet[SerialCommand.DATA1] = 0x00;
            scmd.Packet[SerialCommand.DATA2] = 0x00;

            spex.SerialPortWrite(scmd.Packet, 0, 8);
            int len = spex.SerialPortRead(scmd.Packet, 0, 8);

            if (len == 8)
            {
                value = (byte)scmd.Packet[SerialCommand.DATA1];
                value = (value << 8) + (byte)scmd.Packet[SerialCommand.DATA2];
            }
            else
            {
                value = 0xFFFFFF;   // this is shown as a read error
            }
            return value;
        }

        public void WriteMax14748Reg(byte address, byte value)
        {
            scmd.Packet[SerialCommand.TYPE] = SerialCommand.WRITE;
            scmd.Packet[SerialCommand.ADDR1] = SerialCommand.MAX14748_REG;
            scmd.Packet[SerialCommand.ADDR2] = address;
            scmd.Packet[SerialCommand.DATA1] = 0x00;
            scmd.Packet[SerialCommand.DATA2] = value;

            spex.SerialPortWrite(scmd.Packet, 0, 8);
            spex.SerialPortRead(scmd.Packet, 0, 8);
        }

        public int ReadMax14748Reg(byte address)
        {
            int value;

            scmd.Packet[SerialCommand.TYPE] = SerialCommand.READ;
            scmd.Packet[SerialCommand.ADDR1] = SerialCommand.MAX14748_REG;
            scmd.Packet[SerialCommand.ADDR2] = address;
            scmd.Packet[SerialCommand.DATA1] = 0x00;
            scmd.Packet[SerialCommand.DATA2] = 0x00;

            spex.SerialPortWrite(scmd.Packet, 0, 8);
            int len = spex.SerialPortRead(scmd.Packet, 0, 8);

            if (len == 8)
            {
                value = (byte)scmd.Packet[SerialCommand.DATA2];
            }
            else
            {
                value = 0xFFFFFF;   // this is shown as a read error
            }
            return value;
        }


        public void WriteMax17261Reg(string address, string value)
        {
            byte addr_temp;
            int value_temp;


            int itemp = address.IndexOf("0x");
            string stemp = address.Substring(itemp + 2, 2);
            addr_temp = byte.Parse(stemp, System.Globalization.NumberStyles.HexNumber);




            CultureInfo provider = new CultureInfo("en-US");

            stemp = RegisterValue.Text;

            if (stemp.Length != 6)
            {
                MessageBox.Show("The Register Value must be '0xHHHH'.");

                return;
            }

            itemp = stemp.IndexOf("0x");
            if (itemp != 0)
            {
                MessageBox.Show("The Register Value must be '0xHHHH'.");

                return;
            }

            stemp = stemp.Substring(2, 4);
            if (int.TryParse(stemp, System.Globalization.NumberStyles.HexNumber, provider, out itemp))
            {
                //itemp = int.Parse(stemp, System.Globalization.NumberStyles.HexNumber);

                value_temp = itemp;
                WriteMax17261Reg(addr_temp, value_temp);
            }
            else
            {
                MessageBox.Show("The Register Value must be '0xHHHH'.");

                return;
            }
            

        }

        public string ReadMax17261Reg(string address)
        {
            byte addr_temp;
            int value_temp;


            int itemp = address.IndexOf("0x");
            string stemp = address.Substring(itemp + 2, 2);
            addr_temp = byte.Parse(stemp, System.Globalization.NumberStyles.HexNumber);

            value_temp = ReadMax17261Reg(addr_temp);

            if (value_temp != 0xFFFFFF)
            {
                return "0x" + value_temp.ToString("X4");

            }
            else
            {
                return "Error";
            }
        }

        public void WriteMax14748Reg(string address, string value)
        {

            byte addr_temp;
            int value_temp;


            int itemp = address.IndexOf("0x");
            string stemp = address.Substring(itemp + 2, 2);
            addr_temp = byte.Parse(stemp, System.Globalization.NumberStyles.HexNumber);

            


            CultureInfo provider = new CultureInfo("en-US");
            
            stemp = RegisterValue.Text;

            if (stemp.Length != 4)
            {
                MessageBox.Show("The Register Value must be '0xHH'.");

                return;
            }

            itemp = stemp.IndexOf("0x");
            if (itemp != 0)
            {
                MessageBox.Show("The Register Value must be '0xHH'.");

                return;
            }
            stemp = stemp.Substring(2, 2);

            if (int.TryParse(stemp, System.Globalization.NumberStyles.HexNumber, provider, out value_temp))
            {

                WriteMax14748Reg(addr_temp, (byte)value_temp);
            }
            else
            {
                MessageBox.Show("The Register Value must be '0xHH'.");

                return;
            }


              

        }

        public string ReadMax14748Reg(string address)
        {
            byte addr_temp;
            int value_temp;
            
            
            int itemp = address.IndexOf("0x");
            string stemp = address.Substring(itemp + 2, 2);
            addr_temp = byte.Parse(stemp, System.Globalization.NumberStyles.HexNumber);

            value_temp = ReadMax14748Reg(addr_temp);

            if (value_temp != 0xFFFFFF)
            {
                return "0x" + value_temp.ToString("X2");

            }
            else
            {
                return "Error";
            }
        }

        public void WriteIoControl(byte address, byte value)
        {
            scmd.Packet[SerialCommand.TYPE] = SerialCommand.WRITE;
            scmd.Packet[SerialCommand.ADDR1] = SerialCommand.IO_CONTROLS;
            scmd.Packet[SerialCommand.ADDR2] = address;
            scmd.Packet[SerialCommand.DATA1] = 0x00;
            scmd.Packet[SerialCommand.DATA2] = value;

            spex.SerialPortWrite(scmd.Packet, 0, 8);
            spex.SerialPortRead(scmd.Packet, 0, 8);
        }

        public byte ReadIoControl(byte address)
        {
            byte value;

            scmd.Packet[SerialCommand.TYPE] = SerialCommand.READ;
            scmd.Packet[SerialCommand.ADDR1] = SerialCommand.IO_CONTROLS;
            scmd.Packet[SerialCommand.ADDR2] = address;
            scmd.Packet[SerialCommand.DATA1] = 0x00;
            scmd.Packet[SerialCommand.DATA2] = 0x00;

            spex.SerialPortWrite(scmd.Packet, 0, 8);
            spex.SerialPortRead(scmd.Packet, 0, 8);

            value = scmd.Packet[SerialCommand.DATA2];

            return value;
        }

        public string ReadVersions()
        {
            string Versions = "No Hardware";

            // Read Versions
            

            scmd.Packet[SerialCommand.TYPE] = SerialCommand.READ;


            scmd.Packet[SerialCommand.ADDR1] = SerialCommand.VERSIONS;



            spex.SerialPortWrite(scmd.Packet, 0, scmd.Packet[SerialCommand.LENGTH]);

            int len = spex.SerialPortRead(scmd.Packet, 0, scmd.Packet[SerialCommand.LENGTH]);

            if (len == scmd.Packet[SerialCommand.LENGTH])
            {
                string hw_version = scmd.Packet[SerialCommand.DATA1].ToString("X2");
                string fw_version = scmd.Packet[SerialCommand.DATA2].ToString("X2");

                Versions = "Hw-V" + hw_version.Substring(0, 1) + "." + hw_version.Substring(1, 1)
                                                            + "    Fw-V" + fw_version.Substring(0, 1) + "." + fw_version.Substring(1, 1);
            }

            return Versions;
        }

        public string ReadMax17261Sn()
        {
            //Get MAX17261 serial number
            int i;
            string sn = "Max17261 SN-";
            int len = 0;

            for (i = 7; i >= 0; i--)
            {
                scmd.Packet[SerialCommand.TYPE] = SerialCommand.READ;

                scmd.Packet[SerialCommand.ADDR1] = SerialCommand.MAX17261_SN;
                scmd.Packet[SerialCommand.ADDR2] = (byte)i;
                spex.SerialPortWrite(scmd.Packet, 0, scmd.Packet[SerialCommand.LENGTH]);

                len += spex.SerialPortRead(scmd.Packet, 0, scmd.Packet[SerialCommand.LENGTH]);

                sn += scmd.Packet[SerialCommand.DATA1].ToString("X2");
                sn += scmd.Packet[SerialCommand.DATA2].ToString("X2");
            }

            if (len != scmd.Packet[SerialCommand.LENGTH] * 8)
            {
                sn = "No MAX17261 SN";
            }

            return sn;
        }

        private void LegendSetHigh_Click(object sender, EventArgs e)
        {
            LegendSetHigh.Checked = true;
        }

        private void LegendSetLow_Clicked(object sender, EventArgs e)
        {
            LegendSetLow.Checked = false;
        }

        private void LegendEnabled_CheckedChanged(object sender, EventArgs e)
        {
            LegendEnabled.Checked = true;
        }

        private void LegendDisabled_CheckedChanged(object sender, EventArgs e)
        {
            LegendDisabled.Checked = false;
        }

    }


    


}