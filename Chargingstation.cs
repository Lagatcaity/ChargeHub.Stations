namespace ChargeHub.Stations;

public class ChargingStation
{
    public string Id { get; }
    public double MaxKw { get; }

    public bool IsAvailable { get; private set; } = true;

    public ChargingStation(string id, double maxKw)
    {
        if (maxKw <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(maxKw),
                "MaxKw must be bigger than 0.");
        }

        Id = id;
        MaxKw = maxKw;
    }

    public void StartCharging()
    {
        if (!IsAvailable)
        {
            throw new InvalidOperationException(
                "Station is already occupied.");
        }

        IsAvailable = false;
    }

    public void StopCharging()
    {
        IsAvailable = true;
    }
}