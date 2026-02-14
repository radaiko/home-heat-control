# Home Heat Control (HoHeCo)

A smart home heating control system that reads temperature data from openHAB and automates heating decisions.

## Architecture

- `HoHeCo.Data` — Data access layer (openHAB REST API reader)
- `HoHeCo.Logic` — Heating control logic
- `HoHeCo.Models` — Configuration and data models
- `HoHeCo-Console` — Console application entry point
- `RadLogger` — Custom logging library

## Tech Stack

- C# / .NET
- openHAB integration
