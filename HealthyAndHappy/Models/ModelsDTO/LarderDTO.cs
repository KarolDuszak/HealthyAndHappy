﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAndHappy.Models.ModelsDTO
{
    public class LarderDTO
    {
        public string Id { get; set; }
        public ApplicationUser User { get; set; }
        public List<ProductForLarder> Products { get; set; }
    }
}
