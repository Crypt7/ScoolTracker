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
                newStudent.Name=Util.Console.Asc("StudentName: ");
                newStudent.Grade = int.Parse(Util.Console.Asc("Student Grade: "));
                newStudent.Birthday = Util.Console.Asc("Student Birthday: ");
                newStudent.Adress = Util.Console.Asc("Student adress: ");
                newStudent.Phone = int.Parse(Util.Console.Asc("Student Phone: "));
                Console.WriteLine("Add another? y/n");
                students.Add(newStudent);
                Student.Count++;
                Console.WriteLine($"Student count: {Student.Count}");
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
        static public int Count;
        public string Name;
        public int Grade;
        public string Birthday;
        public string Adress;
        private int phone;
        public Student()
        {
            Console.WriteLine("Constructor");
        }
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
