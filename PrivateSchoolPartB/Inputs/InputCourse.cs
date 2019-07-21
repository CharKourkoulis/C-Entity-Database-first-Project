using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartB
{
    public enum Stream { FullTime = 1, PartTime }


    class InputCourse
    {
        public courses Course { get; set; }

        

        public InputCourse()
        {
            Course = new courses();
        }


        public void InputID()
        {
            privateschoolEntities dbContex = new privateschoolEntities();
            bool valid = true;
            do
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("+++++++++< CREATE A NEW COURSE >++++++++++");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" Type the Course ID:  ");
                    Course.id = Convert.ToInt32(Console.ReadLine());

                    var courseExists = dbContex.courses.Any(c => c.id == Course.id);

                    if (courseExists)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("The Course ID already exists !!! ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    else
                        valid = false;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Type a correct ID !!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                }


            } while (valid);

        }

        public void InputTitle()
        {
            Console.WriteLine(" Type the Course Title:  ");
            Course.title = Console.ReadLine();
        }

        public void InputStream()
        {
            bool valid = true;
            do
            {

                try
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Type (a correct value) '1' for FullTime or '2' for PartTime  :");
                    Console.ForegroundColor = ConsoleColor.White;
                    int stream = Convert.ToInt32(Console.ReadLine());
                    if (Enum.IsDefined(typeof(Stream), stream))
                    {
                        Course.stream = Enum.GetName(typeof(Stream), stream);
                        valid = false;
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Wrong Value.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                finally { }

            } while (valid);

        }

        public void InputType()
        {                          
                    Console.WriteLine("Type the Course Type (e.g Java, C#, Python etc):  ");
                    Course.type = Console.ReadLine();

        }

        public void InputStartDate()
        {
            bool valid = true;
            do
            {
                Console.WriteLine("Type when the Course will start e.g (14/5/2019):");

                if (DateTime.TryParse(Console.ReadLine(), out DateTime startDate))
                {
                    if (startDate >= DateTime.Now)
                    {
                        Course.start_date = startDate;
                        valid = false;
                    }
                }
                else
                    Console.WriteLine("Invalid Date, Please Try Again  ");

            } while (valid);

        }

        public void InputEndDate()
        {
            bool valid = true;
            do
            {
                Console.WriteLine("Type when the Course will End e.g (14/5/2019)");

                if (DateTime.TryParse(Console.ReadLine(), out DateTime endDate))
                {


                    if ( Course.start_date < endDate)
                    {
                        Course.end_date = endDate;
                        valid = false;

                    }

                }
                else
                    Console.WriteLine("Invalid Date, Please Try Again  ");

            } while (valid);

        }


        public void Input()
        {
            InputID();
            InputTitle();
            InputType();
            InputStream();
            InputStartDate();
            InputEndDate();
        }



    }
}
