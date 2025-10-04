# Constructor Chaining Example - C# Console App

## 📖 Description
This is a simple C# console application that demonstrates:
- Creating a **const** variable.
- Creating a variable using the **`var`** keyword (type inference).
- **Constructor chaining** between two constructors.
- Separating classes into their own files.
- Adding detailed **comments** so the code is beginner-friendly and easy to follow.

---

## 📂 Project Structure
ConstructorChainingExample/
│
├── Program.cs # Main entry point of the console app
├── Person.cs # Class demonstrating constructor chaining
└── README.md # Project documentation


---

## 🚀 How to Run
1. Clone or download this repository.  
2. Open the solution/project in **Visual Studio** or any C# IDE.  
3. Build and run the application.  

You should see output similar to:

Welcome to the Constructor Chaining Example!
The value of 'var' variable is: 42
Name: Alice, Age: 0


---

## 🧑‍💻 Key Concepts Demonstrated
- **Const Variable**
  ```csharp
  const string greetingMessage = "Welcome to the Constructor Chaining Example!";
Var Variable (Type Inference)

var number = 42; // Compiler infers this as int

Constructor Chaining
public Person(string name) : this()
{
    Name = name;
}
