namespace Task3Bonus.Models
{
    public class Rectangle : Shape
    {
        public int SideA {  get; set; }
        public int SideB { get; set; }
        public Rectangle() { }
        public override void getArea()
        {
            int result = SideA * SideB;
            Console.WriteLine($"The area of the rectangle with {SideA} and {SideB} is {result}");
        }
        public override void getPerimeter() 
        {
            int result = 2 * (SideA + SideB);
            Console.WriteLine($"The perimeter of the rectangle with {SideA} and {SideB} is {result}");
        }
    }
}
