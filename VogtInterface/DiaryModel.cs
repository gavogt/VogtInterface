﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VogtInterface
{
    class DiaryModel: IDairyModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ShelfLife { get; set; }
    }
}
