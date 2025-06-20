// Reader.cs
using BookLibraryApp.Books.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookLibraryApp.Models
{
    public class Reader
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string FirstName { get; set; }

        [Required, MaxLength(100)]
        public string LastName { get; set; }

        public List<Book> RentedBooks { get; set; } = new List<Book>();
    }
}