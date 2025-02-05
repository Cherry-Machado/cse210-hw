using System;
using System.Collections.Generic;

public class Assignment
{
    private string _studentName = "";
    private string _topic = "";

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Here I provide Getters and Setters for the private memeber variables.
    public string GetStudentName()
    {
        return _studentName;
    }
    public void SetStudentName(string studentName)
    {
        _studentName = studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }

    // Here is the GetSumary() Method

    public string GetSummary()
    {
        return _studentName + " - "+ _topic;
    }
    
}