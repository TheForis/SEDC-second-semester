using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1Delegate.Models
{
    public class HelperClass
    {

        public delegate void GreetingDekegate(string name);
        public GreetingDekegate Greeting { get; set; }

        public void SayHi(string name)
        {
            Console.WriteLine($"Hi {name}");
        }
    }
}
