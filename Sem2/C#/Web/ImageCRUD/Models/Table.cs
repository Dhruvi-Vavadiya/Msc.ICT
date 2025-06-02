using System;
using System.Collections.Generic;

namespace ImageCRUD.Models;

public partial class Table
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }
}
