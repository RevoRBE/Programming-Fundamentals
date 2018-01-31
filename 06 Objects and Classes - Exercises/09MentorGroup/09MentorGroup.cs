using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _09MentorGroup
{
    class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> Attendance { get; set; }
        public Student(string name)
        {
            this.Name = name;
            Comments = new List<string>();
            Attendance = new List<DateTime>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var students = new SortedDictionary<string, Student>();
            while (input != "end of dates")
            {
                string[] tolkens = input.Split(new char[] { ' ', ',' });
                string name = tolkens[0];
                if (!students.ContainsKey(name))
                {
                    Student currStudent = new Student(tolkens[0]);
                    for (int i = 1; i < tolkens.Count(); i++)
                    {
                        currStudent.Attendance.Add(DateTime.ParseExact(tolkens[i].Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    }
                    students.Add(name, currStudent);
                }
                else
                {
                    for (int i = 1; i < tolkens.Count(); i++)
                    {
                        students[name].Attendance.Add(DateTime.ParseExact(tolkens[i].Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    }
                }

                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "end of comments")
            {
                string[] tolkens = input.Split(new char[] { '-' });
                string name = tolkens[0];
                if (students.ContainsKey(name))
                    students[name].Comments.Add(tolkens[1].Trim());
                input = Console.ReadLine();
            }
            //PRINT
            foreach (var student in students.Values.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{student.Name}\nComments:");
                if (student.Comments.Count != 0 )
                {
                    foreach (var comment in student.Comments)
                        Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                if (student.Attendance.Count !=0)
                    foreach (var attendence in student.Attendance.OrderBy(x => x))
                        Console.WriteLine($"-- {attendence:dd/MM/yyyy}");
                        //Console.WriteLine($"-- {attendence.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
