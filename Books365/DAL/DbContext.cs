using Books365.BLL; 
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.RightsManagement;
using System.Text;

namespace Books365
{
    class ReadingStatus
    {
        [MinLength(6), MaxLength(50)]
        public string UserEmail { get; set; }

        [MaxLength(30)]
        public int BookISBN { get; set; }
        public int PagesWritten { get; set; }
        public DateTime StartOfReading { get; set; }
        [MinLength(1), MaxLength(3)]
        public double Rating { get; set; }
        public string BookStatus { get; set; }
    }

    class EmailOfCurrentUser
    {
        [Key]
        public string Email { get; set; }
    }

    class Notification
    {
        public string Message { get; set; }
        [MinLength(6), MaxLength(50)]
        public string Email { get; set; }
        public DateTime Date { get; set; }
    }

    public class User
    {
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }

        [Key]
        [MinLength(6), MaxLength(50)]
        public string Email { get; set; }

        [MinLength(6), MaxLength(30)]
        public string Password { get; set; }

        [MinLength(4), MaxLength(4)]
        public int SecretPin { get; set; }
    }

    class Book
    {
        [Key, MaxLength(30)]
        public int ISBN { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(4)]
        public int Year { get; set; }
        [MaxLength(50)]
        public string Author { get; set; }
    }


    class AppContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<ReadingStatus> ReadingStatuses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<EmailOfCurrentUser> EmailCurrentUser { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Notification>((pc =>
            {
                pc.HasNoKey();
            }));
            modelBuilder.Entity<ReadingStatus>((pc =>
            {
                pc.HasNoKey();
            }));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-E9SSABQ\\MSSQLSERVER01;Initial Catalog=Books365BD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
