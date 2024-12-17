using System;

public abstract class Activity
{
    protected string _date;
    protected int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_length} min): Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
