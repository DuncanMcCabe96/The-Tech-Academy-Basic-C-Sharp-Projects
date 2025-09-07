# C# Console App: Array and List Manipulation

## Overview
This C# console application demonstrates various fundamental programming concepts, including:

- Arrays and lists
- Loops (`for`, `foreach`, `<`, `<=`)
- Searching for unique and duplicate items
- Detecting duplicates in a list
- Safe infinite loop handling with user exit

The program interacts with the user to modify arrays, search lists, and display results in a clear, step-by-step manner.

---

## Features

1. **Array of Strings**
   - Prompts the user to enter text.
   - Appends the user input to each element in the array.
   - Displays the updated array using two types of loops:
     - `for` loop with `<` operator
     - `for` loop with `<=` operator

2. **Unique List Search**
   - Contains a list of unique strings.
   - Prompts the user to search for a string.
   - Displays the index of the first matching item.
   - Informs the user if the string is not in the list.

3. **Duplicate List Search**
   - Contains a list with duplicate strings.
   - Prompts the user to search for a string.
   - Displays all indices of matching items.
   - Informs the user if the string is not in the list.

4. **Detecting Duplicates Using `foreach`**
   - Evaluates each item in a list with duplicates.
   - Displays whether each item is unique or a duplicate.
   - Uses a `HashSet` to track already-seen items.

5. **Infinite Loop with Exit**
   - Allows the user to repeatedly display updated array phrases.
   - User can safely exit the loop by typing `exit`.

---

## How to Use

1. **Clone or download the repository** to your local machine.
2. **Open the project** in Visual Studio or any C# IDE.
3. **Build and run** the application.
4. Follow on-screen prompts:
   - Enter text to append to array phrases.
   - Search unique and duplicate lists.
   - Observe duplicate detection in a sample list.
   - Optionally, explore the infinite loop feature and type `exit` to finish.

---

## Example Run

Enter some text to append to each phrase:
Duncan

Loop with '<' operator:
Index 0: Hello Duncan
Index 1: Welcome Duncan
Index 2: Goodbye Duncan
Index 3: See you Duncan
Index 4: Take care Duncan

Loop with '<=' operator:
Index 0: Hello Duncan
Index 1: Welcome Duncan
Index 2: Goodbye Duncan
Index 3: See you Duncan
Index 4: Take care Duncan

Enter a fruit to search in the unique list:
Banana
Match found at index 1 in unique list!

Enter a color to search in the duplicate list:
Blue
Match found at index 1 in duplicate list!
Match found at index 3 in duplicate list!

Checking list items for duplicates:
A - this item is unique
B - this item is unique
C - this item is unique
D - this item is unique
C - this item is a duplicate
A - this item is a duplicate

Type 'exit' to stop the loop or press Enter to see the updated phrases again:
(exit to end)
