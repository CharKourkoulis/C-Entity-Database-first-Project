using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartB
{
    class InputStudentToManyCourses
    {
        public static void Now()
        {                
            Console.ForegroundColor = ConsoleColor.Yellow;
            AppMessages.EnrollHiMessage();
            for (int i = 0; i < 10; i++) { Console.WriteLine(); }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("++++++++++ INPUT STUDENT TO ANOTHER COURSE +++++++++++");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Do you want to input a Student into another Course? ");
            Console.WriteLine(" Press 'NO' or 'no' to exit or ENTER to Continue!");
            Console.ForegroundColor = ConsoleColor.White;
            privateschoolEntities dbContex = new privateschoolEntities();          

            string value = Console.ReadLine();
            if (value == "NO" || value == "No" || value == "no")
                return;
            Console.WriteLine("COURSES: ");
            foreach (var item in dbContex.courses)
            {
                Console.WriteLine($" {item.id,-5}  |  {item.title} ");
            }
            Console.WriteLine();
            Console.WriteLine("STUDENTS:  ");
            foreach (var student1 in dbContex.students)
            {
                Console.WriteLine($" { student1.id,-5} | {student1.firstname}  {student1.lastname}");
            }
            Console.WriteLine();
                      
            bool validd = true;
            do
            {
                try
                {
                    Console.WriteLine("which Student do you want to select ??? (type student ID!): ");
                    int studentid = Convert.ToInt32(Console.ReadLine());
                    //
                    var studentExists = dbContex.students.Any(s => s.id == studentid);
                    if (!studentExists) throw new Exception("The Student ID you typed doesn't Exist !!!");        
                    //
                    students student = dbContex.students.First(s => s.id == studentid);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"You Selected the Student {student.firstname.ToString().ToUpper()} {student.lastname.ToString().ToUpper()} with ID: {student.id}");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    //
                    Console.WriteLine("Which Course do you want him/her to Enroll to???? (TYPE A COURSE ID!!)");
                    int courseid = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    //
                    courses course = dbContex.courses.First(c => c.id == courseid);
                        student.courses.Add(course);

                        foreach (var assign in course.assignments)
                        {
                            student.assignments.Add(assign);
                        }
                        course.students.Add(student);
                        dbContex.SaveChanges();
                                               
                       Console.WriteLine($"You successfully added {student.firstname} {student.lastname} to another Course !!! ");
                       validd = false;                    
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong ID please try again!!!");
                }

            } while (validd);
        }
    }
}
