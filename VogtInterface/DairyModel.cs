using System;
using System.Collections.Generic;
using System.Text;

namespace VogtInterface
{
    class DairyModel : ProductsBase, IDairyModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ShelfLife { get; set; }

        public void PrintProductDetails()
        {
            Console.WriteLine();
            Console.WriteLine($"Product name: {Name}");
            Console.WriteLine($"Product price: {Price:C2}");
            PrintProductSpecificDetails();
        }

        public override void PrintProductSpecificDetails()
        {
            Console.WriteLine($"Shelf Life type: {ShelfLife}");
        }
    }
}
