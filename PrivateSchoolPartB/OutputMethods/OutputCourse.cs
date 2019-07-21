using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartB
{
    class OutputCourse
    {
        public void Show(courses course)
        {
            Console.WriteLine($"{course.title,-5 } | {course.type,-10} | {course.stream,-10} | {course.start_date.ToString("dd/MM/yyyy"),-10} | {course.end_date.ToString("dd/MM/yyyy"),-9} |");
        }
    }
}
