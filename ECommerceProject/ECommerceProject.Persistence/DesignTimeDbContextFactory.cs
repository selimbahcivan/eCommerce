using ECommerceProject.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ECommerceProject.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<EcommerceDbContext>
    {
        // powershellden migration yapabilmek için eklendi.
        public EcommerceDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<EcommerceDbContext> dbContextOptionsBuilder = new DbContextOptionsBuilder<EcommerceDbContext>();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConfigurationString);
            return new EcommerceDbContext(dbContextOptionsBuilder.Options);
        }
    }
}
