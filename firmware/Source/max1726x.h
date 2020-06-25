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
#ifndef _MAX1726X_H_
#define _MAX1726X_H_

/**** Includes ****/
#include "stdint.h"


/**** Definitions ****/

/**** MAX1726X I2C ADDRESS ****/
#define	MAX1726X_I2C_ADDR					0x6C


/**** MAX1726X REGISTER ADDRESS ****/
//Refer to "MAX1726x-ModelGauge-m5-EZ-user-guide.pdf" page 27

#define MAX1726X_STATUS_REG                 0x00
#define MAX1726X_VALRTTH_REG                0x01
#define MAX1726X_TALRTTH_REG                0x02
#define MAX1726X_SALRTTH_REG                0x03
#define MAX1726X_ATRATE_REG                 0x04
#define MAX1726X_REPCAP_REG                 0x05
#define MAX1726X_REPSOC_REG                 0x06
#define MAX1726X_AGE_REG                    0x07
#define MAX1726X_TEMP_REG                   0x08
#define MAX1726X_VCELL_REG                  0x09
#define MAX1726X_CURRENT_REG                0x0A
#define MAX1726X_AVGCURRENT_REG             0x0B
#define MAX1726X_QRESIDUAL_REG              0x0C
#define MAX1726X_MIXSOC_REG                 0x0D
#define MAX1726X_AVSOC_REG                  0x0E
#define MAX1726X_REMCAP_REG                 0x0F

#define MAX1726X_FULLCAPREP_REG             0x10
#define MAX1726X_TTE_REG                    0X11
#define MAX1726X_QRTABLE00_REG              0x12
#define MAX1726X_FULLSOCTHR_REG             0x13
#define MAX1726X_RCELL_REG                  0x14
//                             reserved for 0x15
#define MAX1726X_AVGTA_REG                  0x16
#define MAX1726X_CYCLES_REG                 0x17
#define MAX1726X_DESIGNCAP_REG              0x18
#define MAX1726X_AVGVCELL_REG               0x19
#define MAX1726X_MAXMINTEMP_REG             0x1A
#define MAX1726X_MAXMINVOLT_REG             0x1B
#define MAX1726X_MAXMINCURR_REG             0x1C
#define MAX1726X_CONFIG_REG                 0x1D
#define MAX1726X_ICHGTERM_REG               0x1E
#define MAX1726X_AVCAP_REG                  0x1F

#define MAX1726X_TTF_REG                    0X20
#define MAX1726X_DEVNAME_REG                0x21
#define MAX1726X_QRTABLE10_REG              0x22
#define MAX1726X_FULLCAPNOM_REG             0x23
//                             reserved for 0x24
//                             reserved for 0x25
//                             reserved for 0x26
#define MAX1726X_AIN_REG                    0x27
#define MAX1726X_LEARNCFG_REG               0x28
#define MAX1726X_FLITERCFG_REG              0x29
#define MAX1726X_RELAXCFG_REG               0x2A
#define MAX1726X_MISCCFG_REG                0x2B
#define MAX1726X_TGAIN_REG                  0x2C
#define MAX1726X_TOFF_REG                   0x2D
#define MAX1726X_CGAIN_REG                  0x2E
#define MAX1726X_COFF_REG                   0x2F

//                             reserved for 0x30
//                             reserved for 0x31
#define MAX1726X_QRTABLE20_REG              0x32
//                             reserved for 0x33
#define MAX1726X_DIETEMP_REG                0x34
#define MAX1726X_FULLCAP_REG                0x35
//                             reserved for 0x36
//                             reserved for 0x37
#define MAX1726X_RCOMP0_REG                 0x38
#define MAX1726X_TEMPCO_REG                 0x39
#define MAX1726X_VEMPTY_REG                 0x3A
//                             reserved for 0x3B
//                             reserved for 0x3C
#define MAX1726X_FSTAT_REG                  0x3D
#define MAX1726X_TIMER_REG                  0x3E
#define MAX1726X_SHDNTIMER_REG              0x3F

//                             reserved for 0x40
//                             reserved for 0x41
#define MAX1726X_QRTABLE30_REG              0x42
#define MAX1726X_RGAIN_REG                  0x43
//                             reserved for 0x44
#define MAX1726X_DQACC_REG                  0x45
#define MAX1726X_DPACC_REG                  0x46
//                             reserved for 0x47
//                             reserved for 0x48
#define MAX1726X_CONVGCFG_REG               0x49
#define MAX1726X_VFREMCAP_REG               0x4A
//                             reserved for 0x4B
//                             reserved for 0x4C
#define MAX1726X_QH_REG                     0x4D
//                             reserved for 0x4E
//                             reserved for 0x4F

#define MAX1726X_MODELDATA0_START_REG       0x80
#define MAX1726X_MODELDATA1_START_REG       0x90

