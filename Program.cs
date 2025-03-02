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
                Console.SetCursorPosition(windowwidth / 2 - 3, windowheight / 2 - 1);
                await Task.Delay(1000);
                Console.CursorVisible = false;

                switch (hour)
                {
                    case 0:
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 2);
                        Console.Write("█   █   █   █   ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 1);
                        Console.Write("█   █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2);
                        Console.Write("█   █   █   █   ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;

                    case 1:
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 3);
                        Console.Write("█████       █");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 2);
                        Console.Write("█   █       █   ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 1);
                        Console.Write("█   █       █");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2);
                        Console.Write("█   █       █   ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;

                    case 2:
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 2);
                        Console.Write("█   █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 1);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2);
                        Console.Write("█   █   █      ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 3:
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 2);
                        Console.Write("█   █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 1);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2);
                        Console.Write("█   █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 4:
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 3);
                        Console.Write("█████   █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 2);
                        Console.Write("█   █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 1);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2);
                        Console.Write("█   █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 5:
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 2);
                        Console.Write("█   █   █      ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 1);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2);
                        Console.Write("█   █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 6:
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 2);
                        Console.Write("█   █   █      ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 1);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2);
                        Console.Write("█   █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 7:
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 2);
                        Console.Write("█   █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 1);
                        Console.Write("█   █       █");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2);
                        Console.Write("█   █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 8:
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 2);
                        Console.Write("█   █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 1);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2);
                        Console.Write("█   █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 9:
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 2);
                        Console.Write("█   █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 1);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2);
                        Console.Write("█   █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 10:
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 3);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 1);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 11:
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 3);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 1);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 + 1);
                        Console.Write("    █       █");
                        break;
                    case 12:
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 3);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 1);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2);
                        Console.Write("    █   █      ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 13:
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 3);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 1);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 14:
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 3);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 1);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 + 1);
                        Console.Write("    █       █");
                        break;
                    case 15:
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 3);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 2);
                        Console.Write("    █   █      ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 1);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 16:
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 3);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 2);
                        Console.Write("    █   █      ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 1);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 17:
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 3);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 1);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 + 1);
                        Console.Write("    █       █");
                        break;
                    case 18:
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 3);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 1);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 19:
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 3);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 1);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 20:
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 1);
                        Console.Write("█████   █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2);
                        Console.Write("█       █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 21:

                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 3);
                        Console.Write("█████       █");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 1);
                        Console.Write("█████       █");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2);
                        Console.Write("█           █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 22:

                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2);
                        Console.Write("█       █      ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 23:
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2);
                        Console.Write("█           █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 20, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                }
                switch (minute)
                {
                    case 0:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█   █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█   █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("█   █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;

                    case 1:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█   █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█   █       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("█   █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;

                    case 2:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█   █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("█   █   █      ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 3:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█   █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("█   █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 4:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█   █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("█   █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 5:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█   █   █      ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("█   █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 6:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█   █   █      ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("█   █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 7:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█   █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█   █       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("█   █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 8:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█   █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("█   █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 9:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█   █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("█   █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 10:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 11:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("    █       █");
                        break;
                    case 12:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █   █      ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2+1);
                        Console.Write("    █   █████");
                        break;
                    case 13:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 14:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("    █       █");
                        break;
                    case 15:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █   █      ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 16:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █   █      ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 17:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("    █       █");
                        break;
                    case 18:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 19:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 20:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("█       █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 21:

                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("█           █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 22:

                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("█       █      ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 23:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("█           █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 24:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("█           █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 25:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █   █      ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("█           █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 26:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █   █      ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("█       █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 27:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("█           █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 28:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("█       █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 29:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("█           █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 30:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 31:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 32:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █   █      ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 33:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 34:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 35:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █   █      ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 36:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █   █      ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 37:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 38:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 39:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 40:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█   █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 41:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█   █       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█   █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("    █       █");
                        break;
                    case 42:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█   █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █   █      ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 43:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█   █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 44:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█   █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█   █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("    █       █");
                        break;
                    case 45:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█   █   █      ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 46:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█   █   █      ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 47:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█   █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("    █       █");
                        break;
                    case 48:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█   █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 49:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█   █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 50:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█       █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 51:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█           █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 52:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█           █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █   █      ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 53:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█           █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 54:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█       █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 55:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█       █      ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 56:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█       █      ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 57:

                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█           █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 58:

                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█       █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █   █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 59:

                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█       █   █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █  ■");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                }
                switch (second)
                {
                    case 0:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("█   █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█   █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("█   █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;

                    case 1:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("█   █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█   █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("█   █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;

                    case 2:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("█   █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("█   █   █    ");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 3:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("█   █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("█   █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 4:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("█   █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("█   █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 5:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("█   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("█   █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 6:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("█   █   █    ");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("█   █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 7:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("█   █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█   █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("█   █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 8:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("█   █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("█   █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 9:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("█   █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("█   █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 10:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 11:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("    █       █");
                        break;
                    case 12:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("    █   █    ");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 13:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 14:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("    █       █");
                        break;
                    case 15:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █   █    ");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 16:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █   █    ");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 17:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("    █       █");
                        break;
                    case 18:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 19:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("    █   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 20:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█████   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("█       █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 21:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█████       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("█           █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 22:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("█       █    ");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 23:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("█           █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 24:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("█           █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 25:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █   █    ");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("█           █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 26:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █   █    ");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("█       █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 27:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█████       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("█           █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 28:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("█       █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 29:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("█           █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 30:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█████   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 31:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█████       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 32:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("    █   █    ");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 33:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 34:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 35:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █   █    ");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 36:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █   █    ");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 37:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█████       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 38:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 39:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 40:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("█   █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█████   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 41:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█   █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("█   █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█████       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("    █       █");
                        break;
                    case 42:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("█   █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("    █   █    ");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 43:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("█   █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 44:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█   █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("█   █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("    █       █");
                        break;
                    case 45:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("█   █   █    ");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 46:
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 3);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 2);
                        Console.Write("█   █   █    ");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 + 16, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 47:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█   █       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("    █       █");
                        break;
                    case 48:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█   █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 49:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█   █   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█   █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("    █   █████");
                        break;
                    case 50:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█       █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 51:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█           █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 52:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█           █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █   █    ");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 53:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█           █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 54:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█       █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 55:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█       █    ");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 56:
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█       █    ");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 57:

                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█           █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████       █");
                        break;
                    case 58:

                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█       █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █   █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                    case 59:

                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 3);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 2);
                        Console.Write("█       █   █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 - 1);
                        Console.Write("█████   █████");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2);
                        Console.Write("    █       █");
                        Console.SetCursorPosition(windowwidth / 2 - 2, windowheight / 2 + 1);
                        Console.Write("█████   █████");
                        break;
                }
            }
        }
    }
}