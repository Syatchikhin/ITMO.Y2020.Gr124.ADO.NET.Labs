using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.Y2020.Gr124.ADO.NET.Lab07.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Student> studentQuery =
            from student in students
            //where //student.Scores[0] > 90 && student.Scores[3] < 80
            where student.Scores[0] > 90
            //var studentQueryW = students.Where(st => st.Scores[0] > 90 &&
            //st.Scores[3] < 80);
            select student;

            foreach (Student student in studentQuery)
            {
                Console.WriteLine("{0}, {1}", student.Last, student.First);
            }

            //
            int studentCount = (
                from student in students
                where student.Scores[0] > 70 && student.Scores[3] < 80
                orderby student.Last ascending //new row
                select student).Count();

            int studentCountW = students.Where(st => st.Scores[0] > 90
            && st.Scores[3] < 80).Count();

            Console.WriteLine("Количество студентов: {0}, {1}", studentCount,
            studentCountW);

            var studentList = (
                from student in students
                where student.Scores[0] > 90 && student.Scores[3] < 80
                //orderby student.Last ascending
                orderby student.Scores[0] descending
                select student).ToList();

            foreach (Student student in studentList)
            {
                Console.WriteLine("{0}, {1} {2}", student.Last, student.First,
                student.Scores[0]);
            }

            var studentQuery2 =
            from student in students
            group student by student.Last[0];

            foreach (var studentGroup in studentQuery2)
            {
                Console.WriteLine(studentGroup.Key);
                foreach (Student student in studentGroup)
                {
                    Console.WriteLine("   {0}, {1}",
                              student.Last, student.First);
                }
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
           new Student {First="Marina", Last="Mainefrau", ID=111,
            Scores= new List<int> {98, 92, 81, 60}},
           new Student {First="Konstantin", Last="Sidoroff", ID=112,
            Scores= new List<int> {75, 84, 91, 39}},
           new Student {First="Sven", Last="Minnerup", ID=113, Scores=
            new List<int> {88, 94, 65, 91}},
           new Student {First="Ivanna", Last="Sun", ID=114, Scores=
            new List<int> {97, 89, 85, 82}},
           new Student {First="Sergey", Last="Labor", ID=115, Scores=
            new List<int> {35, 72, 91, 70}},



        };


    }
}
