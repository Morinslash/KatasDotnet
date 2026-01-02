# FizzBuzz Kata

Description

The FizzBuzz kata is a classic beginner exercise:

- Print the numbers from 1 to 100 (inclusive).
- For multiples of 3, print "Fizz" instead of the number.
- For multiples of 5, print "Buzz" instead of the number.
- For numbers which are multiples of both 3 and 5, print "FizzBuzz".

Example output (first 15 values):

1
2
Fizz
4
Buzz
Fizz
7
8
Fizz
Buzz
11
Fizz
13
14
FizzBuzz

Acceptance criteria

- A method that returns the expected sequence (or prints it) for numbers 1..100.
- Unit tests that validate the behavior for a number of cases (e.g. 3, 5, 15, and a regular number).

Running tests

From the repository root you can run all tests with dotnet (requires the .NET SDK):

```powershell
cd FizzBuzz
dotnet test
```

Implementation notes

- You can implement this in the `FizzBuzzSrc` project and verify behavior with `FizzBuzzTests`.
- Try implementing the solution TDD-style: write tests first, then implement minimal code to pass them, then refactor.


