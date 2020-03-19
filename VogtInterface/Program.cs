using System;
using System.Collections.Generic;

namespace VogtInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IProductsModel> products = new List<IProductsModel>();
            MeatModel meatModel = new MeatModel();

            products = AddSampleData();
            meatModel.PrintProductDetails(products);

        }

        public static List<IProductsModel> AddSampleData()
        {
            List<IProductsModel> sampleData = new List<IProductsModel>();

            sampleData.Add(new MeatModel { Name = "Chicken", Price = 8.00m, Type = "Chicken" });
            sampleData.Add(new ProduceModel { Name = "Apple", Price = 1.50m, Package = "None" });
            sampleData.Add(new DairyModel { Name = "Milk", Price = 3.50m, ShelfLife = "2 weeks" });

            return sampleData;
        }
    }
}
