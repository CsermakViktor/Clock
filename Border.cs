using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class Border
    {
        public static void clockboarder()
        {
            int windowwidth = Console.WindowWidth-1;
            int windowheight = Console.WindowHeight-1;
            Console.SetCursorPosition(0, 0);
            Console.Write("╔");
            Console.SetCursorPosition(windowwidth, 0);
            Console.Write("╗");
            Console.SetCursorPosition(0, windowheight);
            Console.Write("╚");
            Console.SetCursorPosition(windowwidth, windowheight);
            Console.Write("╝");
            for (int i = 1; i < windowwidth; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("═");
                Console.SetCursorPosition(i, windowheight);
                Console.Write("═");
            }
            for (int i = 1; i < windowheight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("║");
                Console.SetCursorPosition(windowwidth, i);
                Console.Write("║");
            }
        }
        int borderX;
        int borderY;

    }
}
