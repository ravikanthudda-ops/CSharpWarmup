# CSharpWarmup

This README is scoped to the CSharpWarmup project only.

Common workspace rules are defined in [../README.md](../README.md).

## Scope

- Track A exercises and hands-on coding warmup.
- Daily tasks are tracked in this README.

## Goal

Rebuild C# fluency through small daily programs, then progress to modern features and interview-focused practice.

## Working Rule for This Folder

- Keep this folder focused on warmup practice only.
- Do not include TaskManager or DesignPattern task plans here.

## Daily Exercise Plan

### Week 1 - C# fundamentals (Days 1-10)

- [x] Day 01 - Hello World
- [x] Day 02 - Print Name and Age
- [x] Day 03 - Add Two Numbers
- [x] Day 04 - Check Even or Odd
- [x] Day 05 - Find Largest of Two Numbers
- [x] Day 06 - Simple Calculator (Add / Subtract / Multiply / Divide)
- [x] Day 07 - Check Leap Year
- [x] Day 08 - Reverse a String
- [x] Day 09 - Count Digits of a Number
- [x] Day 10 - Sum of First N Numbers

### Week 2 - Analytical brainstroming

- [x] Day 11 - Write a program that reads 5 numbers and prints their sum and average.
- [ ] Day 12 - Write a program that checks if a user-entered number is prime.
- [ ] Day 13 - Write a program that reads a string and counts vowels and consonants.
- [ ] Day 14 - Write a program to check whether a string reads the same forward and backward.
- [ ] Day 15 - Write a program that prints all even numbers up to N and print count of even numbers.
- [ ] Day 16 - Write a program that calculates the factorial using a loop.
- [ ] Day 17 - Read 3 numbers and print the smallest, largest, and middle value.
- [ ] Day 18 - Write a program that prints the multiplication table for a number from 1 to 10.
- [ ] Day 19 - Read a number and count how many times each digit appears and Print the digit that appears the most.
- [ ] Day 20 - Write a program to check a leap year.
- [ ] Day 21 - Read a sentence and count the number of words and spaces.
- [ ] Day 22 - Write a program that adds only odd numbers from 1 to N.

### Week 3 - Modern C# features (Days 23-32)

- [ ] Day 23 - record types + init-only properties
- [ ] Day 24 - Pattern matching (switch expressions, is, when)
- [ ] Day 25 - Nullable reference types (?, !, ??, ?. )
- [ ] Day 26 - LINQ deep dive (GroupBy, SelectMany, Aggregate)
- [ ] Day 27 - async/await and Task basics
- [ ] Day 28 - IDisposable, using, IAsyncDisposable
- [ ] Day 29 - Generics with constraints
- [ ] Day 30 - Tuples and deconstruction
- [ ] Day 31 - Extension methods
- [ ] Day 32 - Span<T> and Memory<T> basics

### Week 3 - Async and concurrency (Days 33-42)

- [ ] Day 33 - IMemoryCache basics
- [ ] Day 34 - CancellationToken
- [ ] Day 35 - Task.WhenAll / Task.WhenAny
- [ ] Day 36 - Channel<T> producer-consumer
- [ ] Day 37 - SemaphoreSlim throttling
- [ ] Day 38 - IHostedService
- [ ] Day 39 - Parallel.ForEachAsync
- [ ] Day 40 - Middleware pipeline demo
- [ ] Day 41 - HttpClientFactory + Polly
- [ ] Day 42 - JWT basics

### Week 4 - Architecture and design concepts (Days 43-52)

- [ ] Day 43 - Repository pattern
- [ ] Day 44 - Unit of Work pattern
- [ ] Day 45 - Factory pattern
- [ ] Day 46 - Strategy pattern
- [ ] Day 47 - Decorator pattern
- [ ] Day 48 - Observer pattern
- [ ] Day 49 - SOLID demonstrations
- [ ] Day 50 - CQRS basics
- [ ] Day 51 - Clean Architecture layering
- [ ] Day 52 - Dapper vs EF Core

