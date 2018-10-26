using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VentasSystemMvc.Models
{
    public class VentasSystemMvcDbContext : DbContext
    {
        public VentasSystemMvcDbContext (DbContextOptions<VentasSystemMvcDbContext> options)
            : base(options)
        {
        }

        public DbSet<VentasSystemMvc.Models.Department> Department { get; set; }
    }
}
