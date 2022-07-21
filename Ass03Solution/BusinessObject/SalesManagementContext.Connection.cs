using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BusinessObject
{
    public partial class SalesManagementContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json", true, true);
                IConfigurationRoot configuration = builder.Build();
                string _connectionString = configuration.GetConnectionString("SalesManagement");
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }
    }
}
