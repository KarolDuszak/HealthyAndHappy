using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAndHappy.Models.ModelsDTO
{
    public class MessageDTO
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string SenderId { get; set; }
        public DateTime Date { get; set; }
    }
}
