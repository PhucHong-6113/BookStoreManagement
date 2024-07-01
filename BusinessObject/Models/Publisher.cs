using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Publisher
{
    public int PublisherId { get; set; }

    public string? PublisherName { get; set; }

    public string? PublisherEmail { get; set; }

    public string? PublisherDescription { get; set; }

    public string? PublisherPhoneNo { get; set; }
}