### Week 5-6 - SQL and performance (Days 53-62)

- [ ] Day 53 - ROW_NUMBER, RANK, DENSE_RANK
- [ ] Day 54 - LEAD, LAG, running totals
- [ ] Day 55 - CTEs (including recursive)
- [ ] Day 56 - Indexes and covering indexes
- [ ] Day 57 - Execution plan reading
- [ ] Day 58 - EF Core N+1 and fixes
- [ ] Day 59 - Bulk operations comparison
- [ ] Day 60 - Transaction isolation levels
- [ ] Day 61 - Query optimization rewrite
- [ ] Day 62 - OFFSET/FETCH vs keyset pagination

### Week 6-7 - Testing (Days 63-67)

- [ ] Day 63 - xUnit basics
- [ ] Day 64 - Moq basics
- [ ] Day 65 - Testing async methods
- [ ] Day 66 - WebApplicationFactory integration test
- [ ] Day 67 - Coverage mindset scenarios

### Week 7-8 - DSA refresh (Days 68-82)

- [ ] Day 68 - Two Sum (HashMap)
- [ ] Day 69 - Sliding window max-sum subarray
- [ ] Day 70 - Palindrome with two pointers
- [ ] Day 71 - Reverse words in sentence
- [ ] Day 72 - Most common character
- [ ] Day 73 - Valid parentheses (Stack)
- [ ] Day 74 - Queue using two stacks
- [ ] Day 75 - Next greater element
- [ ] Day 76 - Binary search (iterative + recursive)
- [ ] Day 77 - Merge sort
- [ ] Day 78 - Factorial/Fibonacci recursion vs iteration
- [ ] Day 79 - Find duplicates and complexity comparison
- [ ] Day 80 - BST insert and search
- [ ] Day 81 - BFS level order
- [ ] Day 82 - DFS in-order and pre-order

## Progress Log

- System Reset Restarted (08/07/2026) - focus on system over goals
- Day 01: Print Hello, World! (08/07/2026) 🎯 
- Day 02: Print Name and Age! (08/07/2026) 🎯
- Day 03: Add two numbers! (08/07/2026) 🎯
- Day 04: Check Even or Odd (08/07/2026) 🎯
- Day 05: Find Largest of Two Numbers (08/07/2026) 🎯
- Day 06: Simple Calculator (08/08/2026) 🎯
- Day 07: Check Leap Year (08/09/2026) 🎯
- Day 08: Reverse a String (08/10/2026) 🎯
- Day 09: Count Digits of a Number (08/16/2026) 🎯
- Day 10: Sum of First N Numbers (09/01/2026) 🎯
- Day 11: Reads 5 numbers and prints their sum and average (09/02/2026) 🎯
## Quick Commands

```bash
# From Career/CSharpWarmup

# Build the solution
dotnet build CSharpWarmup.sln

# Run a specific day
dotnet run --project Day06

#add new class
 dotnet new class -n Day10

# Add Project reference to Test
dotnet add CSharpWarmup.Tests.csproj reference /r/Learning/Career/CSharpWarmup/Day07/Day07.csproj

# Run all tests
dotnet test CSharpWarmup.Tests

# List tests first (helps confirm exact filter names)
dotnet test CSharpWarmup.Tests --list-tests

# Run tests for one class (example: Day10)
dotnet test CSharpWarmup.Tests --filter "FullyQualifiedName~CSharpWarmup.Tests.Day10"

# Run a specific test method
dotnet test CSharpWarmup.Tests --filter "FullyQualifiedName~SumOfFirstXNumber_ShouldReturnSum"

# Run tests by day pattern (example: Day06)
dotnet test CSharpWarmup.Tests --filter "FullyQualifiedName~CSharpWarmup.Tests.Day06"

# Alternative: run tests from current folder
dotnet test --filter "FullyQualifiedName~CSharpWarmup.Tests.Day10"
