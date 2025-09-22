using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Drawing;
using snake_aleksejev;

namespace snake_aleksejev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            Walls walls = new Walls(80, 25);
            walls.draw();

            Tochka p = new Tochka(4, 5, "*");
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, "$");
            Tochka food = foodCreator.CreateFood();
            food.draw();
                
            while (true)
            {
                if 
            }
            }

        }
    }
}






     




