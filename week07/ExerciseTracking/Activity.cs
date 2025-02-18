using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

//This is the base Activity class
public abstract class Activity
{
    //Atributes shared between the other classes
    private DateTime date;
    private int durationInMinutes;

    //Constructor
    public Activity(DateTime date, int durationInMinutes)
    {
        this.date = date;
        this.durationInMinutes = durationInMinutes;
    }

    //Properties
    public DateTime Date => date;
    public int DurationInMinutes => durationInMinutes;

    //Abstract methods to be implemented by derived classes.
    public abstract double GetDistance(); //This will be the Distance in miles or kilometers
    public abstract double GetSpeed(); //This will be the Speed in mph or kph
    public abstract double GetPace(); //This will be the Pace in minutes per mile or kilometers

    // This is gonna be the Summary method (common for all activities)
    public virtual string GetSummary()
    {
       return $"{date:dd MMM yyyy} {GetType().Name} ({DurationInMinutes} min) - " +
              $"Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
        

    }
}