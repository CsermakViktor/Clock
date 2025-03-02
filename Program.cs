using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class Program
    {
            public static int windowwidth = Console.WindowWidth;
        public static int windowheight = Console.WindowHeight;

        static async Task Main(string[] args)
        {
            Clock.Border.clockboarder();
            while (true)
            {
                int hour = DateTime.Now.Hour;
                int minute = DateTime.Now.Minute;
                int second = DateTime.Now.Second;
                int width = windowwidth;
                int height = windowheight;
                Console.SetCursorPosition(windowwidth / 2 - 3, windowheight / 2 - 1);
                await Task.Delay(1000);
                Console.CursorVisible = false;
                Clock.digits.digital(hour, minute, second, windowwidth, windowheight);
            }
        }
    }
}