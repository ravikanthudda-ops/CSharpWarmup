# C# Daily Practice & Interview Readiness 🚀

**Goal:** Rebuild modern .NET skills, fill knowledge gaps, and become interview-ready for a Lead Developer / Tech Lead role.

**Strategy:** Three parallel tracks over 8 weeks —
- **Track A** (this repo) — Daily C# exercises: modern language features + DSA problems
- **Track B** (`TaskManager API`) — Real ASP.NET Core Web API portfolio project that grows every week
- **Track C** (weekends) — DevOps progression: Docker → CI/CD → Jenkins → Kubernetes → Microservices

**Time budget:** 1–2 hrs/weekday on Track A+B · 3–4 hrs/day on weekends for Track C

---

## 🤝 Copilot Coaching Rules (How We Work Together)

> These rules govern every interaction with GitHub Copilot during this learning journey. The goal is to make you think — not to hand you answers.

### What Copilot Will Do

- **Review your code first** before responding to any question about it
- **Identify issues silently** — read the full program before deciding whether a hint is needed
- **Give hints, not solutions** — point you toward the concept, the missing piece, or the wrong assumption without writing the fix
- **Ask you questions back** — "What do you think will happen if the input is negative?" rather than showing corrected code
- **Confirm your reasoning** — when you attempt a fix, Copilot will tell you whether your thinking is on the right track
- **Explain the why** — after you solve it yourself, Copilot will explain the underlying concept so it sticks

### What Copilot Will Not Do

- Write the solution or corrected code for you
- Create projects, files, or folders on your behalf
- Run git commands or push anything to GitHub
- Skip the hint phase and jump straight to the answer
- Rewrite your code even if there is a "cleaner" way — unless you explicitly ask

### How to Ask for Help

| What you want | How to ask |
|---------------|------------|
| Something is wrong but you don't know what | Share the code and say "review this" |
| You have a theory about the bug | Share the code and your theory — Copilot will confirm or redirect |
| You're completely stuck after trying | Say "I've tried X and Y, still stuck — give me a stronger hint" |
| You want the full explanation after solving | Say "I solved it — now explain the concept fully" |
| You want a concept explained without code | Say "explain without code examples" |

### The Learning Contract

- You attempt every exercise yourself first — no asking for a starting template
- You read the error message fully before asking for help
- You state what you think is wrong before Copilot responds
- One hint at a time — try the hint before asking for the next one
- When you solve it, you write a one-line comment in the code explaining what the bug was

---

## 📌 Track A — Daily Exercise Plan

### Week 1 — C# Fundamentals Wrap-up (Days 1–10)

> Finish fast. These build the daily habit — but the real content starts Day 11.

- [x] Day 01 – Hello World
- [x] Day 02 – Print Name and Age
- [x] Day 03 – Add Two Numbers
- [x] Day 04 – Check Even or Odd
- [x] Day 05 – Find Largest of Two Numbers
- [ ] Day 06 – Simple Calculator (Add / Subtract / Multiply / Divide)
- [ ] Day 07 – Check Leap Year
- [ ] Day 08 – Reverse a String
- [ ] Day 09 – Count Digits of a Number
- [ ] Day 10 – Sum of First N Numbers

---

### Week 1–2 — Modern C# Features (Days 11–20)

> Each program is a focused demo of one C# 8–12 feature. These come up constantly in Lead Dev interviews.

- [ ] Day 11 – `record` types + `init`-only properties (immutable data models)
- [ ] Day 12 – Pattern matching: `switch` expressions, `is`, `when` guards
- [ ] Day 13 – Nullable Reference Types: `?`, `!`, `??`, `?.` — null safety demo
- [ ] Day 14 – LINQ deep dive: `GroupBy`, `SelectMany`, `Aggregate`, method chaining
- [ ] Day 15 – `async`/`await`: `Task`, `ConfigureAwait(false)`, deadlock demonstration
- [ ] Day 16 – `IDisposable`, `using` declarations, `IAsyncDisposable`
- [ ] Day 17 – Generics with constraints: `where T : IComparable<T>`, `where T : class, new()`
- [ ] Day 18 – Tuples, named returns, deconstruction, `ValueTuple`
- [ ] Day 19 – Extension methods: write custom LINQ-style operators
- [ ] Day 20 – `Span<T>` / `Memory<T>` basics: why they exist, simple slicing demo

---

### Week 3 — Async, Concurrency & Middleware Patterns (Days 21–30)

> These map directly to real API features you'll build in Track B.

