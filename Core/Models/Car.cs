﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Car : Vehicle
    {
        public int PassengerCapacity { get; set; }

        public override void ShowInfo()
        {
            Console.WriteLine($"Marka: {Marka}; Model: {Model}; Year: {Year}; Passanger Capacity: {PassengerCapacity}");
        }
    }
}
