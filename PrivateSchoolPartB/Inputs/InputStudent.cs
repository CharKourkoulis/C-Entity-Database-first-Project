using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartB
{
    class InputStudent
    {
        public students Student { get; set; }


        public InputStudent()
        {
            Student = new students();
        }

        public void InputID()
        {
            privateschoolEntities dbContex = new privateschoolEntities();
            bool valid = true;
            do
            {
                try
                {
                    Console.WriteLine(" Type the Student ID:  ");
                    Student.id = Convert.ToInt32(Console.ReadLine());

                    var studentExists = dbContex.students.Any(t => t.id == Student.id);

                    if (studentExists)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("The Student ID already exists !!! ");
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


        public void InputFirstName()
        {
            Console.WriteLine(" Type Student First Name:  ");
            Student.firstname = Console.ReadLine();
        }

        public void InputLastName()
        {
            Console.WriteLine(" Type Student Last Name:  ");
            Student.lastname = Console.ReadLine();
        }

        public void InputTuitionFees()
        {
            Console.WriteLine(" Type Tuition Fees:  ");
            Student.tuitionfees = Convert.ToInt32(Console.ReadLine());
        }

        public void InputBirthDate()
        {
            bool valid = true;
            do
            {
                Console.WriteLine("Type a valid date of birth e.g (14/5/2019)");

                if (DateTime.TryParse(Console.ReadLine(), out DateTime birthDate))
                {


                    if (birthDate.Year > 2001 || birthDate.Year > 1965)
                    {
                        Student.dateofbirth = birthDate;
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
            InputFirstName();
            InputLastName();
            InputBirthDate();
            InputTuitionFees();
        }


    }
}
