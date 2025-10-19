using C__MINI_Projects;
using System;
using System.Collections.Generic;

namespace StudentManagement
{
    internal class Program
    {
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\n===== STUDENT MANAGEMENT SYSTEM =====");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View All Students");
                Console.WriteLine("3. Search Student by ID");
                Console.WriteLine("4. Delete Student by   ID");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        ViewStudents();
                        break;
                    case 3:
                        SearchStudent();
                        break;
                    case 4:
                        DeleteStudent();
                        break;
                    case 5:
                        Console.WriteLine("Exiting... Thank you!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }

            } while (choice != 5);
        }

        static void AddStudent()
        {
            Student s = new Student();

            Console.Write("Enter Student ID: ");
            s.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            s.Name = Console.ReadLine();

            Console.Write("Enter Student Age: ");
            s.Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Course: ");
            s.Course = Console.ReadLine();

            students.Add(s);
            Console.WriteLine("✅ Student added successfully!");
        }

        static void ViewStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students found!");
                return;
            }

            Console.WriteLine("===== Student List =====");
            foreach (var s in students)
            {
                s.Display();
            }
        }

        static void SearchStudent()
        {
            Console.Write("Enter Student ID to search: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var student = students.Find(s => s.Id == id);

            if (student != null)
                student.Display();
            else
                Console.WriteLine("❌ Student not found!");
        }

        static void DeleteStudent()
        {
            Console.Write("Enter Student ID to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var student = students.Find(s => s.Id == id);

            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("🗑️ Student deleted successfully!");
            }
            else
            {
                Console.WriteLine("❌ Student not found!");
            }
        }
    }
}
