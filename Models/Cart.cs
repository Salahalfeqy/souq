using System;
using System.Collections.Generic;

namespace souq.Models;

public partial class Cart
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public int? ProductId { get; set; }

    public int? Amount { get; set; }

    public virtual Product? Product { get; set; }
}
