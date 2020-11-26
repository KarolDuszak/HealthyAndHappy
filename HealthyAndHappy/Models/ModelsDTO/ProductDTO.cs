using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAndHappy.Models.ModelsDTO
{
    public class ProductDTO
    {
        public string Id { get; set; }
        public int Amount { get; set; }
        public int Kcal { get; set; }
        public Macro Macro { get; set; }
        public int Portion { get; set; }
        public int Chain { get; set; }
        public bool IsAccepted { get; set; }
        public int PortionSize { get; set; }
        public string IdUser { get; set; }
        public string Name { get; set; }
    }
}
