using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartB
{
    class TrainerDataCapture
    {
        public InputTrainer InputTrainer { get; set; }

        public TrainerDataCapture()
        {
            InputTrainer = new InputTrainer();
        }

        public trainers Capture()
        {
            InputTrainer.Input();
            return InputTrainer.Trainer;
        }
    }
}
