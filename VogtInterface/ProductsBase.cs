using System;
using System.Collections.Generic;
using System.Text;

namespace VogtInterface
{
    abstract class ProductsBase: IProductsModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public void PrintProductDetails()
        {

            Console.WriteLine();
            Console.WriteLine($"Product name: {Name}");
            Console.WriteLine($"Product price: {Price:C2}");
            PrintProductSpecificDetails();
        }

        public abstract void PrintProductSpecificDetails();
    }
}
