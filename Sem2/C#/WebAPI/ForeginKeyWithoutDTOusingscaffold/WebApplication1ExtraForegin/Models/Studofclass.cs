using System;
using System.Collections.Generic;

namespace WebApplication1ExtraForegin.Models;

public partial class Studofclass
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public int? ClassId { get; set; }

    //public virtual Class? Class { get; set; }
}
