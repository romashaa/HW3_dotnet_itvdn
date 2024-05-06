using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Plane : Vehicle
    {
        private double altitude;
        private int passengers;

        public Plane(double x, double y, double price, double speed, int year, double altitude, int passengers)
            : base(x, y, price, speed, year)
        {
            this.altitude = altitude;
            this.passengers = passengers;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Altitude: {altitude} meters");
            Console.WriteLine($"Passenger capacity: {passengers}");
        }
    }
}
