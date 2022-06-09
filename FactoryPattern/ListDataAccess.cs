using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
             new Product() { Name = "Phone", Price = 700},
             new Product() { Name = "Entertainment Stand", Price = 150 },
             new Product() { Name = "Rocket Ship", Price = 1000000}


        };
        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from ListDataAccess");
            return Products;
        }
        public void SaveData()
        {
            Console.WriteLine($"I am saving data from ListDataAccess");
        }
        
    }
}
