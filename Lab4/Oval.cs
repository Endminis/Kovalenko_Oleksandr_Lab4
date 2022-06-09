using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
     class Oval : Shape
    {
        public Oval(string color)
        {
            Color = color;
        }
        public override void IsPointBelongs(int x, int y)
        {
            Random random = new Random();
            if (random.Next(0, x+2) == x || random.Next(0, y+2) == y)
            {
                Console.WriteLine("Point belongs to this Oval");
            }
            else
            {
                Console.WriteLine("Point does not belong to this Oval");
            }
        }
        public void CalculateLength(int a, int b)
        {
            Console.WriteLine("The length of this oval = " + Math.PI*(a + b));
        }
    }
}
