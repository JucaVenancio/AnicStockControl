using System.Configuration;
using AnicStockControl.Entities;
using Microsoft.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore;
using System.IO;
using System.Data.Entity.Migrations.Model;
using System;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .HasKey(i => i.Code);
            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);
            modelBuilder.Entity<RecordUserAction>()
                .HasKey(r => r.Id);
            modelBuilder.Entity<RecordUserAction>()
                .HasOne(r => r.User)
                .WithMany()
                .HasForeignKey(r => r.UserId);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["AnicStockControlContext"].ConnectionString;
            optionsBuilder.UseMySql(connectionString);
            
        }

        internal void Query<T>(T sqlQuery)
        {
            throw new NotImplementedException();
        }
    }
}
