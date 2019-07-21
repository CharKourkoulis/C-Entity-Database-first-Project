using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartB
{
    public class AllCourses
    {
        public static void Show()
        {
            privateschoolEntities dbContex = new privateschoolEntities();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("List of All Courses                                              ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------------+-----------------+------------+------------+------------+-----------+");
            Console.WriteLine("{0,-23}| {1,-15 } | {2,-10} | {3,9}  | {4,-9} | {5,-10}", "Title", "Type", "Stream", "Start Date", "End Date", "Course ID");
            Console.WriteLine("----------------------+-----------------+------------+------------+------------+-----------+");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in dbContex.courses)
            {
                Console.WriteLine($" {item.title,-20 } | {item.type,-15} | {item.stream,-10} | {item.start_date.ToString("dd/MM/yyyy"),-10} | {item.end_date.ToString("dd/MM/yyyy"),-9} | {item.id,-4} ");
            }
            Console.WriteLine("----------------------+-----------------+------------+------------+------------+-----------+");
        }
    }
}
