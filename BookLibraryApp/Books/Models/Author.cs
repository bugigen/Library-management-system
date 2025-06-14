using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryApp.Books.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [NotNull]
        [MinLength(3)]
        [MaxLength(200)]
        public string FullName { get; set; }

        [Required]
        [NotNull]
        public int BirthYear { get; set; }
    }
}
