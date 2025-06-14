using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookLibraryApp.Books.Models
{
    [Index(nameof(Name), nameof(AuthorInfoKey), nameof(GenreInfoKey), IsUnique = true)]
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

        [Range(0, int.MaxValue)]
        public int AuthorInfoKey { get; set; }

        [ForeignKey(nameof(AuthorInfoKey))]
        public Author Author { get; set; }

        [Range(0, int.MaxValue)]
        public int GenreInfoKey { get; set; }
        [ForeignKey(nameof(GenreInfoKey))]
        public Genre Genre { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool IsAlreadyTaken { get; set; }


        public Book(string name, int publishingYear, int authorInfoKey, int genreInfoKey, bool isAlreadyTaken)
        {
            Name = name;
            PublishingYear = publishingYear;
            AuthorInfoKey = authorInfoKey;
            GenreInfoKey = genreInfoKey;
            IsAlreadyTaken = isAlreadyTaken;
        }
    }
}
