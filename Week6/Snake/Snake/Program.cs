using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
   }

    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            bool isAlive = true;
            int x = 10;
            int y = 10;

            while (isAlive)
            {


                ConsoleKeyInfo consolekey = Console.ReadKey();
                Console.Clear();
                if (consolekey.Key == ConsoleKey.UpArrow)
                    y--;
                if (consolekey.Key == ConsoleKey.DownArrow)
                    y++;
                if (consolekey.Key == ConsoleKey.LeftArrow)
                    x--;
                if (consolekey.Key == ConsoleKey.RightArrow)
                    x++;
                if (consolekey.Key == ConsoleKey.Escape)
                    break;
                Console.SetCursorPosition(x, y);
                Console.WriteLine("0");
            }
            
            
        }
        

    }

