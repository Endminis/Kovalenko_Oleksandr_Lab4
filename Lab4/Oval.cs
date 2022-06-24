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
        public override bool IsPointBelongs(Point point)
        {
            Random random = new();
            return (random.Next(0, point.X + 1) == point.X || random.Next(0, point.Y + 1) == point.Y);
        }
        public void CalculateLength(int a, int b)
        {
            Console.WriteLine("The length of this oval = " + Math.PI*(a + b));
        }
    }
}
