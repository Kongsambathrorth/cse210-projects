
/// Represents a goal that must be accomplished a specific number of times to be complete.

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    /// Constructor for loading a checklist goal from a file.

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) 
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted++;
            if (IsComplete())
            {
                // Completed the goal on this event.
                int totalPoints = _points + _bonus;
                Console.WriteLine($"Congratulations! You have earned {totalPoints} points!");
                Console.WriteLine($"You get a bonus of {_bonus} for completing the goal!");
                return totalPoints;
            }
            else
            {
                // Made progress but not yet complete.
                Console.WriteLine($"Congratulations! You have earned {_points} points!");
                return _points;
            }
        }
        
        Console.WriteLine("You have already completed this goal.");
        return 0;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        // Format: ChecklistGoal:name,description,points,bonus,target,amountCompleted
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}
