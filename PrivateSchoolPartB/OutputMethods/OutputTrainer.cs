using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartB
{
    class OutputTrainer 
    {
        public void Show(trainers trainer)
        {
            Console.WriteLine($"{trainer.firstname,-15 } | {trainer.lastname,-20} | {trainer.subject,-30} |");
        }
    }
}
