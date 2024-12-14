public class SimpleGoal : Goal
{
    private bool isCompleted;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        isCompleted = false;
    }

    public override int RecordEvent()
    {
        if (!isCompleted)
        {
            isCompleted = true;
            return Points;
        }
        else
        {
            Console.WriteLine("This goal is already completed.");
            return 0;
        }
    }

    public override string ToFileFormat()
    {
        return $"SimpleGoal|{Name}|{Description}|{Points}|{isCompleted}";
    }
}