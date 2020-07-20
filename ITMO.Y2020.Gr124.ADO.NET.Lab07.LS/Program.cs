using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Core.dll;


namespace ITMO.Y2020.Gr124.ADO.NET.Lab07.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Student> studentQuery =
            from student in students
            where student.Scores[0] > 90
            select student;

            foreach (Student student in studentQuery)
            {
                Console.WriteLine("{0}, {1}", student.Last, student.First);
            }


            Console.WriteLine(" Нажмите 'Enter'");
            Console.ReadLine();

        }

        public class Student
        {
            public string First { get; set; }
            public string Last { get; set; }
            public int ID { get; set; }
            public List<int> Scores;
        }

        static List<Student> students = new List<Student>
        {
           new Student {First="Svetlana", Last="Omelchenko", ID=111,
            Scores= new List<int> {97, 92, 81, 60}},
           new Student {First="Claire", Last="O’Donnell", ID=112,
            Scores= new List<int> {75, 84, 91, 39}},
           new Student {First="Sven", Last="Mortensen", ID=113, Scores=
            new List<int> {88, 94, 65, 91}},
           new Student {First="Cesar", Last="Garcia", ID=114, Scores=
            new List<int> {97, 89, 85, 82}},
           new Student {First="Debra", Last="Garcia", ID=115, Scores=
            new List<int> {35, 72, 91, 70}},
        };


    }
}
