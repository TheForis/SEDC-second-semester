using Demo1AbstractClasses.Models;
using System.Security.Cryptography;

namespace Demo1AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Square s = new Square("Kvadrat",5);
            Console.WriteLine(s.CalculateArea());
            Console.WriteLine(s.GetInfo());

            Rectangle rect = new Rectangle("Pravoagolnik", 5, 10);
            Console.WriteLine(rect.GetInfo());

            Circle circle = new Circle("krug", 5);
            Console.WriteLine(circle.GetInfo());

            Rectangle rect2 = new Rectangle("Pravoagolnik", 3, 7);
            Square s2 = new Square("Kvadrat", 3);

            /*List<Square> list = new List<Square>() { s,s2,rect,rect2};*/

            List<Shape> shapes = new List<Shape>() { s,s2,rect,rect2,circle};

            foreach (Shape shape in shapes) { 
            Console.WriteLine(shape.CalculateArea());
            }

            List<Square> squares = new List<Square>();
            List<Rectangle> rectangles = new List<Rectangle>();
            List<Circle> circles = new List<Circle>();

            /*foreach (Shape shape in shapes)
            {
                if(shape is Square)
                {
                    squares.Add((Square)shape);
                }
                if(shape is Rectangle)
                {
                    rectangles.Add((Rectangle)shape);
                }
                if(shape is Circle)
                {
                    Circle circle1 = (Circle)shape;
                    circles.Add(circle1);
                }
            }*/


            foreach (Shape shape in shapes)
            {
                /*squares.Add((Square)shape);*/
                Square trySquare = shape as Square;
                squares.Add(trySquare);
            }

            for(int i = 0; i < squares.Count; i++)
            {
                squares.Remove(null);
            }



        }
    }
}