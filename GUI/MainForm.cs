using System;
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
    class SerialCommand
    {
        // Byte Definition
        public const int START = 0;
        public const int LENGTH = 1;
        public const int TYPE = 2;
        public const int ADDR1 = 3;
        public const int ADDR2 = 4;
        public const int DATA1 = 5;
        public const int DATA2 = 6;
        public const int STOP = 7;

        // Definition for command type
        public const int WRITE = 0;
        public const int TYPE_READ = 1;

        // Definition for addr1
        public const int MAX14748 = 0;
        public const int MAX17261 = 1;
        public const int CONTROLS = 2;

        // Definition for addr of the controls
    }

    public partial class MainForm : Form
    {
        private SerialPort mSerialPort;
        private SplashScreenForm splashScreen;
        private ConnectBoardForm connectBoard;
        byte[] SerialCommand;


        delegate void SerialPortDelegate(byte[] InputBuf);
        SerialPortDelegate serialPortDelegate;

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
            "TTE              , 0X11",
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
            "TTF              , 0X20",
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
            "SERIALNUM0       , 0xD4",
            "SERIALNUM1       , 0xD5",
            "SERIALNUM2       , 0xD9",
            "SERIALNUM3       , 0xDA",
            "SERIALNUM4       , 0xDC",
            "SERIALNUM5       , 0xDD",
            "SERIALNUM6       , 0xDE",
            "SERIALNUM7       , 0xDF",
            "VFOCV            , 0xFB",
            "VFSOC            , 0xFF"
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mSerialPort = new SerialPort();
            splashScreen = new SplashScreenForm(3);
            connectBoard = new ConnectBoardForm(mSerialPort);

            SerialCommand = new byte[8];



            /// Initialize the form controls
            serialPortDelegate = new SerialPortDelegate(SerialPortReceiveIsr);
            mSerialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPortAsyncReceive);

            maximStatusStrip1.Items[0].TextAlign = ContentAlignment.MiddleCenter;
            maximStatusStrip1.Items[0].Text = "Messages";

            PartSelection.Items.AddRange(PartList);
            PartSelection.SelectedIndex = 0;

            



            //Show splash screen if not disabled
            splashScreen.maximSplashScreen1.Checked = Properties.Settings.Default.DisableSplashScreen;
            if (!Properties.Settings.Default.DisableSplashScreen)
            {
                splashScreen.ShowDialog();
            }

            //Show connect board form
            connectBoard.ShowDialog();

        }

        private void SerialPortAsyncReceive(object sender, SerialDataReceivedEventArgs e)
        {
            int n = mSerialPort.BytesToRead;
            byte[] rbuf = new byte[n];


            mSerialPort.Read(rbuf, 0, n);

            BeginInvoke(serialPortDelegate, rbuf);


        }

        // Serial Port Receive Interrupt Handler
        private void SerialPortReceiveIsr(byte[] ReceivedData)
        {
            byte i= ReceivedData[0];
        }

        private void SerialPortWrite(byte[] outbuf, int offset, int outlen)
        {
            mSerialPort.Write(outbuf, offset, outlen);
        }

        private int SerialPortRead(byte[] inbuf, int offset, int inlen)
        {
            int len;

            mSerialPort.DataReceived -= new SerialDataReceivedEventHandler(SerialPortAsyncReceive);

            len = mSerialPort.Read(inbuf, offset, inlen);

            mSerialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPortAsyncReceive);

            return len;
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

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connectBoard.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Exits the application
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mSerialPort.IsOpen)
            {
                mSerialPort.Close();
            }
        }

        private void ReadRegister_Click(object sender, EventArgs e)
        {
            
        }

        private void WriteRegister_Click(object sender, EventArgs e)
        {
            SerialCommand[0] = 0x55;
            SerialCommand[1] = 0x01;
            SerialCommand[2] = 0x02;
            SerialCommand[3] = 0x01;
            SerialCommand[4] = 0x55;
            SerialCommand[5] = 0xAA;

            SerialPortWrite(SerialCommand, 0, 6);
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
    }

}

