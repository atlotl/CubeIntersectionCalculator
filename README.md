# Cube Intersection Calculator

## Overview

The Cube Intersection Calculator is a console-based application designed to handle the geometric calculation of cube intersections in a 3D space. This application allows users to input the dimensions and positions of two cubes and determines if they intersect, as well as calculates the volume of their intersected region.

### Author

This project was developed by Aitor Lopera Toledo.

### Key Features

- **Intersection Detection:** Determines whether two cubes intersect based on their center coordinates and side lengths.
- **Intersection Volume Calculation:** Computes the volume of the overlapping region between the two cubes, if they intersect.

### How It Works

1. **User Input:**
   - The application prompts the user to provide:
     - The side length and center coordinates (X, Y, Z) of the first cube.
     - The side length and center coordinates (X, Y, Z) of the second cube.

2. **Intersection Check:**
   - The application checks if the cubes are intersecting. Cubes are considered intersecting if their projections overlap along all three coordinate axes (X, Y, and Z).

3. **Volume Calculation:**
   - If the cubes intersect, the application calculates the volume of the intersected region using the overlap dimensions along each axis.

### Example Usage

Here’s how a typical interaction with the application might look:

**Sample Input:**
- **Cube 1:**
  - Side Length: `4`
  - Center X: `0`
  - Center Y: `0`
  - Center Z: `0`

- **Cube 2:**
  - Side Length: `4`
  - Center X: `2`
  - Center Y: `2`
  - Center Z: `2`

**Sample Output:**
- `Cubes intersecting: True`
- `Intersection volume: 8.0`

In this example, the application determines that the cubes intersect and calculates that the volume of their intersection is 8.0 cubic units.

## Application Files

This repository contains a `.rar` archive file (`app.rar`) located in the root directory. This archive includes:

- **Executable (`Presentation.exe`):** The compiled console application.
- **DLL Files:** Necessary dynamic link libraries for running the application.

## Instructions for Running the Application

### Extract the Files

1. **Download** the `app.rar` file from the root directory of this repository.
2. **Extract** the contents of `app.rar` to a folder on your computer.

### Running the Application

1. **Open Command Prompt** (Windows) or **Terminal** (macOS/Linux).
2. **Navigate** to the folder where you extracted the files.
3. **Execute** the `Presentation.exe` executable file.
4. **Follow** the prompts displayed by the application.

### Notes

- Ensure you have the .NET runtime installed to run the executable.
- If you encounter any issues, make sure all the DLL files are present in the same directory as the executable.

## License

This project is a technical exercise and does not include a specific license.
