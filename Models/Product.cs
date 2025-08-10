using System;
using System.Collections.Generic;

namespace souq.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public int? CatId { get; set; }

    public string? Photo { get; set; }

    public string? SupllierName { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? ReviewUrl { get; set; }

    public int? Quantity { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual Category? Cat { get; set; }

    public virtual ICollection<ProImage> ProImages { get; set; } = new List<ProImage>();
}
