﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VogtInterface
{
    class MeatModel : IMeatModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }
    }
}
