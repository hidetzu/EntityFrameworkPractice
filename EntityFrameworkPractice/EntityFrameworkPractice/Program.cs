using EntityFrameworkPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new NorthwindContext())
            {
                var products = from product in db.Products select product;
                foreach(var p in products)
                    Console.WriteLine("{0} | {1} | {2} | {3}",
                 p.ProductID, p.ProductName, p.UnitPrice, p.QuantityPerUnit);

                Console.ReadLine();
            }
        }
    }
}
