﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VogtInterface
{
    class ProduceModel : IProduceModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Package { get; set; }
    }
}
