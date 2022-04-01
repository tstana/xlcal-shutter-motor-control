# Calibration Beam Control

The `Calib Beam Ctrl` program is a .NET application running under Windows
meant to send commands to a motor driver board that controls the periodic
rotation of a shutter covering a radioactive source. It was developed for
calibrating the [XL-Calibur instrument](https://sites.wustl.edu/xlcal/home/),
but the software used can be used as a reference to write software (or 
potentially even use as a driver) when calibrating other instruments.

See [System Requirements](#system-requirements) for more details on the setup
this application can work with.

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
- Power supply for the motor driver board, e.g., 24V wall-wart power supply
  or a configurable bench-top power supply.

# User Guide

## Installing CalibBeamCtrl

- Link to installer
- Local link to Setup Project sub-sec

## Preparing the setup

- Equipment needed (pics?)

## Running CalibBeamCtrl

- steps to run it

## Troubleshooting

- motor "dropping"
  - Might happen if velocity is too high
  - "Set Zero Pos" first
  - Rotate to new position
  - "Set Zero Pos" again
  - If drops again: Lower velocity (4000 a good value) and try again

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
