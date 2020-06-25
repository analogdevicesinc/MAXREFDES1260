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
 * @file    my_board.c
 * @brief   max32660 peripherals, uart, spim, gpio.
 *          
 */

/**** Includes ****/
#include <stdio.h>
#include <stdint.h>
#include "mxc_config.h"
#include "mxc_sys.h"
#include "mxc_assert.h"
#include "board.h"
#include "my_board.h"
#include "pwrseq_regs.h"
#include "flc_regs.h"
#include "uart.h"
#include "gpio.h"
#include "i2c.h"
#include "mxc_pins.h"




#define I2C_ERROR   (MXC_F_I2C_INT_FL0_ARB_ER | MXC_F_I2C_INT_FL0_TO_ER | MXC_F_I2C_INT_FL0_ADDR_NACK_ER | \
                    MXC_F_I2C_INT_FL0_DATA_ER | MXC_F_I2C_INT_FL0_DO_NOT_RESP_ER | MXC_F_I2C_INT_FL0_START_ER | \
                    MXC_F_I2C_INT_FL0_STOP_ER)
					
					
					

/**** Globals ****/
mxc_uart_regs_t *uart1 = MXC_UART_GET_UART(1);
const sys_cfg_i2c_t i2c1_sys_cfg = NULL;


volatile int uart1_async_read_flag;
volatile int uart1_async_write_flag;

uart_req_t write_req;
uart_req_t read_req;


const gpio_cfg_t max14748_int_pin   = {PORT_0, PIN_6,  GPIO_FUNC_IN,  GPIO_PAD_NONE};
const gpio_cfg_t max14748_cdir_pin  = {PORT_0, PIN_7,  GPIO_FUNC_IN,  GPIO_PAD_NONE};
const gpio_cfg_t max14748_fsus_pin  = {PORT_0, PIN_8,  GPIO_FUNC_OUT, GPIO_PAD_NONE};
const gpio_cfg_t max14748_sysok_pin = {PORT_0, PIN_9,  GPIO_FUNC_IN,  GPIO_PAD_NONE};
const gpio_cfg_t max14748_fltin_pin = {PORT_0, PIN_13, GPIO_FUNC_OUT, GPIO_PAD_NONE};
const gpio_cfg_t max1726x_alert_pin = {PORT_0, PIN_4,  GPIO_FUNC_IN,  GPIO_PAD_NONE};





/**** Functions ****/



void max14748_int_isr(void *cbdata)
{
    //delay(100);
}

uint8_t max14748_int_get(void)
{
	uint32_t temp;
	
	temp = GPIO_InGet(&max14748_int_pin);
	
	if(temp==0)
	{
		return 0;
	}
	else
	{
		return 1;
	}
}
	
uint8_t max14748_cdir_get(void)
{
	uint32_t temp;
	
	temp = GPIO_InGet(&max14748_cdir_pin);
	
	if(temp==0)
	{
		return 0;
	}
	else
	{
		return 1;
	}
}
	
void max14748_fsus_set(void)
{
	GPIO_OutSet(&max14748_fsus_pin);
}
	
void max14748_fsus_clr(void)
{
	GPIO_OutClr(&max14748_fsus_pin);
}
	
uint8_t max14748_sysok_get(void)
{
	uint32_t temp;
	
	temp = GPIO_InGet(&max14748_sysok_pin);
	
	if(temp==0)
	{
		return 0;
	}
	else
	{
		return 1;
	}
}
	
void max14748_fltin_set(void)
{
	GPIO_OutSet(&max14748_fltin_pin);
}
	
void max14748_fltin_clr(void)
{
	GPIO_OutClr(&max14748_fltin_pin);
}
	
uint8_t max1726x_alert_get(void)
{
	uint32_t temp;
	
	temp = GPIO_InGet(&max1726x_alert_pin);
	
	if(temp==0)
	{
		return 0;
	}
	else
	{
		return 1;
	}
}
	



/* **************************************************************************** */
void uart1_read_cb(uart_req_t* req, int error)
{
    uart1_async_read_flag = error;
}

/* **************************************************************************** */
void uart1_write_cb(uart_req_t* req, int error)
{
    uart1_async_write_flag = error;
}

/* **************************************************************************** */
void UART1_IRQHandler(void)
{
    UART_Handler(MXC_UART1);
}


void maxim_max32660_async_write_via_uart1(uint8_t* buf, uint16_t len)
{
	
    write_req.data = buf;
    write_req.len = len;


    uart1_async_write_flag = 1;
	// after write successfully, the flag will be set to 0 in uart1_write_cb()
	
	UART_WriteAsync(uart1, &write_req);
}

void maxim_max32660_async_read_via_uart1(uint8_t* buf, uint16_t len)
{
    read_req.data = buf;
    read_req.len = len;


    uart1_async_read_flag = 1;
	// after read successfully, the flag will be set to 0 in uart1_read_cb()
	// data is available in buf[] array
	
	UART_ReadAsync(uart1, &read_req);
}








/* ************************************************************************* */
void delay(uint32_t count)
{
	uint32_t i;
	
	i = count;
	
	while(i > 0)
	{
		i--;
	}
}

/* ************************************************************************* */
int My_Board_Init(void)
{
	int err;

	
	//Setup the I2C1 as I2C master, 400kHz
    I2C_Shutdown(MXC_I2C1);
    if((err = I2C_Init(MXC_I2C1, I2C_FAST_MODE, &i2c1_sys_cfg)) != E_NO_ERROR) 
	{
        return err;
    }
 
	
	// Setup the UART1 interrupt
    NVIC_ClearPendingIRQ(UART1_IRQn);
    NVIC_DisableIRQ(UART1_IRQn);
    NVIC_SetPriority(UART1_IRQn, 1);
    NVIC_EnableIRQ(UART1_IRQn);
	
	write_req.callback = uart1_write_cb;
	read_req.callback = uart1_read_cb;
	
	
	// GPIO configurations
	GPIO_Config(&max14748_int_pin);
	GPIO_Config(&max14748_cdir_pin);
	GPIO_Config(&max14748_fsus_pin);
	GPIO_Config(&max14748_sysok_pin);
	GPIO_Config(&max14748_fltin_pin);
	GPIO_Config(&max1726x_alert_pin);
	
	// GPIO interrupt configurations
	GPIO_RegisterCallback(&max14748_int_pin, max14748_int_isr, NULL);
    GPIO_IntConfig(&max14748_int_pin, GPIO_INT_EDGE, GPIO_INT_FALLING);
    GPIO_IntEnable(&max14748_int_pin);
    NVIC_EnableIRQ(GPIO0_IRQn);
	
	
    return E_NO_ERROR;
}

/* ************************************************************************* */
void maxim_max32660_send_char_via_uart1(const uint8_t data)
{
	UART_Write(uart1, &data, 1);
}

/* ************************************************************************* */
void maxim_max32660_send_string_via_uart1(uint8_t* buf, uint16_t len)
{
	UART_Write(uart1, buf, len);
}

/* ************************************************************************* */
void maxim_max32660_i2c1_write(uint8_t slave_addr, uint8_t *data, uint8_t data_len, uint8_t restart)
{
	I2C_MasterWrite(MXC_I2C1, slave_addr, data, data_len, restart);
}

/* ************************************************************************* */
void maxim_max32660_i2c1_read(uint8_t slave_addr, uint8_t *data, uint8_t data_len, uint8_t restart)
{
	I2C_MasterRead(MXC_I2C1, slave_addr, data, data_len, restart);
}

