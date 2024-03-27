namespace Demo1AbstractClasses.Models
{
    public class Circle : Shape
    {
        public Circle(string name,float a) : base(name,a) { }
        public override float CalculateArea()
        {
            return (float)Math.PI * (float)Math.Pow(A,2);
        }
    }
}
