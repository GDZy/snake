﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeM
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 6;
            int y1 = 3;
            char sym1 = '*';

            Drow(x1, y1, sym1);

            int x2 = 5;
            int y2 = 10;
            char sym2 = '#';

            Drow(x2, y2, sym2);

            Console.ReadLine();

       }

        static void Drow(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
