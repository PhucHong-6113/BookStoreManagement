using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Author
{
    public int AuthorId { get; set; }

    public string AuthorName { get; set; } = null!;

    public string? AuthorDescription { get; set; }

    public int? AuthorAge { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
