using System;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public readonly int RollNumber;
    public string Grade { get; set; }

    private static int nextRollNumber = 1;

    public Student(string name, int age, string grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
        RollNumber = nextRollNumber++;
    }

    public override string ToString()
    {
        return $"Roll Number: {RollNumber}, Name: {Name}, Age: {Age}, Grade: {Grade}";
    }
}

public class StudentList<T> where T : Student
{
    private List<T> students = new List<T>();

    public void AddStudent(T student)
    {
        students.Add(student);
    }

    public void DisplayStudents()
    {
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }

    public IEnumerable<T> SearchStudents(string keyword)
    {
        return students.Where(s => s.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase) || s.RollNumber.ToString() == keyword);
    }
}
