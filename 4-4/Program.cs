using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius = 5;
            const float Pi = 3.14159F;
            float surface = 4 * Pi * radius * radius;
            Console.WriteLine("Surface area: {0}", surface);
            float volume = (4 * Pi * radius * radius * radius)/3;
            Console.WriteLine("Volume: {0}", volume);
            String larger = surface > volume ? "Surface Area" : "Volume";
            Console.WriteLine("The {0} is larger",larger);
        }
    }
}
