using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartB
{
    class MultipleStudentDataCapture
    {
        public void MultipleStudentInput()
        {
            
            bool valid = true;
            do
            {              
                AddStudentToCourses.Enroll();
                Music.EndBeep();
                Console.WriteLine();                  
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("STUDENT HAS BEEN CREATED");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Do you want to create another Student?  Press 'NO' or 'no' to exit.");
                Console.WriteLine("Type anything else to continue creating another Student");
                Console.ForegroundColor = ConsoleColor.White;
                string value = Console.ReadLine();

                if (value == "NO" || value == "No" || value == "no")
                    valid = false;

            } while (valid);
        }
    }
}
