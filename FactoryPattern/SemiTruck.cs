using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    internal class SemiTruck : IVehicle
    {
        public SemiTruck()
        {
            

        }

        public int Tires { get; set; } = 6;
        
        public void Drive()
        {
            Console.WriteLine("Building new Semi.");
        }

        
    }
}
