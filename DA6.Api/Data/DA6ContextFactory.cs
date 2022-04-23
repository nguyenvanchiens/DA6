using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA6.Core.Data
{
    public class DA6ContextFactory : IDesignTimeDbContextFactory<DA6DbContext>
    {
        public DA6DbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DA6DbContext>();
            var connectionString = "User Id=root;Host=localhost;Character Set=utf8;Password=Chien12a5;Database=da6";
            optionsBuilder.UseMySql(connectionString, Microsoft.EntityFrameworkCore.ServerVersion.AutoDetect(connectionString));

            return new DA6DbContext(optionsBuilder.Options);
        }
    }
}