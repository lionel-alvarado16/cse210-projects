using System;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public Goal()
    {
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. ChecklistGoal");
        Console.Write("What type of goal would you like to create? ");
        string choice = Console.ReadLine();
        Console.Write("Which is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is the short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of poitns associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();
}