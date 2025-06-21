using BookLibraryApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BookLibraryApp.Infrastructure;

public partial class LibraryAppContext : DbContext
{
    public LibraryAppContext()
    {
    }

    public LibraryAppContext(DbContextOptions<LibraryAppContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Reader> Readers { get; set; }

    public virtual DbSet<RentedBook> RentedBooks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var dbPath = Path.Combine(AppContext.BaseDirectory, "Infrastructure", "libraryApp.db");
        optionsBuilder.UseSqlite($"Data Source={dbPath}");
        MessageBox.Show(dbPath);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasIndex(e => new { e.Title, e.Author, e.Year, e.Genre }, "IX_Books_Title_Author_Year_Genre").IsUnique();
        });

        modelBuilder.Entity<Reader>(entity =>
        {
            entity.HasIndex(e => new { e.FirstName, e.LastName }, "IX_Readers_FirstName_LastName").IsUnique();
        });

        modelBuilder.Entity<RentedBook>(entity =>
        {
            entity.HasIndex(e => new { e.BookId, e.ReaderId }, "IX_RentedBooks_BookId_ReaderId").IsUnique();

            entity.Property(e => e.RentDate).HasDefaultValueSql("datetime('now')");

            entity.HasOne(d => d.Book).WithMany(p => p.RentedBooks).HasForeignKey(d => d.BookId);

            entity.HasOne(d => d.Reader).WithMany(p => p.RentedBooks).HasForeignKey(d => d.ReaderId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
