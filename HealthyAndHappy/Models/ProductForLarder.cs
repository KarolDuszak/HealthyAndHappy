﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAndHappy.Models
{
    public class ProductForLarder : Product
    {
        public string LarderId { get; set; }

        //?? circular reference
        public Larder Larder { get; set; }
    }
}
