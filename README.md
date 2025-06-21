# 🔋 Problem C – Maximum Safe Current Finder

We’ve all had days where things explode under pressure. Sadly, our laptop batteries have started to take that a bit too literally. The goal here? Find the _maximum_ current (in milliamps) we can push through a battery before it _might_ go kaboom 💥—but do it with only **two** test batteries and as few tests as possible.

Because if the first one goes up in smoke, we really want to avoid frying the second.

## 📋 Task Summary

Given a `kaboomThreshold` (the point where things go very badly), calculate the **minimum number of tests** required in the worst case to find the highest safe current _without blowing up both batteries_. This is a classic case of the "2-egg drop" problem, just with a bit more smoke and sizzle.

## 🤔 Approach

We use a mathematical approach based on triangular numbers:

```
k(k+1)/2 ≥ kaboomThreshold - 1
```

Solve for the smallest integer `k` that satisfies this, and you’ve got your answer.

## 📂 Structure

- `Program.cs`: The core logic lives here, including the `CalculateMinTests` method.
- `UnitTests.cs`: Test coverage for edge cases, large values, and input/output validation.

## 🚀 Running the App

To run the console app:

```bash
dotnet run --project ProblemC
```

Then enter your threshold values line-by-line. End input with a `0`.

## 🧪 Running the Tests

This project includes a suite of MSTest unit tests.

To execute them:

```bash
dotnet test
```

You’ll find test cases like:

- `CalculateMinTests(1)` → `0`
- `CalculateMinTests(2)` → `1`
- `CalculateMinTests(10)` → `4`
- `CalculateMinTests(4711)` → `97`

…along with a full test of the console input/output pipeline.

## 🔧 Requirements

- .NET 9.0 SDK
- MSTest framework
