﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeM
{
    class Point
    {
        public int x;
        public int y;
        public char sym;
        
        public Point()
        {
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.DOWN) y = y + offset;
            else if (direction == Direction.LEFT) x = x - offset;
            else if (direction == Direction.RIGHT) x = x + offset;
            else if (direction == Direction.UP) y = y + offset;

        }

        public void Clear()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
        
    }
}
