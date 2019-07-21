using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartB
{
    class InputAssignment
    {
        public assignments  Assignment { get; set; }


        public InputAssignment()
        {
            Assignment = new assignments();
        }

        public void InputID()
        {
            privateschoolEntities dbContex = new privateschoolEntities();
            bool valid = true;
            do
            {
                try
                {
                    Console.WriteLine(" Type the ID of the Assignment:  ");
                    Assignment.id = Convert.ToInt32(Console.ReadLine());

                    var assignExists = dbContex.assignments.Any(a => a.id == Assignment.id);

                    if (assignExists)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The Assignment ID already exists !!! ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    else
                        valid = false;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Type a correct ID !!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                }


            } while (valid);

        }



        public void InputTitle()
        {
            Console.WriteLine("Type the Assignment Title:  ");
            Assignment.title = Console.ReadLine();
        }

        public void InputDescription()
        {
            Console.WriteLine("Type the Assignment Description:  ");
            Assignment.description = Console.ReadLine();
        }

        public void InputSubDate()
        {
            bool valid = true;
            do
            {
                try
                {
                    Console.WriteLine("Type when the Assignment will have to be submitted e.g (14/5/2019):  ");

                    if (DateTime.TryParse(Console.ReadLine(), out DateTime subDate))
                    {
                        if (subDate >= DateTime.Now)
                        {
                            Assignment.subdatetime = subDate;
                            valid = false;
                        }
                    }
                    else
                        Console.WriteLine("Invalid Date, Please Try Again  ");
                }
                catch (Exception)
                {
                    Console.WriteLine("Type a correct Date !!!");
                }

            } while (valid);

        }

        public void InputOralMark()
        {
            Console.WriteLine("Type the Oral Mark:  ");
            Assignment.oralmark = Convert.ToInt32(Console.ReadLine());
        }

        public void InputTotalMark()
        {
            Console.WriteLine("Type the Total Mark:  ");
            Assignment.totalmark = Convert.ToInt32(Console.ReadLine());
        }


        public void InputCourseID()
        {
            privateschoolEntities dbContex = new privateschoolEntities();
            bool valid = true;
            do
            {
                try
                {
                    Console.WriteLine("Type the ID of the COURSE of the Assignment:  ");
                    Assignment.courseid = Convert.ToInt32(Console.ReadLine());

                    var courseExists = dbContex.courses.Any(c => c.id == Assignment.courseid);

                    if (!courseExists)
                    {
                        Console.WriteLine("The course ID you typed doesn't Exist !!!");
                    }
                    else
                    { 
                    Console.WriteLine($"You successfully added the assignment to Course with ID:  {Assignment.courseid}  !!! ");
                    valid = false;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Type a Correct Course ID !!!");
                }


            } while (valid);

        }


        public void Input()
        {
            InputID();
            InputTitle();
            InputDescription();
            InputSubDate();
            InputOralMark();
            InputTotalMark();
            InputCourseID();
        }

    }
}