#define MAX1726X_STATUS2_REG                0xB0
#define MAX1726X_POWER_REG                  0xB1
#define MAX1726X_ID_USERMEM2_REG            0xB2
#define MAX1726X_AVGPOWER_REG               0xB3
#define MAX1726X_IALRTTH_REG                0xB4
#define MAX1726X_TTFCFG_REG                 0xB5
#define MAX1726X_CVMIXCAP_REG               0xB6
#define MAX1726X_CVHALFIME_REG              0xB7
#define MAX1726X_CGTEMPCO_REG               0xB8
#define MAX1726X_CURVE_REG                  0xB9
#define MAX1726X_HIBCFG_REG                 0xBA
#define MAX1726X_CONFIG2_REG                0xBB
#define MAX1726X_VRIPPLE_REG                0xBC
#define MAX1726X_RIPPLECFG_REG              0xBD
#define MAX1726X_TIMERH_REG                 0xBE
//                             reserved for 0xBF

#define MAX1726X_RSENSE_USERMEM3_REG        0xD0
#define MAX1726X_SCOCVLIM_REG               0xD1
#define MAX1726X_VGAIN_REG                  0xD2
#define MAX1726X_SOCHOLD_REG                0xD3
#define MAX1726X_MAXPEAKPOWER_REG           0xD4
#define MAX1726X_SUSPEAKPOWER_REG           0xD5
#define MAX1726X_PACKRESISTANCE_REG         0xD6
#define MAX1726X_SYSRESISTANCE_REG          0xD7
#define MAX1726X_MINSYSVOLTAGE_REG          0xD8
#define MAX1726X_MPPCURRENT_REG             0xD9
#define MAX1726X_SPPCURRENT_REG             0xDA
#define MAX1726X_MODELCFG_REG               0xDB
#define MAX1726X_ATQRESIDUAL_REG            0xDC
#define MAX1726X_ATTTE_REG                  0xDD
#define MAX1726X_ATAVSOC_REG                0xDE
#define MAX1726X_ATAVCAP_REG                0xDF

#define MAX1726X_SERIALNUM0					0xD4
#define MAX1726X_SERIALNUM1					0xD5
#define MAX1726X_SERIALNUM2					0xD9
#define MAX1726X_SERIALNUM3					0xDA
#define MAX1726X_SERIALNUM4					0xDC
#define MAX1726X_SERIALNUM5					0xDD
#define MAX1726X_SERIALNUM6					0xDE
#define MAX1726X_SERIALNUM7					0xDF

#define MAX1726X_VFOCV_REG                  0xFB
#define MAX1726X_VFSOC_REG                  0xFF

/****************************************************************************/
/**
 * @brief struct type for max1726x ez config format.
 * @brief Refer to "MAX1726x-Software-Implementation-user-guide.pdf"
 */
typedef struct 
{
	uint16_t designcap;
	uint16_t ichgterm;
	uint16_t modelcfg;
	uint16_t vempty;
	
} max1726x_ez_config_t;

/****************************************************************************/
/**
 * @brief struct type for max1726x short ini file format.
 * @brief Refer to "MAX1726x-Software-Implementation-user-guide.pdf" page 13
 */
typedef struct 
{
	uint16_t designcap;
	uint16_t ichgterm;
	uint16_t modelcfg;
	uint16_t learncfg;		// optional
	uint16_t fullsocthr;	// optional
	uint16_t qrtable00;
	uint16_t qrtable10;
	uint16_t qrtable20;		// optional
	uint16_t qrtable30;		// optional
	uint16_t vempty;
	uint16_t rcomp0;
	uint16_t tempco;
	
} max1726x_short_ini_t;

/****************************************************************************/
/**
 * @brief struct type for max1726x full ini file format.
 * @brief Refer to "MAX1726x-Software-Implementation-user-guide.pdf" page 13
 */
typedef struct 
{
	uint16_t designcap;
	uint16_t fullcaprep;
	uint16_t ichgterm;
	uint16_t modelcfg;
	uint16_t qrtable00;
	uint16_t qrtable10;
	uint16_t qrtable20;		// optional
	uint16_t qrtable30;		// optional
	uint16_t vempty;
	uint16_t rcomp0;
	uint16_t tempco;
	uint16_t modeldata0[16];
	uint16_t modeldata1[16];
	uint16_t learncfg;		// optional
	uint16_t relaxcfg;		// optional
	uint16_t config;		// optional
	uint16_t config2;		// optional
	uint16_t fullsocthr;	// optional
	uint16_t tgain;			// optional
	uint16_t toff;			// optional
	uint16_t curve;			// optional
	
} max1726x_full_ini_t;

/****************************************************************************/
/**
 * @brief struct type for max1726x learned parameters.
 */
typedef struct 
{
	uint16_t saved_rcomp0;
	uint16_t saved_tempco;
	uint16_t saved_fullcaprep;
	uint16_t saved_cycles;
	uint16_t saved_fullcapnom;
	
} max1726x_learned_parameters_t;

/**** Globals ****/
extern uint16_t max1726x_regs[256];
extern uint16_t max1726x_serialnum[8];
extern max1726x_ez_config_t max1726x_ez_config;
extern max1726x_short_ini_t max1726x_short_ini;
extern max1726x_full_ini_t max1726x_full_ini;
extern max1726x_learned_parameters_t max1726x_learned_parameters;


