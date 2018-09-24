using System;
using System.Collections.Generic;

namespace ScoolTracker
{
    enum School
    {
        Hogwarts,
        Harvard,
            MIT
    }
    class Program
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
           
            

            var adding = true;
            while (adding)
            {
                try
                {
                    var newStudent = new Student();
                    newStudent.Name = Util.Console.Asc("StudentName: ");
                    newStudent.Grade = Util.Console.AskInt("Student Grade: ");
                    newStudent.School = (School) Util.Console.AskInt("School Name: (type corresponding number: \n 0: Hogwarts Hight \n 1: Harvard \n 2: MIT \n)");
                    newStudent.Birthday = Util.Console.Asc("Student Birthday: ");
                    newStudent.Adress = Util.Console.Asc("Student adress: ");
                    newStudent.Phone = Util.Console.AskInt("Student Phone: ");
                    Console.WriteLine("Add another? y/n");
                    students.Add(newStudent);
                    Student.Count++;
                    Console.WriteLine($"Student count: {Student.Count}");
                    if (Console.ReadLine() != "y")
                        adding = false;
                }
              
                catch (FormatException msg)
                {
                    Console.WriteLine(msg.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error adding student, Please try again");
                } 

            }

            foreach (var student in students)

            {
                Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}, Birthday: {student.Birthday}, Adress: {student.Adress}");
            }
            Exports();
        }
        static void Import()
        {
            var importedStudent = new Student("Jenny", 86, "birthday", "adress", 123456);
            Console.WriteLine(importedStudent.Name);
        }
        static void Exports()
        {
            foreach (var student in students)
            {
                switch (student.School)
                {
                    case School.Hogwarts:
                        Console.WriteLine("Exporting to Hogwarsd");
                        break;
                    case School.Harvard:
                        Console.WriteLine("Exporting to Harvard");
                        break;
                    case School.MIT:
                        Console.WriteLine("Exporting to MIT");
                        break;
                    //default:
                        //break;
                }
            }
        }
    }
    class Student :Member
    {
        static public int Count;
        public int Grade;
        public string Birthday;
        public School School; 
        public Student()
        {
        }
        public Student(string name, int grade, string birthday, string adress, int phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Adress = adress;
            Phone = phone;
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
    class Member
    {
        public string Name;
        public string Adress;
        protected int phone;
    } 
    class Teacher :Member
    {
      public string Subject;
        public int Phone
        {
            set { phone = value; }
        }
    }
     
    

}
