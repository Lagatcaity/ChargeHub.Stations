using System;

namespace ChargeHub.Stations
{
    public class ChargingStation
    {
        public string Id { get; }
        public double MaxKw { get; }
        public bool IsAvailable { get; private set; }

        public ChargingStation(string id, double maxKw)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Id must be provided.", nameof(id));
            if (maxKw <= 0)
                throw new ArgumentOutOfRangeException(nameof(maxKw), "MaxKw must be greater than 0.");

            Id = id;
            MaxKw = maxKw;
            IsAvailable = true;
        }

        public void StartCharging()
        {
            if (!IsAvailable)
                throw new InvalidOperationException("Station is already in use.");
            IsAvailable = false;
        }

        public void StopCharging()
        {
            IsAvailable = true;
        }
    }
}
