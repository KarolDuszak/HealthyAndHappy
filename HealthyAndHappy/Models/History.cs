using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAndHappy.Models
{
    public class History
    {
        public string Id { get; set; }
        public string Recipe { get; set; }
        public DateTime data { get; set; }
        public int Kcal { get; set; }
    }
}
