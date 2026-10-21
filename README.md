# ChargeHub.Stations

A C# console application that models an electric vehicle charging station.

## Features
- Each station has an ID and maximum charging power.
- A station starts as available.
- Starting a charge makes the station unavailable.
- Starting a second charge while occupied throws an InvalidOperationException.
- Stopping a charge makes the station available again.
- Maximum charging power must be greater than zero.

## How to run

Run the application from the project directory:

```bash
dotnet run
```