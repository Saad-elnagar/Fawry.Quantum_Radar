# Quantum Radar — Rule-Based Traffic Violation Engine

A C# console application that evaluates vehicle observations against a configurable collection of violation rules and produces fine records.

## Features

- Register reusable violation rules through `IViolationRule`.
- Evaluate observations using vehicle type, speed, and seatbelt state.
- Detect speeding and seatbelt violations.
- Combine all violations for an observation into one fine record.
- Track violation counts by rule.
- Print fine receipts to the console.

## Architecture

```text
RadarObservation
      |
      v
QuantumRadar
      |
      +--> SpeedRule
      +--> SeatbeltRule
      |
      v
ViolationResult --> Fine --> FineReceiptPrinter
```

The rule interface keeps individual checks separate from the radar coordinator, making it straightforward to add another rule without placing all logic in `Program.cs`.

## Tech Stack

- C#
- .NET 10
- Object-oriented design
- Rule-based composition through interfaces

## Run Locally

From the repository root:

```bash
dotnet restore "Fawry.Quantum Radar.slnx"
dotnet run --project "Fawry.Quantum Radar/Fawry.Quantum Radar.csproj"
```

## Example Rules

| Rule | Demonstration logic |
|---|---|
| `SpeedRule` | Uses a vehicle-type-specific speed threshold |
| `SeatbeltRule` | Creates a violation when the seatbelt is not fastened |

The thresholds and fine amounts are sample application rules, not a statement of real-world traffic law.

## Possible Extensions

- Add automated tests for each rule and threshold boundary.
- Add validation for observations and vehicle identifiers.
- Make fine amounts and thresholds configurable.
- Return read-only collections instead of exposing the internal state directly.
