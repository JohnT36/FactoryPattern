using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    internal class Motorcycle : IVehicle
    {                    
        public Motorcycle()
        {
        }
        public int Tires { get; set; } = 4;
        

        public void Drive()
        {
            Console.WriteLine("Building new MotorCycle.");
        }




    }
}
