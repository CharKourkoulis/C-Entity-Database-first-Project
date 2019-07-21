using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartB
{
    class AssignmentDataCapture
    {
        public InputAssignment InputAssignment { get; set; }

        public AssignmentDataCapture()
        {
            InputAssignment = new InputAssignment();
        }

        public assignments Capture()
        {
            InputAssignment.Input();
            return InputAssignment.Assignment;
        }
    }
}
