

public abstract class Goal
{
   
    protected string _shortName;
    protected string _description;
    protected int _points;


    /// Initializes a new instance of the Goal class.
   
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }


    /// Gets the name of the goal.
  
    public string GetName() => _shortName;

  
    /// When overridden in a derived class, records an event (e.g., completion) for the goal.
    /// This method is abstract, forcing subclasses to provide their own logic.

    /// <returns>The points earned for this event.</returns>
    public abstract int RecordEvent();


    /// When overridden in a derived class, determines if the goal is complete.
    /// This is abstract because the definition of "complete" varies by goal type.

    /// <returns>True if the goal is complete; otherwise, false.</returns>
    public abstract bool IsComplete();


    /// Returns the details of the goal in a display-friendly format.
   
   
    public virtual string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description})";
    }

    /// When overridden in a derived class, returns a string representation of the goal for saving to a file.
    /// This is abstract to ensure each goal type can be saved correctly.
  

    public abstract string GetStringRepresentation();
}
