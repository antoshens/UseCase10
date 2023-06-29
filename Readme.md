## Application description

This application had been written in C# 10 language and based pn a .NET 6 version of framework.
The solution is just a simple console application.
The Program.cs file was designed without the usage of boilerplate code, which is possible in the .NET 6.

## Regex implementation description

The regex contains of 4 main sections (groups).
Each of them represents a standalone acceptance criteria, such as Uppercase, lowercase, etc.
Below is the example of the regular expression with some comments:

* ^ - beggining of the string
* (?=.*[A-Z]) - At least 1 uppercase letter
* (?=.*[a-z]) - At least 1 lowercase letter
* (?=.*\d{1}) - At least 1 digit character
* (?=.*[!""#$%&'()*+,\-./:;<=>?@\[\]^_`{|}~]) - at least 1 special character
* [A-Za-z\d!""#$%&'()*+,\-./:;<=>?@\[\]^_`{|}~] - format of the string
* {1, <max_num_of_chars>} - max amount of characters
* $ - end of the string.

## How to run locally
* Clone the repo;
* Open the solution via VisualStudio or VS Code;
* Run in Debug mode (or without debugger, it's not necessary);
* You'll get the result of predefined string matching test cases.
