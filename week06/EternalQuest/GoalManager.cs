using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private readonly List<Goal> _goals = new List<Goal>();
    private int _score;
    private int _level;
    private readonly Random _random = new Random();
}