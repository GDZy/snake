using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeM
{
    class Obstacle: Figure
    {
        int mapWidth;
        int mapHight;
        char sym;

        Random rnd = new Random();

        public Obstacle(int x, int y, char sym )
        {
           mapWidth = x;
           mapHight = y;
           this.sym = sym;
        }

        public Point CreateObstacle()
        {
            Point p = new Point();
            p.x = rnd.Next(2, mapWidth);
            p.y = rnd.Next(2, mapHight);
            p.sym = sym;
            return p;
        }


    }
}
