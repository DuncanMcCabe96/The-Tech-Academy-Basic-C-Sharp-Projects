# Number Logger App

This is a simple C# console application that:

1. Asks the user to enter a number.  
2. Logs that number to a text file (`numberLog.txt`).  
3. Reads the text file and prints its contents back to the user.  

---

## How It Works
- When you run the program, you’ll be prompted to enter a number.  
- The number is saved into `numberLog.txt` in the same directory as the executable.  
- The program then reads the file and displays the contents on the console.  

---

## Example Run
Please enter a number:
42

The file contains:
42

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
