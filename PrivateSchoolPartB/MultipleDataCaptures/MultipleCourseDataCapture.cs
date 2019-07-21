using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PrivateSchoolPartB
{
    class MultipleCourseDataCapture
    {
        public void MultipleCourseInput()

        {

            bool valid = true;
            do
            {
                CourseDataCapture courseCapture = new CourseDataCapture();
                courses course = courseCapture.Capture();

                using (privateschoolEntities dbContex = new privateschoolEntities())
                {
                    dbContex.courses.Add(course);
                    dbContex.SaveChanges();
                }
                Music.EndBeep();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("COURSE HAS BEEN CREATED");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Do you want to create another course?  Press 'NO' or 'no' to exit.");
                Console.WriteLine("Type anything else to continue creating another Course");
                Console.ForegroundColor = ConsoleColor.White;
                string value = Console.ReadLine();

                if (value == "NO" || value == "No" || value == "no")
                    valid = false;

            } while (valid);
        }
    }
}
