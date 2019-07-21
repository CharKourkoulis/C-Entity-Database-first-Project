using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartB
{
    public class StudentWithMoreCourses
    {     
        public static void Show()
        {
            privateschoolEntities dbContex = new privateschoolEntities();

            int counter = 0;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("*******************************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Students enlisted in more than one Courses: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("*******************************************");
            
            foreach (var student in dbContex.students)
            {
                if (student.courses.Count > 1)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"{student.firstname}  {student.lastname}");
                    counter++;
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (counter == 0)
            {
                Console.WriteLine("There aren't any Students Enlisted in more than one Courses.");
                Console.WriteLine();
            }
        }
    }
}
