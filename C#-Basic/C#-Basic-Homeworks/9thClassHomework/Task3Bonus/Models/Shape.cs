using System.Drawing;

namespace Task3Bonus.Models
{
    public class Shape
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public int[] Position {  get; set; }
        public virtual void getArea()
        {
            Console.WriteLine("There is no special implementation for area!");
        }
        public virtual void getPerimeter()
        {
            Console.WriteLine("No special implementation for perimeter");
        }
        public void move()
        {
            Position[0] += 5;
            Position[1] += 5;
        }
        public void setColor (Color color)
        {
            if (color.IsNamedColor)
            {
                Color=color;
            }
        }
        public void getColor ()
        {
            Console.WriteLine(Color);
        }

    }
}