- [ ] Day 21 – `IMemoryCache`: cache-aside pattern, expiry, cache invalidation
- [ ] Day 22 – `CancellationToken`: cancel long-running operations gracefully
- [ ] Day 23 – `Task.WhenAll` / `Task.WhenAny`: parallel async work
- [ ] Day 24 – `Channel<T>`: producer-consumer pattern (background queue)
- [ ] Day 25 – `SemaphoreSlim`: throttle concurrent operations (rate limiting)
- [ ] Day 26 – `IHostedService`: background service that runs on app startup
- [ ] Day 27 – `Parallel.ForEachAsync`: CPU-bound parallel processing
- [ ] Day 28 – Middleware pipeline: build a custom `Invoke` chain from scratch
- [ ] Day 29 – `HttpClientFactory` + `Polly`: resilient HTTP calls with retry + circuit breaker
- [ ] Day 30 – JWT: decode a token manually, understand claims, expiry, signing

---

### Week 4 — Architecture & Design Patterns (Days 31–40)

> These are the Lead Dev differentiators. Know them well enough to draw and explain.

- [ ] Day 31 – Repository pattern: interface + implementation, why it matters for testing
- [ ] Day 32 – Unit of Work pattern: coordinate multiple repositories in one transaction
- [ ] Day 33 – Factory pattern: abstract object creation, open/closed principle in action
- [ ] Day 34 – Strategy pattern: swap algorithms at runtime (e.g., different export formats)
- [ ] Day 35 – Decorator pattern: add logging/caching to a service without modifying it
- [ ] Day 36 – Observer pattern: event-based notifications, `IObservable<T>` intro
- [ ] Day 37 – SOLID: write one clear violation + fix for each principle (5 small demos)
- [ ] Day 38 – CQRS: separate Command (write) and Query (read) with MediatR
- [ ] Day 39 – Clean Architecture: Layer diagram in code (Domain → Application → Infra → API)
- [ ] Day 40 – Dapper vs EF Core: same query both ways, when to choose which

---

### Week 5–6 — SQL & Performance (Days 41–50)

> You have an intermediate SQL base. These push it to Lead-level.

- [ ] Day 41 – Window functions: `ROW_NUMBER()`, `RANK()`, `DENSE_RANK()`
- [ ] Day 42 – Window functions: `LEAD()`, `LAG()`, running totals with `SUM() OVER()`
- [ ] Day 43 – CTEs (`WITH`): readable complex queries, recursive CTEs
- [ ] Day 44 – Indexes: clustered vs non-clustered, when to add which, covering indexes
- [ ] Day 45 – Execution plans: read a plan, spot a missing index, before/after comparison
- [ ] Day 46 – EF Core N+1 problem: demonstrate it, fix with `Include()` and explicit loading
- [ ] Day 47 – Bulk operations: `AddRange` vs `SqlBulkCopy`, performance comparison
- [ ] Day 48 – Transaction isolation levels: `READ COMMITTED` vs `SNAPSHOT` vs `SERIALIZABLE`
- [ ] Day 49 – Query optimization: rewrite a slow subquery as a JOIN or CTE
- [ ] Day 50 – Pagination in SQL: `OFFSET`/`FETCH NEXT` vs keyset (cursor) pagination

---

### Week 6–7 — Unit Testing (Days 51–55)

- [ ] Day 51 – xUnit basics: `[Fact]`, `[Theory]`, `[InlineData]`, test naming conventions
- [ ] Day 52 – Moq: mock interfaces, verify calls, setup return values
- [ ] Day 53 – Testing async methods: `async Task` test methods, `Task.FromResult` mocks
- [ ] Day 54 – `WebApplicationFactory`: in-memory integration test for an API endpoint
- [ ] Day 55 – Test coverage mindset: happy path + null input + not-found + unauthorized

---

### Week 7–8 — DSA Refresh (Days 56–70)

> 1 problem per day. Focus on patterns interviewers actually use. Skip graph theory and complex DP for now.

**Arrays & Strings (Days 56–60)**
- [ ] Day 56 – Two Sum (HashMap approach)
- [ ] Day 57 – Sliding window: max sum subarray of size K
- [ ] Day 58 – Two pointers: check if string is palindrome
- [ ] Day 59 – String manipulation: reverse words in a sentence
- [ ] Day 60 – Frequency count: find the most common character

**Stack & Queue (Days 61–63)**
- [ ] Day 61 – Valid parentheses using a Stack
- [ ] Day 62 – Implement a queue using two stacks
- [ ] Day 63 – Monotonic stack: next greater element

