using System;
using System.Collections.Generic;
using System.Text;

namespace VogtInterface
{
    interface IProduceModel : IProductsModel
    {
        public string Package { get; set; }
    }
}
