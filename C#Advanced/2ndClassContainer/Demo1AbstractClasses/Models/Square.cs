namespace Demo1AbstractClasses.Models
{
    public class Square : Shape
    {
        public Square(string name, float a) : base(name,a)
        {
            
        }
        public override float CalculateArea()
        {
            return A * A;
        }

    }
}
