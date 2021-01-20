using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAndHappy.Models.ModelsDTO
{
    public class HistoryDTO
    {
        public string Id { get; set; }
        public string Recipe { get; set; }
        public DateTime Date { get; set; }
        public int Kcal { get; set; }
        public string UserId { get; set; }
    }
}
