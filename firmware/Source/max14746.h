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
#ifndef _MAX14746_H_
#define _MAX14746_H_

/**** Includes ****/
#include "stdint.h"


/**** Definitions ****/

/**** MAX14746 I2C ADDRESS ****/
#define	MAX14746_I2C_ADDR					0x14


/**** MAX14746 REGISTER ADDRESS ****/
#define MAX14746_CHIP_ID			0x00
#define MAX14746_CHIP_REV			0x01
#define MAX14746_STATUS_A			0x02
#define MAX14746_STATUS_B			0x03
#define MAX14746_STATUS_C			0x04
#define MAX14746_INT_A				0x05
#define MAX14746_INT_B				0x06
#define MAX14746_INT_MASK_A			0x07
#define MAX14746_INT_MASK_B			0x08
#define MAX14746_C_DET_CNTL_A		0x09
#define MAX14746_I_LIM_CNTL			0x0A
#define MAX14746_CHG_CNTL_A			0x0B
#define MAX14746_CHG_CNTL_B			0x0C
#define MAX14746_CHG_TMR			0x0D
#define MAX14746_CHG_V_SET			0x0E
#define MAX14746_RFU				0x0F
#define MAX14746_CHG_P_CNTL			0x10
#define MAX14746_C_DET_CNTL_B		0x11
#define MAX14746_CHG_CNTL_C			0x12
#define MAX14746_I_LIM_MON			0x13



/**** Globals ****/
extern uint8_t max14746_regs[20];



/**** Function Prototypes ****/

/****************************************************************************/
/**
 * @brief      Write 1 max14746 register.
 *
 * @param      Register address (1 byte).
 * @param      Register value (1 byte).
 * @retval     void.
 */
void maxim_max14746_write_reg(uint8_t reg_addr, uint8_t *reg_data);

/****************************************************************************/
/**
 * @brief      Read 1 max14746 register.
 *
 * @param      Register address (1 byte).
 * @param      Register value (1 byte).
 * @retval     void.
 */
void maxim_max14746_read_reg(uint8_t reg_addr, uint8_t *reg_data);


#endif //_MAX14746_H_
