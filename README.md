# ChargeHub Stations

A small console app that demonstrates a charging station's availability state. A station starts available, becomes unavailable when charging starts, and throws an `InvalidOperationException` if charging is started while it is already in use. `StopCharging()` makes it available again.

## Run

From the project directory, run:

```bash
dotnet run
```

The program creates station AC-01 with a maximum power of 11 kW and demonstrates starting and stopping a charging session.
