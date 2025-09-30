# Time Calculator App

This is a simple C# console application that:

1. Prints the current date and time to the console.  
2. Asks the user to enter a number of hours.  
3. Prints the exact date and time it will be after adding that many hours.  

---

## How It Works
- When you run the program, it first shows the current system time.  
- You will be prompted to enter a number (representing hours).  
- The program adds that number of hours to the current time and displays the result.  
- If the input is not a valid number, it displays an error message.  

---

## Example Run

The current date and time is: 9/29/2025 7:15:42 PM

Please enter a number of hours to add:
5

In 5 hours, the date and time will be: 9/30/2025 12:15:42 AM

Press Enter to exit...


---

## Requirements
- .NET SDK (6.0 or later recommended)  
- A text editor or IDE such as Visual Studio or Visual Studio Code  

---

## How to Run
1. Clone or download this repository.  
2. Open a terminal in the project directory.  
3. Run the following commands:  

```bash

dotnet build
dotnet run
TimeCalculatorApp/
├── Program.cs      # Main application code
├── TimeCalculatorApp.csproj
└── README.md       # Project documentation
Notes

Input must be a valid whole number (positive or negative).

You can enter negative numbers to subtract hours.

