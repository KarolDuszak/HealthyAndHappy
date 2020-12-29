using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyAndHappy.Models.ModelsDTO
{
    public class UserDTO
    {
        public bool IsAdmin { get; set; }
        public IEnumerable<History> Histories { get; set; }
        public IEnumerable<Recipe> Recipes { get; set; }
        public Larder Larder { get; set; }
        public virtual string Password { get; set; }
        public virtual string Mail { get; set; }
        public virtual string Name { get; set; }
        public virtual string Id { get; set; }
    }
}
