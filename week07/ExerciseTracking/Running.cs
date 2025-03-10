using System;
using System.Collections.Generic;

public class Running : Activity
{
    private double distance; //Distance in miles

    public Running(DateTime date, int durationInMinutes, double distance) : base(date, durationInMinutes)
    {
        this.distance = distance;
    }

    //Here are the override methods
    public override double GetDistance() => distance;
    public override double GetSpeed() => (distance / DurationInMinutes) * 60;
    public override double GetPace() => DurationInMinutes / distance;

}
