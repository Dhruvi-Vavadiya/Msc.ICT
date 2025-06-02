using System;
using System.Collections.Generic;

namespace ImageCRUD.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public int? Size { get; set; }

    public int? Quantity { get; set; }

    public int? Price { get; set; }
}
