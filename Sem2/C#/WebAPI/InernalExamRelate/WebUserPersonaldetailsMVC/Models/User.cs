using System;
using System.Collections.Generic;

namespace WebUserPersonaldetailsMVC.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<PersonalDetail> PersonalDetails { get; set; } = new List<PersonalDetail>();
}
