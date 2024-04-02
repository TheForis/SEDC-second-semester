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
            else
            {
                throw new Exception("Using Car method in invalid class");
            }
        }
        public static void Wheelie(this Vehicle bike)
        {
            if (bike.GetType() == typeof(MotorBike))
                Console.WriteLine("Driving on one wheel!!");
            else
            {
                throw new Exception("Using MotorBike method in invalid class");
            }
        }
        public static void Sail(this Vehicle boat)
        {
            if (boat.GetType() == typeof(Boat))
                Console.WriteLine("Sailing!");
            else
            {
                throw new Exception("Using Boat method in invalid class");
            }
        }
        public static void Fly(this Vehicle airplane)
        {
            if (airplane.GetType() == typeof(Airplane))
                Console.WriteLine("Flying!");
            else
            {
                throw new Exception("Using Airplane method in invalid class");
            }
        }

    }

}
