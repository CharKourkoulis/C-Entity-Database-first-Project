using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartB
{
    public class AddStudentToCourses
    {
        public static void Enroll()
        {           
            //List<assignments> assignments = new List<assignments>();
            StudentDataCapture studentCapture = new StudentDataCapture();
            students student = studentCapture.Capture();

                privateschoolEntities dbContex = new privateschoolEntities();               
                try
                {                    
                    Console.WriteLine("which course do you want the student to attend?(type course ID!): ");
                    int studentcourse = Convert.ToInt32(Console.ReadLine());
                 
                    var courseExists = dbContex.courses.Any(c => c.id == studentcourse);
                    bool validd = true;
                    do
                    {

                        if (!courseExists)
                        {
                            Console.WriteLine("The course ID you typed doesn't Exist !!!");
                            validd = false;
                        }
                        else
                        {
                            courses course = dbContex.courses.First(c => c.id == studentcourse);
                            student.courses.Add(course);
                        
                            foreach (var assign in dbContex.assignments)
                            {
                                if (course.assignments.Contains(assign))
                                {
                                  student.assignments.Add(assign);                                  
                                }                             
                            }
                           
                            Console.WriteLine($"You successfully added the Student to Course with ID:  {studentcourse}  !!! ");
                            validd = false;
                        }                       

                    } while (validd);
                }
                catch (Exception)
                {
                    Console.WriteLine("Type a Correct Course ID !!!");
                }
                          
                dbContex.students.Add(student);
                dbContex.SaveChanges();
        }
    }
}
