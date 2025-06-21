using System;
using System.Collections.Generic;

namespace BookLibraryApp.Domain.Models;

public partial class Reader
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public virtual ICollection<RentedBook> RentedBooks { get; set; } = new List<RentedBook>();
}
