﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Vehicle
    {
        public void StartEngine(string noiseToMakeWhenStarting)
        {
            Console.WriteLine("Starting engine: {0}", noiseToMakeWhenStarting);
        }
        public void StopEngine(string noiseToMakeWhenStopping)
        {
            Console.WriteLine("Stopping engine: {0}", noiseToMakeWhenStopping);
        }
        public virtual void Drive()
        {
            Console.WriteLine("Default implementation of the Drive() method");
        }
    }
}
