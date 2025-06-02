using System;
using System.Collections.Generic;

namespace InternalWebAppMVC.Models;

public partial class Sale
{
    public int SaleId { get; set; }

    public int? ProductId { get; set; }

    public DateOnly? Date { get; set; }

    public int? Discount { get; set; }

    public int? BasePrice { get; set; }

    public int? SalePrice { get; set; }

    public int? Gst { get; set; }

    public int? TotalAmount { get; set; }

    public virtual Product? Product { get; set; }
}
