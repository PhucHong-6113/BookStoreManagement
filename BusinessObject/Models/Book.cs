using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string? BookName { get; set; }

    public int? AuthorId { get; set; }

    public int? PublisherId { get; set; }

    public int? CategoryId { get; set; }

    public int? Quantity { get; set; }

    public decimal? Price { get; set; }
}
