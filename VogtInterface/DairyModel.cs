using System;
using System.Collections.Generic;
using System.Text;

namespace VogtInterface
{
    class DairyModel : ProductsBase, IDairyModel
    {

        public string ShelfLife { get; set; }

        public override void PrintProductSpecificDetails()
        {
            Console.WriteLine($"Shelf Life type: {ShelfLife}");
        }
    }
}
