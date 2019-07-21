using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace PrivateSchoolPartB
{
    public class Music
    {

        public static void Play()
        {
            using (SoundPlayer snd = new SoundPlayer("StrangerThings.wav")) snd.PlayLooping();
        }

        public static void Beep()
        {
            int frequency = 1050;
            Console.Beep(frequency, 150);
            frequency = 1550;
            Console.Beep(frequency, 200);
        }


        public static void EndBeep()
        {
            int frequency = 1550;
            Console.Beep(frequency, 100);
            frequency = 1050;
            Console.Beep(frequency, 100);
            frequency = 850;
            Console.Beep(frequency, 100);
        }

    }
}
