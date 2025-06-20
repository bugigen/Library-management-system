using BookLibraryApp.Books.Models;
using BookLibraryApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryApp.DataBase
{
    public class BookAppContext : DbContext
    {
        public DbSet<Book> Books => Set<Book>();
        public DbSet<Reader> Readers => Set<Reader>();

        public BookAppContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=libraryApp.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(b => b.CurrentReader)
                .WithMany(r => r.RentedBooks)
                .HasForeignKey(b => b.CurrentReaderId)
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<Book>()
                .HasIndex(b => new { b.Name, b.Author, b.Genre })
                .IsUnique();
        }
    }
}