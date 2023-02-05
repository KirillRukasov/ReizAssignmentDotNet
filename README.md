# Clock Angle Calculator
This is a .NET console application that calculates the lesser angle in degrees between the hour and minute hands on an analogue clock. The user inputs the time in the format 'HH:MM'.

## Problem Statement
Write a console application that calculates the lesser angle between the hour and minute hands of an analogue clock. The user should be able to input the hours and minutes of the time and the program must provide the output in the console window.

##Solution Overview

The application uses three classes:

* **AnalogueClockAngleCalc**: The main class that contains the logic for the user interface.
* **CheckerTime**: A class that validates the input and checks if the input time is valid.
* **CalculateAngle**: A class that calculates the angle between the hour and minute hands.

## Running the Solution
The solution can be run using an IDE such as Visual Studio or by compiling and running the program from the command line. 
Then you must enter the time in the format 'HH:MM'. The angle between the hour and minute hands will be displayed in the console window.

## Testing
The solution includes unit tests for the 'CalculateAngle' and 'CheckerTime' classes. The tests can be run using the built-in testing tools in Visual Studio or by using the [dotnet test](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-test) command in the terminal.

## Conclusion
This application is a simple solution to a classic problem. It provides an accurate calculation of the angle between the hour and minute hands on an analogue clock. The application has been tested using unit tests to ensure its accuracy and reliability.

# Calculate Branch Depth
This project is an implementation of a method to calculate the depth of a tree structure, represented by a 'Branch' class.

## Problem Statement
Given a 'Branch' object, the task is to calculate the maximum depth of the tree structure. Each 'Branch' can have multiple 'Branches', and the depth of the tree is defined as the number of edges from the root 'Branch' to the farthest leaf 'Branch'.

## Technical Details
The solution is implemented in C# and uses recursion to traverse the tree structure. The 'CalculateDepth' class contains a single method, 'GetDepth', which takes a 'Branch' object as an input and returns the calculated depth.

## Running the Solution
The solution can be run using an IDE such as Visual Studio or by compiling and running the program from the command line.

## Testing
Unit tests have been created using xUnit to validate the implementation of the 'GetDepth' method. To run the tests, you can use the built-in testing framework in Visual Studio or by using the 'dotnet test' command in the terminal.

## Conclusion
The 'CalculateDepth' class provides a solution to the problem of calculating the depth of a tree structure represented by a 'Branch' object. The implementation uses recursion to traverse the tree and returns the calculated depth. The unit tests provide a way to validate the solution and ensure its correctness.

## References
[C# Programming Guide](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/)
[xUnit Testing Framework](https://xunit.net/)