using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartB
{
    class OutputAssignment
    {
        public void Show(assignments assignment)
        {
            Console.WriteLine($"{assignment.title,-20} | {assignment.description,-30} | {assignment.subdatetime.ToString("dd/MM/yyyy"),-20} | {assignment.oralmark,-10} | {assignment.totalmark,-12} |");
        }
    }
}

