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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace UsbChargerGui
{
    public delegate void SerialPortAsyncDataReceiveHandler(Object sender, SerialPortEventArgs e);

    public class SerialPortEventArgs : EventArgs
    {
        public byte[] ReceivedData = null;
    }

    public class SerialPortEx
    {
        private const int TIMEOUT = 50;
        private SerialPort port;
        private bool asyncReceiveEnabled;

        public event SerialPortAsyncDataReceiveHandler AsyncDataReceiveHandler = null;



        private Object thisLock = new Object();


        public SerialPortEx()
        {
            port = new SerialPort();
            
            port.DataReceived += new SerialDataReceivedEventHandler(AsyncDataReceive);
            asyncReceiveEnabled = true;
        }


        private void AsyncDataReceive(object sender, SerialDataReceivedEventArgs e)
        {
            int n = port.BytesToRead;

            if(n <= 0)
            {
                return;
            }

            lock (thisLock)
            {
                byte[] rbuf = new byte[n];


                port.Read(rbuf, 0, n);

                SerialPortEventArgs args = new SerialPortEventArgs();
                args.ReceivedData = rbuf;

                if (AsyncDataReceiveHandler != null)
                {
                    //AsyncDataReceiveHandler.BeginInvoke(this, args, null, null);
                    AsyncDataReceiveHandler.Invoke(this, args);
                    
                }
            }

        }



        public void SerialPortWrite(byte[] outbuf, int offset, int outlen)
        {
            port.Write(outbuf, offset, outlen);
        }

        public void EnableSerialPortAsycnReceive()
        {
            if (asyncReceiveEnabled == false)
            {
                asyncReceiveEnabled = true;
                port.DataReceived += new SerialDataReceivedEventHandler(AsyncDataReceive);
            }

        }

        public void DisableSerialPortAsycnReceive()
        {
            if (asyncReceiveEnabled == true)
            {
                asyncReceiveEnabled = false;
                port.DataReceived -= new SerialDataReceivedEventHandler(AsyncDataReceive);
            
            }
        }

        public int SerialPortRead(byte[] inbuf, int offset, int inlen)
        {
            int count;


            count = 0;
            while (port.BytesToRead < inlen)
            {
                System.Threading.Thread.Sleep(1);
                count++;

                if (count == TIMEOUT)
                {
                    return 0;
                }
            }

            
            return port.Read(inbuf, offset, inlen);

        }


        public SerialPort Port
        {
            get
            {
                return port;
            }
            set
            {
                port = value;
            }
        }
    }
}
