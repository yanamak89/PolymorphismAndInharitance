# Inheritance and Polymorphism Tasks

## Description

This repository contains solutions for tasks focused on inheritance and polymorphism in object-oriented programming.

## Tasks

### 1. Basic Concepts Exploration

Understanding the fundamental concepts and constructs discussed in the lesson.

### 2. ClassRoom Management System

- Create a console application using Visual Studio.
- Define a `ClassRoom` class representing a classroom.
- Implement a `Pupil` class with methods `Study()`, `Read()`, `Write()`, and `Relax()`.
- Derive three subclasses `ExcellentPupil`, `GoodPupil`, and `BadPupil` from the `Pupil` class, each overriding methods based on the student's performance.
- The `ClassRoom` constructor takes arguments of type `Pupil`, with the class comprising four pupils. Allow the possibility for the user to pass 2 or 3 arguments.
- Display information about each pupil's abilities to study, read, write, and relax.

### 3. Vehicle Information System

- Create a console application using Visual Studio.
- Define a `Vehicle` class with fields for coordinates and vehicle parameters (price, speed, year of manufacture).
- Create three subclasses: `Plane`, `Car`, and `Ship`.
- For the `Plane` class, specify altitude and the number of passengers. For the `Ship` class, specify the number of passengers and the home port.
- Write a program to display information about each mode of transportation.

### 4. Document Management System

- Create a console application using Visual Studio.
- Define a `DocumentWorker` class with methods `OpenDocument()`, `EditDocument()`, and `SaveDocument()`.
- Implement a subclass `ProDocumentWorker` and override methods to display appropriate messages.
- Implement a subclass `ExpertDocumentWorker` inheriting from `ProDocumentWorker` and override methods accordingly.
- In the `Main()` method, allow user input for access keys `pro` and `exp` to instantiate corresponding versions of the `DocumentWorker` class.

### 5. Printer Class Implementation

- Create a console application using Visual Studio.
- Define a `Printer` class with a method `Print(string value)` to print the argument value to the screen.
- Implement the ability for subclasses to inherit from `Printer` and print strings in different colors when invoking the method on their instances.

## Instructions

Clone this repository to your local machine and explore each task in its corresponding directory.
