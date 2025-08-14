
using System;

/// Represents a stationary cycling activity.

public class Cycling : Activity
{
    private readonly double _speedKph;

    public Cycling(DateTime date, int lengthInMinutes, double speedKph) 
        : base(date, lengthInMinutes)
    {
        _speedKph = speedKph;
    }

    public override double GetDistance()
    {
        // Distance = (speed / 60) * minutes
        return (_speedKph / 60) * GetLengthInMinutes();
    }

    public override double GetSpeed()
    {
        return _speedKph;
    }

    public override double GetPace()
    {
        // Pace = 60 / speed
        return 60 / _speedKph;
    }
}