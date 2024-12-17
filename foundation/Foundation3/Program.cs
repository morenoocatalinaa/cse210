using System;
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var running = new Running("03 Nov 2022", 30, 3.0);
        var cycling = new Cycling("03 Nov 2022", 30, 15.0);
        var swimming = new Swimming("03 Nov 2022", 30, 20);

        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
