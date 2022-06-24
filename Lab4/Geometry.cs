using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Geometry
    {
        List<Shape> shapesList = new List<Shape>();
        public void AddShape(Shape s)
        {
            shapesList.Add(s);
        }
        public void CountShapesOnPoint(Point p)
        {
            int squareCount=0, ovalCount = 0, trianleCount =0, quadrangleCount= 0;
            foreach (Shape shape in shapesList){
                switch (shape)
                {
                    case Square:
                        if (shape.IsPointBelongs(p)) squareCount++;
                        break;                    
                    case Oval:
                        if (shape.IsPointBelongs(p)) ovalCount++;
                        break;                   
                    case Triangle:
                        if (shape.IsPointBelongs(p)) trianleCount++;
                        break;                  
                    case Quadrangle:
                        if (shape.IsPointBelongs(p)) quadrangleCount++;
                        break;
                }
            }
            Console.WriteLine("Загальна кількість фігур, яким належить точка, по категоріям:");
            Console.WriteLine("Square: " + squareCount);
            Console.WriteLine("Oval: " + ovalCount);
            Console.WriteLine("Trianle: " + trianleCount);
            Console.WriteLine("Quadrangle: " + quadrangleCount);
        }
    }
}
