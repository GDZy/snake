using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeM
{
    class OutputScreen
    {
        public OutputScreen(string str)
        {
            Console.SetCursorPosition(10, 10);
            Console.Write("=============================");
            Console.SetCursorPosition(10, 12);
            Console.Write("        Игра окончена        ");
            Console.SetCursorPosition(10, 14);
            Console.Write("            " + str + "           ");
            Console.SetCursorPosition(10, 16);
            Console.Write("=============================");
        }
    }
}
