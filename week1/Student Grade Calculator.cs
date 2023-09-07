// Here is a working solution

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Grade Calculator!");

        Console.Write("Enter your name: "); //Enter name
        string studentName = Console.ReadLine();

        Console.Write("Enter the number of subjects: ");
        int numSubjects = int.Parse(Console.ReadLine());

        Dictionary<string, double> subjectGrades = new Dictionary<string, double>();

        // here we organize the input names and grades in the dictionary
        for (int i = 1; i <= numSubjects; i++)
        {
            Console.Write($"Enter the name of subject {i}: ");
            string subjectName = Console.ReadLine();

            double grade;
            while (true) //ensure the grades are in a valid range
            {
                Console.Write($"Enter the grade for {subjectName}: ");
                if (double.TryParse(Console.ReadLine(), out grade) && grade >= 0 && grade <= 100)
                {
                    subjectGrades[subjectName] = grade;
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid grade between 0 and 100.");
                }
            }
        }

        // wirte a function to calculate the average grade here
        double totalGrade = 0;
        foreach (var grade in subjectGrades.Values) 
        {
            totalGrade += grade;
        }
        double averageGrade = totalGrade / numSubjects;


        Console.WriteLine($"\nStudent Name: {studentName}");
        Console.WriteLine("Subject Grades:");
        foreach (var sub in subjectGrades)
        {
            Console.WriteLine($"{sub.Key}: {sub.Value}");
        }
        Console.WriteLine($"Average Grade: {averageGrade:F2}");

    }
}

//One thing left is, ensuring if a valid number of subjects is entered
