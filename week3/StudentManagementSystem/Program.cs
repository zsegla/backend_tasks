using System;
using System.IO;
using System.Text.Json;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var studentList = new StudentList<Student>();
        LoadStudentData(studentList);

        while (true)
        {
            Console.WriteLine("Student Management System");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Search Students");
            Console.WriteLine("3. Display All Students");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent(studentList);
                    break;
                case "2":
                    SearchStudents(studentList);
                    break;
                case "3":
                    DisplayStudents(studentList);
                    break;
                case "4":
                    SaveStudentData(studentList);
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddStudent(StudentList<Student> studentList)
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();
        Console.Write("Enter student age: ");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            Console.Write("Enter student grade: ");
            string grade = Console.ReadLine();
            Student student = new Student(name, age, grade);
            studentList.AddStudent(student);
            Console.WriteLine("Student added successfully.");
        }
        else
        {
            Console.WriteLine("Invalid age input. Please enter a valid number.");
        }
    }

    static void SearchStudents(StudentList<Student> studentList)
    {
        Console.Write("Enter a name or roll number to search: ");
        string keyword = Console.ReadLine();
        var results = studentList.SearchStudents(keyword).ToList();
        if (results.Any())
        {
            Console.WriteLine("Search results:");
            foreach (var student in results)
            {
                Console.WriteLine(student);
            }
        }
        else
        {
            Console.WriteLine("No students found matching the search criteria.");
        }
    }

    static void DisplayStudents(StudentList<Student> studentList)
    {
        Console.WriteLine("List of Students:");
        studentList.DisplayStudents();
    }

    static void LoadStudentData(StudentList<Student> studentList)
    {
        if (File.Exists("students.json"))
        {
            string json = File.ReadAllText("students.json");
            studentList = JsonSerializer.Deserialize<StudentList<Student>>(json);
        }
    }

    static void SaveStudentData(StudentList<Student> studentList)
    {
        string json = JsonSerializer.Serialize(studentList);
        File.WriteAllText("students.json", json);
    }
}
