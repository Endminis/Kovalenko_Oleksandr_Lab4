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
        public override bool IsPointBelongs(Point point)
        {
            Random random = new();
            return (random.Next(0, point.X + 1) == point.X || random.Next(0, point.Y + 1) == point.Y);
        }

    }
}
