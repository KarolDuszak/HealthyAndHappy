using HealthyAndHappy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace HealthyAndHappy.Data
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {

    }
}
