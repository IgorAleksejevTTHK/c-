using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_aleksejev
{
    public class HorizontalLine : Figure
    {

        public HorizontalLine(int xLeft, int xRight, int y, string sym)
        {
            pList = new List<Tochka>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Tochka p = new Tochka(x, y, sym);
                pList.Add(p);
            }

        }

     }
}

