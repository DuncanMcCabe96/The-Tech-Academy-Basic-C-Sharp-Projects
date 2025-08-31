# Car Insurance Approval Program

This is a basic C# console application that determines whether an applicant qualifies for car insurance based on a few simple rules.  

The program asks the user three questions:
1. What is your age?  
2. Have you ever had a DUI?  
3. How many speeding tickets do you have?  

It then evaluates the answers against the following qualification rules:

- Applicants must be **over 15 years old**.  
- Applicants must **not have any DUIs**.  
- Applicants must have **3 or fewer speeding tickets**.  

Finally, it prints whether the applicant is qualified (`true` or `false`).  

---

## Example Run

What is your age?
32
Have you ever had a DUI? (true/false)
false
How many speeding tickets do you have?
1
Qualified?
true


---

## How to Run

### Using Visual Studio
1. Open the solution in Visual Studio.  
2. Press **Run** (▶️).  
3. Enter the values when prompted in the console.  

### Using .NET CLI
1. Open a terminal/command prompt.  
2. Navigate to the project folder.  
3. Run:
   ```bash
   dotnet run
