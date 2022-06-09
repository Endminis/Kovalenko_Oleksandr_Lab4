using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Triangle : Shape
    {
        
        public Triangle(string color)
        {
            Color = color;
        }
        public override void IsPointBelongs(int x, int y)
        {
            Random random = new Random();
            if (random.Next(0, x+2) == x || random.Next(0, y+2) == y)
            {
                Console.WriteLine("Point belongs to this Triangle");
            }
            else
            {
                Console.WriteLine("Point does not belong to this Triangle");
            }
        }
        public void CalculateAngles(Point A, Point B, Point C)
        {
            double firstSideLength = Math.Sqrt(Math.Pow((A.X - B.Y), 2) + Math.Pow((A.Y - B.Y), 2)); 
            double secondSideLength = Math.Sqrt(Math.Pow((A.X - C.Y), 2) + Math.Pow((A.Y - C.Y), 2)); 
            double thirdSideLength = Math.Sqrt(Math.Pow((C.X - B.Y), 2) + Math.Pow((C.Y - B.Y), 2)); 
            double firstAngle = Math.Acos((Math.Pow(secondSideLength, 2) + 
                Math.Pow(thirdSideLength, 2) - Math.Pow(firstSideLength, 2))
                /(2*secondSideLength*thirdSideLength));            
            double secondAngle = Math.Acos((Math.Pow(firstSideLength, 2) + 
                Math.Pow(thirdSideLength, 2) - Math.Pow(secondSideLength, 2))
                /(2*firstSideLength*thirdSideLength));
            double thirdAngle = 180 - (firstAngle + secondAngle);
            Console.WriteLine($"First angle = {firstAngle}, second angle = {secondAngle}, " +
                $"third angle = {thirdAngle}");
        }
    }
}
