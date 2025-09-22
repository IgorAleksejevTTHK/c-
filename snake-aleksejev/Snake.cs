using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_aleksejev
{
    public class Snake : Figure
    {
        public Direction direction;
        public Snake(Tochka tail,int lenght,Direction direction)
        {
            pList = new List<Tochka>();
            for (int i = 0; i < lenght; i++)
            {
                Tochka p = new Tochka(tail);
                p.move(i, direction);
                pList.Add(p);
            }
        }

        internal void move()
        {
           Tochka tail = pList.First();
            pList.Remove(tail);
            Tochka head = getNextPoint();
            pList.Add(head);    

            tail.clear();
            head.draw();
        }

        public Tochka getNextPoint()
        {
            Tochka head = pList.Last();
            Tochka nextPoint = new Tochka(head);
            nextPoint.move(1, direction);
            return nextPoint;
        }
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
            }
        }
        internal bool eat(Tochka food)
        {
            Tochka head = getNextPoint();
            if (head.isHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
            {
                return false;
            }

        }
    }   

}
