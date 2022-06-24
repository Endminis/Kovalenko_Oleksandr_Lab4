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

        public override bool IsPointBelongs(Point point)
        {
            Random random = new();
            return (random.Next(0, point.X + 1) == point.X || random.Next(0, point.Y + 1) == point.Y);
        }
        public void CalculateAngles()
        {
            Console.WriteLine("All angles are equal 90");
        }
    }
}
