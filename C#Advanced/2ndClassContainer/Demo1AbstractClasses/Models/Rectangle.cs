namespace Demo1AbstractClasses.Models
{
    public class Rectangle : Shape
    {
        public float B {  get; set; }
        public Rectangle(string name, float a, float b) : base(name, a)
        {
            B = b;
        }
        public override float CalculateArea()
        {
            return A * B;
        }
    }
}
