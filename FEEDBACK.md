# Code Review Feedback Log

> Tracks all mistakes, patterns, and observations from daily code reviews.
> Use this to spot what you keep getting wrong — those are your real blind spots.

---

## How to Read This File

- **Recurring** — means this has appeared more than once across different days
- **Fixed** — you corrected it after the hint
- **Conceptual** — not just a syntax mistake, but a gap in understanding

---

## Mistake Categories

### 1. Naming Conventions

| Day | Mistake | Status | Pattern Note |
|-----|---------|--------|--------------|
| Day 02 | Local variables `Name` and `Age` used PascalCase instead of camelCase | Fixed | C# rule: local variables and method parameters are always camelCase. PascalCase is for classes, methods, and properties only. |
| Day 07 | Class name `Leapyear` used inconsistent word casing; preferred `LeapYear` | Fixed | Class/type names use PascalCase per word for readability, especially for compound words. |

**Rule to remember:** If it lives inside a method, it's camelCase. If it's a member of a class or a type name, it's PascalCase.

---

### 2. Redundant / Inconsistent Code

| Day | Mistake | Status | Pattern Note |
|-----|---------|--------|--------------|
| Day 04 | Explicit `using System;` added when implicit usings were already configured in the project | Fixed | .NET 6+ projects enable implicit global usings by default. You never need to write `using System;` manually unless you are targeting an older project style. |

**Rule to remember:** Check the `.csproj` file — if `ImplicitUsings` is enabled, the most common namespaces are already available everywhere in the project.

---

### 3. Input Handling and Defensive Programming

| Day | Mistake | Status | Pattern Note |
|-----|---------|--------|--------------|
| Day 02–05 | All programs used `Convert.ToInt32(Console.ReadLine())` — crashes on non-numeric input | Understood | `Convert.ToInt32` throws `FormatException` on bad input. `int.TryParse` returns false instead of crashing. |
| Day 05 (attempt) | Tried to assign the return value of `int.TryParse` to an `int` variable | Fixed | `TryParse` returns `bool`, not the parsed value. The parsed value comes back via the `out` parameter. |
| Day 05 (attempt) | Passed a regular variable to `TryParse` instead of an `out` variable | Fixed | The second argument must use the `out` keyword so the method can write the result back to the caller. |
| Day 06 | Missing `else` on the inner `int.TryParse` for menu option — silent failure when non-integer entered | Fixed | Every `TryParse` branch that affects user flow should have an `else` with a meaningful message. Silent failures are hard to debug. |

**Rule to remember:** For any input you do not control — user input, file content, API responses, query strings — always use `TryParse` over `Convert`. The `Convert` family is only safe when you already know the type is correct.

### 4. Exception Handling

| Day | Mistake | Status | Pattern Note |
|-----|---------|--------|--------------|
| Day 06 | Used `catch(Exception ex)` — catches every possible exception, not just the expected one | Fixed | Always catch the most specific exception type you know can be thrown. `catch(Exception)` at the top level of an app is acceptable; anywhere else it hides real bugs. |

**Rule to remember:** `catch(Exception)` is a last resort, not a default. If you know `DivideByZeroException` is the risk, name it. Broad catches silence unexpected errors and make debugging very difficult.

---

### 5. Type Selection

| Day | Mistake | Status | Pattern Note |
|-----|---------|--------|--------------|
| Day 06 | Changed ALL `int` to `decimal` including the menu option variable when fixing division precision | Fixed | Fix the right scope — decimal was needed for the calculation values, not for the menu selector. Choose the type that matches the *meaning* of the data, not just the operation. |

**Rule to remember:** When applying a fix, ask "does this change belong here?" A menu option (1/2/3/4) is semantically an integer even if the surrounding code uses decimals.

---

### 6. Conditional Logic Correctness

| Day | Mistake | Status | Pattern Note |
|-----|---------|--------|--------------|
| Day 07 | Leap year condition required divisibility by both 100 and 400, so valid leap years like 2024 were incorrectly rejected | Fixed | Leap-year rule is: divisible by 4, except century years unless divisible by 400. Use: `year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)`. |

**Rule to remember:** For multi-part boolean rules, write the English rule first, then map each clause to code. Test at least one value per branch (normal leap year, normal non-leap year, century non-leap, century leap).

---

## Recurring Patterns (Watch These)

| Pattern | Times Seen | Risk Level |
|---------|------------|------------|
| PascalCase on local variables | 1 (Day 02) | Low — compiler doesn't enforce it, but reviewers will flag it immediately |
| Using `Convert` instead of `TryParse` for user input | 5 (Day 02–05) | High — will throw unhandled exceptions in production |
| Over-applying a fix beyond its required scope | 1 (Day 06) | Medium — introduces new bugs while solving an existing one |
| Catching base `Exception` instead of specific type | 1 (Day 06) | High — hides unexpected errors, makes debugging very hard |
| Missing `else` on a `TryParse` branch — silent failure | 1 (Day 06) | Medium — users get no feedback, hard to diagnose |
| Incorrect boolean condition for business rules | 1 (Day 07) | High — code compiles but returns wrong results |

