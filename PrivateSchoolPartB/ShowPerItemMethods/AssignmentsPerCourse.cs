using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartB
{
    class AssignmentsPerCourse
    {
        public static void Show()
        {
            privateschoolEntities dbContex = new privateschoolEntities();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("++++++++++ ASSIGNMENTS PER COURSE +++++++++ ");
            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach (var course in dbContex.courses)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Course  {course.title}  Has {course.assignments.Count}  Assignments:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---------------------+--------------------------------+----------------------+------------+--------------+");
                Console.WriteLine("{0,-21}| {1,-30 } | {2,-20} | {3,-9}  | {4,-12} ", "Title", "Description", "Submission Date", "Oral Mark", "Total Mark");
                Console.WriteLine("---------------------+--------------------------------+----------------------+------------+--------------+");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var item in course.assignments)
                {
                    Console.WriteLine($"{item.title,-20} | {item.description,-30} | {item.subdatetime.ToString("dd/MM/yyyy"),-20} | {item.oralmark,-10} | {item.totalmark,-12}");
                }
                Console.WriteLine("---------------------+--------------------------------+----------------------+------------+--------------+");
            }
        }
    }
}
