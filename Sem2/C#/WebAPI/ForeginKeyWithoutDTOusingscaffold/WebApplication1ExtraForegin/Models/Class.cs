using System;
using System.Collections.Generic;

namespace WebApplication1ExtraForegin.Models;

public partial class Class
{
    public int ClassId { get; set; }

    public string? Classname { get; set; }

    //public virtual ICollection<Studofclass> Studofclasses { get; set; } = new List<Studofclass>();
}
