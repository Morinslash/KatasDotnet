# Leap Year Kata

Description

The Leap Year kata verifies whether a given year is a leap year using the Gregorian rules:

- Years divisible by 4 are leap years.
- Years divisible by 100 are NOT leap years, unless they are also divisible by 400.

Examples:

- 1996 -> leap (true)
- 1997 -> not leap (false)
- 1900 -> not leap (false)
- 2000 -> leap (true)

Acceptance criteria

- A method that, given an integer year, returns a boolean indicating whether the year is a leap year according to the rules above.
- Unit tests that validate the behavior for a range of cases (divisible by 4, not divisible by 4, divisible by 100 but not 400, divisible by 400).

Running tests

From the repository root you can run the tests with dotnet (requires the .NET SDK):

```powershell
cd LeapYear
dotnet test
```

Implementation notes

- Implement the solution in `LeapYear/LeapYearSrc` (for example `LeapYear.cs`) and add tests to `LeapYear/LeapYearTests` using the same test framework used in the repo.
- Follow strict TDD: write one failing test, implement the minimal code to pass it, then refactor. Add tests and commits for each step.

Suggested file layout

- LeapYear/
  - LeapYearSrc/
    - LeapYear.cs
    - LeapYearSrc.csproj
  - LeapYearTests/
    - LeapYearTests.cs
    - LeapYearTests.csproj

Notes

Keep implementations minimal and well-documented. Prefer clear names and small methods; add tests for each rule and a handful of edge cases.
