using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class MangoDataAccess : IDataAccess
    {


        public static List<Product> Products = new List<Product>()
        {
             new Product() { Name = "Xbox", Price = 350},
             new Product() { Name = "Horse", Price = 7000 },
             new Product() { Name = "Desk", Price = 20}
        

        };

        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from MangoDataAccess");
            return Products;
        }
        public void SaveData()
        {
            Console.WriteLine($"I am saving data from MangoDataAccess");
        }

       
    }
}
