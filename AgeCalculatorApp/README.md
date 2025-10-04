# Age Calculator - C# Console App

## 📖 Description
This is a simple C# console application that:
- Asks the user for their age.
- Displays the year the user was born.
- Handles exceptions with **try/catch** blocks.
- Provides clear error messages for:
  - Zero or negative input.
  - Invalid (non-numeric) input.
  - Any other unexpected errors.
- Separates classes into **Program.cs** and **AgeCalculator.cs** for cleaner design.

---

## 📂 Project Structure
AgeCalculatorApp/
│
├── Program.cs # Handles user input, output, and exception handling
├── AgeCalculator.cs # Contains logic to calculate the birth year
└── README.md # Project documentation


---

## 🚀 How to Run
1. Clone or download this repository.  
2. Open the solution/project in **Visual Studio** or any C# IDE.  
3. Build and run the application.  

Example usage:
Welcome to the Age Calculator!
This program will calculate the year you were born based on your age.

Please enter your age: 25
You were born in the year 2000.


---

## 🧑‍💻 Key Concepts Demonstrated
- **Exception Handling (try/catch)**
  ```csharp
  try
  {
      int age = Convert.ToInt32(Console.ReadLine());
  }
  catch (FormatException)
  {
      Console.WriteLine("Error: Please enter a valid numeric value for age.");
  }
  catch (Exception ex)
  {
      Console.WriteLine($"An unexpected error occurred: {ex.Message}");
  }

Validation for Zero or Negative Numbers
if (age <= 0)
{
    Console.WriteLine("Error: Age must be a positive number greater than zero.");
}

Separate Class for Logic

int birthYear = AgeCalculator.CalculateBirthYear(age);
