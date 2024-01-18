using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BookMovieTicketDbContext : DbContext
    {
        public BookMovieTicketDbContext() { }

        public BookMovieTicketDbContext(DbContextOptions<BookMovieTicketDbContext> dbContextOptions) : base(dbContextOptions) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookMovieTickets;Integrated Security=True");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Venu> Venus { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Event> Events { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<User>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<User>().HasMany(x=>x.Bookings).WithOne(x => x.User).HasForeignKey(x=>x.UserId);

            modelBuilder.Entity<Venu>().HasKey(x => x.Id);
            modelBuilder.Entity<Venu>().Property(x => x.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Event>().HasKey(x => x.Id);
            modelBuilder.Entity<Event>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Event>().HasMany(x => x.Bookings).WithOne(x => x.Event).HasForeignKey(x => x.EventId);

            modelBuilder.Entity<Booking>().HasKey(x => x.Id);
            modelBuilder.Entity<Booking>().Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}
