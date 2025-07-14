using System;
using System.Collections.Generic; // Required for List<T>

public class Resume
{
    // Member variables for resume details
    public string _name = "";
    public List<Job> _jobs = new List<Job>(); // Initialize the list here

    // Method to display the resume details
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Iterate through each job and display its details
        foreach (Job job in _jobs)
        {
            job.Display(); // Calls the Display() method from the Job class
        }
    }
}