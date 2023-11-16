using System;

public class EternalGoal : Goal
{
    private int _points;

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return true;
    }
}