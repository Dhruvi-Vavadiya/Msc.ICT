using System;
using System.Collections.Generic;

namespace ExampleExpenseAPI.Models;

public partial class Einformation
{
    public int Eid { get; set; }

    public int? Uid { get; set; }

    public DateOnly? Date { get; set; }

    public double? Amount { get; set; }

    public virtual TblUser? UidNavigation { get; set; }
}
