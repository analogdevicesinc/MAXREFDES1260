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
 
 
 /**** Includes ****/
#include "max32660.h"
#include "stdio.h"
#include "board.h"
#include "my_board.h"
#include "max1726x.h"
#include "max14748.h"
#include "max14746.h"
#include "protocol.h"

 
int main(void)
{
	/// Initialize the BSP and board interfaces.
	My_Board_Init();

	
	// Initialize MAX1726X
	maxim_max1726x_check_por();
	maxim_max1726x_wait_dnr();
	maxim_max1726x_initialize_ez_config();
	maxim_max1726x_clear_por();
	
	maxim_max1726x_get_serial_number(max1726x_serialnum);
	

	// Start to read UART command
	maxim_max32660_async_read_via_uart1(command_packet, 8);
	
	while(1)
	{
	
		if(uart1_async_read_flag==0)
		{
			CommandOperation(command_packet);
			maxim_max32660_send_string_via_uart1(command_packet, 8);
			
			maxim_max32660_async_read_via_uart1(command_packet, 8);
		}
		
		
		
		
		
		
	}
	
}
