public abstract class Goal
{
    public string Name { get; }
    public string Description { get; }
    public int Points { get; }

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public abstract int RecordEvent();

    public abstract string ToFileFormat();

    public override string ToString()
    {
        return $"{Name} ({Description})";
    }
}
