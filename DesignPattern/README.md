# C# Design Pattern Practice 🧩

**Goal:** Build a practical C# design-pattern notebook with small, focused demos that are easy to review, explain, and extend.

**Strategy:** One pattern per folder or small project. Keep each example tiny, runnable, and written to highlight the design decision rather than the boilerplate.

**Time budget:** 30–60 minutes per session, with one pattern recap and one code change per day.

---

## 🤝 Copilot Coaching Rules

> These rules keep the practice loop focused on understanding, not copying.

### What Copilot Will Do

- Review the current code first before giving feedback
- Point out the design issue or missing concept without writing the full fix
- Ask questions that help you reason about the pattern
- Explain the tradeoff after you solve the exercise yourself

### What Copilot Will Not Do

- Write the full pattern implementation for you
- Skip the reasoning step and jump straight to the answer
- Rewrite code just to make it look cleaner

---

## 📌 Pattern Practice Plan

### Week 1 — Core Principles

- [x] SRP — Single Responsibility Principle
- [ ] OCP — Open/Closed Principle
- [ ] LSP — Liskov Substitution Principle
- [ ] ISP — Interface Segregation Principle
- [ ] DIP — Dependency Inversion Principle

### Week 2 — Creational Patterns

- [ ] Factory Method
- [ ] Abstract Factory
- [ ] Builder
- [ ] Singleton

### Week 3 — Structural Patterns

- [ ] Adapter
- [ ] Decorator
- [ ] Facade
- [ ] Proxy

### Week 4 — Behavioral Patterns

- [ ] Strategy
- [ ] Observer
- [ ] Command
- [ ] Chain of Responsibility

---

## 🏗️ Project Structure

```text
DesignPattern/
├── DesignPattern.slnx
└── SRP/
    ├── Program.cs
    └── SRP.csproj
```

The SRP project is the first starter example. Each new pattern can either live in its own folder or expand this solution with a similar minimal console app.

---

## ▶️ Run the Current Demo

```bash
dotnet run --project SRP
```

---

## 🧠 Daily Workflow

```bash
dotnet run --project SRP
dotnet build
git status
```

If the pattern is not yet clear, keep the example small and add only one behavior at a time.

---

## 📝 Progress Log (MM/DD/YYYY)

(Add one line here every day)
- Day 01: SRP is done! (08/07/2026) 🎯

---

## ✅ Practice Rules

- Start with the simplest version of the pattern
- Prefer small console demos over large abstractions
- Explain the tradeoff in one sentence after each exercise
- Keep one runnable example per concept
