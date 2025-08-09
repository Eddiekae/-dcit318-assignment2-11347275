# DCIT318 Assignment 2 - Object-Oriented Programming Tasks

This repository contains three C# console applications demonstrating key Object-Oriented Programming concepts.

## Project Structure

```
dcit318-assignment2-11347275/
├── Task1_Inheritance_Project/
│   └── Program.cs          # Inheritance & Method Overriding
├── Task2_AbstractClasses_Project/
│   └── Program.cs          # Abstract Classes & Methods
├── Task3_Interfaces_Project/
│   └── Program.cs          # Interfaces
├── Task1_Inheritance.cs    # Standalone file
├── Task2_AbstractClasses.cs # Standalone file
├── Task3_Interfaces.cs     # Standalone file
└── README.md              # This file
```

## Task 1 - Inheritance & Method Overriding

**Location**: `Task1_Inheritance_Project/`

**Concepts Demonstrated**:
- Base class inheritance
- Virtual methods
- Method overriding
- Polymorphism

**Classes**:
- `Animal`: Base class with virtual `MakeSound()` method
- `Dog`: Derived class overriding `MakeSound()` to print "Bark"
- `Cat`: Derived class overriding `MakeSound()` to print "Meow"

**Run Command**:
```bash
dotnet run --project Task1_Inheritance_Project
```

**Expected Output**:
```
Some generic sound
Bark
Meow
```

## Task 2 - Abstract Classes & Methods

**Location**: `Task2_AbstractClasses_Project/`

**Concepts Demonstrated**:
- Abstract classes
- Abstract methods
- Concrete implementations
- Polymorphism with abstract types

**Classes**:
- `Shape`: Abstract base class with abstract `GetArea()` method
- `Circle`: Concrete class implementing `GetArea()` for circles
- `Rectangle`: Concrete class implementing `GetArea()` for rectangles

**Run Command**:
```bash
dotnet run --project Task2_AbstractClasses_Project
```

**Expected Output**:
```
Circle Area: 78.53981633974483
Rectangle Area: 24
```

## Task 3 - Interfaces

**Location**: `Task3_Interfaces_Project/`

**Concepts Demonstrated**:
- Interface definition
- Interface implementation
- Polymorphism with interfaces

**Components**:
- `IMovable`: Interface with `Move()` method
- `Car`: Class implementing `IMovable` interface
- `Bicycle`: Class implementing `IMovable` interface

**Run Command**:
```bash
dotnet run --project Task3_Interfaces_Project
```

**Expected Output**:
```
Car is moving
Bicycle is moving
```

## Requirements

- .NET 7.0 or later
- Visual Studio Code or any C# IDE

## How to Run

1. Clone or download the repository
2. Navigate to the project directory
3. Run any of the commands listed above for each task

## Testing

All projects have been tested in both Debug and Release configurations to ensure proper functionality.

## Author

Student ID: 11347275
Course: DCIT318 - Object-Oriented Programming
