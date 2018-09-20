using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentNames = new List<string>();
            var studentGrades = new List<int>();
            var student = new Student();
            student.Name = Console.ReadLine();
            Console.Write(student.Name);
            var adding = true;
            while (adding)
            {
                Console.Write("StudentName: ");
                studentNames.Add(Console.ReadLine());

                Console.Write("StudentGrade ");
                studentGrades.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine("Add another? y/n");
                if (Console.ReadLine() != "y")
                    adding = false;
            }

            for (int i = 0; i < studentNames.Count; i++)
            {
                //Console.WriteLine("Name: {0}, Grade: {1}", studentNames[i], studentGrades[i]);
                Console.WriteLine($"Name: {studentNames[i]}, Grade: {studentGrades[i]}");
            }
        }
        
    }
    class Student
    {
        public string Name;
        public int Grade;
        public string Birthday;
        public string Adress;
        public int Phone;
        
    }
}
