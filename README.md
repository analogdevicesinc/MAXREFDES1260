# MAXREFDES1260
 This repository is where you can download the Firmware and PC GUI program of the MAXREFDES1260 reference design.
 
The MAXREFDES1260 is a USB Type-C multi-cell battery charging and fuel gauge demonstration application. The software consists of a PC GUI and firmware. The GUI runs on a Microsoft-based PC and connects via serial port to a custom MAX32660 microcontroller-based board running the included firmware. The GUI can setup and exercise/read both the MAX14748 battery charger and the MAX17261 fuel gauge on the custom board. 

# Software Download/Install:

-Click the "Clone or Download" button and click "Download ZIP" above (from the main GITHUB repo page). After the download finishes, unzip the archive to the directory of choice. All the files needed to run the board can be found in the firmware and GUI directories
-Program the the MAXREFDES1260 board with the appropriate binary file found in the firmware directory. Or, you can load the Keil project and compile/load the firmware that way (making sure that the Daplink board is connected to the reference design board and the PC).
-Install the GUI by double-clicking UsbChargerGuiSetupV1.0.exe located in the .\GUI\installer directory.
