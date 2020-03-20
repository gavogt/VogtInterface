using System;
using System.Collections.Generic;
using System.Text;

namespace VogtInterface
{
    class ProduceModel : ProductsBase, IProduceModel
    {
        public string Package { get; set; }

        public override void PrintProductSpecificDetails()
        {
            Console.WriteLine($"Package type: {Package}");
        }
    }
}
