using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartB
{
    public class AppMessages
    {
        public static void EndMessage()
        {
            Console.WriteLine();
            Console.WriteLine(" ALL DATA HAS BEEN CREATED. PLEASE RUN AGAIN THE PROGRAM AND PRESS 2 TO VIEW ALL DATA");
        }

        public static void ThanksMessage()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine(" ░▒▓▚ YOU HAVE SEEN ALL DATA!  THANKS FOR USING THIS APP !!!  ░▒▓▚");
        }

        public static void EnrollMessage()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine(" ░▒▓▚  !!! THANKS FOR USING THIS APP !!!  ░▒▓▚");
        }

        public static void WelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string text = @".______   .______       __  ____    ____  ___   .___________. _______ 
|   _  \  |   _  \     |  | \   \  /   / /   \  |           ||   ____|
|  |_)  | |  |_)  |    |  |  \   \/   / /  ^  \ `---|  |----`|  |__   
|   ___/  |      /     |  |   \      / /  /_\  \    |  |     |   __|  
|  |      |  |\  \----.|  |    \    / /  _____  \   |  |     |  |____ 
| _|      | _| `._____||__|     \__/ /__/     \__\  |__|     |_______|
                                                                      
     _______.  ______  __    __    ______     ______    __      
    /       | /      ||  |  |  |  /  __  \   /  __  \  |  |     
   |   (----`|  ,----'|  |__|  | |  |  |  | |  |  |  | |  |     
    \   \    |  |     |   __   | |  |  |  | |  |  |  | |  |     
.----)   |   |  `----.|  |  |  | |  `--'  | |  `--'  | |  `----.
|_______/     \______||__|  |__|  \______/   \______/  |_______|
                                                                ";            
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void EnrollHiMessage()
        {
            string text = @" _____ _             _            _    
/  ___| |           | |          | |   
\ `--.| |_ _   _  __| | ___ _ __ | |_  
 `--. \ __| | | |/ _` |/ _ \ '_ \| __| 
/\__/ / |_| |_| | (_| |  __/ | | | |_  
\____/ \__|\__,_|\__,_|\___|_| |_|\__| 
                                       
                                       
 _____                _ _              
|  ___|              | | |             
| |__ _ __  _ __ ___ | | | ___ _ __    
|  __| '_ \| '__/ _ \| | |/ _ \ '__|   
| |__| | | | | | (_) | | |  __/ |      
\____/_| |_|_|  \___/|_|_|\___|_|      
                                     ";

            Console.WriteLine(text);
        }

        public static void CreateCourseMessage()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            string text = @"    _____ _____ _   _______  _____ _____   
   /  __ \  _  | | | | ___ \/  ___|  ___|  
   | /  \/ | | | | | | |_/ /\ `--.| |__    
   | |   | | | | | | |    /  `--. \  __|   
   | \__/\ \_/ / |_| | |\ \ /\__/ / |___   
    \____/\___/ \___/\_| \_|\____/\____/   
                                           
                                           
 _____ ______ _____  ___ _____ ___________ 
/  __ \| ___ \  ___|/ _ \_   _|  _  | ___ \
| /  \/| |_/ / |__ / /_\ \| | | | | | |_/ /
| |    |    /|  __||  _  || | | | | |    / 
| \__/\| |\ \| |___| | | || | \ \_/ / |\ \ 
 \____/\_| \_\____/\_| |_/\_/  \___/\_| \_|
                                           ";

            Console.WriteLine(text);
            for (int i = 0; i < 11; i++) { Console.WriteLine(); }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
