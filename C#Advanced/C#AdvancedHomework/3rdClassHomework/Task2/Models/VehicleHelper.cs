using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Task2.Models;

namespace System
{
    public static class VehicleHelper
    {
        public static void Drive(this Vehicle car)
        {
            if(car.GetType() == typeof(Car))
            Console.WriteLine("Driving the car");
        }
        public static void Wheelie(this Vehicle bike)
        {
            if (bike.GetType() == typeof(MotorBike))
                Console.WriteLine("Driving on one wheel!!");
        }
        public static void Sail(this Vehicle boat)
        {
            if (boat.GetType() == typeof(Boat))
                Console.WriteLine("Sailing!");
        }
        public static void Fly(this Vehicle airplane)
        {
            if (airplane.GetType() == typeof(Airplane))
                Console.WriteLine("Flying!");
        }

    }

}