/**** Function Prototypes ****/
// Refer to "MAX1726x-Software-Implementation-user-guide.pdf"

/****************************************************************************/
/**
 * @brief      Write 1 max1726x register.
 *
 * @param      Register address (1 byte).
 * @param      Register value (2 byte).
 * @retval     void.
 */
void maxim_max1726x_write_reg(uint8_t reg_addr, uint16_t *reg_data);

/****************************************************************************/
/**
 * @brief      Read 1 max1726x register.
 *
 * @param      Register address (1 byte).
 * @param      Register value (2 byte).
 * @retval     void.
 */
void maxim_max1726x_read_reg(uint8_t reg_addr, uint16_t *reg_data);

/****************************************************************************/
/**
 * @brief      Write 1 max1726x register and verify the readback value
 *
 * @param      Register address (1 byte).
 * @param      Register value (2 byte).
 * @retval     Status: 0 - no error; 1 - error.
 */
uint8_t maxim_max1726x_write_and_verify_reg(uint8_t reg_addr, uint16_t *reg_data);

/****************************************************************************/
/**
 * @brief      Check max1726x power on reset state
 *
 * @param      void.
 * @retval     State: 0 - no por; 1 - por assert.
 */
uint8_t maxim_max1726x_check_por(void);

/****************************************************************************/
/**
 * @brief      Clear max1726x power on reset state
 *
 * @param      void.
 * @retval     Status: 0 - no error; 1 - error.
 */
uint8_t maxim_max1726x_clear_por(void);

/****************************************************************************/
/**
 * @brief      Wait for max1726x data ready after power up
 *
 * @param      void.
 * @retval     void.
 */
void maxim_max1726x_wait_dnr(void);

/****************************************************************************/
/**
 * @brief      Initialize max1726x for EZ config mode
 * @brief      Customer must provide the battery parameters accordingly
 *
 * @param      void.
 * @retval     void.
 */
void maxim_max1726x_initialize_ez_config(void);

/****************************************************************************/
/**
 * @brief      Initialize max1726x for short INI mode
 * @brief      Customer must provide the battery parameters in this function
 * @brief      Get the parameters from MAXIM INI file
 *
 * @param      void.
 * @retval     void.
 */
void maxim_max1726x_initialize_short_ini(void);

/****************************************************************************/
/**
 * @brief      Initialize max1726x for full INI mode
 * @brief      Customer must provide the battery parameters in this function
 * @brief      Get the parameters from MAXIM INI file
 *
 * @param      void.
 * @retval     void.
 */
void maxim_max1726x_initialize_full_ini(void);

/****************************************************************************/
/**
 * @brief      Get max1726x RepCap value
 *
 * @param      Rsense value (in mOhm).
 * @retval     RepCap value (in mAh).
 */
float maxim_max1726x_get_repcap(float Rsense);

/****************************************************************************/
/**
 * @brief      Get max1726x RepSoc value
 *
 * @param      void.
 * @retval     RepSoc value (in percentage).
 */
float maxim_max1726x_get_repsoc(void);

/****************************************************************************/
/**
 * @brief      Get max1726x Time to Empty (TTE) value
 *
 * @param      void.
 * @retval     TTE (in second).
 */
float maxim_max1726x_get_tte(void);

/****************************************************************************/
/**
 * @brief      Save max1726x learned parameters
 *
 * @param      max1726x learned parameters.
 * @retval     void.
 */
void maxim_max1726x_save_learned_parameters(max1726x_learned_parameters_t *lp);

/****************************************************************************/
/**
 * @brief      Restore max1726x learned parameters
 *
 * @param      max1726x learned parameters.
 * @retval     void.
 */
void maxim_max1726x_restore_learned_parameters(max1726x_learned_parameters_t *lp);

/****************************************************************************/
/**
 * @brief      Get max1726x serial number
 *
 * @param      max1726x serial number.
 * @retval     void.
 */
void maxim_max1726x_get_serial_number(uint16_t *sn);

/****************************************************************************/
/**
 * @brief      Unlock max1726x model data access
 *
 * @param      void.
 * @retval     void.
 */
void maxim_max1726x_unlock_model_data(void);

/****************************************************************************/
/**
 * @brief      Write max1726x model data and verify the readback value
 *
 * @param      First 16 word.
 * @param      Sencod 16 word.
 * @retval     Number of error word.
 */
uint8_t maxim_max1726x_write_model_data(uint16_t *data0, uint16_t *data1);

/****************************************************************************/
/**
 * @brief      Lock max1726x model data access
 *
 * @param      void.
 * @retval     void.
 */
void maxim_max1726x_lock_model_data(void);


/****************************************************************************/
/**
 * @brief      Verify max1726x model data is locked
 * @param      void.
 * @retval     Number of error word.
 */
uint8_t maxim_max1726x_verify_model_data_locked(void);

#endif //_MAX1726X_H_
