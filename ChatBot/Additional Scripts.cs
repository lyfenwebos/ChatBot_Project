using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    public class Additional_Scripts
    {
        public static void Typing(int sleep)
        {

            for (int i = 0; i < sleep; ++i)
            {
                Console.Write("\rI am typing!   ");
            }
        }
    }
    public class ConsoleSpiner
    {
        int counter;
        public ConsoleSpiner()
        {
            counter = 0;
        }
        public void Turn()
        {
            counter++;
            switch (counter % 3)
            {
                case 0: Console.Write("Loading."); break;
                case 1: Console.Write("Loading.."); break;
                case 2: Console.Write("Loading..."); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
    }
}
