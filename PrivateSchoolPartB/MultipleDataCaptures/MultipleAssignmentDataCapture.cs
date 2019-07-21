using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartB
{
    class MultipleAssignmentDataCapture
    {
        public void MultipleAssignmentInput()
        {

            bool valid = true;
            do
            {
                AssignmentDataCapture assignmentCapture = new AssignmentDataCapture();
                assignments assignment = assignmentCapture.Capture();

                using (privateschoolEntities dbContex = new privateschoolEntities())
                {
                                    
                    dbContex.assignments.Add(assignment);                    
                    foreach (var student in dbContex.students)
                    {
                        if (student.courses.Contains(assignment.courses))
                        {
                            student.assignments.Add(assignment);
                        }
                    }

                    dbContex.SaveChanges();
                }
                Console.WriteLine();
                Music.EndBeep();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("ASSIGNMENT HAS BEEN CREATED");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Do you want to create another assignment?  Press 'NO' or 'no' to exit.");
                Console.WriteLine("Type anything else to continue creating another Assignment");
                Console.ForegroundColor = ConsoleColor.White;
                string value = Console.ReadLine();

                if (value == "NO" || value == "No" || value == "no")
                    valid = false;

            } while (valid);
        }
    }
}
