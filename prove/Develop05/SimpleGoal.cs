using System;

public class SimpleGoal : Goal
{
    private int _points;
    private bool _complete;

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return true;
    }
}