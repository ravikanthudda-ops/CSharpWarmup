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
- [ ] Day 05 - Find Largest of Two Numbers
- [ ] Day 06 - Simple Calculator (Add / Subtract / Multiply / Divide)
- [ ] Day 07 - Check Leap Year
- [ ] Day 08 - Reverse a String
- [ ] Day 09 - Count Digits of a Number
- [ ] Day 10 - Sum of First N Numbers

### Week 2 - Modern C# features (Days 11-20)

- [ ] Day 11 - record types + init-only properties
- [ ] Day 12 - Pattern matching (switch expressions, is, when)
- [ ] Day 13 - Nullable reference types (?, !, ??, ?.)
- [ ] Day 14 - LINQ deep dive (GroupBy, SelectMany, Aggregate)
- [ ] Day 15 - async/await and Task basics
- [ ] Day 16 - IDisposable, using, IAsyncDisposable
- [ ] Day 17 - Generics with constraints
- [ ] Day 18 - Tuples and deconstruction
- [ ] Day 19 - Extension methods
- [ ] Day 20 - Span<T> and Memory<T> basics

### Week 3 - Async and concurrency (Days 21-30)

- [ ] Day 21 - IMemoryCache basics
- [ ] Day 22 - CancellationToken
- [ ] Day 23 - Task.WhenAll / Task.WhenAny
- [ ] Day 24 - Channel<T> producer-consumer
- [ ] Day 25 - SemaphoreSlim throttling
- [ ] Day 26 - IHostedService
- [ ] Day 27 - Parallel.ForEachAsync
- [ ] Day 28 - Middleware pipeline demo
- [ ] Day 29 - HttpClientFactory + Polly
- [ ] Day 30 - JWT basics

### Week 4 - Architecture and design concepts (Days 31-40)

- [ ] Day 31 - Repository pattern
- [ ] Day 32 - Unit of Work pattern
- [ ] Day 33 - Factory pattern
- [ ] Day 34 - Strategy pattern
- [ ] Day 35 - Decorator pattern
- [ ] Day 36 - Observer pattern
- [ ] Day 37 - SOLID demonstrations
- [ ] Day 38 - CQRS basics
- [ ] Day 39 - Clean Architecture layering
- [ ] Day 40 - Dapper vs EF Core

### Week 5-6 - SQL and performance (Days 41-50)

- [ ] Day 41 - ROW_NUMBER, RANK, DENSE_RANK
- [ ] Day 42 - LEAD, LAG, running totals
- [ ] Day 43 - CTEs (including recursive)
- [ ] Day 44 - Indexes and covering indexes
- [ ] Day 45 - Execution plan reading
- [ ] Day 46 - EF Core N+1 and fixes
- [ ] Day 47 - Bulk operations comparison
- [ ] Day 48 - Transaction isolation levels
- [ ] Day 49 - Query optimization rewrite
- [ ] Day 50 - OFFSET/FETCH vs keyset pagination

### Week 6-7 - Testing (Days 51-55)

- [ ] Day 51 - xUnit basics
- [ ] Day 52 - Moq basics
- [ ] Day 53 - Testing async methods
- [ ] Day 54 - WebApplicationFactory integration test
- [ ] Day 55 - Coverage mindset scenarios

### Week 7-8 - DSA refresh (Days 56-70)

- [ ] Day 56 - Two Sum (HashMap)
- [ ] Day 57 - Sliding window max-sum subarray
- [ ] Day 58 - Palindrome with two pointers
- [ ] Day 59 - Reverse words in sentence
- [ ] Day 60 - Most common character
- [ ] Day 61 - Valid parentheses (Stack)
- [ ] Day 62 - Queue using two stacks
- [ ] Day 63 - Next greater element
- [ ] Day 64 - Binary search (iterative + recursive)
- [ ] Day 65 - Merge sort
- [ ] Day 66 - Factorial/Fibonacci recursion vs iteration
- [ ] Day 67 - Find duplicates and complexity comparison
- [ ] Day 68 - BST insert and search
- [ ] Day 69 - BFS level order
- [ ] Day 70 - DFS in-order and pre-order

## Progress Log

- System Reset Restarted (08/07/2026) - focus on system over goals
- Day 01: Print Hello, World! (08/07/2026)
- Day 02: Print Name and Age! (08/07/2026)
- Day 03: Add two numbers! (08/07/2026)
- Day 04: Check Even or Odd (08/07/2026)

## Quick Commands

```bash
# From Career/CSharpWarmup
dotnet build Practice/Practice.slnx

# Create a new day project
dotnet new console -n DayXX
dotnet sln add Practice/DayXX/DayXX.csproj

# Run a day project
dotnet run --project Practice/DayXX
```
