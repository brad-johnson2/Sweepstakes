using System;
using System.Collections.Generic;

namespace Sweepstakes
{
    public class Contestant
    {
        Contestant[] contestant = new Contestant[4];
        

        string firstNamee;
        string lastName;
        string emailAddress;
        int regNumber;
    }

    public void DisplayEmployeeIdName()
    {
        Dictionary<int, string> contestants = new Dictionary<int, string>();
        contestants.Add(1337, "Terrill");
        contestants.Add(1234, "Heinisch");
        contestants.Add(9541, "Carlson");

        Console.Write("Enter an employee name: ");
        string value = Console.ReadLine();
        foreach (KeyValuePair<int, string> contestant in contestants)
        {
            if (contestant.Value == value)
                Console.WriteLine($"Employee ID: {contestant.Key} Employee Name: {contestant.Value}");
        }
    }
}