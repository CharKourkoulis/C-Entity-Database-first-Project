using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartB
{
    public class OutputStudent
    {
        #region //METHODOI OUTPUT////////////////
        public void Output(students student)
        {
            OutputFirstName(student);
            OutputLastName(student);
            OutputDateOfBirth(student);
            OutputTuitionFees(student);

        }

        public void OutputFirstName(students student)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{student.firstname}  ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void OutputLastName(students student)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{student.lastname}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void OutputDateOfBirth(students student)
        {
            Console.WriteLine($" Date of Birth: {student.dateofbirth.ToString("dd/MM/yyyy")} ");
        }

        public void OutputTuitionFees(students student)
        {
            Console.WriteLine($"Tuition Fees: {student.tuitionfees} euro");
        }
        #endregion

        public void Show(students student)
        {
            Console.WriteLine($"{student.firstname,-15 } | {student.lastname,-20} | {student.dateofbirth.ToString("dd/MM/yyyy"),-20} | {student.tuitionfees,-15} | ");
        }
    }
}
