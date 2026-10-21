using ChargeHub.Stations;

class Program
{
    static void Main()
    {
        var station = new ChargingStation("AC-01", 11);

        Console.WriteLine($"Station: {station.Id}");
        Console.WriteLine($"Max power: {station.MaxKw} kW");
        Console.WriteLine($"Available: {station.IsAvailable}");

        station.StartCharging();
        Console.WriteLine($"After starting: {station.IsAvailable}");

        try
        {
            station.StartCharging();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        station.StopCharging();
        Console.WriteLine($"After stopping: {station.IsAvailable}");
    }
}