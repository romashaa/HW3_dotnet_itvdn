using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Vehicle
    {
        protected double x, y; 
        protected double price; 
        protected double speed; 
        protected int year; 

        public Vehicle(double x, double y, double price, double speed, int year)
        {
            this.x = x;
            this.y = y;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Vehicle coordinates: ({x}, {y})");
            Console.WriteLine($"Price: {price}$");
            Console.WriteLine($"Speed: {speed} km/h");
            Console.WriteLine($"Year of manufacture: {year}");
        }
    }
}
