using System;
using System.Collections.Generic;

namespace WebApplicationWebAPI.Models;

public partial class Department
{
    public int DeptId { get; set; }

    public string? Deptname { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
