﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Car : Vehicle
    {
        private string model;

        public Car(double x, double y, double price, double speed, int year, string model)
            : base(x, y, price, speed, year)
        {
            this.model = model;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Model: {model}");
        }
    }
}
