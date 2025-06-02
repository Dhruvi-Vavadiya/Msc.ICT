using System;
using System.Collections.Generic;

namespace WebApplicationAPI.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public DateOnly Dob { get; set; }
}
