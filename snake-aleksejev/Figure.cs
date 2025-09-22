using snake_aleksejev;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_aleksejev
{
    public class Figure
    {
        protected List<Tochka> pList;

        public void Draw()
        {
            foreach (Tochka p in pList)
            {
                p.draw();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var p in pList)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }

        private bool IsHit(Tochka point)
        {
            foreach (var p in pList)
            {
                if (p.isHit(point))
                    return true;
            }
            return false;
        }
    }
}