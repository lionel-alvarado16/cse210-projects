using System;
using System.Collections.Generic;

public class Interface
{
    private List<Goal> _goals = new List<Goal>();

    public void CreateGoal()
    {

    }
    
    public void ListGoals()
    {

    }

    public void SaveGoals()
    {
    }

    public List<Goal> LoadGoals()
    {
        List<Goal> savedGoals = new List<Goal>();

        _goals = savedGoals;

        return _goals;
    }
}