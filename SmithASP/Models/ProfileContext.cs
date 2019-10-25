using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmithASP.Models
{
    public class ProfileContext : IdentityDbContext<ApplicationUser>
    {
        public ProfileContext(DbContextOptions<ProfileContext> options):base(options)
        {

        }
    }
}
