using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartB
{
    class StudentDataCapture
    {
        public InputStudent InputStudent { get; set; }

        public StudentDataCapture()
        {
            InputStudent = new InputStudent();
        }

        public students Capture()
        {
            InputStudent.Input();
            return InputStudent.Student;
        }
    }
}
