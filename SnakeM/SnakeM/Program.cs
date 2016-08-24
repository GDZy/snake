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
        private static object console;

        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
       
            // Отрисовка рамочки
            HorizontalLine topLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, 24, '+');
            VerticalLine rightLine = new VerticalLine(78, 0, 24, '+');
            topLine.Draw();
            bottomLine.Draw();
            leftLine.Draw();
            rightLine.Draw();


            // Создание змейки
            Point p = new Point(3, 5, '*');
            Snake snake = new Snake(p, 5, Direction.RIGHT);
            snake.Draw();

            // Создание еды
            FoodCreater food = new FoodCreater(78, 24, '$');
            Point foodPoint = food.CreateFood();
            foodPoint.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }            
       }      
    }
}
