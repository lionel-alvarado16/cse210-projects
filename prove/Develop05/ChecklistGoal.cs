using System;

public class ChecklistGoal : Goal
{
    private int _points;
    private int _bonus;
    private int _totalTimes;
    private int _currentlyTimes;

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return true;   
    }
}