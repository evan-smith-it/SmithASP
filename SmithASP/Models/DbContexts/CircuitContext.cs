using Microsoft.EntityFrameworkCore;
using SmithASP.Models.Electronics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmithASP.Models.DbContexts
{
    public class CircuitContext : DbContext
    {
        public CircuitContext(DbContextOptions<CircuitContext> options) : base(options) { }
        public DbSet<Circuit> Circuits { get; set; }
     }


}
