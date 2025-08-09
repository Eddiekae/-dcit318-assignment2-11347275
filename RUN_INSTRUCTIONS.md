# DCIT318 Assignment 2 - 11347275 C# OOP Implementation

## Overview
This program demonstrates three key Object-Oriented Programming concepts:
1. **Inheritance & Method Overriding** - Animal hierarchy with Dog and Cat classes
2. **Abstract Classes & Methods** - Shape hierarchy with Circle and Rectangle classes
3. **Interfaces** - IMovable interface with Car and Bicycle implementations

## How to Run

### Option 1: Using .NET CLI (Recommended)
1. Ensure you have .NET 6.0 or later installed
2. Open terminal/command prompt in the project directory
3. Run the following commands:
   ```
   dotnet restore
   dotnet build
   dotnet run
   ```

### Option 2: Using Visual Studio
1. Open Visual Studio
2. Select "Open a project or solution"
3. Navigate to the project folder and select `DCIT318_Assignment2.csproj`
4. Press F5 or click "Start" to run the program

### Option 3: Using Visual Studio Code
1. Install the C# extension for VS Code
2. Open the project folder in VS Code
3. Press F5 or use the terminal to run `dotnet run`

## Expected Output
When you run the program, you should see output similar to:

```
=== TASK 1: Inheritance & Method Overriding ===
Some generic sound
Bark
Meow

=== TASK 2: Abstract Classes & Methods ===
Circle Area: 78.53981633974483
Rectangle Area: 24

=== TASK 3: Interfaces ===
Car is moving
Bicycle is moving

Press any key to exit...
```

## Project Structure
- `Program.cs` - Main program file containing all classes and implementation
- `DCIT318_Assignment2.csproj` - Project configuration file
- `README.md` - Original assignment instructions
