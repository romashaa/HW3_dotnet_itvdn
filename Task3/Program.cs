using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[]
        {
            new Plane(0, 0, 1000000, 900, 2010, 10000, 250),
            new Car(10, 20, 50000, 180, 2018, "Toyota Camry"),
            new Ship(-10, -15, 2000000, 50, 2015, 1500, "New York")
        };

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine("Vehicle Information:");
                vehicle.ShowInfo();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
