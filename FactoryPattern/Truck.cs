using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    internal class Truck : IVehicle
    {
        public Truck()
        {
        }

        public int Tires { get; set; } = 4;
        

        public void Drive()
        {
            Console.WriteLine("Building new Truck.");
        }




    }
}
