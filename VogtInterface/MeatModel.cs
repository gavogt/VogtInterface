using System;
using System.Collections.Generic;
using System.Text;

namespace VogtInterface
{
    class MeatModel : ProductsBase, IMeatModel
    {

        public string Type { get; set; }

        public override void PrintProductSpecificDetails()
        {
            Console.WriteLine($"Meat type: {Type}");
        }

    }
}
