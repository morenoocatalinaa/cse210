public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return Points;
    }

    public override string ToFileFormat()
    {
        return $"EternalGoal|{Name}|{Description}|{Points}";
    }
}
