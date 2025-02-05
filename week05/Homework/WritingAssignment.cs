using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


//Creating the WrittingAssignment Class
public class WritingAssignment : Assignment
{
    private string _title;

    // Creating the Constructor with 3 parameters, 2 of them
    // coming from the base Class Assignment.
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    // Creating the GetWritingInformation() Method
    public string GetWritingInformation()
    {
        // Using Getter because studentName is a private attribute on base.
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}
