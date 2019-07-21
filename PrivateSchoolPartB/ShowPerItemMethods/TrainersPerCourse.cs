using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartB
{
    class TrainersPerCourse
    {
        public static void Show()
        {
            privateschoolEntities dbContex = new privateschoolEntities();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("++++++++++ TRAINERS PER COURSE +++++++++ ");
            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach (var course in dbContex.courses)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Course  {course.title}  Has {course.trainers.Count}  Trainers:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("----------------+----------------------+----------------------+-----------------+--------------------+");
                Console.WriteLine("{0,-16}| {1,-20 } | {2,-20} | {3,-15} | {4,-20}  ", "First Name", "Last Name", "Teaching Subject", "Trainer ID", "Teaching Course");
                Console.WriteLine("----------------+----------------------+----------------------+-----------------+--------------------+");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var item in course.trainers)
                {
                    Console.WriteLine($"{item.firstname,-15 } | {item.lastname,-20} | {item.subject,-15} | {item.id,-15} | {item.courses.title,-20} ");
                }
                Console.WriteLine("----------------+----------------------+----------------------+-----------------+--------------------+");
            }
        }
    }
}
