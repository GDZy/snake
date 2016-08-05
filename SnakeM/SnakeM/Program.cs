using System;
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
            
            Point p1 = new Point(3, 4, '*');           
            p1.Draw(); 

            Point p2 = new Point(3,6,'#');           
            p2.Draw();

            HorizontalLine hLine = new HorizontalLine(4, 9, 8, '+');
            hLine.Draw();

            VerticalLine vLine = new VerticalLine(4, 3, 8, '-');
            vLine.Draw();

            Console.ReadLine();
       }
               
      
    }
}
