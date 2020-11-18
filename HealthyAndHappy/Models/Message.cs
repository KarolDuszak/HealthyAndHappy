﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAndHappy.Models
{
    public class Message
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Sender { get; set; }
        public DateTime Date { get; set; }
    }
}