---

## Concepts Unlocked Through Mistakes

These are concepts you now understand because you made the mistake first — which means they will stick.

- **`out` keyword** — pass a variable into a method so the method can write a value back to the caller
- **`TryParse` pattern** — safe parsing that returns success/failure as a bool instead of throwing
- **Inline `out var`** — `out int num1` declared directly inside the method call, no pre-declaration needed (Day 05)
- **Implicit usings** — .NET 6+ projects auto-include common namespaces; you don't need to add them manually
- **camelCase vs PascalCase** — C# naming rules by scope and member type
- **Specific exception catching** — catch the exact exception you expect; `catch(Exception)` is a last resort
- **Type semantics** — pick the type that matches the meaning of the data, not just what compiles
- **Leap year boolean logic** — translate the rule into grouped conditions and verify each branch with sample years

---

## Open Questions (To Revisit)

- When would you choose `int.Parse` over both `Convert.ToInt32` and `int.TryParse`?

---

## Latest Review Notes

| Date | Day | Feedback | Severity | Status |
|------|-----|----------|----------|--------|
| 07/15/2026 | Day 09 | The zero case is still wrong: `counter` stays 0, so input `0` prints 0 digits instead of 1. | High | Open |
| 07/15/2026 | Day 09 | The digit-count loop uses `i < 0`, so it only runs for negative numbers; positive inputs like `123` return 0 digits. | High | Open |
| 07/15/2026 | Day 09 | Negative numbers are counted incorrectly because `number.ToString().Length` includes the minus sign, so `-123` is reported as 4 digits instead of 3. | Medium | Open |
| 07/15/2026 | Day 07 | The final century-year check is still inverted: `yy % 400 != 0` rejects valid leap years like 2000 instead of accepting them. | High | Open |
| 07/15/2026 | Day 07 | Leap-year condition is still too broad: the `||` allows any year divisible by 4 to pass, so century non-leap years like 1900 are still treated as leap years. | High | Open |
| 07/15/2026 | Day 07 | Leap-year logic is reversed for normal leap years and still does not check the 400-year exception, so values like 2024 are rejected and 1900 is accepted. | High | Open |
| 07/08/2026 | Day 05 | Input prompt says "Enter any two numbers" but does not clarify input format (separate lines), which can confuse users | Low | Open |
| 07/08/2026 | Day 05 | Output text "Both numbers are same" is understandable but grammatically awkward | Low | Open |
| 07/08/2026 | Day 05 | Explicit `using System;` appears again while implicit usings are likely enabled, creating style inconsistency with modern project defaults | Low | Open |
| 07/08/2026 | Day 06 | Division branch calls `add` instead of `divide`, so option 4 returns wrong results | High | Open |
| 07/08/2026 | Day 06 | Zero-check compares raw string (`num2 != "0"`) instead of parsed numeric value, so inputs like `0.0` are mishandled | High | Open |
| 07/08/2026 | Day 06 | Unused import `using System.Linq.Expressions;` adds noise and triggers style warnings | Low | Open |
| 07/08/2026 | Day 06 | Method names use camelCase (`add`, `subtract`, etc.) instead of PascalCase for C# methods | Low | Open |

---

## Review History

| Date | Days Reviewed | Issues Found | Issues Fixed |
|------|---------------|--------------|--------------|
| 07/15/2026 | Day 09 (re-check 2) | 1 | 0 |
| 07/15/2026 | Day 09 (re-check) | 1 | 0 |
| 07/15/2026 | Day 09 | 1 | 0 |
| 07/15/2026 | Day 01–06 | 3 | 0 |
| 07/15/2026 | Day 06 (re-check) | 0 | 3 (divide guard, naming, unused using) |
| 07/15/2026 | Day 07 | 1 | 0 |
| 07/15/2026 | Day 07 | 1 | 0 |
| 05/25/2026 | Day 01–05 | 4 | 3 (naming in Day02, redundant using in Day04, TryParse pattern in Day05) |
| 05/25/2026 | Day 06 | 4 | 4 (decimal return type, Divide rename, specific exception catch, type selection for menu option) |
| 05/27/2026 | Day 07 | 2 | 0 (boolean leap-year rule incorrect, class naming style suggestion) |
| 05/27/2026 | Day 07 (re-check) | 1 | 1 (class naming fixed; leap-year condition still incorrect) |
| 05/27/2026 | Day 07 (re-check 2) | 0 | 1 (leap-year condition fixed and validated with 1900/2000/2024) |
| 07/08/2026 | Day 05 | 3 | 0 (prompt clarity, message wording, implicit usings style consistency) |
| 07/08/2026 | Day 06 | 4 | 0 (wrong operation in divide branch, fragile zero-check, unused import, method naming style) |
