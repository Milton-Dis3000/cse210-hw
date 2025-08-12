using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.");
    }

    public void ListGoals()
    {
        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
    
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (goalType == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (goalType == "3")
        {
            Console.Write("How many times does this goal need to be completed for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    public void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _goals[goalIndex].RecordEvent();
            _score += _goals[goalIndex].GetPoints();
            Console.WriteLine($"Congratulations! You have earned {_goals[goalIndex].GetPoints()} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }
    
    public void DeleteGoal()
    {
        ListGoals();
        Console.Write("Which goal would you like to delete? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            string deletedGoalName = _goals[goalIndex].GetDetailsString();
            _goals.RemoveAt(goalIndex);
            Console.WriteLine($"The goal has been deleted: {deletedGoalName}");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
        Console.WriteLine("\nPress Enter to return to the menu.");
        Console.ReadLine();
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
        Console.WriteLine("\nPress Enter to return to the menu.");
        Console.ReadLine();
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            _goals.Clear(); // Clear existing goals before loading new ones
            string[] lines = File.ReadAllLines(filename);

            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(":");
                string goalType = parts[0];
                string[] goalDetails = parts[1].Split(",");

                string name = goalDetails[0];
                string description = goalDetails[1];
                int points = int.Parse(goalDetails[2]);

                if (goalType == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(goalDetails[3]);
                    _goals.Add(new SimpleGoal(name, description, points, isComplete));
                }
                else if (goalType == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(name, description, points));
                }
                else if (goalType == "ChecklistGoal")
                {
                    int bonus = int.Parse(goalDetails[3]);
                    int target = int.Parse(goalDetails[4]);
                    int amountCompleted = int.Parse(goalDetails[5]);
                    _goals.Add(new ChecklistGoal(name, description, points, bonus, target, amountCompleted));
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found. No goals were loaded.");
        }
        Console.WriteLine("\nPress Enter to return to the menu.");
        Console.ReadLine();
    }
}