using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookLibraryApp.Books.Models
{
    [Microsoft.EntityFrameworkCore.Index(nameof(Name), nameof(Author), nameof(Genre), IsUnique = true)]
    public sealed class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(255)]
        public string Name { get; set; }

        [Range(0, 2025)]
        [Required]
        public int PublishingYear { get; set; }

        [Required, MaxLength(255), MinLength(3)]
        public string Author { get; set; }

        [Required, MinLength(1), MaxLength(100)]
        public string Genre { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool IsAlreadyTaken { get; set; }


        public Book(string name, int publishingYear, string author, string genre, bool isAlreadyTaken)
        {
            Name = name;
            PublishingYear = publishingYear;
            Author = author;
            Genre = genre;
            IsAlreadyTaken = isAlreadyTaken;
        }
    }
}
