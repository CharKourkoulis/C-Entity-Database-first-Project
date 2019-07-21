using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartB
{
    class AllTrainers
    {     
        public static void Show()
        {
            privateschoolEntities dbContex = new privateschoolEntities();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("List of All Trainers                                              ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------+----------------------+--------------------------------+----------------+");
            Console.WriteLine("{0,-16}| {1,-20 } | {2,-30} | {3,-15}", "First Name", "Last Name", "Subject", "Teaching Course");
            Console.WriteLine("----------------+----------------------+--------------------------------+----------------+");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var item in dbContex.trainers)
            {
                Console.WriteLine($"{item.firstname,-15 } | {item.lastname,-20} | {item.subject,-30} | {item.courses.title,-15}");
            }
            Console.WriteLine("----------------+----------------------+--------------------------------+----------------+");
        }
    }
}
