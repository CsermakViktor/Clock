using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Clock.Border.clockboarder();
            while (true)
            {
                int hour = DateTime.Now.Hour;
                int minute = DateTime.Now.Minute;
                int second = DateTime.Now.Second;
                int windowwidth = Console.WindowWidth;
                int windowheight = Console.WindowHeight;

                Console.SetCursorPosition(windowwidth/2-3, windowheight/2-1);    
                Console.WriteLine($"{hour:D2}:{minute:D2}:{second:D2}");
                await Task.Delay(1000);
                Console.CursorVisible = false;

            }
        }
    }
}
