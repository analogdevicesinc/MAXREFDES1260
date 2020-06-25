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
 * @file    max14746.c
 * @brief   max14746 driver.
 *          
 */


/**** Includes ****/
#include "max14746.h"
#include "my_board.h"

/**** Globals ****/
uint8_t max14746_regs[20];


/**** Functions ****/

/* ************************************************************************* */
void maxim_max14746_write_reg(uint8_t reg_addr, uint8_t *reg_data)
{
	uint8_t i2c_data[2];
	
	i2c_data[0] = reg_addr;
	i2c_data[1] = (*reg_data);

	maxim_max32660_i2c1_write(MAX14746_I2C_ADDR, i2c_data, 2, 0);

}

/* ************************************************************************* */
void maxim_max14746_read_reg(uint8_t reg_addr, uint8_t *reg_data)
{
	uint8_t i2c_data[1];
	
	i2c_data[0] = reg_addr;
	maxim_max32660_i2c1_write(MAX14746_I2C_ADDR, i2c_data, 1, 1);
	
	maxim_max32660_i2c1_read(MAX14746_I2C_ADDR, i2c_data, 1, 0);
	
	*reg_data = i2c_data[0];

}
