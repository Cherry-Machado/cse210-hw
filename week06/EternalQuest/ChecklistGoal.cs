using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private readonly int _target;
        private readonly int _bonus;

        public ChecklistGoal(string name, string description, int points, 
                            int target, int bonus) : base(name, description, points)
        {
            _target = target;
            _bonus = bonus;
            _amountCompleted = 0;
        }

        public override int RecordEvent()
        {
            _amountCompleted++;
            int points = _points;
             if (_amountCompleted == _target) points += _bonus;
            return points;
        }

        public override bool IsComplete() => _amountCompleted >= _target;

        public override string GetStringRepresentation() => 
            $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_bonus}|{_target}|{_amountCompleted}";

        public override string GetDetailsString() => 
            $"[{(_amountCompleted >= _target ? "X" : " ")}] {_shortName} ({_description}) -- Completed {_amountCompleted}/{_target} times";
    }
}