using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartB
{
    class AssignmentsPerCoursePerStudent
    {
        public static void Show()
        {

            privateschoolEntities dbContex = new privateschoolEntities();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("++++++++++ ASSIGNMENTS PER COURSE PER STUDENT +++++++++ ");
            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach (var student in dbContex.students)
            {

                var courseAsssingments = student.assignments.Join(student.courses,
                                                            a => a.courseid,
                                                            c => c.id,
                                                            (assignment, course) => new
                                                            {
                                                                assignmentname = assignment.title,
                                                                assignmentdescription = assignment.description,
                                                                assignmentDate = assignment.subdatetime,
                                                                courseid = course.id,
                                                                courseTitle = course.title
                                                            });
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Student  {student.firstname}  {student.lastname}  Has to submit the following assignments per course:");
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("---------------------+--------------------------------+----------------------+------------+-------------------+");
                Console.WriteLine("{0,-21}| {1,-30 } | {2,-20} | {3,-9}  | {4,-12} ", "Assignment Title", "Assignment Description", "Submission Date", "Course ID", "Course Title");
                Console.WriteLine("---------------------+--------------------------------+----------------------+------------+-------------------+");
                Console.ForegroundColor = ConsoleColor.White;

                foreach (var item in courseAsssingments)
                {
                    Console.WriteLine($"{item.assignmentname,-20} | {item.assignmentdescription,-30} | {item.assignmentDate.ToString("dd/MM/yyyy"),-20} | {item.courseid,-10} | {item.courseTitle,-20}");
                }
                Console.WriteLine("---------------------+--------------------------------+----------------------+------------+-------------------+");
            }
        }
    }
}
