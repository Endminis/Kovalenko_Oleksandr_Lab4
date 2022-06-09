using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
     class Quadrangle : Shape
    {
        public Quadrangle(string color)
        {
            Color = color;
        }
        public override void IsPointBelongs(int x, int y)
        {
            Random random = new Random();
            if (random.Next(0, x+2) == x || random.Next(0, y+2) == y)
            {
                Console.WriteLine("Point belongs to this Quadrangle");
            }
            else
            {
                Console.WriteLine("Point does not belong to this Quadrangle");
            }
        }

    }
}
