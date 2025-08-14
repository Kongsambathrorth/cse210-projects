
using System;

/// Represents a swimming activity.
public class Swimming : Activity
{
    private readonly int _laps;
    private const double MetersPerLap = 50;
    private const int MetersPerKm = 1000;

    public Swimming(DateTime date, int lengthInMinutes, int laps) 
        : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // Distance (km) = swimming laps * 50 / 1000
        return _laps * MetersPerLap / MetersPerKm;
    }

    public override double GetSpeed()
    {
        // Speed (kph) = (distance / minutes) * 60
        double distance = GetDistance();
        return (distance / GetLengthInMinutes()) * 60;
    }

    public override double GetPace()
    {
        // Pace (min per km) = minutes / distance
        double distance = GetDistance();
        // Avoid division by zero if distance is 0
        return distance > 0 ? GetLengthInMinutes() / distance : 0;
    }
}