﻿using System;
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
                try
                {
                    var newStudent = new Student();
                    newStudent.Name = Util.Console.Asc("StudentName: ");
                    newStudent.Grade = Util.Console.AskInt("Student Grade: ");
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
        }

    }
    class Student :Member
    {
        static public int Count;
        public int Grade;
        public string Birthday;
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
