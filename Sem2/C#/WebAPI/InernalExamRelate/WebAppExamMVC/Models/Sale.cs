using System;
using System.Collections.Generic;

namespace WebAppExamMVC.Models;

public partial class Sale
{
    public int SaleId { get; set; }

    public int? ProductId { get; set; }

    public DateOnly? Date { get; set; }

    public double? Discount { get; set; }

    public double? BasePrice { get; set; }

    public double? SalePrice { get; set; } =  0;

    public double? Gst { get; set; } = 0;

    public double? TotalAmount { get; set; } = 0;

    public virtual Product? Product { get; set; }
}
