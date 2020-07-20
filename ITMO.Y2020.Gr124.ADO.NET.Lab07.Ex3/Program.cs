using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.Y2020.Gr124.ADO.NET.Lab07.Ex3
{
    class Program
    {
        static void Main(string[] args)
        {

            // MyProcedure3();
            // MyProcedure5();
            // MyProcedure6();
            //MyProcedure7();
            MyProcedure8();
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


        public class Student
        {
            public string First { get; set; }
            public string Last { get; set; }
            public int ID { get; set; }
            public List<int> Scores;
        }

        public static void MyProcedure3()
        {
            var studentQuery3 =
            from student in students
            group student by student.Last[0] into studentGroup
            orderby studentGroup.Key
            select studentGroup;

            foreach (var groupOfStudents in studentQuery3)
            {
                Console.WriteLine(groupOfStudents.Key);
                foreach (var student in groupOfStudents)
                {
                    Console.WriteLine("   {0}, {1}",
                        student.Last, student.First);
                }
            }

            Console.WriteLine(" Нажмите 'Enter'");
            Console.ReadLine();
        }



        public static void MyProcedure5()
        {
            var studentQuery5 =
            from student in students
            let totalScore = student.Scores[0] + student.Scores[1] +
            student.Scores[2] + student.Scores[3]
            where totalScore / 4 < student.Scores[0]
            select student.Last + " " + student.First;

            foreach (string s in studentQuery5)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(" Нажмите 'Enter'");
            Console.ReadLine();
            }

    public static void MyProcedure6()
            { 
            var studentQuery6 =
            from student in students
            let totalScore = student.Scores[0] + student.Scores[1] +
            student.Scores[2] + student.Scores[3]
            select totalScore;

            double averageScore = studentQuery6.Average();
            Console.WriteLine("Class average score = {0}", averageScore);

            Console.WriteLine(" Нажмите 'Enter'");
            Console.ReadLine();
            }

        public static void MyProcedure7()
        {
            IEnumerable<string> studentQuery7 =
                from student in students
                where student.Last == "Garcia"
                select student.First;

            Console.WriteLine("The Garcias in the class are:");
            foreach (string s in studentQuery7)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(" Нажмите 'Enter'");
            Console.ReadLine();
        }

        public static void MyProcedure8()
        {
            //IEnumerable<string> studentQuery8 =
            //    from student in students
            //    where student.Last == "Garcia"
            //    select student.First;

            //Console.WriteLine("The Garcias in the class are:");
            //foreach (string s in studentQuery8)
            //{
            //    Console.WriteLine(s);
            //}
            
            //variable average from 6th task
            var studentQuery6 =
            from student in students
            let totalScore = student.Scores[0] + student.Scores[1] +
            student.Scores[2] + student.Scores[3]
            select totalScore;

            double averageScore = studentQuery6.Average();
            // end from 6th

            var studentQuery8 =
               from student in students
               let x = student.Scores[0] + student.Scores[1] +
                   student.Scores[2] + student.Scores[3]
               where x > averageScore
               select new { id = student.ID, score = x };

            foreach (var item in studentQuery8)
            {
                Console.WriteLine("Student ID: {0}, Score: {1}", item.id,
            item.score);
            }

            Console.WriteLine(" Нажмите 'Enter'");
            Console.ReadLine();

            // result
            //Student ID: 111, Score: 330
            //Student ID: 113, Score: 338
            //Student ID: 114, Score: 353
            //Student ID: 111, Score: 331
            //Student ID: 113, Score: 338
            //Student ID: 114, Score: 353

        }

    }
}
