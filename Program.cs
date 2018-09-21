using System;
using System.Collections.Generic;

namespace ScoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            var adding = true;
            while (adding)
            {
                var newStudent = new Student();
                Console.Write("StudentName: ");
                newStudent.Name = (Console.ReadLine());
                Console.Write("StudentGrade ");
                newStudent.Grade = int.Parse(Console.ReadLine());
                Console.Write("Student birthday: ");
                newStudent.Birthday = Console.ReadLine();
                Console.Write("Student adress: ");
                newStudent.Adress = Console.ReadLine();
                Console.Write("Student phone: ");
                newStudent.Phone = int.Parse(Console.ReadLine());
                Console.WriteLine("Add another? y/n");
                students.Add(newStudent);
                if (Console.ReadLine() != "y")
                    adding = false;
            }

            foreach (var student in students)

            {
                Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}, Birthday: {student.Birthday}, Adress: {student.Adress}");
            }
        }

    }
    class Student
    {
        static public int count;
        public string Name;
        public int Grade;
        public string Birthday;
        public string Adress;
        private int phone;

        public int Phone
        {
            set { phone = value; }
        }
        public void SetPhone(int number)
        {
            phone = number;
        }


    }
}
