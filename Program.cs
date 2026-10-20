using System;
using ChargeHub.Stations;

internal class Program
{
    private static void Main()
    {
        var station = new ChargingStation("AC-01", 11);

        Console.WriteLine($"Station {station.Id} is available: {station.IsAvailable}");

        station.StartCharging();
        Console.WriteLine($"After start: available = {station.IsAvailable}");

        try
        {
            station.StartCharging();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }

        station.StopCharging();
        Console.WriteLine($"After stop: available = {station.IsAvailable}");
    }
}
