using System;
using System.Collections.Generic;

//This is the base Activity class
public abstract class Activity
{
    //Atributes shared between the other classes
    private DateTime date;
    private int durationInMinutes;

    //Constructor
    public Activity(DateTime date, int durationInMinutes)
    {
        this.date;
        this.durationInMinutes = durationInMinutes;
    }

    //Properties
    public DateTime Date => date;
    public int DurationInMinutes => dura
}