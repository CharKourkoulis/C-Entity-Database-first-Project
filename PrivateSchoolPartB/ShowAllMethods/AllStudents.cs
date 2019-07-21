using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartB
{
    public class AllStudents
    {
        public static void Show()
        {
            privateschoolEntities dbContex = new privateschoolEntities();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("List of All Students");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------+----------------+----------------------+----------------------+-----------------+-");
            Console.WriteLine("{0,-10} | {1,-16} | {2,-20 } | {3,-20} | {4,-15} ", "student ID", "First Name", "Last Name", "Date of Birth", "Tuition Fees");
            Console.WriteLine("----------+----------------+----------------------+----------------------+-----------------+-");
            Console.ForegroundColor = ConsoleColor.White;
            var studs = dbContex.students.OrderBy(s => s.firstname).ThenBy(l => l.lastname);
            foreach (var item in studs)
            {
                Console.WriteLine($"{item.id, -10} | {item.firstname,-15 } | {item.lastname,-20} | {item.dateofbirth.ToString("dd/MM/yyyy"),-20} | {item.tuitionfees,-15} ");
            }
            Console.WriteLine("---------+----------------+----------------------+----------------------+-----------------+-");
        }
    }
}
