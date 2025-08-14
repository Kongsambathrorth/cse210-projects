
using System;


/// An abstract base class for tracking physical activities.

public abstract class Activity
{
    private readonly DateTime _date;
    private readonly int _lengthInMinutes;

    /// <summary>
    /// Initializes a new instance of the Activity class.
    /// </summary>
    /// <param name="date">The date of the activity.</param>
    /// <param name="lengthInMinutes">The length of the activity in minutes.</param>
    public Activity(DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }


    /// When overridden in a derived class, gets the distance in kilometers.

    public abstract double GetDistance();

  
    /// When overridden in a derived class, gets the speed in kilometers per hour.

    public abstract double GetSpeed();

    /// When overridden in a derived class, gets the pace in minutes per kilometer.

    public abstract double GetPace();
 
    /// Gets the length of the activity in minutes.
    /// This protected method allows derived classes to access the value for calculations.

    protected int GetLengthInMinutes()
    {
        return _lengthInMinutes;
    }

    /// Generates a summary string for the activity.
    /// This method is virtual and can be overridden if needed.

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_lengthInMinutes} min) - Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
    }
}