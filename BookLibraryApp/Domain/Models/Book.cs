using System;
using System.Collections.Generic;

namespace BookLibraryApp.Domain.Models;

public partial class Book
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Author { get; set; } = null!;

    public int Year { get; set; }

    public string Genre { get; set; } = null!;

    public string Status { get; set; } = null!;

    public virtual ICollection<RentedBook> RentedBooks { get; set; } = new List<RentedBook>();
}
