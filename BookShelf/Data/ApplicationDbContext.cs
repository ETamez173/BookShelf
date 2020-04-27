using System;
using System.Collections.Generic;
using System.Text;
using BookShelf.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookShelf.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Book> Book { get; set;  }

        public DbSet<Genre> Genre { get; set; }

        public DbSet<BookGenre> BookGenre { get; set; }

        //explained Bookshelf video at 13 min pt



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genre>().HasData(new Genre()
            {
                Id = 1,
                Name = "Fiction"
            });
            modelBuilder.Entity<Genre>().HasData(new Genre()
            {
                Id = 2,
                Name = "Non-Fiction"
            });
            modelBuilder.Entity<Genre>().HasData(new Genre()
            {
                Id = 3,
                Name = "Science Fiction"
            });
            modelBuilder.Entity<Genre>().HasData(new Genre()
            {
                Id = 4,
                Name = "Poetry"
            });
            modelBuilder.Entity<Genre>().HasData(new Genre()
            {
                Id = 5,
                Name = "Horror"
            });
            modelBuilder.Entity<Genre>().HasData(new Genre()
            {
                Id = 6,
                Name = "Romance"
            });
            modelBuilder.Entity<Genre>().HasData(new Genre()
            {
                Id = 7,
                Name = "Murder Mystery"
            });
        }
    }
}