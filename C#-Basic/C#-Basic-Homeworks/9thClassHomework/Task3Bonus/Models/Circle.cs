namespace Task3Bonus.Models
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public override void getArea()
        {
            double result = Math.PI * Math.Pow(Radius,2);
            Console.WriteLine($"The area of circle with radius: {Radius} is {result}");
        }
        public override void getPerimeter()
        {
            double diameter = 2 * Radius;
            double perimeterResult = Math.PI * diameter;
            Console.WriteLine($"The perimeter of the circle with radius: {Radius} is {perimeterResult}");


        }
    }
}
