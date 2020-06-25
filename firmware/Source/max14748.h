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
#ifndef _MAX14748_H_
#define _MAX14748_H_

/**** Includes ****/
#include "stdint.h"


/**** Definitions ****/

/**** MAX14748 I2C ADDRESS ****/
#define	MAX14748_I2C_ADDR					0x14


/**** MAX14748 REGISTER ADDRESS ****/
#define MAX14748_CHIP_ID			0x00
#define MAX14748_CHIP_REV			0x01
#define MAX14748_DEV_STATUS1		0x02
#define MAX14748_AICL_STATUS		0x03
#define MAX14748_DEV_STATUS2		0x04
#define MAX14748_CHG_STATUS			0x05
#define MAX14748_JEITA_STATUS		0x06
#define MAX14748_BC_STATUS			0x07
#define MAX14748_RESERVED_X08		0x08
#define MAX14748_CC_STATUS1			0x09
#define MAX14748_CC_STATUS2			0x0A
#define MAX14748_DEV_INT1			0x0B
#define MAX14748_AICL_INT			0x0C
#define MAX14748_DEV_INT2			0x0D
#define MAX14748_CHG_INT			0x0E
#define MAX14748_JETIA_INT			0x0F
#define MAX14748_BC_INT				0x10
#define MAX14748_CC_INT				0x11
#define MAX14748_DEV_INT1_MASK		0x12
#define MAX14748_AICL_INT_MASK		0x13
#define MAX14748_DEV_INT2_MASK		0x14
#define MAX14748_CHG_INT_MASK		0x15
#define MAX14748_JETIA_INT_MASK		0x16
#define MAX14748_BC_INT_MAKS		0x17
#define MAX14748_CC_INT_MASK		0x18
#define MAX14748_LED_CTRL			0x19
#define MAX14748_THERMA_CFG1		0x1A
#define MAX14748_THERMA_CFG2		0x1B
#define MAX14748_THERMA_CFG3		0x1C
#define MAX14748_CHARGER_CTRL1		0x1D
#define MAX14748_CHARGER_CTRL2		0x1E
#define MAX14748_CHARGER_CTRL3		0x1F
#define MAX14748_CHARGER_CTRL4		0x20
#define MAX14748_CUR_LIM_CTRL		0x21
#define MAX14748_CUR_LIM_STATUS		0x22
#define MAX14748_BB_CFG1			0x23
#define MAX14748_BB_CFG2			0x24
#define MAX14748_BC_CTRL1			0x25
#define MAX14748_RESERVED_X26		0x26
#define MAX14748_CC_CTRL1			0x27
#define MAX14748_CC_CTRL2			0x28
#define MAX14748_CC_CTRL3			0x29
#define MAX14748_CHG_INI_LIM1		0x2A
#define MAX14748_CHG_INI_LIM2		0x2B
#define MAX14748_AICL_CFG1			0x2C
#define MAX14748_AICL_CFG2			0x2D
#define MAX14748_AICL_CFG3			0x2E
#define MAX14748_DP_DN_SW			0x2F
#define MAX14748_OTHERS				0x30
#define MAX14748_RESERVED_X31		0x31
#define MAX14748_RESERVED_X32		0x32
#define MAX14748_LOW_POW			0x33
#define MAX14748_RESERVED_X34		0x34
#define MAX14748_FLT_SEL			0x35


/**** Globals ****/
extern uint8_t max14748_regs[54];



/**** Function Prototypes ****/

/****************************************************************************/
/**
 * @brief      Write 1 max14748 register.
 *
 * @param      Register address (1 byte).
 * @param      Register value (1 byte).
 * @retval     void.
 */
void maxim_max14748_write_reg(uint8_t reg_addr, uint8_t *reg_data);

/****************************************************************************/
/**
 * @brief      Read 1 max14748 register.
 *
 * @param      Register address (1 byte).
 * @param      Register value (1 byte).
 * @retval     void.
 */
void maxim_max14748_read_reg(uint8_t reg_addr, uint8_t *reg_data);




#endif //_MAX14748_H_
