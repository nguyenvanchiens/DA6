using DA6.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA6.Core.Data
{
    public class DA6DbContext : DbContext
    {
        public DA6DbContext(DbContextOptions<DA6DbContext> options) : base(options)
        {

        }
        public DbSet<ChungLoai> ChungLoais { get; set; }
        public DbSet<Ao> Aos { get; set; }
    }
}
