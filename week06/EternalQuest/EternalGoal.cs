
/// Represents a goal that is never complete but provides points each time it is recorded.

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        // No extra fields needed for this type of goal.
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        return _points; // Always award points.
    }

    public override bool IsComplete()
    {
        // An eternal goal is never considered "complete".
        return false;
    }

    public override string GetStringRepresentation()
    {
        // Format: EternalGoal:name,description,points
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}
