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

        public override void PrintProductDetails(List<IProductsModel> products)
        {
            foreach (var product in products)
            {
                if (product is IDairyModel dairy)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine($"Product name: {product.Name}");
                    Console.WriteLine($"Product price: {product.Price:C2}");
                    Console.WriteLine($"Shelf life: {dairy.ShelfLife}");
                }
            }
        }
    }
}
