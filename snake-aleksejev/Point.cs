using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_aleksejev
{
    public class Tochka
    {
        public int x;
        public int y;
        public string sym;

        public Tochka()
        {

        }

        public Tochka(int x, int y, string sym   )
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }
        public Tochka(Tochka p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public void move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }

        public bool isHit(Tochka p)
        {
            return p.x == this.x && p.y == this.y;
        }
        public void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public void clear()
        {
            sym = " ";
            draw();
        }
        public override string ToString()
        {
            return x + "," + y + "," + sym;
        }
    }
}
