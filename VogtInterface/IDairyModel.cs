using System;
using System.Collections.Generic;
using System.Text;

namespace VogtInterface
{
    interface IDairyModel : IProductsModel
    {
        public string ShelfLife { get; set; }
    }
}
