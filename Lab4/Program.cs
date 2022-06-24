namespace Lab4 {
    class Program
    {
        static void Main()
        {

            Square square1 = new("Red");
            Square square2 = new("Dark red");
         //   Console.WriteLine(square.Color);
          //  square.CalculateAngles();

            Oval oval1 = new("Green");
            Oval oval2 = new("Orange");
            Oval oval3 = new("Lime");
            Oval oval4 = new("Brown");
         //   Console.WriteLine(oval.Color);
            //oval.CalculateLength(2, 4);

            Triangle triangle1 = new("Yellow");
            Triangle triangle2 = new("Dark yellow");
            Triangle triangle3 = new("Dark green");
            Triangle triangle4 = new("Cyan");
            Triangle triangle5 = new("Gray");
            Point point1 = new(2, 4);
      //      Point point2 = new(1, 2);
        //    Point point3 = new(3, 1);
          //  triangle.CalculateAngles(point1, point2, point3);

            Quadrangle quadrangle1 = new("Dark blue");
            Quadrangle quadrangle2 = new("Black");
            Quadrangle quadrangle3 = new("Blue");
          //  quadrangle.IsPointBelongs(point1);
            //quadrangle.IsPointBelongs(point2);


            Geometry geometry = new();
            geometry.AddShape(triangle1);
            geometry.AddShape(triangle2);
            geometry.AddShape(triangle3);
            geometry.AddShape(triangle4);
            geometry.AddShape(triangle5);
            geometry.AddShape(quadrangle1);
            geometry.AddShape(quadrangle2);
            geometry.AddShape(quadrangle3);
            geometry.AddShape(square1);
            geometry.AddShape(square2);
            geometry.AddShape(oval1);
            geometry.AddShape(oval2);
            geometry.AddShape(oval3);
            geometry.AddShape(oval4);

            geometry.CountShapesOnPoint(point1);
        }
    }
}