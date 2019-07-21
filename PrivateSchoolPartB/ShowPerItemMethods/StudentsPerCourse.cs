using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartB
{
    class StudentsPerCourse
    {
        public static void Show()
        {
            privateschoolEntities dbContex = new privateschoolEntities();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("++++++++++ STUDENTS PER COURSE +++++++++ ");
            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach (var course in dbContex.courses)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Course  {course.title}  Has {course.students.Count}  students:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("----------------+----------------------+----------------------+-----------------+--------------------+");
                Console.WriteLine("{0,-16}| {1,-20 } | {2,-20} | {3,-15} | {4,-15}  ", "First Name", "Last Name", "Date of Birth", "Tuition Fees", "Student ID");
                Console.WriteLine("----------------+----------------------+----------------------+-----------------+--------------------+");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var item in course.students)
                {
                    Console.WriteLine($"{item.firstname,-15 } | {item.lastname,-20} | {item.dateofbirth.ToString("dd/MM/yyyy"),-20} | {item.tuitionfees,-15} | {item.id,-15}  ");
                }
                Console.WriteLine("----------------+----------------------+----------------------+-----------------+--------------------+");
            }
        }
    }
}
