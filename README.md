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

1. Download the [installer file](https://www.dropbox.com/s/qovgwud9kwxqwqf/CalibBeamCtrl.msi?dl=0)
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
   **NOTE:** If there are multiple COM ports and you do not know which port is
   connected to the EZStepper, do the following:
   - Click the drop-down;
   - Grab a glance of which ports appear in the list of COM ports;
   - Disconnect the USB to Serial converter of the EZStepper motor driver;
   - Click the drop-down again;
   - A COM port should have dissapeared;
   - Re-connect the USB to Serial converter;
   - Click the drop-down again;
   - A new COM port should have appeared. This is the COM port of the EZStepper.

     <img src="images/CalibBeamCtrl-OpenPort.PNG">

## Troubleshooting

- motor "dropping"
  - Might happen if velocity is too high
  - "Set Zero Pos" first
  - Rotate to new position
  - "Set Zero Pos" again
  - If drops again: Lower velocity (4000 a good value) and try again

- recreate steps above using TeraTerm...

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
