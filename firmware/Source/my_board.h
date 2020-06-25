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
#ifndef _MY_BOARD_H_
#define _MY_BOARD_H_


/**** Includes ****/
#include "stdint.h"
#include "uart.h"

extern volatile int uart1_async_read_flag;
extern volatile int uart1_async_write_flag;


/**** Function Prototypes ****/

void maxim_max32660_async_write_via_uart1(uint8_t* buf, uint16_t len);
void maxim_max32660_async_read_via_uart1(uint8_t* buf, uint16_t len);
uint8_t max14748_int_get(void);
uint8_t max14748_cdir_get(void); 
void max14748_fsus_set(void);
void max14748_fsus_clr(void);
uint8_t max14748_sysok_get(void);
void max14748_fltin_set(void);
void max14748_fltin_clr(void);
uint8_t max1726x_alert_get(void);


/****************************************************************************/
/**
 * @brief   Initialize the BSP and board interfaces.
 *
 * @param   void.
 * @retval	#E_NO_ERROR if everything is successful
 */
int My_Board_Init(void);

/****************************************************************************/
/**
 * @brief      General delay function.
 *
 * @param      Time length for delay.
 * @retval     void.
 */
void delay(uint32_t count);

/****************************************************************************/
/**
 * @brief      Send 1 byte via max32660 uart1.
 *
 * @param      The data to send.
 * @retval     void.
 */
void maxim_max32660_send_char_via_uart1(const uint8_t data);

/****************************************************************************/
/**
 * @brief      Send a string via max32660 uart1.
 *
 * @param      The data buffer to send.
 * @param      The data length to send.
 * @retval     void.
 */
void maxim_max32660_send_string_via_uart1(uint8_t* buf, uint16_t len);

/****************************************************************************/
/**
 * @brief      Send a string via max32660 i2cm1 to a slave device.
 *
 * @param      Device address (high 7 bit).
 * @param      The data buffer to send (in byte).
 * @param      The data length to send.
 * @param      1-restart, 0-stop.
 * @retval     void.
 */
void maxim_max32660_i2c1_write(uint8_t slave_addr, uint8_t *data, uint8_t data_len, uint8_t restart);

/****************************************************************************/
/**
 * @brief      Receive a string via max32660 i2cm1 from a slave device.
 *
 * @param      Device address (high 7 bit).
 * @param      The data buffer to receive (in byte).
 * @param      The data length to receive.
 * @param      1-restart, 0-stop.
 * @retval     void.
 */
void maxim_max32660_i2c1_read(uint8_t slave_addr, uint8_t *data, uint8_t data_len, uint8_t restart);


#endif //_MY_BOARD_H_
