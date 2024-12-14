public class ChecklistGoal : Goal
{
    public int TargetCount { get; }
    public int Bonus { get; }
    private int currentCount;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        TargetCount = targetCount;
        Bonus = bonus;
        currentCount = 0;
    }

    public override int RecordEvent()
    {
        currentCount++;
        if (currentCount == TargetCount)
        {
            currentCount = 0; // Reset count for future accomplishments
            return Points + Bonus;
        }
        return Points;
    }

    public override string ToFileFormat()
    {
        return $"ChecklistGoal|{Name}|{Description}|{Points}|{TargetCount}|{Bonus}|{currentCount}";
    }

    public override string ToString()
    {
        return base.ToString() + $" - Completed {currentCount}/{TargetCount} times";
    }
}