using System;
using System.Collections.Generic;

// Creating the MathAssignment Class

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // Building the Constructor with 4 parameters, 2 of them heritaged from
    // Assignment class using "base".
    
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}