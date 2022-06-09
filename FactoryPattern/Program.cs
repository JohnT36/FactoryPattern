using System;
using System.Collections.Generic;
using System.Threading;

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

            
            
            Console.ReadLine();
            string userInput;
            bool response;
            do
            {
                
                response = true;
                Console.WriteLine($"Okay John, what Database would you like to use?");
                Console.WriteLine("Type: sql");
                Console.WriteLine("Type: list");
                Console.WriteLine("Type: mango");

                userInput = Console.ReadLine();
                if (userInput != "sql" && userInput != "list" && userInput != "mango")
                {
                    Console.WriteLine("Bad Input");
                    response = false;
                }


            } while (!response);
            IDataAccess johnsDB = DataAccessFactory.DataAccessType(userInput);

            Console.WriteLine("---Enter any key to continue----");
            Console.ReadLine();
            string userInput2;
            do
            {
                response = true;
                
                Console.WriteLine($"Okay Alina, What Database would you like to use?");
                Console.WriteLine("Type: sql");
                Console.WriteLine("Type: list");
                Console.WriteLine("Type: mango");


                userInput2 = Console.ReadLine();
                 if (userInput2 != "sql" && userInput2 != "list" && userInput2 != "mango")
                {
                    Console.WriteLine("Bad Input");
                    response = false;
                }



            } while (response == false);

                IDataAccess alinasDB = DataAccessFactory.DataAccessType(userInput2);

                Console.WriteLine("---Enter any key to continue----");
                Console.ReadLine();
            string userInput3;
            do
            {
                response = true;

                Console.WriteLine($"Okay Jesiah, What Database would you like to use?");
                Console.WriteLine("Type: sql");
                Console.WriteLine("Type: list");
                Console.WriteLine("Type: mango");


                userInput3 = Console.ReadLine();
                if (userInput3 != "sql" && userInput3 != "list" && userInput3 != "mango")
                {
                    Console.WriteLine("Hey man cant you see the pattern?");
                    response = false;
                }


            } while (!response);
                var jesiahsDB = DataAccessFactory.DataAccessType(userInput3);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();




            var productsA = alinasDB.LoadData();
            Console.WriteLine("--------------------------");
                var productsJ = johnsDB.LoadData();
            Console.WriteLine("--------------------------");
            var productsJe = jesiahsDB.LoadData();
            Console.WriteLine("--------------------------");

            foreach (var product in productsA)
                {
                    Console.WriteLine($"Item:{product.Name}, Price:${product.Price}");
                }
                Console.WriteLine($"-------------------ENTER --------------------------------");
                Console.ReadLine();

                foreach (var product in productsJ)
                {
                    Console.WriteLine($"Item:{product.Name}, Price:${product.Price}");
                }
                Console.WriteLine($"-------------------ENTER --------------------------------");
                Console.ReadLine();
                foreach (var product in productsJe)
                {
                    Console.WriteLine($"Item:{product.Name}, Price:${product.Price}");
                }



























        }


    }
}