**Recursion & Sorting (Days 64–67)**
- [ ] Day 64 – Binary search (iterative + recursive)
- [ ] Day 65 – Merge sort implementation
- [ ] Day 66 – Factorial and Fibonacci using recursion vs iteration
- [ ] Day 67 – Find duplicates in an array (multiple approaches, compare complexity)

**Trees (Days 68–70)**
- [ ] Day 68 – Build a simple Binary Search Tree with Insert + Search
- [ ] Day 69 – BFS traversal (level-order) using a Queue
- [ ] Day 70 – DFS traversal (in-order, pre-order) using recursion


---

## 📝 Progress Log (MM/DD/YYYY)

(Add one line here every day)
- Day 01: Print Hello, World! (05/24/2026) 🎯
- Day 02: Print Name and Age! (05/24/2026) 🎯
- Day 03: Add two numbers (05/24/2026) 🎯
- Day 04: Check Even or Odd (05/25/2026) 🎯
- Day 05: Find Largest of Two Numbers (05/25/2026) 🎯
---

## �️ 8-Week Roadmap Overview

> Track A (this repo) runs every weekday. Track B and Track C are separate projects that grow alongside it.

| Week | Track A — Exercises (this repo) | Track B — TaskManager API | Track C — DevOps (weekends) |
|------|----------------------------------|---------------------------|------------------------------|
| 1 | Days 1–20: Fundamentals + Modern C# | Scaffold API, EF Core, CRUD, Swagger | Docker: containerize API + `docker-compose` with SQL Server |
| 2 | Days 21–25: Caching, CancellationToken, Parallel async | Pagination, Caching, Filtering+Sorting | GitHub Actions: CI pipeline (build → test → Docker image push) |
| 3 | Days 26–30: Background tasks, Middleware, JWT, Polly | JWT Auth, Unit Tests (15+), Integration Test | Jenkins: `Jenkinsfile` pipeline, local Jenkins in Docker |
| 4 | Days 31–40: Repository, UoW, Factory, SOLID, CQRS | Background queue, Parallel batch endpoint, Clean Architecture refactor | Kubernetes: deploy to Minikube, write `deployment.yaml` + `service.yaml` |
| 5 | Days 41–50: SQL window functions, Indexes, EF N+1, Dapper | Dapper pagination, DB indexes, Output Cache, Rate Limiting | Microservices: split into TaskService + NotificationService, RabbitMQ, YARP gateway |
| 6 | Days 51–55: xUnit, Moq, async tests, WebApplicationFactory | Polish tests, finalize Clean Architecture | React frontend: login + task list + forms, add to `docker-compose` |
| 7 | Days 56–65: DSA — Arrays, Strings, Stack, Queue, Binary Search | — | AI/MCP: Semantic Kernel chat endpoint OR MCP server exposing task tools |
| 8 | Days 66–70: DSA — Merge Sort, Trees, BFS, DFS | GitHub polish, architecture diagram, README | Full integration + interview prep |

---

## 🏗️ Track B — Portfolio Project: TaskManager API

**Repo:** `r:\Learning\Career\TaskManager\`

A real ASP.NET Core Web API that grows every week. Every backend topic learned in Track A gets applied here.

**Solution structure:**
```
TaskManager/
├── TaskManager.API/          ← Controllers, middleware, JWT, config
├── TaskManager.Core/         ← Domain models, interfaces, business rules
├── TaskManager.Application/  ← MediatR commands/queries (CQRS)
├── TaskManager.Infrastructure/ ← EF Core, Dapper, repositories, caching
└── TaskManager.Tests/        ← xUnit + Moq unit + integration tests
```

**Features built week by week:**

| Week | Feature Added |
|------|---------------|
| 1 | CRUD endpoints, EF Core (SQLite → SQL Server in Docker), Swagger |
| 2 | Pagination, `IMemoryCache`, filtering + sorting query params |
| 3 | JWT login/register, `[Authorize]`, role-based access, 15+ unit tests |
| 4 | `IHostedService` background queue, `Task.WhenAll` batch endpoint |
| 4 | Clean Architecture layers, CQRS with MediatR |
| 5 | Dapper + CTE pagination, DB indexes, Output Cache, Rate Limiting |
| 6 | Full test suite: unit + integration, `WebApplicationFactory` |
| 7 | AI chat endpoint (Semantic Kernel) or MCP server |

---

## 🐳 Track C — DevOps Weekend Sprint

| Weekend | Topic | Deliverable |
|---------|-------|-------------|
| 1 | Docker | API + SQL Server via `docker-compose up`, multi-stage `Dockerfile` |
| 2 | GitHub Actions CI/CD | Push to `main` → build → test → Docker image pushed to registry |
| 3 | Jenkins | `Jenkinsfile` declarative pipeline, local Jenkins running in Docker |
| 4 | Kubernetes (Minikube) | `kubectl apply` deploys API, understand Pod/Deployment/Service/ConfigMap |
| 5 | Microservices | TaskService + NotificationService + RabbitMQ (MassTransit) + YARP gateway |
| 6 | React + Full stack | Vite + React + TypeScript UI, login → task list, added to `docker-compose` |
| 7 | AI / MCP | Semantic Kernel chat endpoint OR .NET MCP server for AI tool integration |
| 8 | Polish | All repos pushed to GitHub with READMEs, architecture diagrams, setup docs |

**Key Docker commands:**
```bash
# Build and start everything
docker-compose up --build

