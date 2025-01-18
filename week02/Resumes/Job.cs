using System;

public class Job 
{
#region Attibutes
   public string _company;
   public string _jobTitle;
   public int _startYear;
   public int _endYear;
#endregion

#region Methods
    public void Display()
    {
        Console.WriteLine("{0} ({1}) {2}-{3}.",  _jobTitle, _company, _startYear, _endYear);
    }
#endregion
}