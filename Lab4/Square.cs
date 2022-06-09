using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{

    class Square : Quadrangle
    {
        public Square(string color) : base(color)
        {
        }

        public override void IsPointBelongs(int x, int y)
        {
            Random random = new Random();
            if (random.Next(0, x+2) == x || random.Next(0, y+2) == y)
            {
                Console.WriteLine("Point belongs to this Square");
            }
            else
            {
                Console.WriteLine("Point does not belong to this Square");
            }
        }
        public void CalculateAngles()
        {
            Console.WriteLine("All angles are equal 90");
        }
    }
}
