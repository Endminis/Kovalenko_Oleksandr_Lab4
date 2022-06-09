namespace Lab4 {
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square("Red");
            Console.WriteLine(square.Color);
            square.CalculateAngles();

            Oval oval = new Oval("Green");
            Console.WriteLine(oval.Color);
            oval.CalculateLength(2, 4);

            Triangle triangle = new Triangle("Yellow");
            Point point1 = new Point(2, 4);
            Point point2 = new Point(1, 2);
            Point point3 = new Point(-2, 1);
            triangle.CalculateAngles(point1, point2, point3);

            Quadrangle quadrangle = new Quadrangle("Blue");
            quadrangle.IsPointBelongs(1, 1);
            quadrangle.IsPointBelongs(0, 1);
        }
    }
}