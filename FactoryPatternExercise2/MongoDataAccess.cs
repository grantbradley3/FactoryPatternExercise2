using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class MongoDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){Name="Xbox", Price = 350},
            new Product(){Name="Toothbrush", Price = 50},
            new Product(){Name="Waterfilter", Price = 100},
            new Product(){Name="Computer", Price = 1000}

        };

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from SQL Data Access.");

            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a SQL Data Access");
        }
    }
}
