using System;
using System.Collections.Generic;

namespace VogtInterface
{
    class Program
    {
        static void Main(string[] args)
        {

            MeatModel meatModel = new MeatModel { Name = "Chicken", Price = 8.00m, Type = "Chicken" };
            DairyModel dairyModel = new DairyModel { Name = "Milk", Price = 3.50m, ShelfLife = "2 weeks" };
            ProduceModel produceModel = new ProduceModel { Name = "Apple", Price = 1.50m, Package = "None" };

            dairyModel.PrintProductDetails();
            meatModel.PrintProductDetails();
            produceModel.PrintProductDetails();

        }
    }
}
