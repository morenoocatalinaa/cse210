using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        double distanceKm = GetDistance();
        return (distanceKm / _length) * 60;
    }

    public override double GetPace()
    {
        double distanceKm = GetDistance();
        return (double)_length / distanceKm;
    }
}
