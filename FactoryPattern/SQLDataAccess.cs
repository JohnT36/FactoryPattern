using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class SQLDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
             new Product() { Name = "Comp", Price = 700},
             new Product() { Name = "Crib", Price = 150 },
             new Product() { Name = "Satelite", Price = 10000}


        };
        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from SQLDataAccess");
            return Products;
        }
        public void SaveData()
        {
            Console.WriteLine($"I am saving data from SQLDataAccess");
        }
      
    }
}
