using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartB
{
    class CourseDataCapture
    {
        public InputCourse InputCourse { get; set; }

        public CourseDataCapture()
        {
            InputCourse = new InputCourse();
        }

        public courses Capture()
        {
         InputCourse.Input();
         return InputCourse.Course;                        
        }
    }
}
