using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartB
{
    class InputTrainer
    {

        public trainers Trainer { get; set; }


        public InputTrainer()
        {
            Trainer = new trainers();
        }


        public void InputID()
        {
            privateschoolEntities dbContex = new privateschoolEntities();
            bool valid = true;
            do
            {
                try
                {
                    Console.WriteLine(" Type the Trainer ID:  ");
                    Trainer.id = Convert.ToInt32(Console.ReadLine());

                    var trainerExists = dbContex.trainers.Any(t => t.id == Trainer.id);

                    if (trainerExists)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("The Trainer ID already exists !!! ");
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
            Console.WriteLine(" Type Trainer's First Name:  ");
            Trainer.firstname = Console.ReadLine();
        }

        public void InputLastName()
        {
            Console.WriteLine(" Type Trainer's Last Name:  ");
            Trainer.lastname = Console.ReadLine();

        }

        public void InputSubject()
        {
            Console.WriteLine(" Type Teaching Subject:  ");
            Trainer.subject = Console.ReadLine();
        }

        public void InputCourseID()
        {
            privateschoolEntities dbContex = new privateschoolEntities();
            bool valid = true;
            do
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" Type the ID of the COURSE of the Trainer:  ");
                    Trainer.courseid = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    var trainerExists = dbContex.courses.Any(c => c.id == Trainer.courseid);

                    if (!trainerExists)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("The course ID you typed doesn't Exist !!!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"You successfully added the assignment to Course with ID:  {Trainer.courseid}  !!! ");
                        Console.ForegroundColor = ConsoleColor.White;
                        valid = false;
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Type a Correct Course ID !!!");
                    Console.ForegroundColor = ConsoleColor.White;
                }


            } while (valid);

        }

        public void Input()
        {
            InputID();
            InputFirstName();
            InputLastName();
            InputSubject();
            InputCourseID();
        }


    }
}
