using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points) : base(name, description, points) { }

        public override int RecordEvent() => _points;
        public override bool IsComplete() => false;
         public override string GetStringRepresentation() => 
            $"EternalGoal|{_shortName}|{_description}|{_points}";

        public override string GetDetailsString() => 
            $"[ ] {_shortName} ({_description})";
    }
}