using System;
using System.Collections.Generic;

public class Cycling : Activity
{
    private double speed; // This the speed in mph

    public Cycling(DateTime date, int durationInMinutes, double speed) : base(date, durationInMinutes)
    {
        this.speed = speed;
    }

    //Here are the override methods
    public override double GetDistance() => (speed * DurationInMinutes) / 60;
    public override double GetSpeed() => speed;
    public override double GetPace() => 60 / speed;
}