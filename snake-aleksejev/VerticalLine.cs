using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_aleksejev
{
    class VerticalLine : Figure
    {
        
        public VerticalLine(int yUp, int yDown, int x, string sym)
        {
            pList = new List<Tochka>();
            for (int y = yUp; y <= yDown; y++)
            {
                Tochka p = new Tochka(x, y, sym);
                pList.Add(p);
            }
        }
       
    }
}

