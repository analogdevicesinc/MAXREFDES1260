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
 
 /**
 * @file    protocol.c
 * @brief   Serial Command Protocol.
 *          
 */


/**** Includes ****/
#include "my_board.h"
#include "protocol.h"
#include "max1726x.h"
#include "max14748.h"

/**** Globals ****/
uint8_t command_packet[MAX_LENGTH];


/**** Functions ****/

/* ************************************************************************* */
uint8_t CommandOperation(uint8_t *packet)
{
	uint8_t address;
	
	if(packet[START] != START_MARK)
	{
		return 1;
	}
	
	if(packet[STOP] != STOP_MARK)
	{
		return 1;
	}
	
	switch(packet[TYPE])
	{
		case WRITE:
			
			switch(packet[ADDR1])
			{
				case MAX14748_REG:
					
					address = packet[ADDR2];
					max14748_regs[address] = packet[DATA2];
					maxim_max14748_write_reg(address, &max14748_regs[address]);
					
					break;
				
				case MAX17261_REG:
					address = packet[ADDR2];
					max1726x_regs[address] = packet[DATA1];
					max1726x_regs[address] = (max1726x_regs[address] <<8 ) | packet[DATA2];
					maxim_max1726x_write_reg(address, &max1726x_regs[address]);
					
					break;
				

				case IO_CONTROLS:
					switch(packet[ADDR2])
					{
						case FLTIN_SET:
							if(packet[DATA2] ==1)
							{
								max14748_fltin_set();
							}
							else if(packet[DATA2] ==0)
							{
								max14748_fltin_clr();
							}
							break;
						
						case FSUS_SET:
							if(packet[DATA2] ==1)
							{
								max14748_fsus_set();
							}
							else if(packet[DATA2] ==0)
							{
								max14748_fsus_clr();
							}
							break;
						
						default:
							return 1;
					}
					break;
				default:
					return 1;
			}
			break;
		case READ:
			switch(packet[ADDR1])
			{
				case MAX14748_REG:
					address = packet[ADDR2];
					maxim_max14748_read_reg(address, &max14748_regs[address]);
					packet[DATA1] = 0x00;
					packet[DATA2] = max14748_regs[address];
					break;
				case MAX17261_REG:
					address = packet[ADDR2];
					maxim_max1726x_read_reg(address, &max1726x_regs[address]);
					packet[DATA1] = max1726x_regs[address] >> 8;
					packet[DATA2] = max1726x_regs[address] & 0xFF;
					break;
				
				case MAX17261_SN:
					address = packet[ADDR2];
					// SN is read at the beginning of the main() function
					packet[DATA1] = max1726x_serialnum[address] >> 8;
					packet[DATA2] = max1726x_serialnum[address] & 0xFF;
					break;
				
				case VERSIONS:
					packet[DATA1] = VERSION_HW;
					packet[DATA2] = VERSION_FW;
					break;
				
				case IO_CONTROLS:
					switch(packet[ADDR2])
					{
						case CDIR_INDICATOR:
							packet[DATA2] = max14748_cdir_get();
							break;
						
						case SYSOK_INDICATOR:
							packet[DATA2] = max14748_sysok_get();
							break;
						
						case INT_INDICATOR:
							packet[DATA2] = max14748_int_get();
							break;
						
						case ALERT_INDICATOR:
							packet[DATA2] = max1726x_alert_get();
							break;
						
						default:
							return 1;
					}
					break;
				
				default:
					return 1;
			}
			break;
		
		default:
			return 1;
	}
	
	return 0;
}
