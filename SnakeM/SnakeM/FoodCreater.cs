using System;

namespace SnakeM
{
    class FoodCreater
    {
        int mapWidth;
        int mapHight;
        char sym;

        Random rnd = new Random();

        public FoodCreater (int mapWidth, int mapHight, char sym)
        {
            this.mapWidth = mapWidth;
            this.mapHight = mapHight;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = rnd.Next(2, mapWidth - 2);
            int y = rnd.Next(2, mapHight - 2);            
            return new Point(x, y, sym);

        }
    }
}