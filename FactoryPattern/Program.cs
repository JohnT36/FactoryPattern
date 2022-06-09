using System;
using System.Collections.Generic;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels do you want on your vehicle?");
            int answer;
            int.TryParse(Console.ReadLine(), out answer);
             var johnsV = VehicleFactory.GetVehicle(answer);
            johnsV.Drive();

            Console.WriteLine("What would you like for your next vehicle?");
            int answer1;
            int.TryParse(Console.ReadLine(), out answer1);
            var alinasV = VehicleFactory.GetVehicle(answer1);
            alinasV.Drive();

            Console.WriteLine("What would you like for your next vehicle?");
            int answer2;
            int.TryParse(Console.ReadLine(), out answer2);
            var jesiahV = VehicleFactory.GetVehicle(answer2);
            alinasV.Drive();

            var allVehicles = new List<IVehicle>();
            allVehicles.Add(johnsV);
            allVehicles.Add(alinasV);
            allVehicles.Add(jesiahV);
            
            foreach (var vehicle in allVehicles)
            {
                Console.WriteLine(vehicle.Tires);
                vehicle.Drive();
            }


















        }


    }
}
