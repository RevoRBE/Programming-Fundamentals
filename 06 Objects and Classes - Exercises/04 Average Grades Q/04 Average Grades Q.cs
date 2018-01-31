using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Average_Grades_Q
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade => Grades.Average();
    }
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < num; i++)
            {
                string[] arguments = Console.ReadLine().Split();
                Student student = new Student();
                student.Name = arguments[0];
                student.Grades = arguments.Skip(1).Select(double.Parse).ToList();
                students.Add(student);
            }
            students
                .Where(s => s.AverageGrade >= 5.00)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.AverageGrade)
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.Name} -> {s.AverageGrade:F2}"));
        }
    }
}
