using System;
using System.Collections.Generic;
using System.Text;

namespace VogtInterface
{
    interface IMeatModel : IProductsModel
    {
        public string Type { get; set; }
    }
}
