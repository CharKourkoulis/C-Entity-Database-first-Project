using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartB
{
    public class AllAssignments
    {
        public static void Show()
        {
            privateschoolEntities dbContex = new privateschoolEntities();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("List of All Assignments                                              ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------+--------------------------------+----------------------+------------+--------------+-----------------+");
            Console.WriteLine("{0,-21}| {1,-30 } | {2,-20} | {3,-9}  | {4,-12} | {5,-10} ", "Title", "Description", "Submission Date", "Oral Mark", "Total Mark", "Course Name");
            Console.WriteLine("---------------------+--------------------------------+----------------------+------------+--------------+-----------------+");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in dbContex.assignments)
            {
               Console.WriteLine($"{item.title,-20} | {item.description,-30} | {item.subdatetime.ToString("dd/MM/yyyy"),-20} | {item.oralmark,-10} | {item.totalmark,-12} | {item.courses.title,-10}");
            }
            Console.WriteLine("---------------------+--------------------------------+----------------------+------------+--------------+-----------------+");
        }
    }
}
