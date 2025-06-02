using System;
using System.Collections.Generic;

namespace WebApplication1ExtraForegin.Models;

public partial class ErrorLog
{
    public int Id { get; set; }

    public string? ErrorMessage { get; set; }

    public string? StackTrace { get; set; }

    public DateTime? LogTime { get; set; }
}
