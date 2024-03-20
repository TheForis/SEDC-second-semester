using Task3Bonus.Models;

namespace Task3Bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            shape.Name = "Circle";
            shape.Position = new int[] {2,5};
            shape.setColor(System.Drawing.Color.Crimson);
            shape.getPerimeter();
            shape.getArea();
            shape.getColor();
            Console.WriteLine(shape.Position[0]);
            Console.WriteLine(shape.Position[1]);
            shape.move();
            Console.WriteLine(shape.Position[0]);
            Console.WriteLine(shape.Position[1]);

            Rectangle rectangle = new Rectangle() { Name = "Rectangle", Position = new int[] { 20, 11 }, Color = System.Drawing.Color.BlueViolet };
            rectangle.SideA = 2;
            rectangle.SideB = 5;
            rectangle.getArea();
            rectangle.getPerimeter();

            Circle circle = new Circle() { Name="Circle", Color=System.Drawing.Color.AliceBlue, Position = new int[]{ 6, 8 }, Radius=5};
            circle.getArea();
            circle.getPerimeter();
            Console.WriteLine(circle.Position[0]);
            circle.move();
            Console.WriteLine(circle.Position[0]);
        }
    }
}