# Run in background
docker-compose up -d

# Tear down
docker-compose down

# View logs for a specific service
docker-compose logs -f taskmanager-api
```

**Key Kubernetes commands:**
```bash
# Start Minikube
minikube start

# Deploy from YAML files
kubectl apply -f k8s/

# Check running pods
kubectl get pods

# View logs
kubectl logs <pod-name>

# Get service URL in Minikube
minikube service taskmanager-service --url
```

---

## ✅ Week-by-Week Verification Checkpoints

- [ ] End Week 1 — API runs via `docker-compose up`, Swagger accessible at `localhost:8080`
- [ ] End Week 2 — GitHub push triggers CI pipeline; Docker image pushed to registry
- [ ] End Week 3 — JWT login working; 15+ tests all green in CI pipeline
- [ ] End Week 4 — `kubectl get pods` shows API running in Minikube
- [ ] End Week 5 — Two microservices communicating via RabbitMQ in `docker-compose`
- [ ] End Week 6 — React UI: login, view paginated tasks, create a task — all working
- [ ] End Week 7 — AI chat endpoint answers "What tasks are overdue?" using real data
- [ ] End Week 8 — Can do a 15-min verbal walkthrough of every architectural decision without notes

---

## �🔧 .NET CLI Commands (Quick Reference)

### Create Solution & First Project (One Time)

```bash
dotnet new sln -n CSharpDailyPractice
dotnet new console -n Day01
dotnet sln add Day01/Day01.csproj
```

### Create Project for New Day

```bash
dotnet new console -n Day02
dotnet sln add Day02/Day02.csproj
```

---

### ▶️ Run a Project

```bash
dotnet run --project Day01
```

---

### 🏗 Build

Build current folder:
```bash
dotnet build
```

Build solution:
```bash
dotnet build CSharpDailyPractice.sln
```

---

### 🧹 Clean Build Files

```bash
dotnet clean
```

---

### 🔍 Check Installed .NET Version

```bash
dotnet --version
```

---

## 🔄 Git Commands (Daily Use)

Check status:
```bash
git status
```

Stage changes:
```bash
git add .
```

Commit:
```bash
git commit -m "Day 01 - Completed Hello World program"
```

Push to GitHub:
```bash
git push
```

---

## 🌱 Git Setup (One Time Only)

```bash
git init
git branch -M main
git remote add origin https://github.com/<your-username>/csharp-daily-practice.git
git push -u origin main
```

---

## 📌 Useful Git Commands (Occasional)

Undo last commit (keep changes):
```bash
git reset --soft HEAD~1
```

View commit history:
```bash
git log --oneline
```

Create a new branch:
```bash
git checkout -b experiments
```

Switch back to main:
```bash
git checkout main
```

---

## 🧠 Daily Workflow (Follow This Blindly)

```bash
dotnet new console -n DayXX
dotnet sln add DayXX/DayXX.csproj
dotnet run --project DayXX
git add .
git commit -m "Day XX - Program name"
git push
```
---

## 🚫 .gitignore Notes (Important)

This project uses a `.gitignore` file to prevent committing build artifacts.

### Why bin/ and obj/ are ignored?
- These folders are auto-generated by .NET
- They are recreated every time you build or run
- They should NEVER be committed to Git

### Common ignored folders/files
- `bin/` – compiled output
- `obj/` – temporary build files
- `.vscode/` – editor settings
- `.idea/` – IDE files
- OS files like `.DS_Store`, `Thumbs.db`

### If bin/ or obj/ are already committed
Run once:
```bash
git rm -r --cached bin obj

---

## ✅ Rules

- Commit every day (even tiny code)
- Difficulty does not matter
- Consistency matters more than perfection
- One commit per day is a win
