using Task2.Models;
using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car();
            Vehicle motorBike = new MotorBike();
            Vehicle boat = new Boat();
            Vehicle plane = new Airplane();

            car.DisplayInfo();
            motorBike.DisplayInfo();
            boat.DisplayInfo();
            plane.DisplayInfo();

            try
            {
                car.Drive();
                motorBike.Wheelie();
                boat.Sail();
                plane.Fly();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
