﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAndHappy.Models.ModelsDTO
{
    public class ResponseDTO
    {
        public string Message { get; set; }
        public string Status { get; set; }
        public int Code { get; set; }
    }
}