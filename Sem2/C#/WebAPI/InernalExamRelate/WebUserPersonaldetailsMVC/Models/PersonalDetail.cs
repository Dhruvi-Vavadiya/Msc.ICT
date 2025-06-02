using System;
using System.Collections.Generic;

namespace WebUserPersonaldetailsMVC.Models;

public partial class PersonalDetail
{
    public int PersonalId { get; set; }

    public DateOnly? Dob { get; set; }

    public string? Gender { get; set; }

    public string? Hobby { get; set; }

    public string? Education { get; set; }

    public string? City { get; set; }

    public int? UserId { get; set; }

    public virtual User? User { get; set; }

    


}
