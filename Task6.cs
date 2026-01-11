using System;

namespace KamustaMundoApp
{
    // Student class with properties and methods
    class Student
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        // Method to display student information
        public void DisplayInfo()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Grade: {Grade}");
        }

        // Method to check if student passed (grade >= 75)
        public bool IsPassed()
        {
            return Grade >= 75;
        }
    }

    class Task6
    {
        static void Main(string[] args)
        {
            // Create an instance of the Student class
            Student student = new Student();

            // Assign sample values to the properties
            student.Name = "Emmanuel";
            student.Age = 19;
            student.Grade = 90.1;

            // Call DisplayInfo() method to display student details
            student.DisplayInfo();

            // Call IsPassed() method and display the status
            if (student.IsPassed())
            {
                Console.WriteLine("Status: Passed");
            }
            else
            {
                Console.WriteLine("Status: Failed");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
