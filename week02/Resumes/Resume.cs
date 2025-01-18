using System;
using System.Collections.Generic;

class Resume {
    
    #region Attibutes
    public string _name;
    public List<Job> _jobs = new List<Job>();
    #endregion

    #region Methods
    public void Display() {
        Console.WriteLine("Name: {0}", _name);
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs) {
            job.Display();
        }
    }
    #endregion
}