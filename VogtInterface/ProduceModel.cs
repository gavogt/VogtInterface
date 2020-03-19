using System;
using System.Collections.Generic;
using System.Text;

namespace VogtInterface
{
    class ProduceModel : ProductsBase, IProduceModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Package { get; set; }

        public override void PrintProductDetails(List<IProductsModel> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine(" ");
                Console.WriteLine($"Product name: {product.Name}");
                Console.WriteLine($"Product price: {product.Price:C2}");

                if (product is IProduceModel produce)
                {
                    Console.WriteLine($"Packaging: {produce.Package}");
                }
            }
        }
    }
}
