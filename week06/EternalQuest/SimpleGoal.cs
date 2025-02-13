namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        private bool isComplete;
        public SimpleGoal(string name, string description, int points) : base(name, description, points)
        {
            isComplete = false;
        }

        public override int RecordEvent()
        {
            if (!_isComplete)
            {
                _isComplete = true;
                return _points;
            }
            return 0;
        }

        public override bool IsComplete() => _isComplete;
        
        public override string GetStringRepresentation() => 
            $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";

        public override string GetDetailsString() => 
            $"[{(_isComplete ? "X" : " ")}] {_shortName} ({_description})";
    }
}