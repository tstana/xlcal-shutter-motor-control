# Calibration Beam Control

The `Calib Beam Ctrl` program is a .NET application running under Windows
meant to send commands to a motor driver board that controls the periodic
rotation of a shutter covering a radioactive source. It was developed for
calibrating the [XL-Calibur instrument](https://sites.wustl.edu/xlcal/home/),
but the software used can be used as a reference to write software (or 
potentially even use as a driver) when calibrating other instruments.

See [System Requirements](#system-requirements) for more details on the setup
this application can work with.

<img src="images/CalibBeamCtrl.PNG">

# Table of Contents

- [System Requirements](#system-requirements)
- [User Guide](#user-guide)
  * [Installing CalibBeamCtrl](#installing-calibbeamctrl)
  * [Preparing the setup](#preparing-the-setup)
  * [Running CalibBeamCtrl](#running-calibbeamctrl)
  * [Troubleshooting](#troubleshooting)
- [Developer Guide](#developer-guide)
  * [Main Project](#main-project)
  * [Setup Project](#setup-project)

# System Requirements

- Windows: Tested on Windows 10, but should work on Windows 11 (or earlier)
- [.NET v4.6.1](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net461)
- Stepper motor (several available in a cardboard box containing several
  motors and motor driver boards)
- Motor driver used with this version of the app:
  - [EZHR17EN](http://www.allmotion.com/EZHR17ENDescription.htm)
  - RS-485 to RS-232 converter (available in the cardboard box containing
    several motors and motor driver boards)
  - Standard USB to Serial Port converter
- Power supply for the motor driver board:
  - 24V wall-wart power supply or a configurable bench-top power supply
  - Voltage range for the supply: 12-40 V
  - Current consumption of the test setup: ~0.8 A

# User Guide

## Installing CalibBeamCtrl

Before the program can be used, it needs to be installed locally on Windows.

Follow these steps to install `CalibBeamCtrl`:

1. Download the [installer file](https://www.dropbox.com/s/qovgwud9kwxqwqf/CalibBeamCtrl.msi?dl=0).
2. Run the downloaded MSI file in administrator mode.
4. Choose the folder to install to, if the default one is not appropriate.
5. After the installation completes, navigate to the installation folder.
6. Create a shortcut of the `CalibBeamCtrl.exe` to the computer's Desktop,
   so it can be easily run.

Note that the program can also be run directly from Visual Studio, if an
installation of it is available. The installed version is of course the
most out-of-the box solution available -- and is linked to a defined release
of the program.

## Preparing the setup

See the [EZStepper Start Guide](http://www.allmotion.com/New%20PDF's/EZ17_23/EZ_17_23%20EZ%20Start.pdf)
for details on the setup.

For XL-Calibur, the motor to be connected to the EZHR17EN motor driver is
placed inside the calibration setup aluminum cage:

**------TODO------: Add picture(s)!**

## Running CalibBeamCtrl

1. Apply power to the calibration setup, either from the wall-wart power supply
   or the bench-top power supply.
   - **NOTE:** The EZHR17EN motor driver should be powered with between 12 V and
     40 V! Ensure the power supply can provide at least 1 A of power, the motor
     alone needs about 600 mA!
2. Start the `CalibBeamCtrl` program, e.g., using the Desktop shortcut.
3. Click the **COM Port** drop-down, select the port of the USB to Serial converter
   attached to the EZStepper motor driver and click the **Open** button.

   <img src="images/CalibBeamCtrl-OpenPort.PNG">
       
   - **NOTE:** If there are multiple COM ports and you do not know which port is
   connected to the EZStepper, do the following:
     - Click the drop-down;
     - Grab a glance of which ports appear in the list of COM ports;
     - Disconnect the USB to Serial converter of the EZStepper motor driver;
     - Click the drop-down again;
     - A COM port should have dissapeared;
     - Re-connect the USB to Serial converter;
     - Click the drop-down again;
     - A new COM port should have appeared. This is the COM port of the EZStepper.

4. Confirm that the connection status lights green:

   <img src="images/CalibBeamCtrl-ConnOpen.PNG">

5. If you wish to have a log of the steps performed by the program, use the
   check-box under the **Log File** group and the **New...** button to create a new
   log file, or the **Open...** button to open an existing file. In both cases,
   a window opens to select the file to be written to. The file selected is open in
   _append_ mode, i.e., contents will be added to the end of the file.
   
   <img src="images/CalibBeamCtrl-Logfile.PNG">
   
6. Looking _into_ the shutter, calculate the approximate number of degrees it needs
   to rotate clockwise (right) so that it covers the radioactive source:
   
   <img src="images/CalibSetupStartup.jpg" width="60%">
   
7. Type in the angle in degrees in the rotation angle control and click the
   **Rotate >>** button:
   
   <img src="images/CalibBeamCtrl-RotationControls.PNG">
   
8. Tweak the position using the rotation controls until a vertical position
   for the shutter has been found, where it covers the radioactive source:
   
   <img src="images/CalibSetupVertical.jpg" width="60%">
   
   - Notes:
     - The **Rotate <<** button is enabled and can be used after the
       motor has been rotated clockwise at least once. Should the rotation
       previously configure go beyound the vertical position, you can rotate
       the shutter counter-clockwise too.
     - The **Stop** button under **Configure Motor Positions** can also be used
       to stop the motor mid-motion.

9. Once the vertical position of the shutter has been found, click the
   **Set zero position (vertical)** button:
   
   <img src="images/CalibBeamCtrl-SetZeroPos.PNG">

10. Use the controls under the **Calibration Beam** group to select shutter _on_
    and _off_ times. You can configure number of minutes and seconds as desired:
   
    <img src="images/CalibBeamCtrl-BeamCtrl.PNG">
   
    - Notes:
      - The TAB key on the keyboard can be used to quickly switch between
        controls;
      - The minimum time that the shutter can be both _on_ or _off_ is 10
        seconds; 

11. Click the **Start** button to start the motor control. The **Start** button
    changes into the **Stop** button and the program starts counting the
    selected _off_ time. The progress bar will show the percentage of time
    elapsed:
    
    <img src="images/CalibBeamCtrl-RunningBeamOff.PNG">

12. After the _off_ time you selected elapses, the shutter moves 90 degrees
    clockwise to expose the radioactive source. The beam status label also
    colors green to indicate the beam is _on_ (shutter is _off_). The program
    will count the _on_ time before moving the shutter to the _off_ (beam
    _on_) position. The progress bar will again show the percentage of time
    elapsed in the progress bar:
    
    <img src="images/CalibBeamCtrl-RunningBeamOn.PNG">
    
13. After you are done with the calibration, hit the **Stop** button under
    **Calibration Beam** to stop the motor control.
    
**NOTE:** If you intend to run the motor control again, make sure the shutter is
vertical (covering the radioactive source) and click
**Set zero position (vertical)** before re-starting the motor control.

## Troubleshooting

### Motor "dropping"

Cases have been observed of the motor controller losing control of the motor's
position ("dropping" the motor). This is understood to be due to the motor
control velocity being too high, but it can also be that the weight
distribution is not tolerable by the motor controller.

The steps to perform in case this problem appears are:

1. After the shutter has finished spinning, set the zero position using
   the button under **Configure Motor Positions**.
2. Rotate it again to the vertical (zero position) using the rotate
   clockwise and counter-clockwise buttons, as applicable.
3. Set the motor's zero position again using the button.
4. If the motor "drops" again, decrease the velocity via the control
   under **Configure Motor Positions**.
   
   <img src="images/CalibBeamCtrl-Velocity.PNG">
   
   - Notes:
     - Too low velocity values will result in the motor controller not
       being able to move the shutter at all
     - A good value to try first is **4000**. After this, you can try
       increasing if you like, but there is no great difference between
       hundreds of velocity units.
     - The unit for velocity is motor microsteps per second -- very
       abstract.

### Sending commands via serial port software

If worse comes to worst, you can always try to manually control the
motor controller. The `CalibBeamCtrl` program essentially sends the
commands one can send via serial port software to achieve the motor
control.

The command set for the EZStepper motor driver can be found
at this link:
- http://www.allmotion.com/PDF_Datasheets/Command_Set_EZHR17EN.pdf

Notes:
- Ensure you enable character echoing on the serial port software,
  so you get feedback of the characters sent to the EZStepper. The
  EZStepper itself does no echoing of characters it receives.
- The baud rate for communication is **9600 baud**.
- The EZHR17EN is a bit weird in its behaviour: Although the
  firmware version is listed to be 3.75 (**_CONFIRM!!_**), it seems
  to accept some commands that are only available in later versions,
  according to the command set linked above, but some of the
  commands of later versions are not available on the EZStepper.

TODO:
- how-to on using TeraTerm for sending commands
- commands to achieve the troubleshooting above
- include the encoder setup commands!
- example of `\1n8R` command not working...
- get firmware version example

# Developer Guide

## Main Project

- Developed under VS 2019 _and_ 2017 -- any works, including probably
  2022 & later!
- code organization: Methods ordered according to UI elements, for
  readability
- Navigate to functions using drop-down in VS
- Anything else mentioned in CitirocUI Developer Guide?

## Setup Project

- How created?
- Steps to releasing a new version
