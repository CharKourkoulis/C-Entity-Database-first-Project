using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartB
{
    class MultipleTrainerDataCapture
    {
        public void MultipleTrainerInput()
        {

            bool valid = true;
            do
            {
                TrainerDataCapture trainerCapture = new TrainerDataCapture();
                trainers trainer = trainerCapture.Capture();

                using (privateschoolEntities dbContex = new privateschoolEntities())
                {
                    dbContex.trainers.Add(trainer);
                    dbContex.SaveChanges();
                }
                Console.WriteLine();
                Music.EndBeep();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("TRAINER HAS BEEN CREATED");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Do you want to create another Trainer?  Press 'NO' or 'no' to exit.");
                Console.WriteLine("Type anything else to continue creating another Trainer");
                Console.ForegroundColor = ConsoleColor.White;
                string value = Console.ReadLine();


                if (value == "NO" || value == "No" || value == "no")
                    valid = false;

            } while (valid);
        }
    }
}
