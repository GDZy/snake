using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeM
{
    class Snake : Figure
    {
        public Direction direction;

        public Snake (Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);

            }
        }

        public void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextHead();            
            pList.Add(head);

            tail.Clear();
            head.Draw();

        }

        public Point GetNextHead()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;            
        }

        internal bool HitTail()
        {
            Point head = GetNextHead();
            foreach (var p in pList)
            {
                if (p.IsHit(head))
                {
                    return true;
                }
            }
            return false;
        }

        
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
            if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
        }
                
        public bool Eat(Point food)
        {
            Point head = GetNextHead();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }
    }
}
