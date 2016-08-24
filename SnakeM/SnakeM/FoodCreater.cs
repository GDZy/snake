using System;

namespace SnakeM
{
    class FoodCreater
    {
        int mapWidth;
        int mapHight;
        char sym;

        public FoodCreater (int mapWidth, int mapHight, char sym)
        {
            this.mapWidth = mapWidth;
            this.mapHight = mapHight;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            Random rnd = new Random();

            int x = rnd.Next(2, mapWidth - 2);
            int y = rnd.Next(2, mapHight - 2);
            Point food = new Point(x, y, sym);
            return food;

        }
    }
}