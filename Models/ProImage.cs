using System;
using System.Collections.Generic;

namespace souq.Models;

public partial class ProImage
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public string? Image { get; set; }

    public virtual Product? Product { get; set; }
}
