# 📦 Package Express Shipping Quote Calculator

This is a simple C# console application that calculates a shipping quote for a package based on its **weight and dimensions**.  
It follows the rules provided by *Package Express* and either provides an estimated shipping cost or rejects the package if it’s too heavy or too large.  

---

## 🚀 Features

- Greets the user with a welcome message.  
- Prompts the user for:
  - Package **weight**  
  - Package **width**  
  - Package **height**  
  - Package **length**  
- Checks if:
  - **Weight > 50** → package is too heavy (program ends).  
  - **Width + Height + Length > 50** → package is too big (program ends).  
- Calculates the shipping quote using the formula:  

quote = (width * height * length * weight) / 100

