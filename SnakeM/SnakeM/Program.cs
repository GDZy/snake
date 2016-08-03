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
            
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 4;
            p1.sym = '%';
            p1.Draw();

            Point p2 = new Point();
            p2.x = 4;
            p2.y = 6;
            p2.sym = 'b';
            p2.Draw();

            Console.ReadLine();
       }
               
      
    }
}
