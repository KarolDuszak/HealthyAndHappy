using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAndHappy.Models.ModelsDTO
{
    public class LarderDTO
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public List<ProductForLarder> Products { get; set; }
    }
}
