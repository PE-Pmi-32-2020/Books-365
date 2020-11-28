using Books365.BLL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.RightsManagement;
using System.Text;

namespace Books365
{
    internal class AppContext : DbContext, IDisposable
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Notification> Notifications { get; set; }

        public DbSet<ReadingStatus> ReadingStatuses { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<EmailOfCurrentUser> EmailCurrentUser { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReadingStatus>(pc =>
            {
                pc.HasNoKey();
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = Books365DB; Trusted_Connection = True; MultipleActiveResultSets = true");
        }

#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        public void Dispose()
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
        {
            base.Dispose();
        }
    }
}
