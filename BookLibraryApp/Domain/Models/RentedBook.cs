using System;
using System.Collections.Generic;

namespace BookLibraryApp.Domain.Models;

public partial class RentedBook
{
    public int Id { get; set; }

    public int BookId { get; set; }

    public int ReaderId { get; set; }

    public string RentDate { get; set; } = null!;

    public string Status { get; set; } = null!;

    public virtual Book Book { get; set; } = null!;

    public virtual Reader Reader { get; set; } = null!;
}
