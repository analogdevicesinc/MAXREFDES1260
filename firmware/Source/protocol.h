/*******************************************************************************
 * Copyright (C) 2016 Maxim Integrated Products, Inc., All Rights Reserved.
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
 *
 * $Date: 2019-10-18 09:19:34 -0500 (18 Oct 2019) $
 * $Revision: 1.0 $
 *
 ******************************************************************************/
 

 /* Define to prevent redundant inclusion */
#ifndef _PROTOCOL_H_
#define _PROTOCOL_H_

/**** Includes ****/
#include "stdint.h"


/**** Definitions ****/

#define VERSION_HW	0x10	// Hardware version = V1.0
#define VERSION_FW	0x10	// Firmware version = V1.0


#define START   0
#define LENGTH  1
#define TYPE    2
#define ADDR1   3
#define ADDR2   4
#define DATA1   5
#define DATA2   6
#define STOP    7

#define START_MARK  0xAA
#define STOP_MARK   0x55

#define MAX_LENGTH      8
#define DEFAULT_LENGTH  8

#define WRITE  0x00
#define READ   0x01

#define MAX14748_REG  0x00
#define MAX17261_REG  0x01
#define MAX17261_SN   0x02
#define IO_CONTROLS   0x03
#define VERSIONS      0x04


#define CDIR_INDICATOR        0x00
#define SYSOK_INDICATOR       0x01
#define INT_INDICATOR         0x02
#define FLTIN_SET             0x03
#define FSUS_SET              0x04
#define ALERT_INDICATOR       0x05




/**** Globals ****/
extern uint8_t command_packet[MAX_LENGTH];


/**** Function Prototypes ****/

/****************************************************************************/
/**
 * @brief      Decode the received command packet, response, and prepare the packet to send
 *
 * @param      Data packet array.
 * @retval     0-OK, 1-Error
 */
uint8_t CommandOperation(uint8_t *packet);

#endif //_PROTOCOL_H_
