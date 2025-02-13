namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        private bool isComplete;
        public SimpleGoal(string name, string description, int points) : base(name, description, points)
        {
            isComplete = false;
        }
    }
}