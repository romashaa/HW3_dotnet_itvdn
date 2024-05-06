using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Ship : Vehicle
    {
        private int passengers;
        private string homePort; 

        public Ship(double x, double y, double price, double speed, int year, int passengers, string homePort)
            : base(x, y, price, speed, year)
        {
            this.passengers = passengers;
            this.homePort = homePort;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Passenger capacity: {passengers}");
            Console.WriteLine($"Home port: {homePort}");
        }
    }
}
