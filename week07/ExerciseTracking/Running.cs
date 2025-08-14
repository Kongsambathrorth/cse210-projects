
using System;

/// Represents a running activity.
public class Running : Activity
{
    private readonly double _distanceKm;

    public Running(DateTime date, int lengthInMinutes, double distanceKm) 
        : base(date, lengthInMinutes)
    {
        _distanceKm = distanceKm;
    }

    public override double GetDistance()
    {
        return _distanceKm;
    }

    public override double GetSpeed()
    {
        // Speed (kph) = (distance / minutes) * 60
        return (_distanceKm / GetLengthInMinutes()) * 60;
    }

    public override double GetPace()
    {
        // Pace (min per km) = minutes / distance
        return GetLengthInMinutes() / _distanceKm;
    }
}