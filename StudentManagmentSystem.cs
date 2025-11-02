
using System;
using System.Collections.Generic;

namespace StudentSystem_Roha070
{
    // Student class to store info
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string ClassName { get; set; }
    }

    class Program
    {
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            Console.Title = "Student Management System - Roha 070";
            int choice = 0;

            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n===============================");
                Console.WriteLine("   STUDENT MANAGEMENT SYSTEM");
                Console.WriteLine("===============================");
                Console.ResetColor();

                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Delete Student");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter your choice (1-4): ");

                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        ViewStudents();
                        break;
                    case 3:
                        DeleteStudent();
                        break;
                    case 4:
                        Console.WriteLine("\nExiting system...");
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice, try again!");
                        break;
                }

            } while (choice != 4);

            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();
        }

        static void AddStudent()
        {
            Console.Write("\nEnter student name: ");
            string name = Console.ReadLine();

            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter class: ");
            string className = Console.ReadLine();

            Student s = new Student
            {
                Name = name,
                Age = age,
                ClassName = className
            };
            students.Add(s);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Student added successfully!");
            Console.ResetColor();
        }

        static void ViewStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("\nNo students found!");
                return;
            }

            Console.WriteLine("\nList of Students:");
            Console.WriteLine("-----------------------------------");
            foreach (var s in students)
            {
                Console.WriteLine($"Name: {s.Name} | Age: {s.Age} | Class: {s.ClassName}");
            }
        }

        static void DeleteStudent()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("\nNo students to delete!");
                return;
            }

            Console.Write("\nEnter student name to delete: ");
            string name = Console.ReadLine();

            Student st = students.Find(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (st != null)
            {
                students.Remove(st);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Student deleted successfully!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Student not found!");
            }
            Console.ResetColor();
        }
    }
}

