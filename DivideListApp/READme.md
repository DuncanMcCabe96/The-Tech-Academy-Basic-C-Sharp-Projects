# Divide List Console App

## Overview
This C# console application demonstrates how to:
- Create a list of integers.
- Accept user input for a divisor.
- Divide each integer in the list by the user-provided value.
- Handle errors using **try/catch** blocks, including:
  - Invalid input (non-numeric values).
  - Division by zero.
  - Unexpected exceptions.

The program ensures that execution continues after errors by printing a message once it has exited the try/catch block.

---

## Features
- Uses a **list of integers** as input data.
- Prompts the user to enter a number.
- Loops through the list, dividing each number by the input.
- Displays the results on screen.
- Implements exception handling with descriptive error messages.
- Always confirms program continuation using a message after try/catch.

---

## Example Usage

### Case 1: Valid Input  
**Input:**  

5

**Output:**  

10 divided by 5 equals 2
20 divided by 5 equals 4
30 divided by 5 equals 6
40 divided by 5 equals 8
50 divided by 5 equals 10

The program has emerged from the try/catch block and continued execution.
