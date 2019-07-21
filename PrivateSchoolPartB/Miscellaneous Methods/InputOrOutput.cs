using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartB
{
    public class InputOrOutput
    {
        public static void UserInputOrOutput(bool valid, out int number)
        {
            number = 0;
            do
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("*******************************************************************************");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(" Hello, PRESS '1' FOR USER INPUT, '2' TO VIEW DATA or '3' TO ENROLL A STUDENT !");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("*******************************************************************************");
                    Console.ForegroundColor = ConsoleColor.Red;
                    number = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();

                    if (number == 1 || number == 2 || number == 3)
                    {
                        for (int i = 0; i < 25; i++) { Console.WriteLine(); }
                        Music.Beep();
                        valid = false;
                    }                      
                    else
                        Console.WriteLine("Wrong Answer!");                       
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong Answer!");
                }
                finally
                {

                }

            } while (valid);
        }
    }
}
