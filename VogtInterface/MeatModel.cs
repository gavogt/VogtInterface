using System;
using System.Collections.Generic;
using System.Text;

namespace VogtInterface
{
    class MeatModel : ProductsBase, IMeatModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }

        public override void PrintProductDetails(List<IProductsModel> products)
        {

            foreach (var product in products)
            {
                Console.WriteLine(" ");
                Console.WriteLine($"Product name: {product.Name}");
                Console.WriteLine($"Product price: {product.Price:C2}");

                if (product is IMeatModel meat)
                {
                    Console.WriteLine($"Meat type: {meat.Type}");
                }
            }
        }
    }
}
