# DCIT318 Assignment 2 - Object-Oriented Programming Concepts

## Overview
This assignment demonstrates three fundamental Object-Oriented Programming (OOP) concepts in C#: inheritance with method overriding, abstract classes, and interfaces.

## Project Structure

### Task 1: Inheritance & Method Overriding
**File:** `Task1_Animal.cs`
- **Concept:** Demonstrates inheritance and polymorphism through method overriding
- **Classes:**
  - `Animal`: Base class with virtual `MakeSound()` method
  - `Dog`: Derived class that overrides `MakeSound()` to print "Bark"
  - `Cat`: Derived class that overrides `MakeSound()` to print "Meow"
- **Main() Section:** Creates instances of each class and demonstrates polymorphic behavior

### Task 2: Abstract Classes & Methods
**File:** `Task2_Shape.cs`
- **Concept:** Demonstrates abstract classes and abstract methods
- **Classes:**
  - `Shape`: Abstract base class with abstract `GetArea()` method
  - `Circle`: Concrete class implementing `GetArea()` for circles
  - `Rectangle`: Concrete class implementing `GetArea()` for rectangles
- **Main() Section:** Creates instances and calculates areas for different shapes

### Task 3: Interfaces
**File:** `Task3_IMovable.cs`
- **Concept:** Demonstrates interface implementation and polymorphism
- **Components:**
  - `IMovable`: Interface defining the `Move()` method
  - `Car`: Class implementing `IMovable` with car-specific movement
  - `Bicycle`: Class implementing `IMovable` with bicycle-specific movement
- **Main() Section:** Demonstrates polymorphic behavior through interface references

## Original Combined Version
**File:** `Program.cs`
- Contains all three tasks combined in a single file
- Demonstrates all OOP concepts in one comprehensive program

## How to Run

### Individual Tasks
Each task can be run independently by changing the startup object in the project settings:

1. **Task 1:** Set `ProgramTask1` as the startup object
2. **Task 2:** Set `ProgramTask2` as the startup object  
3. **Task 3:** Set `ProgramTask3` as the startup object

### Combined Version
Run the original `Program.cs` to see all tasks executed together:
```bash
dotnet run
```

## Learning Objectives
- Understand inheritance and method overriding in C#
- Learn how to use abstract classes and methods
- Master interface implementation and polymorphism
- Practice organizing code into separate files for better maintainability

## Key OOP Concepts Demonstrated
- **Inheritance:** Derived classes inherit from base classes
- **Polymorphism:** Same method behaves differently based on the object type
- **Abstraction:** Abstract classes provide blueprints for derived classes
- **Encapsulation:** Classes encapsulate data and behavior
- **Interface Implementation:** Multiple classes can implement the same interface differently
