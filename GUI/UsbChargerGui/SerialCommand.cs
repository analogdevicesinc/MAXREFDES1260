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

namespace UsbChargerGui
{
    public class SerialCommand
    {
        private byte[] packet;

        // Byte Definition
        public const byte START  = 0;
        public const byte LENGTH = 1;
        public const byte TYPE   = 2;
        public const byte ADDR1  = 3;
        public const byte ADDR2  = 4;
        public const byte DATA1  = 5;
        public const byte DATA2  = 6;
        public const byte STOP   = 7;

        public const byte START_MARK = 0xAA;
        public const byte STOP_MARK  = 0x55;

        // Default command length
        public const byte MAX_LENGTH     = 8;
        public const byte DEFAULT_LENGTH = 8;

        // Definition for command type
        public const byte WRITE = 0x00;
        public const byte READ  = 0x01;

        // Definition for addr1
        public const byte MAX14748_REG = 0x00;
        public const byte MAX17261_REG = 0x01;
        public const byte MAX17261_SN  = 0x02;
        public const byte IO_CONTROLS  = 0x03;
        public const byte VERSIONS     = 0x04;

        // Definition for addr of the controls
        public const byte CDIR_INDICATOR       = 0x00;
        public const byte SYSOK_INDICATOR      = 0x01;
        public const byte INT_INDICATOR        = 0x02;
        public const byte FLTIN_SET            = 0x03;
        public const byte FSUS_SET             = 0x04;
        public const byte ALERT_INDICATOR      = 0x05;



        public SerialCommand()
        {
            packet = new byte[MAX_LENGTH];

            // will not change for normal operation
            packet[START] = START_MARK;
            packet[LENGTH] = DEFAULT_LENGTH;
            packet[STOP] = STOP_MARK;

            // will change during operation
            packet[TYPE] = 0x00;
            packet[ADDR1] = 0x00;
            packet[ADDR2] = 0x00;
            packet[DATA1] = 0x00;
            packet[DATA2] = 0x00;
        }


        public byte[] Packet
        {
            get
            {
                return packet;
            }
            set
            {
                packet = value;
            }
        }

    }
}

