using Microsoft.EntityFrameworkCore;
using AnicStockControl.Entities;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Runtime.Remoting.Channels;
using System.IO;

namespace AnicStockControl.Data
{
    public class AnicStockControlContext : DbContext
    {

        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<RecordUserAction> RecordUserActions { get; set; }

        public AnicStockControlContext()
        {
        }
        public AnicStockControlContext(DbContextOptions<AnicStockControlContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();

            var connectionString = configuration.GetConnectionString("AnicStockControlContext");
            optionsBuilder.UseMySql(connectionString);

        }
    }
}
