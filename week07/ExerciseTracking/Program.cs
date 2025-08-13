// This is the entry point for the program. It creates instances of each activity
// type and demonstrates polymorphism by calling GetSummary() on a list of
// the base class type.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold all the different activities
        List<Activity> activities = new List<Activity>();

        // Create instances of each derived class
        Running runningActivity = new Running("03 Nov 2022", 30, 3.0);
        Cycling cyclingActivity = new Cycling("04 Nov 2022", 45, 15.0);
        Swimming swimmingActivity = new Swimming("05 Nov 2022", 60, 20);

        // Add each activity to the list of the base class type
        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        // Iterate through the list and display the summary for each activity
        foreach (Activity activity in activities)
        {
            // This single line of code demonstrates polymorphism.
            // The correct GetSummary() method is called for each specific object.
            string summary = activity.GetSummary();
            Console.WriteLine(summary);
        }
    }
}
