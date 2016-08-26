using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeM
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            Walls walls = new Walls(78, 24, '+');
            walls.Draw();
            
            // Создание змейки
            Point p = new Point(20, 5, '*');
            Snake snake = new Snake(p, 5, Direction.LEFT);
            snake.Draw();

            // Создание еды
            FoodCreater foodCreater = new FoodCreater(78, 24, '$');
            Point food = foodCreater.CreateFood();
            food.Draw();
            

            while (true)
            {
                // проверка на пересечение
                if (walls.IsHit(snake) || snake.HitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreater.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
            OutputScreen outScr = new OutputScreen("DiG");

            Console.ReadLine();        
       }      
    }
}
