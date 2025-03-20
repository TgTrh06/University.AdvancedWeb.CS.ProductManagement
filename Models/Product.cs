using System;
using System.Collections.Generic;

namespace ProductManagement.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public decimal? DiscountPercent { get; set; }

    public decimal? DiscountPrice { get; set; }

    public string? ImagePath { get; set; }

    public int? CategoryId { get; set; }

    public virtual Category? Category { get; set; }
}
