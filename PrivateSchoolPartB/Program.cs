using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Media;

namespace PrivateSchoolPartB
{
    class Program
    {
        static void Main(string[] args)
        {
            Music.Play();
            AppMessages.WelcomeMessage();
            //To SqlConnection to exw afisei se periptwsi pou thelame na syndethoume stin vasi me sql connection.
            //ISqlConnection sql = SqlServerConnection.ConnectionEstablisher;
            
            bool valid = true;
            int number;
            InputOrOutput.UserInputOrOutput(valid, out number);
                    
            switch (number)
            {
                case 1:
                    //Insert Data.                    
                    AppMessages.CreateCourseMessage();
                    MultipleCourseDataCapture inputcourses = new MultipleCourseDataCapture();
                    inputcourses.MultipleCourseInput();
                    MultipleAssignmentDataCapture assignments = new MultipleAssignmentDataCapture();
                    assignments.MultipleAssignmentInput();
                    MultipleTrainerDataCapture trainers = new MultipleTrainerDataCapture();
                    trainers.MultipleTrainerInput();
                    MultipleStudentDataCapture students = new MultipleStudentDataCapture();
                    students.MultipleStudentInput();

                    AppMessages.EndMessage();
                    break;
                case 2:                  
                    //show data. 
                    AllCourses.Show();
                    AllAssignments.Show();
                    AllTrainers.Show();
                    AllStudents.Show();
                    StudentsPerCourse.Show();
                    TrainersPerCourse.Show();
                    AssignmentsPerCourse.Show();                 
                    AssignmentsPerCoursePerStudent.Show();
                    StudentWithMoreCourses.Show();

                    AppMessages.ThanksMessage();
                    Console.Read();
                    break;
                case 3:
                    //Enroll a Student in another Course.
                    InputStudentToManyCourses.Now();
                    AppMessages.EnrollMessage();
                    break;

                default:
                    break;
            }                     
        }
    }
}
