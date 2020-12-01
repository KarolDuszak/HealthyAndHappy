using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace HealthyAndHappy.Models
{
    public class ApplicationUser: IdentityUser
    {
        public bool IsAdmin { get; set; }
        public IEnumerable<History> Histories { get; set; }
        public IEnumerable<Recipe> FavouriteRecipes { get; set; }

    }
}
