using System;
using System.Collections.Generic;

namespace WebApplicationWebAPI.Models;

public partial class Student
{
    public int StudId { get; set; }

    public string? StudName { get; set; }

    public int? StudAge { get; set; }

    public int? DeptId { get; set; }

    public virtual Department? Dept { get; set; }
}
