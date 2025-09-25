# Employee Console App

This is a simple C# console application that demonstrates:

- Creating a class (`Employee`) with properties
- Working with lists of objects
- Filtering data using **foreach loops** and **lambda expressions**

---

## Features

1. **Employee Class**
   - `Id` (int)
   - `FirstName` (string)
   - `LastName` (string)

2. **Main Functionality**
   - Creates a list of 10 employees (including at least 2 named "Joe")
   - Filters employees named "Joe" using:
     - `foreach` loop
     - Lambda expression (`Where`)
   - Filters employees with `Id > 5` using a lambda expression

---

## How to Run

1. Open the project in Visual Studio (or your preferred C# IDE).
2. Ensure the project references `System.Linq` for lambda expressions.
3. Build and run the project.
4. The console will display:
   - Employees named "Joe" (via foreach loop)
   - Employees named "Joe" (via lambda)
   - Employees with `Id > 5`

---

## Project Structure

YourProject/
│
├── Employee.cs // Employee class definition
└── Program.cs // Main program with list creation and filtering


---

## Example Output

Employees named Joe (foreach loop):
Id: 1, Name: Joe Smith
Id: 4, Name: Joe Davis

Employees named Joe (lambda expression):
Id: 1, Name: Joe Smith
Id: 4, Name: Joe Davis

Employees with Id > 5:
Id: 6, Name: Mike Wilson
Id: 7, Name: Anna Taylor
Id: 8, Name: Chris Brown
Id: 9, Name: Laura White
Id: 10, Name: Tom Clark


---

## Notes

- This project is a great starting point to practice filtering and working with lists of objects in C#.
- Both **foreach loops** and **lambda expressions** are demonstrated for flexibility and learning purposes.
