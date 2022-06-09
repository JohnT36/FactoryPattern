using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public static class VehicleFactory 
    {


        public static IVehicle GetVehicle(int tires)
        {
            if (tires == 2 )
            { return new Motorcycle(); }
            if (tires == 4)
            { return new Truck(); }
            if (tires == 6)
            { return new SemiTruck(); }
            return new SemiTruck(); ;

            

        }
    }
}
