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
            
            Point p1 = new Point(1, 4, '*');           
            p1.Draw(); 

            Point p2 = new Point(4,6,'#');           
            p2.Draw();

            Console.ReadLine();
       }
               
      
    }
}
