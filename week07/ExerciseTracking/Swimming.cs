using System;
using System.Collections.Generic;

//Creating the derived class for Swimming

public class Swimming : Activity
{
    private int laps; //This is going to get the numbers of laps

    public Swimming(DateOnly date, int durationInMinutes, int laps) : base(date, durationInMinutes)
    {
        this.laps = laps;
        
    }

    //Here are the overrides methods
    public override double GetDistance() => laps * 50 / 1000.0 * 0.62; //This expresion converts laps to miles
    public override double GetSpeed() => (GetDistance() / DurationInMinutes) * 60; 
    public override double GetPace() => DurationInMinutes / GetDistance();
}