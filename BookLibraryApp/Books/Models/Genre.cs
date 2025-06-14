using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryApp.Books.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [NotNull]
        [MinLength(1)]
        [MaxLength(100)]
        public string Name { get; set; }

        public Genre(string name)
        {
            Name = name;
        }
    }
}
