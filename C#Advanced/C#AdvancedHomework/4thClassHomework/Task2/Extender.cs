using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Models;

namespace Extender;

public static class Extender
{
    public static void Drive(this Car car)
    {
        Console.WriteLine("Driving the car");
    }
    public static void Wheelie(this MotorBike bike)
    {
        Console.WriteLine("Driving on one wheel!!");
    }
    public static void Sail(this Boat boat)
    {
        Console.WriteLine("Sailing!");
    }
    public static void Fly(this Airplane airplane)
    {
        Console.WriteLine("Flying!");
    }

}
