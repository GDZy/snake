using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeM
{
    class Walls
    {
        List<Figure> wallList;
             
        public Walls(int mapWidth, int mapHight, char sym)
        {
            wallList = new List<Figure>();

            HorizontalLine topLine = new HorizontalLine(0, mapWidth-2, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, mapWidth-2, mapHight-1, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, mapHight-1, '+');
            VerticalLine rightLine = new VerticalLine(mapWidth-1, 0, mapHight-2, '+');

            wallList.Add(topLine);
            wallList.Add(bottomLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        internal void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }

        internal bool IsHit(Figure figure)
        {
           foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
