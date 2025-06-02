using System;
using System.Collections.Generic;

namespace InternalWebAppMVC.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? Category { get; set; }

    public int? BasePrice { get; set; }

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
